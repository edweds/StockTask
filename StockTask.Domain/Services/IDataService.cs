﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockTask.Domain.Services
{
    interface IDataService <T>
    {
        Task<IEnumerable <T>> GetAll();
        Task<T> Get(int id);
        Task<T> Create(T entity);
        Task<T> Update(int id, T entity);
        Task<bool> Delete(int id);
    }
}
