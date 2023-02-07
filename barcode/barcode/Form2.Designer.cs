namespace barcode
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bARCODEDataKHO = new barcode.BARCODEDataKHO();
            this.kHO1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHO1TableAdapter = new barcode.BARCODEDataKHOTableAdapters.KHO1TableAdapter();
            this.tableAdapterManager = new barcode.BARCODEDataKHOTableAdapters.TableAdapterManager();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel_container = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton_kho = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel_choose = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton_taodon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BUTTON_CANCEL = new Bunifu.Framework.UI.BunifuiOSSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.bARCODEDataKHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHO1BindingSource)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bARCODEDataKHO
            // 
            this.bARCODEDataKHO.DataSetName = "BARCODEDataKHO";
            this.bARCODEDataKHO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHO1BindingSource
            // 
            this.kHO1BindingSource.DataMember = "KHO1";
            this.kHO1BindingSource.DataSource = this.bARCODEDataKHO;
            // 
            // kHO1TableAdapter
            // 
            this.kHO1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KHO1TableAdapter = this.kHO1TableAdapter;
            this.tableAdapterManager.UpdateOrder = barcode.BARCODEDataKHOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // panel_container
            // 
            this.bunifuTransition1.SetDecoration(this.panel_container, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panel_container, "panel_container");
            this.panel_container.Name = "panel_container";
            // 
            // bunifuGradientPanel1
            // 
            resources.ApplyResources(this.bunifuGradientPanel1, "bunifuGradientPanel1");
            this.bunifuGradientPanel1.Controls.Add(this.BUTTON_CANCEL);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton_kho);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel_choose);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton_taodon);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Magenta;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bunifuFlatButton2, "bunifuFlatButton2");
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Sự cố";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            this.bunifuFlatButton2.MouseHover += new System.EventHandler(this.bunifuFlatButton2_MouseHover);
            this.bunifuFlatButton2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton2_MouseMove);
            // 
            // bunifuFlatButton_kho
            // 
            this.bunifuFlatButton_kho.Activecolor = System.Drawing.Color.Magenta;
            this.bunifuFlatButton_kho.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bunifuFlatButton_kho, "bunifuFlatButton_kho");
            this.bunifuFlatButton_kho.BorderRadius = 0;
            this.bunifuFlatButton_kho.ButtonText = "Quản lý kho";
            this.bunifuFlatButton_kho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton_kho, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton_kho.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_kho.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_kho.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton_kho.Iconimage")));
            this.bunifuFlatButton_kho.Iconimage_right = null;
            this.bunifuFlatButton_kho.Iconimage_right_Selected = null;
            this.bunifuFlatButton_kho.Iconimage_Selected = null;
            this.bunifuFlatButton_kho.IconMarginLeft = 0;
            this.bunifuFlatButton_kho.IconMarginRight = 0;
            this.bunifuFlatButton_kho.IconRightVisible = true;
            this.bunifuFlatButton_kho.IconRightZoom = 0D;
            this.bunifuFlatButton_kho.IconVisible = true;
            this.bunifuFlatButton_kho.IconZoom = 70D;
            this.bunifuFlatButton_kho.IsTab = false;
            this.bunifuFlatButton_kho.Name = "bunifuFlatButton_kho";
            this.bunifuFlatButton_kho.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_kho.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton_kho.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_kho.selected = false;
            this.bunifuFlatButton_kho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton_kho.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton_kho.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton_kho.Click += new System.EventHandler(this.bunifuFlatButton_kho_Click);
            this.bunifuFlatButton_kho.MouseHover += new System.EventHandler(this.bunifuFlatButton_kho_MouseHover);
            // 
            // bunifuGradientPanel_choose
            // 
            resources.ApplyResources(this.bunifuGradientPanel_choose, "bunifuGradientPanel_choose");
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel_choose, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel_choose.GradientBottomLeft = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel_choose.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel_choose.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel_choose.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel_choose.Name = "bunifuGradientPanel_choose";
            this.bunifuGradientPanel_choose.Quality = 10;
            // 
            // bunifuFlatButton_taodon
            // 
            this.bunifuFlatButton_taodon.Activecolor = System.Drawing.Color.Magenta;
            this.bunifuFlatButton_taodon.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bunifuFlatButton_taodon, "bunifuFlatButton_taodon");
            this.bunifuFlatButton_taodon.BorderRadius = 0;
            this.bunifuFlatButton_taodon.ButtonText = "Tạo đơn hàng";
            this.bunifuFlatButton_taodon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton_taodon, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton_taodon.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_taodon.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_taodon.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton_taodon.Iconimage")));
            this.bunifuFlatButton_taodon.Iconimage_right = null;
            this.bunifuFlatButton_taodon.Iconimage_right_Selected = null;
            this.bunifuFlatButton_taodon.Iconimage_Selected = null;
            this.bunifuFlatButton_taodon.IconMarginLeft = 0;
            this.bunifuFlatButton_taodon.IconMarginRight = 0;
            this.bunifuFlatButton_taodon.IconRightVisible = true;
            this.bunifuFlatButton_taodon.IconRightZoom = 0D;
            this.bunifuFlatButton_taodon.IconVisible = true;
            this.bunifuFlatButton_taodon.IconZoom = 70D;
            this.bunifuFlatButton_taodon.IsTab = false;
            this.bunifuFlatButton_taodon.Name = "bunifuFlatButton_taodon";
            this.bunifuFlatButton_taodon.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_taodon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton_taodon.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_taodon.selected = false;
            this.bunifuFlatButton_taodon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton_taodon.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton_taodon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton_taodon.Click += new System.EventHandler(this.bunifuFlatButton_taodon_Click);
            this.bunifuFlatButton_taodon.MouseHover += new System.EventHandler(this.bunifuFlatButton_taodon_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::barcode.Properties.Resources.qr_code;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BUTTON_CANCEL
            // 
            this.BUTTON_CANCEL.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BUTTON_CANCEL, "BUTTON_CANCEL");
            this.BUTTON_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.BUTTON_CANCEL, BunifuAnimatorNS.DecorationType.None);
            this.BUTTON_CANCEL.Name = "BUTTON_CANCEL";
            this.BUTTON_CANCEL.OffColor = System.Drawing.Color.Gray;
            this.BUTTON_CANCEL.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.BUTTON_CANCEL.Value = true;
            this.BUTTON_CANCEL.OnValueChange += new System.EventHandler(this.BUTTON_CANCEL_OnValueChange);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.Custom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bARCODEDataKHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHO1BindingSource)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_taodon;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel_choose;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_kho;
        private System.Windows.Forms.Timer timer1;
        private BARCODEDataKHO bARCODEDataKHO;
        private System.Windows.Forms.BindingSource kHO1BindingSource;
        private BARCODEDataKHOTableAdapters.KHO1TableAdapter kHO1TableAdapter;
        private BARCODEDataKHOTableAdapters.TableAdapterManager tableAdapterManager;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_container;
        private KHO kho1;
        private SCANFORM scanform1;
        private Bunifu.Framework.UI.BunifuiOSSwitch BUTTON_CANCEL;
    }
}