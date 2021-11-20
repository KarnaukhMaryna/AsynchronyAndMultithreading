using EquationSolver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronyAndMultithreading.Classes
{
    public static class StreamWriterExtension
    {
        public static void AddEquation(this StreamWriter streamWriter, Equation equation)
        {
            streamWriter.Write(equation.A);
            streamWriter.Write(" ");
            streamWriter.Write(equation.B);
            streamWriter.Write(" ");
            streamWriter.WriteLine(equation.C);
            streamWriter.Flush();
        }

        public static void AddEquations(this StreamWriter streamWriter, List<Equation> equations)
        {
            foreach (var equation in equations)
            {
                streamWriter.AddEquation(equation);
            }
        }
    }
}
