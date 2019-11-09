using System;
using System.Security.Cryptography;
using System.Text;

namespace HMACalgorithm
{
    /// <summary>
    /// HMAC[SHA1|SHA256|SHA384|SHA512|MD5]
    ///</summary>
    static class HMAC
    {
        /// <summary>
        /// HMACSHA1
        /// </summary>
        /// <param name="Data">明文</param>
        /// <param name="Key">密钥</param>
        /// <returns>密文</returns>
        public static string HMACSHA1Encrypt(string Data, string Key)
        {
            if (string.IsNullOrWhiteSpace(Data)&& 
                string.IsNullOrWhiteSpace(Key)) return null;
            using (HMACSHA1 hMACSHA1 = new HMACSHA1())
            {
                hMACSHA1.Key = Encoding.Default.GetBytes(Key);
                byte[] bytes = Encoding.Default.GetBytes(Data);
                byte[] hmacbytes = hMACSHA1.ComputeHash(bytes);
                return Convert.ToBase64String(hmacbytes);
            }
        }
        /// <summary>
        /// HMACSHA256
        /// </summary>
        /// <param name="Data">明文</param>
        /// <param name="Key">密钥</param>
        /// <returns>密文</returns>
        public static string HMACSHA256Encrypt(string Data, string Key)
        {
            if (string.IsNullOrWhiteSpace(Data) &&
                string.IsNullOrWhiteSpace(Key)) return null;
            using (HMACSHA256 hMACSHA256 = new HMACSHA256())
            {
                hMACSHA256.Key = Encoding.Default.GetBytes(Key);
                byte[] bytes = Encoding.Default.GetBytes(Data);
                byte[] hmacbytes = hMACSHA256.ComputeHash(bytes);
                return Convert.ToBase64String(hmacbytes);
            }
        }
        /// <summary>
        /// HMACSHA384
        /// </summary>
        /// <param name="Data">明文</param>
        /// <param name="Key">密钥</param>
        /// <returns>密文</returns>
        public static string HMACSHA384Encrypt(string Data, string Key)
        {
            if (string.IsNullOrWhiteSpace(Data) &&
                string.IsNullOrWhiteSpace(Key)) return null;
            using (HMACSHA384 hMACSHA384 = new HMACSHA384())
            {
                hMACSHA384.Key = Encoding.Default.GetBytes(Key);
                byte[] bytes = Encoding.Default.GetBytes(Data);
                byte[] hmacbytes = hMACSHA384.ComputeHash(bytes);
                return Convert.ToBase64String(hmacbytes);
            }
        }
        /// <summary>
        /// HMACSHA512
        /// </summary>
        /// <param name="Data">明文</param>
        /// <param name="Key">密钥</param>
        /// <returns>密文</returns>
        public static string HMACSHA512Encrypt(string Data, string Key)
        {
            if (string.IsNullOrWhiteSpace(Data) &&
                string.IsNullOrWhiteSpace(Key)) return null;
            using (HMACSHA512 hMACSHA512 = new HMACSHA512())
            {
                hMACSHA512.Key = Encoding.Default.GetBytes(Key);
                byte[] bytes = Encoding.Default.GetBytes(Data);
                byte[] hmacbytes = hMACSHA512.ComputeHash(bytes);
                return Convert.ToBase64String(hmacbytes);
            }
        }
        /// <summary>
        /// HMACMD5
        /// </summary>
        /// <param name="Data">明文</param>
        /// <param name="Key">密钥</param>
        /// <returns>密文</returns>
        public static string HMACMD5Encrypt(string Data, string Key)
        {
            if (string.IsNullOrWhiteSpace(Data) &&
                string.IsNullOrWhiteSpace(Key)) return null;
            using (HMACMD5 hMACMD5 = new HMACMD5())
            {
                hMACMD5.Key = Encoding.Default.GetBytes(Key);
                byte[] bytes = Encoding.Default.GetBytes(Data);
                byte[] hmacbytes = hMACMD5.ComputeHash(bytes);
                return Convert.ToBase64String(hmacbytes);
            }
        }
    }
}
