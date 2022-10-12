using IMDBSWA.Business.Abstract;
using IMDBSWA.Core.Abstract;
using IMDBSWA.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IMDBSWA.Business.Concrete
{
    public class FavoriteListManager : IFavoriteListService
    {
        private readonly IFavoriteList _favoriteList;
        public FavoriteListManager(IFavoriteList favoriteList)
        {
            _favoriteList= favoriteList;
        }
        public int Add(FavoriteList entity)
        {
            return _favoriteList.Add(entity);
        }

        public bool Delete(FavoriteList entity)
        {
            return _favoriteList.Delete(entity);
        }

        public FavoriteList Get(Expression<Func<FavoriteList, bool>> filter = null, Func<IQueryable<FavoriteList>, IIncludableQueryable<FavoriteList, object>> includesPath = null)
        {
            return _favoriteList.Get(filter, includesPath);
        }

        public List<FavoriteList> GetAll(Expression<Func<FavoriteList, bool>> filter = null, Func<IQueryable<FavoriteList>, IIncludableQueryable<FavoriteList, object>> includesPath = null)
        {
            return _favoriteList.GetAll(filter,includesPath);
        }

        public bool Update(FavoriteList entity)
        {
            return _favoriteList.Update(entity);
        }
    }
}
