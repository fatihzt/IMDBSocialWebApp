﻿using IMDBSWA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IMDBSWA.Core
{
    public class DataBaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:fatihozata.database.windows.net,1433;Initial Catalog=IMDBSWA;Persist Security Info=False;User ID=ozata;Password=fatih.0703;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        }
        public DbSet<User> User { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<TvSeries> TvSeries { get; set; }
        public DbSet<FavoriteList> FavoriteList { get; set; }
        public DbSet<LikedList> LikedList { get; set; }
        public DbSet<CommentedList> CommentedList { get; set; }
    }
}
