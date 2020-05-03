using DevExpress.XtraEditors;
using DmssYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyMemoEdit:MemoEdit,IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MyMemoEdit()//not tututlacak edit
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 500;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; } = "Açıklama Giriniz.";
    }
}
