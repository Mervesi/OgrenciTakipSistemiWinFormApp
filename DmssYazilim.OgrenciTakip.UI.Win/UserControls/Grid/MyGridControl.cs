using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DmssYazilim.OgrenciTakip.UI.Win.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Registrator;
using System.ComponentModel;

namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Grid
{
    [ToolboxItem(true)]
    public class MyGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()//default olarak gelen viewın olusturulma asamasına mudehale edecegız.
        {
            var view = (GridView)CreateView("MyGridView");//kendi grıd vıewımızı oluşturduk
            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;//menunun üzerine sağ tuş basınca default gelecek olan menu duzenemesı filtrele  vs.
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;//colonlar arası enterıle gecıs

            view.OptionsPrint.AutoWidth = false;//yazıcıya gonderılen belgeler ıcın colon alanlarının otomatık daraltmasını ıstemıyoruz oyuzden false
            view.OptionsPrint.PrintFooter = false;//footer alanlarını yazıcıya göndermez
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowViewCaption = true;//grıdın baslıgını gostersın defaultu false
            view.OptionsView.ShowAutoFilterRow = true;//filtrleme satırını acar
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;//colonlar bızım belırledıgımız genıslıkte kalacak
            view.OptionsView.RowAutoHeight = true;//not yazıp enter dedıgımızde eger bır kac satır varsa satırın genıslıgını ordakı satırlara gore ayarlıyor
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;//defaultu smarttag.colonlardakı filtreleme butonu (boş olanlar boş olmayanlar)

            var idColumn = new MyGridColumn();//gridimizde otomatık her seferınde ıkı colonla gelsın
            idColumn.Caption = "Id";//colon baslıgı
            idColumn.FieldName = "Id";//buraya gonderecegımız verının databasedekı satır-colon adı
            idColumn.OptionsColumn.AllowEdit = false;//colon eklendıgınde calısacaktır
            idColumn.OptionsColumn.ShowInCustomizationForm = false;//surukleyıp bıraktıgımız kutuda ıdcolumn gorunmesın dıye
            view.Columns.Add(idColumn);

            var kodColumn = new MyGridColumn();
            kodColumn.Caption = "Kod";
            kodColumn.FieldName = "Kod";
            kodColumn.OptionsColumn.AllowEdit = false;
            kodColumn.Visible = true;
            kodColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            kodColumn.AppearanceCell.Options.UseTextOptions = true;//bu ozellıgı truya cekıyoruz kı yaptıgımız degısıklıklerı kullanabılsın colon
            view.Columns.Add(kodColumn);//kolonumuzu vıewa eklıyoruz

            return view;
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)//grid sectıgımızde ozellıklerını olutrudugumuz gelsın dıye ovverıde ettık
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridInfoRegistrator());
        }

        private class MyGridInfoRegistrator : GridInfoRegistrator
        {
            public override string ViewName => "MyGridView";
            public override BaseView CreateView(GridControl grid) => new MyGridView(grid);
        }
    }
    public class MyGridView : GridView, IStatusBarKisaYol
    {
        #region Properties
        public string StatusaBarKisaYol { get; set; }
        public string StatusBarKisaYolAçıklama { get; set; }
        public string StatusBarAciklama { get; set; }
        #endregion

        public MyGridView() { }

        public MyGridView(GridControl ownerGrid) : base(ownerGrid) { }
        protected override void OnColumnChangedCore(GridColumn column)//grid column turunden bır degısken alıyor-columnda herhangı bır degısıkılık olursa boyle boyle yap
        {
            base.OnColumnChangedCore(column);

            if (column.ColumnEdit == null) return;//bu kolonun bır columnedıtı yoksa devam et
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;//column edıtı reposıtorydate e castettık maskten faydalanmak ıcın
            }
        }
        protected override GridColumnCollection CreateColumnCollection()//colon eklenırse  bunu yap
        {
            return new MyGridColumnCollection(this);

        }
        private class MyGridColumnCollection : GridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view) { }
            protected override GridColumn CreateColumn()
            {
                var column = new MyGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
    }
    public class MyGridColumn : GridColumn, IStatusBarKisaYol
    {
        #region Properties
        public string StatusaBarKisaYol { get; set; }
        public string StatusBarKisaYolAçıklama { get; set; }
        public string StatusBarAciklama { get; set; }
        #endregion
    }
}
