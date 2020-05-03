using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using DmssYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MySpinEdit:SpinEdit, IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "d";
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get ; set ; }
    }
}
