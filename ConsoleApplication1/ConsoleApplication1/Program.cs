using System;
using CommonCounter;
using CommonCounter.Interface;
using ConsoleApplication1.Model;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ornek A: New Process with Thread and two example
            new Process();

            // Ornek B: DoIt without Thread and just one example
            var result = DoIt();
            Console.WriteLine("Result: " + result.Key + "  Value: " + result.Value);


            Console.ReadKey();
        }

        private static Counter DoIt()
        {
            var counterData = new Counter()
            {
                Id = 1,
                IncrementValue = 10,
                InitialValue = 10,
                Key = "TEST",
                MaxValue = 100,
                Period = "Monthly",
                Recyle = false,
                Value = null
            };

            
            var counterProcess = new CounterProcess<Counter>(counterData);

            if (counterProcess.Initial())
                counterData = counterProcess.GetNextCounterData();


            return counterData;
        }
    }
}
