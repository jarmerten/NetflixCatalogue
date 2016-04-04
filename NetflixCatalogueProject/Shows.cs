using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueProject
{
    class Shows: Title
    {
        List<string> EpisodesList = new List<string>();
        public int? episodeRating;
        public string amountOfTotalEpisodes;
        public string titleOfShow;
        public void AddEpisodesToList ()
        {
            EpisodesList.Add("Episode 1");
            EpisodesList.Add("Episode 2");
            EpisodesList.Add("Episode 3");
            EpisodesList.Add("Episode 4");
            EpisodesList.Add("Episode 5");
            EpisodesList.Add("Episode 6");
            EpisodesList.Add("Episode 7");
        }
        public override string ToString()
        {
            return titleOfShow + amountOfTotalEpisodes;
        }
        public override int? RatingOfMovieOrShow()
        {
            return episodeRating;
        }
    }
}
