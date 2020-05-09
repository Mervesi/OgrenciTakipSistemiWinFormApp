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

namespace DmssYazilim.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BaseListForm()
        {
            InitializeComponent();
        }

        private void ShowEditForm(long id)
        {
          //  var result =
        }

        private void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarItem button://formda ıkı tur control vardı ve ıkısı de BarItem dan turedıgı ıcın burdan oluşturduk.
                        button.ItemClick += Button_ItemClick;  //(+= den sonra tab tab-apply)
                        break;

                }
            }
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
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
        }

        

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}