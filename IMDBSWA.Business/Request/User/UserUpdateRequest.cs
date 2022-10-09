using IMDBSWA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBSWA.Business.Request.User
{
    public class UserUpdateRequest
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }
        public string Mail { get; set; }
        public string TelNo { get; set; }
        public GenderType Gender { get; set; }
    }
}
