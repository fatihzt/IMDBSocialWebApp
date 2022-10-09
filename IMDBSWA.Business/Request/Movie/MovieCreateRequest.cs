using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBSWA.Business.Request.Movie
{
    public class MovieCreateRequest
    {
        public int MovieId { get; set; }
        public string OriginalTitle { get; set; }
        public string OriginalLanguage { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
