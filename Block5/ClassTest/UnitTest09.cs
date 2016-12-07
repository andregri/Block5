using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System.Collections.Generic;
using System.Linq;

namespace ClassTest
{
    [TestClass]
    public class UnitTest09
    {
        List<LibraryItem> items = new List<LibraryItem>();
        List<LibraryPatron> patrons = new List<LibraryPatron>();

        //patrons
        LibraryPatron patron1 = new LibraryPatron("Andrew", "a1w");
        LibraryPatron patron2 = new LibraryPatron("Mike", "m2o");
        //books
        LibraryItem b1 = new LibraryBook("Multithreading with C# Cookbook - Second Edition", "Packt Publishing", 2016, 14, "ZZ25 3G", "Eugene Agafonov");
        LibraryItem b2 = new LibraryBook("Agile Software Development: Principles, Patterns, and Practices", "Prentice Hall", 2002, 14, "ZZ27 3G", "Robert Cecil Martin ");
        //movies
        LibraryItem m1 = new LibraryMovie("The Lord of the Rings: The Fellowship of the Ring", "New Line Cinema", 2002, 7, "MM33 2D", 178, "Peter Jackson", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG);
        LibraryItem m2 = new LibraryMovie("Star Wars", "LucasFilm", 1977, 7, "MM35 3D", 97.5, "George Lucas", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG);
        //music
        LibraryItem t1 = new LibraryMusic("Ten", "Epic", 1991, 14, "CD44 4Z", 53.2, "Pearl Jam", LibraryMediaItem.MediaType.CD, 11);
        LibraryItem t2 = new LibraryMusic("Born to Run", "columbia", 1975, 14, "CD46 4Z", 39.26, "Bruce Springsteen", LibraryMediaItem.MediaType.CD, 8);
        //journals
        LibraryItem j1 = new LibraryJournal("IEEE Transactions on Pattern Analysis and Machine Intelligence", "IEEE", 2011, 14, "JJ12 7M", 1, 2, "Bioengineering Computing & Processing", "David A. Forsyth");
        LibraryItem j2 = new LibraryJournal("IEEE Transactions on Image Processing", "IEEE", 2011, 14, "JJ15 7M", 1, 2, "Image Processing", "Scott Acton");
        //mags
        LibraryItem z1 = new LibraryMagazine("C# Monthly", "Unige Mags", 2010, 14, "MA53 9A", 16, 9);
        LibraryItem z2 = new LibraryMagazine("C# Monthly", "Unige Mags", 2010, 14, "MA57 9A", 19, 12);

        [TestInitialize]
        public void Initialize()
        {
            //add items to list
            items.Add(b1);
            items.Add(b2);
            items.Add(m1);
            items.Add(m2);
            items.Add(t1);
            items.Add(t2);
            items.Add(j1);
            items.Add(j2);
            items.Add(z1);
            items.Add(z2);

            //add patrons to list
            patrons.Add(patron1);
            patrons.Add(patron2);

            //checkout some items
            items[0].CheckOut(patron1);
            items[3].CheckOut(patron1);
            items[6].CheckOut(patron1);

            items[1].CheckOut(patron2);
            items[2].CheckOut(patron2);
            items[5].CheckOut(patron2);
            items[8].CheckOut(patron2);
        }

        [TestMethod]
        public void TestCheckedOutItems()
        {
            var checkedItems = from item in items
                                   where item.IsCheckedOut()
                                   select item;

            foreach (var i in checkedItems)
                Assert.IsTrue(i.IsCheckedOut());
        }
    }
}
