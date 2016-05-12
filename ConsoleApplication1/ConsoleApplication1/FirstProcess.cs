using CommonCounter;
using ConsoleApplication1.Model;

namespace ConsoleApplication1
{
    public class FirstProcess
    {
        public Counter Doit()
        {
            var counterData = new Counter()
            {
                Id = 1,
                IncrementValue = 3,
                InitialValue = 7,
                Key = "firstclass",
                MaxValue = 100,
                Period = "Monthly",
                Recyle = false,
                Value = 40
            };
            
            var counterProcess = new CounterProcess<Counter>(counterData);

            if (counterProcess.Initial())
                counterData = counterProcess.GetNextCounterData();

            return counterData;
        }
    }
}