using IMDBSWA.Core.Abstract;
using IMDBSWA.Core.EntityFramework;
using IMDBSWA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBSWA.Core.Concrete
{
    public class EfUser:EfEntityRepositoryBase<User,DataBaseContext>,IUser
    {
    }
}
