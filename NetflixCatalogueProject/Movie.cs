using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueProject
{
    class Movie: Title
    {
        string movieTitle;
        string durationOfMovie;
        public override string ToString()
        {
            return movieTitle + durationOfMovie;
        }
    }

}
