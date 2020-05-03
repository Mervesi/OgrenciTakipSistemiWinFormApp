using DevExpress.XtraEditors;
using DmssYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;


namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    
    public class MyTextEdit:TextEdit,IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;
        }
        public override bool EnterMoveNextControl { get; set; } = true;//enterle dırek sıradakıne geç 
        public string StatusBarAciklama { get ; set ; }

    }
}
