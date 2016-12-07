using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace ClassTest
{
    [TestClass]
    public class UnitTest09
    {
        Library.Library library = new Library.Library();
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
            //add items to library
            library.AddLibraryBook(b1.Title, b1.Publisher, b1.CopyrightYear, b1.LoanPeriod, b1.CallNumber, ((LibraryBook)b1).Author);
            library.AddLibraryBook(b2.Title, b2.Publisher, b2.CopyrightYear, b2.LoanPeriod, b2.CallNumber, ((LibraryBook)b2).Author);

            library.AddLibraryMovie(m1.Title, m1.Publisher, m1.CopyrightYear, m1.LoanPeriod, m1.CallNumber, ((LibraryMediaItem)m1).Duration, ((LibraryMovie)m1).Director, ((LibraryMediaItem)m1).Medium, ((LibraryMovie)m1).Rating);
            library.AddLibraryMovie(m2.Title, m2.Publisher, m2.CopyrightYear, m2.LoanPeriod, m2.CallNumber, ((LibraryMediaItem)m2).Duration, ((LibraryMovie)m2).Director, ((LibraryMediaItem)m2).Medium, ((LibraryMovie)m2).Rating);

            library.AddLibraryMusic(t1.Title, t1.Publisher, t1.CopyrightYear, t1.LoanPeriod, t1.CallNumber, ((LibraryMediaItem)t1).Duration, ((LibraryMusic)t1).Artist, ((LibraryMediaItem)t1).Medium, ((LibraryMusic)t1).NumTracks);
            library.AddLibraryMusic(t2.Title, t2.Publisher, t2.CopyrightYear, t2.LoanPeriod, t2.CallNumber, ((LibraryMediaItem)t2).Duration, ((LibraryMusic)t2).Artist, ((LibraryMediaItem)t2).Medium, ((LibraryMusic)t2).NumTracks);

            library.AddLibraryJournal(j1.Title, j1.Publisher, j1.CopyrightYear, j1.LoanPeriod, j1.CallNumber, ((LibraryPeriodical)j1).Volume, ((LibraryPeriodical)j1).Number, ((LibraryJournal)j1).Discipline, ((LibraryJournal)j1).Editor);
            library.AddLibraryJournal(j2.Title, j2.Publisher, j2.CopyrightYear, j2.LoanPeriod, j2.CallNumber, ((LibraryPeriodical)j2).Volume, ((LibraryPeriodical)j2).Number, ((LibraryJournal)j2).Discipline, ((LibraryJournal)j2).Editor);

            library.AddLibraryMagazine(z1.Title, z1.Publisher, z1.CopyrightYear, z1.LoanPeriod, z1.CallNumber, ((LibraryPeriodical)z1).Volume, ((LibraryPeriodical)z1).Number);
            library.AddLibraryMagazine(z2.Title, z2.Publisher, z2.CopyrightYear, z2.LoanPeriod, z2.CallNumber, ((LibraryPeriodical)z2).Volume, ((LibraryPeriodical)z2).Number);

            //add patrons
            library.AddPatron(patron1.PatronName, patron1.PatronID);
            library.AddPatron(patron2.PatronName, patron2.PatronID);

            //checkout some items
            library.CheckOut(0, 0);
            library.CheckOut(3, 0);
            library.CheckOut(6, 0);

            library.CheckOut(1, 1);
            library.CheckOut(2, 1);
            library.CheckOut(5, 1);
            library.CheckOut(8, 1);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
