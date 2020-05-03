using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    class MyCardEdit:MyTextEdit
    {
        [ToolboxItem(true)]
        public MyCardEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?";//d ler sayıları ıfade eder
            Properties.Mask.AutoComplete = AutoCompleteType.None;//16 haneye 0 koyarak tamamlama
            StatusBarAciklama = "Kart No Giriniz.";
            //Properties.MaxLength = 19; maskemıze gore karakter gırılecegı ıcın cokta gereklı degıl
        }
    }
}
