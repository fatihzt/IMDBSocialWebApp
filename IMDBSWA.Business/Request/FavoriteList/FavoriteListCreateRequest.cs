using IMDBSWA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBSWA.Business.Request.FavoriteList
{
    public class FavoriteListCreateRequest
    {
        public string ListTitle { get; set; }
        [ForeignKey("UserId")]
        public int? UserId { get; set; }
        public ListContent ListContent { get; set; }
        public ListType ListType { get; set; }

    }
}
