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
    public class TvSeries
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public int? TvSeriesId { get; set; }
        public string Name { get; set; }
        public string? OriginTitle { get; set; }
        public string Overview { get; set; }
        public string PosterPath { get; set; }
        public string BackgroundPath { get; set; }
        public DateTime? FirstAirDate { get; set; }
        public DateTime? LastAirDate { get; set; }
        public int NumberofEpisodes { get; set; }
        public int NumberofSeasons { get; set; }
        public string OriginalLanguage { get; set; }


    }
}
