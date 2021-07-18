using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Interfaces
{
    public interface IPaginator<T> where T : class
    {
        public IQueryable<T> BuildPageResult<TOrder>(
            IQueryable<T> data,
            int page,
            int perPage,
            Expression<Func<T, TOrder>> orderByExp,
            bool isDescending = true
            );

        public IQueryable<T> BuildPageResult<TOrder>(
            IQueryable<T> data,
            int page,
            int perPage,
            Expression<Func<T, bool>> whereExp,
            Expression<Func<T, TOrder>> orderByExp
            );
    }
}
