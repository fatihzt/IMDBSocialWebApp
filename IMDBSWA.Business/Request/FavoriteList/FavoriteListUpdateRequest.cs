using IMDBSWA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBSWA.Business.Request.FavoriteList
{
    public class FavoriteListUpdateRequest
    {
        public int Id { get; set; }
        public string ListTitle { get; set; }
        public int? UserId { get; set; }
        public ListContent ListContent { get; set; }
        public ListType ListType { get; set; }
    }
}
