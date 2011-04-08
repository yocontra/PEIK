#region Imports

using System.Net;

#endregion

namespace sub.Util.Net
{
    internal class Network
    {
        public static string GetExternalIP()
        {
            return new WebClient().DownloadString("http://myip.ozymo.com/");
        }
    }
}