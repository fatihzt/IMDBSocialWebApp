using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Objects.General;


namespace IMDBSWA.Entities
{
    public class Movie
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public int MovieId { get; set; }
        public string Overview { get; set; }
        public string OriginalTitle { get; set; }
        public string OriginalLanguage { get; set; }
        public string PosterPath { get; set; }
        public string BackgroundPath { get; set; }
        public bool Adult { get; set; }
        public long Budget { get; set; }
        public int? Runtime { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
