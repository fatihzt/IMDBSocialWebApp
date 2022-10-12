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
    public class LikedListManager : ILikedListService
    {
        private readonly ILikedList _likedList;
        public LikedListManager(ILikedList likedList)
        {
            _likedList= likedList;
        }
        public int Add(LikedList entity)
        {
            return _likedList.Add(entity);
        }

        public bool Delete(LikedList entity)
        {
            return _likedList.Delete(entity);
        }

        public LikedList Get(Expression<Func<LikedList, bool>> filter = null, Func<IQueryable<LikedList>, IIncludableQueryable<LikedList, object>> includesPath = null)
        {
            return _likedList.Get(filter, includesPath);
        }

        public List<LikedList> GetAll(Expression<Func<LikedList, bool>> filter = null, Func<IQueryable<LikedList>, IIncludableQueryable<LikedList, object>> includesPath = null)
        {
            return _likedList.GetAll(filter, includesPath);
        }

        public bool Update(LikedList entity)
        {
            return _likedList.Update(entity);
        }
    }
}
