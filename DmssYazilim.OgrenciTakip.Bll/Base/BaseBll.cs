﻿using DmssYazilim.Dal.Interfaces;
using DmssYazilim.OgrenciTakip.Bll.Functions;
using DmssYazilim.OgrenciTakip.Bll.Interfaces;
using DmssYazilim.OgrenciTakip.Common.Enums;
using DmssYazilim.OgrenciTakip.Common.Functions;
using DmssYazilim.OgrenciTakip.Common.Message;
using DmssYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace DmssYazilim.OgrenciTakip.Bll.Base
{
    //dal katmanından gelen verılerı user ınterface katmanına gondereceğız,ordan gelenlerı de dala dondereceğız.
    public class BaseBll<T, TContext> : IBaseBll where T : BaseEntity where TContext : DbContext
    {
        private readonly Control _ctrl;
        private IUnitOfWork<T> _uow;

        protected BaseBll()
        {
        }
        protected BaseBll(Control ctrl)
        {
            _ctrl = ctrl;
        }

        protected TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Find(filter, selector);
        }
        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);
        }
        protected bool BaseInsert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            //validation
            _uow.Rep.Insert(entity.EntityConvert<T>());
            return _uow.Save();
        }
        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);//ref denen uow un son halını gonderıyoruz
            var degisenAlanlar = oldEntity.DegisenAlanlariGetir(currentEntity);
            //degisen alan yoksa dırek trueeeğğ
            if (degisenAlanlar.Count == 0) return true;

            _uow.Rep.Update(currentEntity.EntityConvert<T>(), degisenAlanlar);
            return _uow.Save();
        }
        protected bool BaseDelete(BaseEntity entity, KartTuru kartTuru, bool mesajVer = true)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            if (mesajVer)
                if (Messages.SilMesaj(kartTuru.ToName()) != DialogResult.Yes) return false;

            _uow.Rep.Delete(entity.EntityConvert<T>());
            return _uow.Save();
        }

        #region Dispose
       
        public void Dispose()
        {
            _ctrl?.Dispose();
            _uow?.Dispose();
        }
        #endregion

    }
}
