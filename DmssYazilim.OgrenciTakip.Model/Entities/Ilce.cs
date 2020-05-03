using DmssYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmssYazilim.OgrenciTakip.Model.Entities
{
    public class Ilce:BaseEntityDurum
    {
        [Index("IX_Kod",IsUnique =false)]//herılın kendı ıcınde kodları tekrardan baslayacagı ıcın false

        public override string Kod { get ; set; }

        [Required,StringLength(50)]
        public string IlceAdi { get; set; }

        public long IlId { get; set; }

        [StringLength(500)]
        public string Acikalama { get; set; }

        public Il Il { get; set; }
        //sen il ile bağlısın demek Il tipinden propertyi gidip oluşturuyor 
        //IlId dıye bır alan oluşturuyor ve bizim prop ile eşleştiriyor

    }
}
