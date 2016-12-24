using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    internal class QuoteUnsubscriber : IDisposable
    {
        private List<IObserver<Quote>> observers;
        private IObserver<Quote> observer;

        public QuoteUnsubscriber(List<IObserver<Quote>> observers, IObserver<Quote> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
    }
}
