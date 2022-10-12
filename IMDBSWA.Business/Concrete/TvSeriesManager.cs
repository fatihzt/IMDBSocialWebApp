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
    public class TvSeriesManager : ITvSeriesService
    {
        private readonly ITvSeries _tvSeries;
        public TvSeriesManager(ITvSeries tvSeries)
        {
            _tvSeries = tvSeries;
        }

        public int Add(TvSeries entity)
        {
            return _tvSeries.Add(entity);
        }

        public bool Delete(TvSeries entity)
        {
            return _tvSeries.Delete(entity);
        }

        public TvSeries Get(Expression<Func<TvSeries, bool>> filter = null, Func<IQueryable<TvSeries>, IIncludableQueryable<TvSeries, object>> includesPath = null)
        {
            return _tvSeries.Get(filter, includesPath);
        }

        public List<TvSeries> GetAll(Expression<Func<TvSeries, bool>> filter = null, Func<IQueryable<TvSeries>, IIncludableQueryable<TvSeries, object>> includesPath = null)
        {
            return _tvSeries.GetAll(filter, includesPath);
        }

        public bool Update(TvSeries entity)
        {
            return _tvSeries.Update(entity);
        }
    }
}
