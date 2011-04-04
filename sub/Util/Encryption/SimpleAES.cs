using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace sub.Util.Encryption
{
    sealed class SimpleAES
    {
        private ICryptoTransform _encryptorTransform, _decryptorTransform;
        private UTF8Encoding _utfEncoder;
        public byte[] Key;

        public SimpleAES(string key)
        {
            RijndaelManaged rm = new RijndaelManaged();
            Key = Encoding.Default.GetBytes(key);

            byte[] vector = Encoding.Default.GetBytes("Ijd0!$FDdg8s(*&J");
            _encryptorTransform = rm.CreateEncryptor(Key, vector);
            _decryptorTransform = rm.CreateDecryptor(Key, vector);

            _utfEncoder = new UTF8Encoding();
        }

        public string EncryptToString(string textValue)
        {
            return Encoding.Default.GetString(Encrypt(textValue));
        }

        public byte[] Encrypt(string textValue)
        {
            Byte[] bytes = _utfEncoder.GetBytes(textValue);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cs = new CryptoStream(memoryStream, _encryptorTransform, CryptoStreamMode.Write);
            cs.Write(bytes, 0, bytes.Length);
            cs.FlushFinalBlock();
            memoryStream.Position = 0;
            byte[] encrypted = new byte[memoryStream.Length];
            memoryStream.Read(encrypted, 0, encrypted.Length);

            cs.Close();
            memoryStream.Close();
            return encrypted;
        }

        public string DecryptString(string encryptedString)
        {
            return Decrypt(StrToByteArray(encryptedString));
        }
    
        public string Decrypt(byte[] encryptedValue)
        {
            MemoryStream encryptedStream = new MemoryStream();
            CryptoStream decryptStream = new CryptoStream(encryptedStream, _decryptorTransform, CryptoStreamMode.Write);
            decryptStream.Write(encryptedValue, 0, encryptedValue.Length);
            decryptStream.FlushFinalBlock();

            encryptedStream.Position = 0;
            Byte[] decryptedBytes = new Byte[encryptedStream.Length];
            encryptedStream.Read(decryptedBytes, 0, decryptedBytes.Length);
            encryptedStream.Close();
            return _utfEncoder.GetString(decryptedBytes);
        }

        public byte[] StrToByteArray(string str)
        {
            if (str.Length == 0)
                throw new Exception("Invalid string value in StrToByteArray");

            byte val;
            byte[] byteArr = new byte[str.Length / 3];
            int i = 0;
            int j = 0;
            do
            {
                val = byte.Parse(str.Substring(i, 3));
                byteArr[j++] = val;
                i += 3;
            }
            while (i < str.Length);
            return byteArr;
        }
    }
}