using System.ComponentModel;

namespace DmssYazilim.OgrenciTakip.Common.Enums
{
    public enum KartTuru:byte//defaultu ınt alanı kucultmek adına byte yaptık
    {
        [Description("Okul Kartı")]
        Okul=1,//defaultu 0 dan baslar bız bırden baslattık
        [Description("İl Kartı")]
        Il =2,
        [Description("İlçe Kartı")]
        Ilce =3
    }
}
