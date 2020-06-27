using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MyCMS.Blog.Entities.Interfaces;
namespace MyCMS.Blog.DataAccess.Interfaces
{
    public  interface IGenericDal<TEntity> where TEntity:class,ITable,new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>filter);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>>filter);
        Task AddSync(TEntity entity);
        Task UpdateSync(TEntity entity);
        Task RemoveSync(TEntity entity);


    }
}
