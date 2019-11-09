using System;
using System.Security.Cryptography;
using System.Text;

namespace SHAalgorithm
{
    /// <summary>
    /// SHA【1|256|384|512】 系列加密助手
    /// </summary>
    public static class ShaxEncrypt
    {
        /// <summary>
        /// SHA1
        /// </summary>
        /// <param name="palinData">明文</param>
        /// <returns>string：密文</returns>
        public static string Sha1Encrypt(string palinData)
        {
            if (string.IsNullOrWhiteSpace(palinData)) return null;
            using (SHA1 sha1 = new SHA1CryptoServiceProvider())
            {
                byte[] bytes = Encoding.Default.GetBytes(palinData);
                byte[] sha1Bytes = sha1.ComputeHash(bytes);
                return Convert.ToBase64String(sha1Bytes);
            }
        }

        /// <summary>
                /// SHA256
                /// </summary>
                /// <param name="palinData">明文</param>
                /// <returns>string：密文</returns>
        public static string Sha256Encrypt(string palinData)
        {
            if (string.IsNullOrWhiteSpace(palinData)) return null;
            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                byte[] bytes = Encoding.Default.GetBytes(palinData);
                byte[] sha256Bytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(sha256Bytes);
            }
        }

        /// <summary>
                /// SHA384
                /// </summary>
                /// <param name="palinData">明文</param>
                /// <returns>string：密文</returns>
        public static string Sha384Encrypt(string palinData)
        {
            if (string.IsNullOrWhiteSpace(palinData)) return null;
            using (SHA384 sha384 = new SHA384CryptoServiceProvider())
            {
                byte[] bytes = Encoding.Default.GetBytes(palinData);
                byte[] sha384Bytes = sha384.ComputeHash(bytes);
                return Convert.ToBase64String(sha384Bytes);
            }
        }

        /// <summary>
                /// SHA512
                /// </summary>
                /// <param name="palinData">明文</param>
                /// <returns>string：密文</returns>
        public static string Sha512Encrypt(string palinData)
        {
            if (string.IsNullOrWhiteSpace(palinData)) return null;
            using (SHA512 sha512 = new SHA512CryptoServiceProvider())
            {
                byte[] bytes = Encoding.Default.GetBytes(palinData);
                byte[] sha512Bytes = sha512.ComputeHash(bytes);
                return Convert.ToBase64String(sha512Bytes);
            }
        }
    }
}
