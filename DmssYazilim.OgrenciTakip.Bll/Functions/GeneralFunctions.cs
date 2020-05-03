using DmssYazilim.Dal.Base;
using DmssYazilim.Dal.Interfaces;
using DmssYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;

namespace DmssYazilim.OgrenciTakip.Bll.Functions
{
    public static class GeneralFunctions
    {
        public static IList<string>DegisenAlanlariGetir<T>(this T oldEntity, T currentEntity)//this yazınca extentıon metod oluyor
        {
            IList<string> alanlar = new List<string>();//ınterfacelerın ınstancesı alınmadıgı ıcın lıst tıpınden ornekleme yaptık

            foreach (var prop in currentEntity.GetType().GetProperties())//reflectıon yapıldı
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue ;//gelenın tipi buysa devam et,yanı eger generıcse
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                if (prop.PropertyType == typeof(byte[]))//eger bu property bır byte dızısı ıse(resım vs.)
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                        oldValue = new byte[] { 0 };//gelen byte prop boşsa default 0 ata
                    if (string.IsNullOrEmpty(currentEntity.ToString()))
                        currentValue = new byte[] { 0 };
                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                        alanlar.Add(prop.Name);
                }
                else if (!currentValue.Equals(oldValue))
                    alanlar.Add(prop.Name);
;            }
            return alanlar;
        }
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["OgrenciTakipContext"].ConnectionString;
        }

        private  static TContext CreateContext<TContext>() where TContext : DbContext
        {
            return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());
        }

        ////tipi  class olacak ama IBaseEntityden implemente olanlar
        //public static void CreateUnitOfWork<T,TContext>(ref IUnitOfWork<T> uow) where T :class,IBaseEntity where TContext :DbContext
        //{
        //    //? demek eğer uow null değilse dispose et
        //    uow?.Dispose();
        //    uow = new UnitOfWork<T>(CreateContext<TContext>());
        //}
        public static void CreateUnitOfWork<T, TContext>(ref IUnitOfWork<T> uow) where T : class, IBaseEntity where TContext : DbContext
        {
            uow?.Dispose();
            uow = new UnitOfWork<T>(CreateContext<TContext>());
        }
    }
}
