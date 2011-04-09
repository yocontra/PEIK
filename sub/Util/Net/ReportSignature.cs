#region Imports

using System;

#endregion

namespace sub.Util.Net
{
    static class ReportSignature
    {
        private static string _signature = null;
        public static string GetSignature()
        {
            if (String.IsNullOrEmpty(_signature))
            {
                //standard email signature identifier. Most email programs won't regognize this as a signture without this first part being exactly how it is
                //a few more \r\n at the begining probably wouldn't hurt anything but it just makes things look a bit weird
                _signature += "\r\n-- \r\n";
                _signature += "OS: " + Environment.OSVersion + "\r\n";
                _signature += "MAC:" + Misc.HardwareInfo.GetMACAddress() + "\r\n";
                _signature += "IP: " + Network.GetExternalIP(); // +"\r\n";
            }
            return _signature;
        }
    }
}
