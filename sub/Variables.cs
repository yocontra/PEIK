#region Imports

using System.Collections;
using System.Text;
using System.Threading;
using System;

#endregion

namespace sub
{
    class Variables
    {
        public static ArrayList StealerPool = new ArrayList();
        public static bool CreatedMutex;
        public static Mutex Mutex;
    }
}
