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
        public int Add(Move entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Move entity)
        {
            throw new NotImplementedException();
        }

        public Move Get(Expression<Func<Move, bool>> filter = null, Func<IQueryable<Move>, IIncludableQueryable<Move, object>> includesPath = null)
        {
            throw new NotImplementedException();
        }

        public List<Move> GetAll(Expression<Func<Move, bool>> filter = null, Func<IQueryable<Move>, IIncludableQueryable<Move, object>> includesPath = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Move entity)
        {
            throw new NotImplementedException();
        }
    }
}
