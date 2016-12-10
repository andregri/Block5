using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise08;

namespace ClassTest
{
    [TestClass]
    public class UnitTest08
    {
        [TestMethod]
        public void TestObserverPattern()
        {
            ObservableQuote publisher = new ObservableQuote();
            QuoteRepository quotes = new QuoteRepository();
            IBMObserver ibmObserver = new IBMObserver();
            DELLObserver dellObserver = new DELLObserver();

            ibmObserver.Subscribe(publisher);
            dellObserver.Subscribe(publisher);

            publisher.OpenStockExchange(quotes.GetAllQuotes());
            Assert.AreEqual(3.2m, ibmObserver.MaxValueMln);
            Assert.AreEqual(1.46d, ibmObserver.MaxGrowth, 0.01d);
            Assert.AreEqual(2.9m, dellObserver.MaxValueMln);
            Assert.AreEqual(0.38d, dellObserver.MaxGrowth, 0.01d);

            publisher.CloseStockExchange();
            ibmObserver.Unsubscribe();
            dellObserver.Unsubscribe();
        }
    }
}
