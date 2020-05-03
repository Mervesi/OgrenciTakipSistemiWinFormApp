namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Navigators
{
    partial class InsUpNavigator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsUpNavigator));
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.Navigator = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "first_16x16.png");
            this.ımageCollection1.Images.SetKeyName(1, "prev_16x16.png");
            this.ımageCollection1.Images.SetKeyName(2, "next_16x16.png");
            this.ımageCollection1.Images.SetKeyName(3, "last_16x16.png");
            this.ımageCollection1.Images.SetKeyName(4, "addfile_16x16.png");
            this.ımageCollection1.Images.SetKeyName(5, "deletelist_16x16.png");
            this.ımageCollection1.Images.SetKeyName(6, "doublefirst_16x16.png");
            this.ımageCollection1.Images.SetKeyName(7, "doublelast_16x16.png");
            this.ımageCollection1.Images.SetKeyName(8, "doublenext_16x16.png");
            this.ımageCollection1.Images.SetKeyName(9, "doubleprev_16x16.png");
            // 
            // Navigator
            // 
            this.Navigator.Buttons.Append.ImageIndex = 4;
            this.Navigator.Buttons.CancelEdit.Visible = false;
            this.Navigator.Buttons.Edit.Visible = false;
            this.Navigator.Buttons.EndEdit.Visible = false;
            this.Navigator.Buttons.First.ImageIndex = 0;
            this.Navigator.Buttons.ImageList = this.ımageCollection1;
            this.Navigator.Buttons.Last.ImageIndex = 3;
            this.Navigator.Buttons.Next.ImageIndex = 2;
            this.Navigator.Buttons.NextPage.ImageIndex = 8;
            this.Navigator.Buttons.NextPage.Visible = false;
            this.Navigator.Buttons.Prev.ImageIndex = 1;
            this.Navigator.Buttons.PrevPage.ImageIndex = 9;
            this.Navigator.Buttons.PrevPage.Visible = false;
            this.Navigator.Buttons.Remove.ImageIndex = 5;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Location = new System.Drawing.Point(0, 0);
            this.Navigator.Name = "Navigator";
            this.Navigator.Size = new System.Drawing.Size(419, 24);
            this.Navigator.TabIndex = 0;
            this.Navigator.Text = "controlNavigator1";
            // 
            // InsUpNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Navigator);
            this.Name = "InsUpNavigator";
            this.Size = new System.Drawing.Size(419, 24);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.ControlNavigator Navigator;
    }
}
