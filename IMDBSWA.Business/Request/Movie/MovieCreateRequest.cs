using IMDBSWA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Lists;

namespace IMDBSWA.Business.Request.Movie
{
    public class MovieCreateRequest
    {
        public int MovieId { get; set; }
        public string Overview { get; set; }
        public string OriginalTitle { get; set; }
        public string OriginalLanguage { get; set; }
        public string PosterPath { get; set; }
        public string BackgroundPath { get; set; }
        public bool Adult { get; set; }
        public long Budget { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string HomepageLink { get; set; }
        public TMDbLib.Objects.General.Images Images { get; set; }

    }
}
