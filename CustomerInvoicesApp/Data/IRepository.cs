﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerInvoicesApp.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
       
        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
