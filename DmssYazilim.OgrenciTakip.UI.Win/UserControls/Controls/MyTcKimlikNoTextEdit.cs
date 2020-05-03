using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
    
{
    public class MyTcKimlikNoTextEdit:MyTextEdit
    {
        [ToolboxItem(true)]
        public MyTcKimlikNoTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d?\d?\d?\d?\d?\d?\d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Tc Kimlik No Giriniz.";

        }
    }
}
