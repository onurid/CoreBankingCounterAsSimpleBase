using CommonCounter;
using CommonCounter.Interface;

namespace ConsoleApplication1
{
    // CommonCounter Kullanarak kendimize ait kendi kurallarimiza ait counter olusturmak icin bir ornek, tamamlamadim ama methodlari ezerek devam edebiliriz.
    public class AccountCounter<T> : BaseCounter<T> where T : ICounterModel
    {
        public AccountCounter(T counter) : base(counter)
        {
            
        }
    }
}
