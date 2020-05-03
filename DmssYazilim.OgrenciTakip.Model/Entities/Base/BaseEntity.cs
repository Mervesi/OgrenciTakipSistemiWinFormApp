using DmssYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmssYazilim.OgrenciTakip.Model.Entities.Base
{
    public class BaseEntity:IBaseEntity
    {
        [Column(Order =0),Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Column(Order =1),Required,StringLength(20)]
        public virtual string  Kod { get; set; }
    }
}
//long olmasının sebebı kendımızın oluşturup gonderecegı bir ıd
//Id kolonunu database ı create ederken 0 ıncı ındexe koy
//DatabaseGenerated(DatabaseGeneratedOption.None)= id nin 1 den baslayıp sırayla ilerlemesine müdehale 
//ediyoruz. ıd noyu kendimiz göndereceğiz