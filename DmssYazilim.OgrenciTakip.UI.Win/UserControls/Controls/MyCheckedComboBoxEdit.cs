using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DmssYazilim.OgrenciTakip.UI.Win.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyCheckedComboBoxEdit:CheckedComboBoxEdit,IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyCheckedComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusaBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAçıklama { get; set; }
        public string StatusBarAciklama { get; set; }
    }
}

