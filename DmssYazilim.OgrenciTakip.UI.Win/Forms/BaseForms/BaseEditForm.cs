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
using DevExpress.XtraBars.Ribbon;
using DmssYazilim.OgrenciTakip.Common.Enums;

namespace DmssYazilim.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        protected internal IslemTuru IslemTuru;
        protected internal long Id;
        protected internal bool RefreshYapilacak;

        public BaseEditForm()
        {
            InitializeComponent();
        }

        protected internal void Yukle()
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void myEmailTextEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}