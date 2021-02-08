﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic constraint
    //class : Referans tip
    //IEntity : IEntitiy olabilir veya IEntity implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı
    //filter=null filtresiz de olabilir, sadece filter var iste mutlaka filtre olmalıdır.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
