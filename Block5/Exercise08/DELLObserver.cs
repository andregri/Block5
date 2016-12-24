using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    public class DELLObserver : IStockExchange, IObserver<Quote>
    {
        private const string id = "DELL";
        private IDisposable cancellation;
        private List<double> growthHistory = new List<double>();
        private List<decimal> valueMlnHistory = new List<decimal>();

        public string Id
        {
            get
            {
                return id;
            }
        }

        public double MaxGrowth
        {
            get
            {
                return growthHistory.Max();
            }
        }

        public decimal MaxValueMln
        {
            get
            {
                return valueMlnHistory.Max();
            }
        }

        public void Subscribe(ObservableQuote publisher)
        {
            cancellation = publisher.Subscribe(this);
        }

        public void Unsubscribe()
        {
            cancellation.Dispose();
        }

        public void OnCompleted()
        {
            valueMlnHistory.Clear();
            growthHistory.Clear();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public void OnNext(Quote value)
        {
            valueMlnHistory.Add(value.Price);

            int count = valueMlnHistory.Count;
            if (count > 1)
            {
                decimal previous = valueMlnHistory[count - 2];
                decimal last = valueMlnHistory[count - 1];
                growthHistory.Add((double)(last - previous) / (double)previous);
            }
        }
    }
}
