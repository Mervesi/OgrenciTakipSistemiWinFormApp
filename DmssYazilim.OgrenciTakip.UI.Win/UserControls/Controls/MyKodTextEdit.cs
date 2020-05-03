using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyKodTextEdit:MyTextEdit
    {
        [ToolboxItem(true)]
        public MyKodTextEdit()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;//arka plan rengı baska bu controlun
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;//yazıyı ortalar
            Properties.MaxLength = 20;
            StatusBarAciklama = "Kod Giriniz.";
        }
    }
}
