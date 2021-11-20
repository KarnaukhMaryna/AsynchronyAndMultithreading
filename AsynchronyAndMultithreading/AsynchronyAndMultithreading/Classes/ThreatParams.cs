using EquationSolver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronyAndMultithreading.Classes
{
    class ThreatParams
    {
        public StreamWriter streamWriter { get; set; }
        public List<Equation> equations { get; set; }
        public Stopwatch stopWatch { get; set; }

        public ThreatParams(StreamWriter streamWriter, List<Equation> equations, Stopwatch stopWatch)
        {
            this.streamWriter = streamWriter;
            this.equations = equations;
            this.stopWatch = stopWatch;
        }
    }
}
