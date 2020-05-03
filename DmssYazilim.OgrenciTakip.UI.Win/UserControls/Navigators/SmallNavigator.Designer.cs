namespace DmssYazilim.OgrenciTakip.UI.Win.UserControls.Navigators
{
    partial class Navigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navigator));
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
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
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.controlNavigator1.Appearance.Options.UseForeColor = true;
            this.controlNavigator1.Buttons.Append.Visible = false;
            this.controlNavigator1.Buttons.CancelEdit.Visible = false;
            this.controlNavigator1.Buttons.Edit.Visible = false;
            this.controlNavigator1.Buttons.EnabledAutoRepeat = false;
            this.controlNavigator1.Buttons.EndEdit.Visible = false;
            this.controlNavigator1.Buttons.First.ImageIndex = 0;
            this.controlNavigator1.Buttons.ImageList = this.ımageCollection1;
            this.controlNavigator1.Buttons.Last.ImageIndex = 3;
            this.controlNavigator1.Buttons.Next.ImageIndex = 2;
            this.controlNavigator1.Buttons.NextPage.Visible = false;
            this.controlNavigator1.Buttons.Prev.ImageIndex = 1;
            this.controlNavigator1.Buttons.PrevPage.Visible = false;
            this.controlNavigator1.Buttons.Remove.Visible = false;
            this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator1.Location = new System.Drawing.Point(0, 0);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.Size = new System.Drawing.Size(336, 24);
            this.controlNavigator1.TabIndex = 0;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.controlNavigator1.TextStringFormat = "Kartlar ( {0} / {1} )";
            // 
            // Navigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlNavigator1);
            this.Name = "Navigator";
            this.Size = new System.Drawing.Size(336, 24);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
    }
}
