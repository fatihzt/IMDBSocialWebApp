using IMDBSWA.Business.Abstract;
using IMDBSWA.Business.Request.User;
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
    public class UserManager : IUserService
    {
        private readonly IUser _user;
        public UserManager(IUser user)
        {
            _user= user;
        }

        public int Add(User entity)
        {
            return _user.Add(entity);
        }

        public bool Delete(User entity)
        {
            return _user.Delete(entity);
        }

        public User Get(Expression<Func<User, bool>> filter = null, Func<IQueryable<User>, IIncludableQueryable<User, object>> includesPath = null)
        {
            return _user.Get(filter, includesPath);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null, Func<IQueryable<User>, IIncludableQueryable<User, object>> includesPath = null)
        {
            return _user.GetAll(filter, includesPath);
        }

        public bool Update(User entity)
        {
            return _user.Update(entity);
        }
    }
}
