﻿using System;
using System.Linq.Expressions;
using UploadService.Core.Entities.Abstract;

namespace UploadService.Core.DataAccess
{
    public interface IRepositoryBase<TEntity>
        where TEntity : class, IEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);

        //Task AddAsync(TEntity entity);
        //Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);
    }
}

