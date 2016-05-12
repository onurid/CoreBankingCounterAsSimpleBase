using System;
using System.Threading;

namespace ConsoleApplication1
{
    public class Process
    {
        public Process()
        {
            var firstProcess = new Thread(new ThreadStart(Doit1));
            var secondProcess = new Thread(new ThreadStart(Doit2));

            firstProcess.Start();
            secondProcess.Start();
        }

        public void Doit1()
        {
            var result = new FirstProcess().Doit();

            Console.WriteLine("Thread - Data1: " + result.Key + "  Value: " + result.Value);
        }

        public void Doit2()
        {
            var result = new SecondProcess().Doit();

            Console.WriteLine("Thread - Data2: " + result.Key + "  Value: " + result.Value);
        }
    }
}