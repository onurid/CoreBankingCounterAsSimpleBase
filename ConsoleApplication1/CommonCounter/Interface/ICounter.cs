namespace CommonCounter.Interface
{
    public interface ICounter<T> 
    {
        bool Initial();
        T GetNextCounterData();
    }
}
