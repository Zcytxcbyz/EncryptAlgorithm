using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TripleDESalgorithm
{
    public class TripleDES
    {
        /// <summary>
        /// 3DES加密
        /// </summary>
        /// <param name="str">需要加密的</param>
        /// <param name="sKey">密匙(24位)</param>
        /// <param name="iv">向量(8位)</param>
        /// <returns></returns>
        public static string Encrypt(string str, string sKey, string iv)
        {
            try
            {
                TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.Default.GetBytes(str);
                tripledes.Key = ASCIIEncoding.ASCII.GetBytes(sKey);// 密匙
                tripledes.IV = ASCIIEncoding.ASCII.GetBytes(iv);// 初始化向量
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, tripledes.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                var retB = Convert.ToBase64String(ms.ToArray());
                return retB;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 3DES解密
        /// </summary>
        /// <param name="pToDecrypt">需要解密的</param>
        /// <param name="sKey">密匙(24位)</param>
        /// <param name="iv">向量(8位)</param>
        /// <returns></returns>
        public static string Decrypt(string pToDecrypt, string sKey, string iv)
        {
            try
            {
                TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
                byte[] inputByteArray = Convert.FromBase64String(pToDecrypt);
                tripledes.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                tripledes.IV = ASCIIEncoding.ASCII.GetBytes(iv);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, tripledes.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                // 如果两次密匙不一样，这一步可能会引发异常
                cs.FlushFinalBlock();
                return System.Text.Encoding.Default.GetString(ms.ToArray());
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 3DES加密
        /// </summary>
        /// <param name="pToDecrypt">需要加密的</param>
        /// <param name="sKey">密匙(24位)</param>
        /// <returns></returns>
        public static string Encrypt(string str, string sKey)
        {
            try
            {
                return Encrypt(str, sKey, sKey.Substring(0, 8));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 3DES解密
        /// </summary>
        /// <param name="pToDecrypt">需要解密的</param>
        /// <param name="sKey">密匙(24位)</param>
        /// <returns></returns>
        public static string Decrypt(string pToDecrypt, string sKey)
        {
            try
            {
                return Decrypt(pToDecrypt, sKey, sKey.Substring(0, 8));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
