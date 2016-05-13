using ConsoleApplication1.Model;
using FluentAssertions;
using NUnit.Framework;

namespace CommonCounter.UnitTest
{
    [TestFixture]
    public class CommonCounterTest
    {
        [Test]
        public void CounterProcess_Test()
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

            counterData = counterProcess.GetNextCounterData();

            counterData.Value.Should().Be(10);
        }
    }
}
