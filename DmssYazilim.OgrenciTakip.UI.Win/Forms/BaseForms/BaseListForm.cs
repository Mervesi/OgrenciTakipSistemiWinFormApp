using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DmssYazilim.OgrenciTakip.UI.Win.Show.Interfaces;
using DmssYazilim.OgrenciTakip.Common.Enums;
using DevExpress.XtraGrid.Views.Grid;
using DmssYazilim.OgrenciTakip.UI.Win.Functions;
using DmssYazilim.OgrenciTakip.Model.Entities.Base;
using DmssYazilim.OgrenciTakip.Bll.Interfaces;

namespace DmssYazilim.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        protected IBaseFormShow FormShow;
        protected KartTuru KartTuru;
        protected internal GridView Tablo;
        protected bool AktifKartlariGoster = true;
        protected internal bool MultiSelect;
        protected internal BaseEntity SelectedEntity;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;


        public BaseListForm()
        {
            InitializeComponent();
        }
        private void Listele()
        {
            throw new NotImplementedException();
        }
        private void FiltreSec()
        {
            throw new NotImplementedException();
        }
        private void Yazdir()
        {
            throw new NotImplementedException();
        }
        private void FormCaptionAyarlar()
        {
            throw new NotImplementedException();
        }
        private void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                //guncellenecek
                SelectEntity();
            }
            else
                btnDuzelt.PerformClick();//btnduzelt basılıymış gibi işlem yap
        }
        private void EventsLoad()
        {
            //button events
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarItem button://formda ıkı tur control vardı ve ıkısı de BarItem dan turedıgı ıcın burdan oluşturduk.
                        button.ItemClick += Button_ItemClick;  //(+= den sonra tab tab-apply)
                        break;
                }
            }
            //table events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
            //form events
        }
        protected internal void Yukle()
        {
            DegiskenleriDoldur();
            EventsLoad();

            Tablo.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Tablo.GridControl;

            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;

            //guncellenecek
        }

        protected virtual void DegiskenleriDoldur()
        {
        }
        private void ShowEditForm(long id)
        {
            var result = FormShow.ShowDialogEditForm(KartTuru, id);
        }
        private void EntityDelete()
        {
            throw new NotImplementedException();
        }
        private void SelectEntity()
        {
            if (MultiSelect)
            {
                //guncellenecek
            }
            else
            {
                SelectedEntity = Tablo.GetRow<BaseEntity>();
            }
            DialogResult = DialogResult.OK;
            Close();

        }
        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if(e.Item==btnGonder)//btn gondere tıklanılmışsa
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandartExcelDosyasi)
            {

            }
            else if (e.Item==btnFormatliExcelDosyasi)
            {

            }
            else if (e.Item==btnFormatsizExcelDosyasi)
            {

            }
            else if (e.Item==btnWordDosyasi)
            {

            }
            else if (e.Item==btnPdfDosyasi)
            {

            }
            else if (e.Item==btnTxtDosyasi)
            {

            }
            else if (e.Item==btnYeni)
            {
                //yetki kontrolu olacak
                ShowEditForm(-1);
            }
            else if (e.Item==btnDuzelt)
            {
                ShowEditForm((long)Tablo.GetRowId());
            }
            else if (e.Item==btnSil)
            {
                //yetki kntrolu
                EntityDelete();
            }
            else if (e.Item == btnSec)
            {
                SelectEntity();
            }
            else if (e.Item==btnYenile)
            {
                Listele();
            }
            else if (e.Item==btnFiltreler)
            {
                FiltreSec();
            }
            else if (e.Item==btnKolonlar)
            {
                if (Tablo.CustomizationForm == null)
                    Tablo.ShowCustomization();
                else
                    Tablo.HideCustomization();
            }
            else if (e.Item==btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item==btnCikis)
            {
                Close();
            }
            else if (e.Item==btnAktifPasifKartlar)
            {
                AktifKartlariGoster = !AktifKartlariGoster;//true ıse fasle yap - false ıse true yap
                FormCaptionAyarlar();
            }

            Cursor.Current = DefaultCursor;
        }

        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }
        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    IslemTuruSec();
                    break;

                case Keys.Escape:
                    Close();
                    break;
            }
        }


        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}