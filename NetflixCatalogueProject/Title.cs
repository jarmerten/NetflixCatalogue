using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueProject
{
        public class Title
        {
        public Title()
        {
        }
            public int? rating;
            public string titleOfMovie;
            public int? lengthOfMovie;
            public int? howmanyepisodes;
            public string genreofmovie;
            string titleOne;
            string titleTwo;
        public Title(string AddATitle, int Duration, int Rating, string Genre)
            {
                 titleOfMovie = AddATitle;
                 lengthOfMovie = Duration;
                 rating = Rating;
                 genreofmovie = Genre;
            }
        public Title(string AddATitle, int Duration, int Rating, int howmanyEpisodes,string Genre)
            {
                titleOfMovie = AddATitle;
                lengthOfMovie = Duration;
                rating = Rating;
                howmanyepisodes = howmanyEpisodes;
                genreofmovie = Genre;
            }
        public Title(string titleOne, string titleTwo)
            {
                this.titleOne = titleOne;
                this.titleTwo = titleTwo;
            }
            public static Title operator +(Title c1, Title c2)
            {
                return new Title(c1.titleOne + c2.titleOne, c1.titleTwo + c2.titleTwo);
            }
            public override string ToString()
            {
                return (String.Format(titleTwo));
            }
            public void SetAllFields(string title, int? Rating)
            {
            title = titleOne;
            Rating = rating;
            }
            public void SetAllFields()
            {
            rating = null;
            titleOne = null;
            }
            public virtual string TitleOfMovieOrShow()
            {
                  return titleOne;
            }
            public virtual int? LengthOfMovie()
            {
                  return lengthOfMovie;
            }
            public virtual int? RatingOfMovieOrShow()
            {
                  return rating;
            }
            public virtual int? NumberOfEpisodes()
            {
                  return null;
            }

        }


}

