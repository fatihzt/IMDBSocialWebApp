using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBSWA.Entities
{
    public class FavoriteList
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ListTitle { get; set; }
        [ForeignKey("UserId")]
        public int? UserId { get; set; }
        public ListContent ListContent { get; set; }
        public ListType ListType { get; set; }
        public virtual User User { get; set; }
    }
    public enum ListContent
    {
        Movie = 1,
        TvSeries = 2,
    }
    public enum ListType
    {
        Public = 1,
        Private = 2,
    }
}
