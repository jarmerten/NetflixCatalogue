using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCatalogueProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueProject.Tests
{
    [TestClass()]
    public class GenreTests
    {
        [TestMethod()]
        public void AddOneItemToMovieList()
        {
            Genre genre = new Genre();
            genre.TitleList.Add(new Title("Wedding Crashers", 160, 5, "funny"));
            Assert.AreEqual( genre.TitleList.Count() , 1);
        }
        [TestMethod()]
        public void CheckMovieTitleIsNull()
        {
            Title title = new Title();
            Genre genre = new Genre();
            genre.TitleList.Add(new Title("Wedding Crashers", 160, 5, "funny"));
            Assert.AreEqual(title.titleOfMovie, null);
        }
        [TestMethod()]
        public void CheckAddedMovieTitleCorrect()
        {
            Title FindCorrectMovieTitle = new Title("Wedding Crashers", 160, 5, "Romantic");
            Genre genre = new Genre();
            genre.TitleList.Add(FindCorrectMovieTitle);
            Assert.AreEqual(FindCorrectMovieTitle.titleOfMovie, "Wedding Crashers");
        }
        [TestMethod()]
        public void CheckGenresReadCorrectly()
        {
            Genre genre = new Genre();          
            Assert.AreEqual(genre.MovieGenre.ElementAt(0), "All");
        }
        [TestMethod()]
        public void CheckLengthOfList()
        {
            Title FindCorrectMovieTitle = new Title();
            Genre genre = new Genre();
            genre.AddTitleToList<Title>();
            Assert.AreEqual(genre.TitleList.Count, 10);
        }



    }
}