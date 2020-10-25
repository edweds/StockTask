﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using StockTask.Domain.Models;
using StockTask.Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockTask.EntityFramework.Services
{
    public class GenericDataService<T> : IDataService<T> where T: TableDomainObject
    {
        private readonly DesignDbContextOptions _contextFactory;

        public GenericDataService(DesignDbContextOptions contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using (StockTaskDbContext context = _contextFactory.CreateDbContext())
            {
                EntityEntry <T> createdEntity = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return createdEntity.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (StockTaskDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e)=>e.Id==id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<T> Get(int id)
        {
            using (StockTaskDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);                
                return entity;
            }
        }

        public  async Task<IEnumerable<T>> GetAll()
        {
            using (StockTaskDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();
                return entities;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (StockTaskDbContext context = _contextFactory.CreateDbContext())
            {
                entity.Id = id;
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();
                return entity;
            }
        }
    }
}
