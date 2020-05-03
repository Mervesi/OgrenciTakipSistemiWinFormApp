using DevExpress.XtraEditors;
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
   
    class MyCalcEdit:CalcEdit,IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            Properties.EditMask = "n2";
        }
        public override bool EnterMoveNextControl { get ; set; }
        public string StatusaBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAçıklama { get; set; } = "Hesap Makinesi";
        public string StatusBarAciklama { get ;set ; }
    }
}
