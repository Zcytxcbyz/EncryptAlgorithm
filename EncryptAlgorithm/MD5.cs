using System;
using System.Security.Cryptography;
using System.Text;

namespace MD5algorithm
{
    /// <summary>
    /// MD5加密类
    /// </summary>
    public static class MD5
    {
        /// <summary>
        /// MD5
        /// </summary>
        /// <param name="palinData">明文</param>
        /// <returns>密文</returns>
        public static string MD5Encrypt(string palinData)
        {
            if (string.IsNullOrWhiteSpace(palinData)) return null;
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] bytes = Encoding.Default.GetBytes(palinData);
                byte[] md5Bytes = md5.ComputeHash(bytes);
                return Convert.ToBase64String(md5Bytes);
            }
        }
    }
}
