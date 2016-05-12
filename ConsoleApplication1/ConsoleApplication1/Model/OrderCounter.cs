using CommonCounter.Interface;

namespace ConsoleApplication1.Model
{
    public class OrderCounter: ICounterModel
    {
        public virtual int Id { get; set; }
        public virtual int CustomerId { get; set; }
        public virtual string Number { get; set; }
        public int? Value { get; set; }
        public int InitialValue { get; set; }
        public int IncrementValue { get; set; }
        public int MaxValue { get; set; }
        public bool Recyle { get; set; }
    }
}
