using System;
using System.Collections.Generic;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueProject
{
    public class Genre: IEnumerable
    {
        public List<Title> TitleList = new List<Title>();
        public string[] MovieGenre = new string[4] { "All", "Romance", "Action", "Comedy" };
        string genreOne;
        string genreTwo;
        string newGenre;
        string oldGenre;
        public Genre()
        {
        }
        public void AddTitleToList<T>()
        {
            TitleList.Add(new Title("Wedding Crashers",160,5, MovieGenre.ElementAt(0)));
            TitleList.Add(new Title("Bad Boys",120,4, MovieGenre.ElementAt(2)));
            TitleList.Add(new Title("Super Troopers",180,4, MovieGenre.ElementAt(3)));
            TitleList.Add(new Title("Iron Man",160,2, MovieGenre.ElementAt(2)));
            TitleList.Add(new Title("The Martian",120,3, MovieGenre.ElementAt(2)));
            TitleList.Add(new Title("Interstellar",15,6, MovieGenre.ElementAt(2)));
            TitleList.Add(new Title("The Office", 120, 3, 16, MovieGenre.ElementAt(0)));
            TitleList.Add(new Title("White Collar", 15, 6, 17, MovieGenre.ElementAt(1)));
            TitleList.Add(new Title("Blindspot", 120, 3, 18, MovieGenre.ElementAt(2)));
            TitleList.Add(new Title("Quantico", 15, 6, 48, MovieGenre.ElementAt(2)));
        }
        public IEnumerator<Title> GetEnumerator()
        {
            for (int i = 0; i < TitleList.Count; i++)
            {
                yield return TitleList[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Genre(string genreOne, string genreTwo, string title)
        {
            this.genreOne = genreOne;
            this.genreTwo = genreTwo;
        }
        public Genre(string genreOne, string genreTwo)
        {
            this.genreOne = genreOne;
            this.genreTwo = genreTwo;
        }
        public static Genre operator +(Genre c1, Genre c2)
        {
            return new Genre(c1.genreOne + c2.genreOne, c1.genreTwo + c2.genreTwo);
        }
        public override string ToString()
        {
            return (String.Format(genreOne + genreTwo));
        }

    }
}
