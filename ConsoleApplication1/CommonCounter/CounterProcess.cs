using CommonCounter.Interface;

namespace CommonCounter
{
    public class CounterProcess<T> : BaseCounter<T> where T : ICounterModel
    {
        public CounterProcess(T counter) : base(counter) { }
    }
}