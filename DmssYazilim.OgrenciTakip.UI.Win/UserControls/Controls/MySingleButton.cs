using DevExpress.XtraEditors;
using DmssYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MySingleButton :SimpleButton,IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MySingleButton()
        {
            Appearance.ForeColor = Color.Maroon;
        }

        public string StatusBarAciklama { get ; set ; }
    }
}
