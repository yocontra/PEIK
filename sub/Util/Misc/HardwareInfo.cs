#region Imports

using System;
using System.Globalization;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;

#endregion

namespace sub.Util.Misc
{
    public static class HardwareInfo
    {
        public static byte[] GetLocalKey()
        {
            NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            int num = -1;
            int index = -1;
            int num4 = allNetworkInterfaces.Length - 1;
            for (int i = 0; i <= num4; i++)
            {
                switch (allNetworkInterfaces[i].OperationalStatus)
                {
                    case OperationalStatus.Up:
                        {
                            IPInterfaceProperties iPProperties = allNetworkInterfaces[i].GetIPProperties();
                            if (iPProperties == null) continue;
                            IPv4InterfaceProperties properties2 = iPProperties.GetIPv4Properties();
                            if ((properties2 == null) || ((index >= 0) && (properties2.Index >= index))) continue;
                            num = i;
                            index = properties2.Index;
                        }
                        break;
                }
            }
            byte[] buffer2 = ConvertByteEncoding(Mac(GetMACAddress()));
            return num >= 0
                       ? buffer2
                       : Encoding.Default.GetBytes(Environment.UserName +
                                                   CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
        }

        public static byte[] Mac(string ino)
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

        public static byte[] ConvertByteEncoding(byte[] key)
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

        public static string GetMACAddress()
        {
            ManagementObjectCollection instances =
                new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
            string str1 = string.Empty, str2 = string.Empty;
            foreach (ManagementObject obj2 in instances)
            {
                if (!str2.Equals(string.Empty)) continue;
                if (Convert.ToBoolean(obj2["IPEnabled"]))
                {
                    str1 = obj2["MacAddress"].ToString();
                }
                obj2.Dispose();
            }

            /*Not needed, MAC address was already in an acceptable format
            //put the standard dashes in the MAC
            for (int i = 0; i < str1.Length; i++)
            {
                //Note: the ToString() call is nessisary or it trys to add the chacter values instead of concating them
                str2 += str1[i].ToString() + str1[++i].ToString() + "-";
            }
            str2 = str2.Remove(str2.Length - 1);*/
            return str2;
        }

        public static bool IsValidIso88591(byte value)
        {
            return (value <= 0x7f) || (value >= 160);
        }
    }
}