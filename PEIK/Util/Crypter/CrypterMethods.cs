#region Imports

using System;
using System.Text;

#endregion

namespace PEIK.Util.Crypter
{
    internal class CrypterMethods
    {
        static Random random = new Random();
        public static string GetKey(int length)
        {
            const string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder sb = new StringBuilder();

            while ((length--) > 0)
                sb.Append(str[(int)(random.NextDouble() * str.Length)]);

            return sb.ToString();
        }

        public static byte[] Encrypt(byte[] message, string password)
        {
            byte[] passarr = Encoding.Default.GetBytes(password);
            int rand = Convert.ToInt32(random.Next(9001));
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