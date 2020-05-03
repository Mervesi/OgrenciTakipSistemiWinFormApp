﻿using DmssYazilim.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DmssYazilim.Dal.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Variables
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;//_li olmasının sebebi yerel bir değişken oldugunu ıfade eder.
                                         //readonly degıskenlere olusturuldugu anda yada tanımlandıgı clasın ctorun da deger atanabilir.baska yerde atanmaz. 
        #endregion
        public Repository(DbContext context)
        {
            if (context == null) return;
            _context = context;
            _dbSet = _context.Set<T>();

        }

        public void Insert(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Insert(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
        }
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update(T entity, IEnumerable<string> fields)//degısmeyen alanların update işlemi
        {
            _dbSet.Attach(entity);
            var entry = _context.Entry(entity);
            foreach (var field in fields)
            {
                entry.Property(field).IsModified = true;
            }
        }

        public void Update(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }
        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Delete(IEnumerable<T> entities)
        {

            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }

        public TResult Find<TResult>(Expression<Func<T, bool>> filter,Expression<Func<T,TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector).FirstOrDefault() : _dbSet.Where(filter).Select(selector).FirstOrDefault();
            //eger fıltre null ıse gıt sadece benım sanana gonderecegımden ılk kaydı dondur.
        }
        
        public IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector) : _dbSet.Where(filter).Select(selector);
        }

        #region Disposable
        private bool _disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();

                    _disposedValue = true;
                }
                
            }
        }
        public void Dispose()
        { 
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
