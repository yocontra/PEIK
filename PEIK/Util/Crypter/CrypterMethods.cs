#region Imports

using System;
using System.Text;

#endregion

namespace PEIK.Util.Crypter
{
    internal class CrypterMethods
    {
        public static string GetKey(int length){
            Random ra = new Random();
            StringBuilder s = new StringBuilder();
            char[] b = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int i = 1; i <= length; i++)
            {
                s.Append(b[ra.Next(0, b.Length)]);
            }
            return s.ToString();
        }

        public static byte[] Encrypt(byte[] message, string password)
        {
            byte[] passarr = Encoding.Default.GetBytes(password);
            Random ra = new Random();
            int rand = Convert.ToInt32(ra.Next(9001));
            byte[] outarr = new byte[message.Length + 1];
            int u = 0;
            for (int i = 0; i <= message.Length - 1; i++)
            {
                outarr[i] += (byte) ((message[i] ^ passarr[u]) ^ rand);
                if (u == password.Length - 1)
                    u = 0;
                else
                    u = u + 1;
            }
            outarr[message.Length] = (byte) (112 ^ rand);
            return outarr;
        }
    }
}