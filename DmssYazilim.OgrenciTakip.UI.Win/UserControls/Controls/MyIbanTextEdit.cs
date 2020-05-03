using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyIbanTextEdit:MyTextEdit
    {
        [ToolboxItem(true)]
        public MyIbanTextEdit()
        {
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"TR\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;//yazarken kalan kısmı otomatık 0 yapmasını engeller
            StatusBarAciklama = "Iban No Giriniz.";
        }
    }
}
