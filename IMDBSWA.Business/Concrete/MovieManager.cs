using IMDBSWA.Business.Abstract;
using IMDBSWA.Core.Abstract;
using IMDBSWA.Entities;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IMDBSWA.Business.Concrete
{
    public class MovieManager : IMovieService
    {
        private readonly IMovie _movie;
        public MovieManager(IMovie movie)
        {
            _movie= movie;
        }
        public int Add(Movie entity)
        {
            return _movie.Add(entity);
        }

        public bool Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public Movie Get(Expression<Func<Movie, bool>> filter = null, Func<IQueryable<Movie>, IIncludableQueryable<Movie, object>> includesPath = null)
        {
            return _movie.Get(filter, includesPath);
        }

        public List<Movie> GetAll(Expression<Func<Movie, bool>> filter = null, Func<IQueryable<Movie>, IIncludableQueryable<Movie, object>> includesPath = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}
