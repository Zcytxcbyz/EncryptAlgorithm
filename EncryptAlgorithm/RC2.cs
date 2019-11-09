using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RC2algorithm
{
    public class RC2
    {
        /// <summary>
        /// RC2加密
        /// </summary>
        /// <param name="str">需要加密的</param>
        /// <param name="sKey">密匙(16位)</param>
        /// <param name="iv">向量(8位)</param>
        /// <returns></returns>
        public static string Encrypt(string str, string sKey, string iv)
        {
            try
            {
                RC2CryptoServiceProvider rc2 = new RC2CryptoServiceProvider();
                byte[] inputByteArray = Encoding.Default.GetBytes(str);
                rc2.Key = ASCIIEncoding.ASCII.GetBytes(sKey);// 密匙
                rc2.IV = ASCIIEncoding.ASCII.GetBytes(iv);// 初始化向量
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, rc2.CreateEncryptor(), CryptoStreamMode.Write);
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
        /// RC2解密
        /// </summary>
        /// <param name="pToDecrypt">需要解密的</param>
        /// <param name="sKey">密匙(16位)</param>
        /// <param name="iv">向量(8位)</param>
        /// <returns></returns>
        public static string Decrypt(string pToDecrypt, string sKey, string iv)
        {
            try
            {
                RC2CryptoServiceProvider rc2 = new RC2CryptoServiceProvider();
                byte[] inputByteArray = Convert.FromBase64String(pToDecrypt);
                rc2.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                rc2.IV = ASCIIEncoding.ASCII.GetBytes(iv);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, rc2.CreateDecryptor(), CryptoStreamMode.Write);
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
        /// RC2加密
        /// </summary>
        /// <param name="str">需要加密的</param>
        /// <param name="sKey">密匙(16位)</param>
        /// <returns></returns>
        public static string Encrypt(string str, string sKey)
        {
            return Encrypt(str, sKey, sKey.Substring(0, 8));
        }
        /// <summary>
        /// RC2解密
        /// </summary>
        /// <param name="pToDecrypt">需要解密的</param>
        /// <param name="sKey">密匙(16位)</param>
        /// <returns></returns>
        public static string Decrypt(string pToDecrypt, string sKey)
        {
            return Decrypt(pToDecrypt, sKey, sKey.Substring(0,8));
        }
    }
}
