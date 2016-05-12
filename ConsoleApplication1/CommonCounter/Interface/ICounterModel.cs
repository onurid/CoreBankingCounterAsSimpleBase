namespace CommonCounter.Interface
{
    public interface ICounterModel
    {
        int? Value { get; set; }
        int InitialValue { get; set; }

        int IncrementValue { get; set; }

        int MaxValue { get; set; }

        bool Recyle { get; set; }
    }
}
