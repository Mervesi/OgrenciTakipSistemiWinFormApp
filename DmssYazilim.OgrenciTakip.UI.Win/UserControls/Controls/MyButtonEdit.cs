using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DmssYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;
using System;


namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    
    public class MyButtonEdit : ButtonEdit, IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;//button edıt kısmında textımıze herhangi bişey yazamamızı sağlar
            Properties.AppearanceFocused.BackColor = Color.LightCyan;//ilgili tere focuslama yapılınca arka plan rengi seçilen renk gelsin
        }
        public override bool EnterMoveNextControl { get; set; } = true;//devexte enter ile sıradakı satıra gec default false gelir onu true ya çektik override ederek
        public string StatusBarAciklama { get; set; }
        public string StatusaBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAçıklama { get; set; }
        //public long? Id { get; set; }

        #region Events
        private long? _id;

        [Browsable(false)]
        public long? Id
        {
            get { return _id; }
            set
            {
                var oldValue = _id;
                var newValue = value;

                if (newValue == oldValue) return;
                _id = value;

                //if(IdChanged !=null)//simplisi var
                IdChanged(this, new IdChangedEventArgs(oldValue, newValue));
            }
        }

        public event EventHandler<IdChangedEventArgs> IdChanged = delegate { };//sondaki delegate { }; => if(IdChanged !=null) ile aynı işlevi görüyor 
        #endregion

    }
    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(long? oldValue, long? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
        public long? OldValue { get; }
        public long? NewValue { get; }
    }
}
