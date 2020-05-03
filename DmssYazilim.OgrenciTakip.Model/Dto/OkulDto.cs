using DmssYazilim.OgrenciTakip.Model.Entities;
using DmssYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmssYazilim.OgrenciTakip.Model.Dto
{
    //attribute
    [NotMapped]//OkulS klasımızı oluşturulacak olan database e eklemıyor
    public class OkulS:Okul
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
    }
    public class OkulL : BaseEntity
    {
        public string OkulAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
