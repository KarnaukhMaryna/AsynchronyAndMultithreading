using EquationSolver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronyAndMultithreading.Classes
{
    class Reader
    {
        public static List<Equation> ReadFromFile(StreamReader streamReader)
        {
            List<Equation> equations = new();
            double[] array = new double [3];
            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                var substring = line.Split(' ');
                for (int i = 0; i < substring.Length; i++)
                {
                    array[i] = double.Parse(substring[i]);
                }
                Equation equation = new();
                equation.Initialization(array);
                equations.Add(equation);
            }
            return equations;
        }
    }
}
