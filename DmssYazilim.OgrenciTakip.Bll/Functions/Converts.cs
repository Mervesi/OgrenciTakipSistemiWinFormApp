using DmssYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmssYazilim.OgrenciTakip.Bll.Functions
{
    public static class Converts
    {
        public static TTarget EntityConvert<TTarget>(this IBaseEntity source)
        {
            if (source == null) return default(TTarget);//eğer null ise targetındefaultunu gonderıyoruz o da null zaten
            var hedef = Activator.CreateInstance<TTarget>();
            var kaynakProp = source.GetType().GetProperties();//reflectıon yoluyla soucrenın propertılerıne ulaşmış olduk
            var hedefProp = typeof(TTarget).GetProperties();

            foreach (var kp in kaynakProp)
            {
                var value = kp.GetValue(source);//kaynak propun degerıne ulaşmış oluyoruz
                var hp = hedefProp.FirstOrDefault(x => x.Name == kp.Name);
                if (hp != null)
                    hp.SetValue(hedef, ReferenceEquals(value, "") ? null : value);
                //diyelımkı gelen deger bos bır strıng verı tabanına tırnak kaydedılmesın dıye bu sekılde nulla esıtledık
            }
            return hedef;
        }
    }
}
