using CommonCounter.Interface;

namespace CommonCounter
{
    public abstract class BaseCounter<T> : ICounter<T> where T : ICounterModel
    {
        private readonly T counter;

        private bool hasValue { get; set; }
        private int newValue { get; set; }
        private bool isOverMaxValue { get; set; }
        private bool initialStatus { get; set; }

        protected BaseCounter(T counter)
        {
            this.counter = counter;

            initialStatus = false;
            if (!HasData(counter)) return;

            initialStatus = true;
            hasValue = HasValue(counter.Value);
        }


        public virtual T GetNextCounterData()
        {
            if (!initialStatus) return default(T);

            this.counter.Value = CalcNextCounterValue(hasValue, counter.InitialValue, counter.Recyle);

            return this.counter;
        }

        protected virtual int? CalcNextCounterValue(bool hasValue, int initialValue, bool recyle)
        {
            if (!hasValue) return initialValue;

            newValue = CalculateNewValue((int)counter.Value, counter.IncrementValue);
            isOverMaxValue = IsOverMaxValue(counter.MaxValue, newValue);

            if (!isOverMaxValue) return newValue;

            if (recyle) return initialValue;

            return null;
        }

        protected virtual bool IsOverMaxValue(int maxValue, int value)
        {
            return maxValue < value;
        }

        protected virtual int CalculateNewValue(int value, int incrementValue)
        {
            return value + incrementValue;
        }

        private static bool HasValue(int? value)
        {
            return value != null;
        }

        private static bool HasData(object data)
        {
            return data != null;
        }
    }
}
