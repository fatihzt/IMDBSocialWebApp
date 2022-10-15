using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBSWA.Entities
{
    public class CommentedList
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("FavoriteListId")]
        public int? FavoriteListId { get; set; }
        [ForeignKey("UserId")]
        public int? UserId { get; set; }
        public string Comment { get; set; }
        public virtual FavoriteList FavoriteList { get; set; }
        public virtual User User { get; set; }
    }
}
