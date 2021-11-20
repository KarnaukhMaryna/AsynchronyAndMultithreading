using AsynchronyAndMultithreading.Classes;
using EquationSolver;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace AsynchronyAndMultithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Project1";
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
            DirectoryInfo directory = Directory.CreateDirectory(path);
            string filenameInput = $"{directory}\\input.txt";
            string filenameOutput = $"{directory}\\output.txt";

            using (StreamWriter streamWriter = new(filenameInput))
                for (int i = 0; i < 10; i++)
                {
                    Equation equation = new();
                    equation.Initialization();
                    streamWriter.AddEquation(equation);
                }

            Stopwatch stopWatch = new();
            stopWatch.Start();

            List<Equation> equations = new();

            using (StreamReader streamReader = new(filenameInput))
                equations = Reader.ReadFromFile(streamReader);

            StreamWriter streamWriter1 = new(filenameOutput);
            ThreatParams threatParams = new (streamWriter1, equations, stopWatch);
            Thread myThread = new (new ParameterizedThreadStart(WriterForExplanation.WriteExplanation));
            myThread.Start(threatParams);           
        }
    }
}
