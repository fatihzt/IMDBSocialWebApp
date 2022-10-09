using IMDBSWA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBSWA.Core
{
    public class DataBaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:fatihserver.database.windows.net,1433;Initial Catalog=PersonalFavList;Persist Security Info=False;User ID=fatihzt;Password=a784390bFatih;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        }
        public DbSet<User> User { get; set; }

    }
}
