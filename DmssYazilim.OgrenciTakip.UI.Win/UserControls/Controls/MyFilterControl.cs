using DevExpress.XtraEditors;
using DmssYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyFilterControl:FilterControl,IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MyFilterControl()
        {
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz.";
    }
}
