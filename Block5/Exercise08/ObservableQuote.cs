using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    public class ObservableQuote : IObservable<Quote>
    {
        private Dictionary<string, List<IObserver<Quote>>> observers;

        public ObservableQuote()
        {
            observers = new Dictionary<string, List<IObserver<Quote>>>();
        }

        public IDisposable Subscribe(IObserver<Quote> observer)
        {
            string id = ((IStockExchange)observer).Id;
            List<IObserver<Quote>> listObs;

            if (!observers.TryGetValue(id, out listObs))
            {
                observers[id] = new List<IObserver<Quote>>();
                observers[id].Add(observer);
            }
            else if (!observers[id].Contains(observer))
            {
                observers[id].Add(observer);
            }

            return new QuoteUnsubscriber(observers[id], observer);
        }

        public void OpenStockExchange(IEnumerable<Quote> quotes)
        {
            foreach (var quote in quotes)
            {
                string id = quote.Symbol;
                foreach (var observer in observers[id])
                {
                    observer.OnNext(quote);
                }
            }
        }

        public void CloseStockExchange()
        {
            foreach (var k in observers.Keys)
            {
                foreach (var observer in observers[k])
                {
                    observer.OnCompleted();
                }
            }
        }
    }
}
