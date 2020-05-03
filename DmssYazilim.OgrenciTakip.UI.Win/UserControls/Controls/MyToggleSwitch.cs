using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Drawing;
using DmssYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyToggleSwitch:ToggleSwitch,IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MyToggleSwitch()
        {
            Name = "tglDurum";
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false;//otomatık yukseklıgı ayarlanmasın
            Properties.AutoWidth = true;//genel texte gore genıslık ayarlaması ıcın
            Properties.GlyphAlignment = HorzAlignment.Far;//text solunda gozuksun
            Properties.Appearance.ForeColor = Color.Maroon;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; } = "Kartın Kullanım Durumunu Seçiniz.";
    }
}
