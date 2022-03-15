﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreCoreSample.Models.Repositories
{
   public interface IBookStoreRepository<TEntity>
    {
        IList<TEntity> List();
        TEntity Find(int id);
        void Delete(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity newEntity);
    }
}
