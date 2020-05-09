using DmssYazilim.OgrenciTakip.Bll.General;
using DmssYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;

namespace DmssYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    public partial class OkulListForm : BaseListForm//BaseKartlarForm'dan implemente ediyoruz, BKF iskeletiyle geliyor
    {
        public OkulListForm()
        {
            InitializeComponent();

            OkulBll bll = new OkulBll();
            grid.DataSource = bll.List(null);
        }
    }
}