using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace Trip.Seller.Utility
{
    public static class Encryption
    {
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="text">已加密的内容</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string Decrypt(string text, string key)
        {
            byte[] buff = Convert.FromBase64String(text);
            byte[] kb = Encoding.Default.GetBytes(key);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = md5.ComputeHash(kb);
            des.Mode = CipherMode.ECB;
            byte[] decryptBytes = des.CreateDecryptor().TransformFinalBlock(buff, 0, buff.Length);

            return Encoding.Default.GetString(decryptBytes);
        }
    }
}
