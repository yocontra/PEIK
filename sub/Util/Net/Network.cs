using System.Net;

namespace sub.Util.Net
{
    class Network
    {
        public static string GetExternalIP()
        {
            return new WebClient().DownloadString("http://myip.ozymo.com/");
        }
    }
}
