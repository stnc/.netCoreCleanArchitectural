﻿using MyCMS.Blog.Business.Interfaces;
using MyCMS.Blog.DataAccess.Interfaces;
using MyCMS.Blog.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyCMS.Blog.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {

        IGenericDal<TEntity> _genericDal;

        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task AddAsync(TEntity entity)
        {
         await _genericDal.AddAsync(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
          return  await _genericDal.GetAllAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _genericDal.GetAllAsync(filter);
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            return await _genericDal.GetAllAsync(filter,keySelector);
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            return await _genericDal.GetAllAsync(keySelector);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _genericDal.GetAsync(filter);
        }

        public async Task RemoveSync(TEntity entity)
        {
             await _genericDal.RemoveSync(entity);
        }

        public async Task UpdateSync(TEntity entity)
        {
            await _genericDal.UpdateSync(entity);

        }
    }
}
