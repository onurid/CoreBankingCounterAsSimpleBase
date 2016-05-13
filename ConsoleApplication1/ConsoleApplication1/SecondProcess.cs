using CommonCounter;
using ConsoleApplication1.Model;

namespace ConsoleApplication1
{
    public class SecondProcess
    {
        public Counter Doit()
        {
            var counterData = new Counter()
            {
                Id = 1,
                IncrementValue = 10,
                InitialValue = 10,
                Key = "secondclass",
                MaxValue = 100,
                Period = "Monthly",
                Recyle = false,
                Value = null
            };
            

            var counterProcess = new CounterProcess<Counter>(counterData);

            counterData = counterProcess.GetNextCounterData();


            return counterData;
        }
    }
}