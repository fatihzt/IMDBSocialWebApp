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
    public class CommentedListManager : ICommentedListService
    {
        private readonly ICommentedList _commentedList;
        public CommentedListManager(ICommentedList commentedList)
        {
            _commentedList= commentedList;
        }
        public int Add(CommentedList entity)
        {
            return _commentedList.Add(entity);
        }

        public bool Delete(CommentedList entity)
        {
            return _commentedList.Delete(entity);
        }

        public CommentedList Get(Expression<Func<CommentedList, bool>> filter = null, Func<IQueryable<CommentedList>, IIncludableQueryable<CommentedList, object>> includesPath = null)
        {
            return _commentedList.Get(filter, includesPath);
        }

        public List<CommentedList> GetAll(Expression<Func<CommentedList, bool>> filter = null, Func<IQueryable<CommentedList>, IIncludableQueryable<CommentedList, object>> includesPath = null)
        {
            return _commentedList.GetAll(filter, includesPath);
        }

        public bool Update(CommentedList entity)
        {
            return _commentedList.Update(entity);
        }
    }
}
