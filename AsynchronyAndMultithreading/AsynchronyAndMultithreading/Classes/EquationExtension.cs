using EquationSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronyAndMultithreading.Classes
{
    static class EquationExtension
    {
        public static void Initialization(this Equation equation)
        {
            Random random = new ();
            equation.A = Math.Round(random.NextDouble(), 3);
            equation.B = Math.Round(random.NextDouble(), 3);
            equation.C = Math.Round(random.NextDouble(), 3);
        }

        public static void Initialization(this Equation equation, double[] array)
        {
            equation.A = array[0];
            equation.B = array[1];
            equation.C = array[2];
        }
    }
}
