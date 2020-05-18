using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LoginProject
{
    class HashCode
    {
        public string GetMD5(string text)        //For Encryption of text
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();

            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString());
            }
            return str.ToString();
        }
    }
}
