using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Title titleone = new Title("Die Hard", " Action ");
            Title titletwo = new Title("Super Troopers", " Comedy ");
            Title sum = titleone + titletwo;
            Console.WriteLine(sum);
            Console.ReadLine();

            Genre genre = new Genre();
            genre.AddTitleToList<Title>();
            Genre genreone = new Genre("Romantic ", " Comedy");
            Console.WriteLine(genreone);

                Genre newGenre = new Genre((genre.MovieGenre.ElementAt(1)), " Comedy" , "The Office");
                Console.WriteLine(" it is " + newGenre);   
            
            foreach(Title title in genre)
            {
                Console.WriteLine(title.titleOfMovie);
            }

            foreach (Title title in genre)
            {
                if((title.genreofmovie)=="All")
                {
                    Console.WriteLine(title.titleOfMovie);
                }
            }

            Console.ReadLine();
        }
    }
}
