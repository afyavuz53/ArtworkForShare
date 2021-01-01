﻿using ArtworkForShare.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ArtworkForShare.Core.DataAccess.EntityFramework
{
    public class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        TContext context;
        public EFRepositoryBase()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddDbContext<TContext>();
            ServiceProvider provider = services.BuildServiceProvider();
            context = provider.GetService<TContext>();
        }
        public void Add(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] include)
        {
            return context.Set<TEntity>().Where(filter).MyInclude(include).SingleOrDefault();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] include)
        {
            if (filter == null)
            {
                return context.Set<TEntity>().MyInclude(include).ToList();
            }
            else
            {
                return context.Set<TEntity>().Where(filter).MyInclude(include).ToList();
            }
        }
    }
}
