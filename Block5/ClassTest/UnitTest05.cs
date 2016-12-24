using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise05;

namespace ClassTest
{
    [TestClass]
    public class UnitTest05
    {
        Participant[] guests;

        [TestInitialize]
        public void GuestInitialize()
        {
            guests = new Participant[]
            {
                new Participant("Mario", 35),
                new Participant("Luigi", 37),
                new Participant("Yoshi", 22),
                new Participant("Peach", 20),
                new Participant("Toad", 15),
                new Participant("Bowser", 40),
            };
        }

        [TestMethod]
        public void EventTest()
        {
            Event castleParty = new Event();

            for (int i = 0; i <= 5; i++)
            {
                castleParty.AddGuest(guests[i]);
            }


            string[] expectedName = new string[6];
            for (int i = 0; i <= 5; i++)
            {
                expectedName[i] = guests[i].Name;
            }

            int counter = 0; // just to correctly synchronize the counter

            foreach (Participant guest in castleParty)
            {
                Assert.AreEqual(expectedName[counter++], guest.Name);
            }
        }
    }
}
