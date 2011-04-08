using System;
using System.Collections.Generic;
using System.Text;

namespace sub.Util.Net
{
    class ReportSignature
    {
        public ReportSignature()
        {
            
        }
        public override string ToString()
        {
            string temp = null;
            temp += "\r\n\r\n\r\n---------------\r\n";
            temp += "OS: " + Environment.OSVersion + "\r\n";
            temp += "MAC:" + Misc.HardwareInfo.GetMACAddress() + "\r\n";
            temp += "IP: " + Network.GetExternalIP() + "\r\n";
            return temp;
        }
    }
}
