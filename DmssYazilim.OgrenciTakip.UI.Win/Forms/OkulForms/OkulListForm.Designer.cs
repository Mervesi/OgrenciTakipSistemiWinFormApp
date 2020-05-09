namespace DmssYazilim.OgrenciTakip.UI.Win.Forms.OkulForms
{
    partial class OkulListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new DmssYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new DmssYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colId = new DmssYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKod = new DmssYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colOkulAdi = new DmssYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIlAdi = new DmssYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colIlceAdi = new DmssYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colAciklama = new DmssYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.longNavigator1 = new DmssYazilim.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barInsert = new DevExpress.XtraBars.BarStaticItem();
            this.barInsertAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.barDelete = new DevExpress.XtraBars.BarStaticItem();
            this.barDeleteAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.barEnter = new DevExpress.XtraBars.BarStaticItem();
            this.barSec = new DevExpress.XtraBars.BarStaticItem();
            this.barDuzelt = new DevExpress.XtraBars.BarStaticItem();
            this.barDuzeltAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.barYenile = new DevExpress.XtraBars.BarStaticItem();
            this.barYenileAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.barFiltrele = new DevExpress.XtraBars.BarStaticItem();
            this.barFiltreleAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.barKolonlar = new DevExpress.XtraBars.BarStaticItem();
            this.barKolonlarAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.barYazdir = new DevExpress.XtraBars.BarStaticItem();
            this.barYazdirAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.barGonder = new DevExpress.XtraBars.BarStaticItem();
            this.barGonderAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.barCikis = new DevExpress.XtraBars.BarStaticItem();
            this.barCikisAciklama = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barInsert,
            this.barInsertAciklama,
            this.barDelete,
            this.barDeleteAciklama,
            this.barEnter,
            this.barSec,
            this.barDuzelt,
            this.barDuzeltAciklama,
            this.barYenile,
            this.barYenileAciklama,
            this.barFiltrele,
            this.barFiltreleAciklama,
            this.barKolonlar,
            this.barKolonlarAciklama,
            this.barYazdir,
            this.barYazdirAciklama,
            this.barGonder,
            this.barGonderAciklama,
            this.barCikis,
            this.barCikisAciklama});
            this.ribbonControl.MaxItemId = 34;
            this.ribbonControl.Size = new System.Drawing.Size(1042, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1042, 315);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKod,
            this.colOkulAdi,
            this.colIlAdi,
            this.colIlceAdi,
            this.colAciklama});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusaBarKisaYol = null;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYolAçıklama = null;
            this.tablo.ViewCaption = "Okul Kartları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusaBarKisaYol = null;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYolAçıklama = null;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusaBarKisaYol = null;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYolAçıklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 110;
            // 
            // colOkulAdi
            // 
            this.colOkulAdi.Caption = "Okul Adı";
            this.colOkulAdi.FieldName = "OkulAdi";
            this.colOkulAdi.Name = "colOkulAdi";
            this.colOkulAdi.OptionsColumn.AllowEdit = false;
            this.colOkulAdi.StatusaBarKisaYol = null;
            this.colOkulAdi.StatusBarAciklama = null;
            this.colOkulAdi.StatusBarKisaYolAçıklama = null;
            this.colOkulAdi.Visible = true;
            this.colOkulAdi.VisibleIndex = 1;
            this.colOkulAdi.Width = 250;
            // 
            // colIlAdi
            // 
            this.colIlAdi.Caption = "İl";
            this.colIlAdi.FieldName = "IlAdi";
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.StatusaBarKisaYol = null;
            this.colIlAdi.StatusBarAciklama = null;
            this.colIlAdi.StatusBarKisaYolAçıklama = null;
            this.colIlAdi.Visible = true;
            this.colIlAdi.VisibleIndex = 2;
            this.colIlAdi.Width = 130;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.Caption = "İlçe";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.StatusaBarKisaYol = null;
            this.colIlceAdi.StatusBarAciklama = null;
            this.colIlceAdi.StatusBarKisaYolAçıklama = null;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.VisibleIndex = 3;
            this.colIlceAdi.Width = 130;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusaBarKisaYol = null;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYolAçıklama = null;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 450;
            // 
            // longNavigator1
            // 
            this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator1.Location = new System.Drawing.Point(0, 417);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(1042, 24);
            this.longNavigator1.TabIndex = 3;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 14;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barInsert
            // 
            this.barInsert.Caption = "Insert :";
            this.barInsert.Id = 14;
            this.barInsert.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barInsert.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barInsert.ItemAppearance.Normal.Options.UseFont = true;
            this.barInsert.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barInsert.Name = "barInsert";
            // 
            // barInsertAciklama
            // 
            this.barInsertAciklama.Caption = "Yeni ";
            this.barInsertAciklama.Id = 15;
            this.barInsertAciklama.Name = "barInsertAciklama";
            // 
            // barDelete
            // 
            this.barDelete.Caption = "Delete :";
            this.barDelete.Id = 16;
            this.barDelete.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barDelete.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barDelete.ItemAppearance.Normal.Options.UseFont = true;
            this.barDelete.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barDelete.Name = "barDelete";
            // 
            // barDeleteAciklama
            // 
            this.barDeleteAciklama.Caption = "Sil";
            this.barDeleteAciklama.Id = 17;
            this.barDeleteAciklama.Name = "barDeleteAciklama";
            // 
            // barEnter
            // 
            this.barEnter.Caption = "Enter :";
            this.barEnter.Id = 18;
            this.barEnter.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barEnter.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barEnter.ItemAppearance.Normal.Options.UseFont = true;
            this.barEnter.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barEnter.Name = "barEnter";
            // 
            // barSec
            // 
            this.barSec.Caption = "Seç";
            this.barSec.Id = 19;
            this.barSec.Name = "barSec";
            // 
            // barDuzelt
            // 
            this.barDuzelt.Caption = "F3 :";
            this.barDuzelt.Id = 20;
            this.barDuzelt.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barDuzelt.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barDuzelt.ItemAppearance.Normal.Options.UseFont = true;
            this.barDuzelt.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barDuzelt.Name = "barDuzelt";
            // 
            // barDuzeltAciklama
            // 
            this.barDuzeltAciklama.Caption = "Düzelt";
            this.barDuzeltAciklama.Id = 21;
            this.barDuzeltAciklama.Name = "barDuzeltAciklama";
            // 
            // barYenile
            // 
            this.barYenile.Caption = "F5 :";
            this.barYenile.Id = 22;
            this.barYenile.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barYenile.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barYenile.ItemAppearance.Normal.Options.UseFont = true;
            this.barYenile.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barYenile.Name = "barYenile";
            // 
            // barYenileAciklama
            // 
            this.barYenileAciklama.Caption = "Yenile";
            this.barYenileAciklama.Id = 23;
            this.barYenileAciklama.Name = "barYenileAciklama";
            // 
            // barFiltrele
            // 
            this.barFiltrele.Caption = "F8 :";
            this.barFiltrele.Id = 24;
            this.barFiltrele.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barFiltrele.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barFiltrele.ItemAppearance.Normal.Options.UseFont = true;
            this.barFiltrele.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barFiltrele.Name = "barFiltrele";
            // 
            // barFiltreleAciklama
            // 
            this.barFiltreleAciklama.Caption = "Filtrele";
            this.barFiltreleAciklama.Id = 25;
            this.barFiltreleAciklama.Name = "barFiltreleAciklama";
            // 
            // barKolonlar
            // 
            this.barKolonlar.Caption = "Ctrl+O :";
            this.barKolonlar.Id = 26;
            this.barKolonlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barKolonlar.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barKolonlar.ItemAppearance.Normal.Options.UseFont = true;
            this.barKolonlar.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barKolonlar.Name = "barKolonlar";
            // 
            // barKolonlarAciklama
            // 
            this.barKolonlarAciklama.Caption = "Kolonlar";
            this.barKolonlarAciklama.Id = 27;
            this.barKolonlarAciklama.Name = "barKolonlarAciklama";
            // 
            // barYazdir
            // 
            this.barYazdir.Caption = "Ctrl+P :";
            this.barYazdir.Id = 28;
            this.barYazdir.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barYazdir.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barYazdir.ItemAppearance.Normal.Options.UseFont = true;
            this.barYazdir.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barYazdir.Name = "barYazdir";
            // 
            // barYazdirAciklama
            // 
            this.barYazdirAciklama.Caption = "Yazdır";
            this.barYazdirAciklama.Id = 29;
            this.barYazdirAciklama.Name = "barYazdirAciklama";
            // 
            // barGonder
            // 
            this.barGonder.Caption = "F12 :";
            this.barGonder.Id = 30;
            this.barGonder.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barGonder.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barGonder.ItemAppearance.Normal.Options.UseFont = true;
            this.barGonder.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barGonder.Name = "barGonder";
            // 
            // barGonderAciklama
            // 
            this.barGonderAciklama.Caption = "Gönder";
            this.barGonderAciklama.Id = 31;
            this.barGonderAciklama.Name = "barGonderAciklama";
            // 
            // barCikis
            // 
            this.barCikis.Caption = "Esc :";
            this.barCikis.Id = 32;
            this.barCikis.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barCikis.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.barCikis.ItemAppearance.Normal.Options.UseFont = true;
            this.barCikis.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barCikis.Name = "barCikis";
            // 
            // barCikisAciklama
            // 
            this.barCikisAciklama.Caption = "Çıkış";
            this.barCikisAciklama.Id = 33;
            this.barCikisAciklama.Name = "barCikisAciklama";
            // 
            // OkulKartlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 472);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator1);
            this.Name = "OkulKartlari";
            this.Text = "Okul Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl grid;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grid.MyGridColumn colOkulAdi;
        private UserControls.Grid.MyGridColumn colIlAdi;
        private UserControls.Grid.MyGridColumn colIlceAdi;
        private UserControls.Grid.MyGridColumn colAciklama;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barInsert;
        private DevExpress.XtraBars.BarStaticItem barInsertAciklama;
        private DevExpress.XtraBars.BarStaticItem barDelete;
        private DevExpress.XtraBars.BarStaticItem barDeleteAciklama;
        private DevExpress.XtraBars.BarStaticItem barEnter;
        private DevExpress.XtraBars.BarStaticItem barSec;
        private DevExpress.XtraBars.BarStaticItem barDuzelt;
        private DevExpress.XtraBars.BarStaticItem barDuzeltAciklama;
        private DevExpress.XtraBars.BarStaticItem barYenile;
        private DevExpress.XtraBars.BarStaticItem barYenileAciklama;
        private DevExpress.XtraBars.BarStaticItem barFiltrele;
        private DevExpress.XtraBars.BarStaticItem barFiltreleAciklama;
        private DevExpress.XtraBars.BarStaticItem barKolonlar;
        private DevExpress.XtraBars.BarStaticItem barKolonlarAciklama;
        private DevExpress.XtraBars.BarStaticItem barYazdir;
        private DevExpress.XtraBars.BarStaticItem barYazdirAciklama;
        private DevExpress.XtraBars.BarStaticItem barGonder;
        private DevExpress.XtraBars.BarStaticItem barGonderAciklama;
        private DevExpress.XtraBars.BarStaticItem barCikis;
        private DevExpress.XtraBars.BarStaticItem barCikisAciklama;
    }
}