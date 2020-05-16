using DevExpress.XtraGrid.Views.Grid;
using DmssYazilim.OgrenciTakip.Common.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmssYazilim.OgrenciTakip.UI.Win.Functions
{
    public static class GeneralFunctions
    {
        private static object messages;

        public static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle > -1) return (long)tablo.GetFocusedRowCellValue("Id");
            Messages.KartSecmemeUyariMesajı();
            return -1;

        }
        public static T GetRow<T>(this GridView tablo, bool mesajVer = true)
        {
            if (tablo.FocusedRowHandle > -1)
                return (T)tablo.GetRow(tablo.FocusedRowHandle);

            if (mesajVer)
                Messages.KartSecmemeUyariMesajı();

            return default(T);
            
        }
    }
}
