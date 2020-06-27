using MyCMS.Blog.DataAccess.Interfaces;
using MyCMS.Blog.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyCMS.Blog.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericsRepository<Tentity> : IGenericDal<Tentity> where Tentity : class, ITable, new()
    {
        public Task AddSync(Tentity entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tentity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Tentity>> GetAllAsync(Expression<Func<Tentity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<Tentity> GetAsync(Expression<Func<Tentity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSync(Tentity entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSync(Tentity entity)
        {
            throw new NotImplementedException();
        }
    }
}
