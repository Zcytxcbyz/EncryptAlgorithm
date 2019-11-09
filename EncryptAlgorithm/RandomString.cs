using System;
using System.Collections.Generic;

namespace RandomString
{
    class RandomString
    {
        /// <summary>
        /// 生成随机字符串
        /// </summary>
        /// <param name="Uppercaseletter">是否生成大写字母</param>
        /// <param name="Lowercaseletters">是否生成小写字母</param>
        /// <param name="Numbers">是否生成数字</param>
        /// <param name="MinLength">最小长度</param>
        /// <param name="MaxLength">最大长度</param>
        /// <returns></returns>
        public static string GenerateRandomString(bool Uppercaseletter, bool Lowercaseletters, bool Numbers, int MinLength, int MaxLength)
        {
            try
            {
                List<char> chars = new List<char>();
                if (Uppercaseletter)
                    for (char i = 'A'; i <= 'Z'; i++)
                        chars.Add(i);
                if (Lowercaseletters)
                    for (char i = 'a'; i <= 'z'; i++)
                        chars.Add(i);
                if (Numbers)
                    for (char i = '0'; i <= '9'; i++)
                        chars.Add(i);
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int length = random.Next(MinLength, MaxLength + 1);
                string result = null;
                for (int i = 0; i < length; i++)
                {
                    int index = random.Next(0, chars.Count);
                    result += chars[index].ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 生成随机字符串
        /// </summary>
        /// <param name="Uppercaseletter">是否生成大写字母</param>
        /// <param name="Lowercaseletters">是否生成小写字母</param>
        /// <param name="Numbers">是否生成数字</param>
        /// <param name="Length">长度</param>
        /// <returns></returns>
        public static string GenerateRandomString(bool Uppercaseletter, bool Lowercaseletters, bool Numbers, int Length)
        {
            return GenerateRandomString(Uppercaseletter, Lowercaseletters, Numbers, Length, Length);
        }
    }
}
