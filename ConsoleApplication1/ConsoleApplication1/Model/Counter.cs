using CommonCounter.Interface;

namespace ConsoleApplication1.Model
{
    public class Counter : ICounterModel
    {
        public virtual int Id { get; set; }
        public virtual string Key { get; set; }
        public virtual int? Value { get; set; }
        public virtual string Period { get; set; }
        public virtual int InitialValue { get; set; }
        public virtual int IncrementValue { get; set; }
        public virtual int MaxValue { get; set; }
        public virtual bool Recyle { get; set; }
    }
}
