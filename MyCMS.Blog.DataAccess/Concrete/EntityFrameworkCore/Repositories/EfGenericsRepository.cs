﻿using Microsoft.EntityFrameworkCore;
using MyCMS.Blog.DataAccess.Concrete.EntityFrameworkCore.Context;
using MyCMS.Blog.DataAccess.Interfaces;
using MyCMS.Blog.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyCMS.Blog.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericsRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            //throw new NotImplementedException();
            using var context = new MyBlogContext();
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
         
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            using var context = new MyBlogContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
          using var context = new MyBlogContext();
          return await context.Set<TEntity>().Where(filter).ToListAsync();
        }


        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter,Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new MyBlogContext();
            return await context.Set<TEntity>().Where(filter).OrderByDescending(keySelector).ToListAsync();
        }


        public async Task<List<TEntity>> GetAllAsync<TKey>( Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new MyBlogContext();
            return await context.Set<TEntity>().OrderByDescending(keySelector).ToListAsync();
        }


        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new MyBlogContext();
            return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task RemoveSync(TEntity entity)
        {
            using var context = new MyBlogContext();
            context.Remove(entity);
           await context.SaveChangesAsync();
        }

        public async  Task UpdateSync(TEntity entity)
        {
            using var context = new MyBlogContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }

  
}
