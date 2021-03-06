using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronyAndMultithreading.Classes
{
    class GetTime
    {
        public static string GetExecutionTime(Stopwatch stopWatch)
        {
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            return ("RunTime " + elapsedTime);
        }
    }
}
