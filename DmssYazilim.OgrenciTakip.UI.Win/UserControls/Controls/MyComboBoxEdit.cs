using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DmssYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyComboBoxEdit :ComboBoxEdit, IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusaBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAçıklama { get ; set; }
        public string StatusBarAciklama { get ; set; }
    }

}
