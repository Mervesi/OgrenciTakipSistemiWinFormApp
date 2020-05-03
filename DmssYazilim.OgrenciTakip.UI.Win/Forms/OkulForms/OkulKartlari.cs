using DmssYazilim.OgrenciTakip.Bll.General;
using DmssYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;

namespace DmssYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    public partial class OkulKartlari : BaseKartlarForm//BaseKartlarForm'dan implemente ediyoruz, BKF iskeletiyle geliyor
    {
        public OkulKartlari()
        {
            InitializeComponent();

            OkulBll bll = new OkulBll();
            grid.DataSource = bll.List(null);
        }
    }
}