using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DmssYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyPictureEdit:PictureEdit, IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.NullText = "Resim Yok.";//resım olmadıgında gelecek text
            Properties.SizeMode = PictureSizeMode.Stretch;
            Properties.ShowMenu = false;//uzerınde yakınlaştır uzaklastır ısaretlerı gelmesın
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusaBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAçıklama { get ; set ; }
        public string StatusBarAciklama { get ; set; }
    }
}
