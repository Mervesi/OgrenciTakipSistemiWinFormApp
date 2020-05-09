using DmssYazilim.OgrenciTakip.Common.Enums;
using DmssYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using System;

namespace DmssYazilim.OgrenciTakip.UI.Win.Show
{
    public class ShowEditForms<TForm> where TForm : BaseEditForm //InterfaceGelecek
    {
        public long ShowDialogEditForm(KartTuru kartTuru, long id)//,params object[] prm)
        {
            //Yetki Kontrolu

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.IslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;//eger id 0 dan buyukse işlem turun update degılse ınsert
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;//eger refresh yapılacaksa ıd yı yapılmayacaksa 0 gondereceksın
            }
        }
    }
}
