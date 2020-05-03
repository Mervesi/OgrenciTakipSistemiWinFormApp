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
    public class MyCheckEdit:CheckEdit,IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MyCheckEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Transparent;//seçildiğinde dırek formun rengını al

        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get ; set ; }
    }
}
