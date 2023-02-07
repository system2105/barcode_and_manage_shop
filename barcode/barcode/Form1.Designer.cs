namespace barcode
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bARCODEDataSet_LOGIN = new barcode.BARCODEDataSet_LOGIN();
            this.adminloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminloginTableAdapter = new barcode.BARCODEDataSet_LOGINTableAdapters.adminloginTableAdapter();
            this.tableAdapterManager = new barcode.BARCODEDataSet_LOGINTableAdapters.TableAdapterManager();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BTN_cancel = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bARCODEDataSet_LOGIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminloginBindingSource)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bARCODEDataSet_LOGIN
            // 
            this.bARCODEDataSet_LOGIN.DataSetName = "BARCODEDataSet_LOGIN";
            this.bARCODEDataSet_LOGIN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminloginBindingSource
            // 
            this.adminloginBindingSource.DataMember = "adminlogin";
            this.adminloginBindingSource.DataSource = this.bARCODEDataSet_LOGIN;
            // 
            // adminloginTableAdapter
            // 
            this.adminloginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminloginTableAdapter = this.adminloginTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = barcode.BARCODEDataSet_LOGINTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.BTN_cancel);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuMaterialTextbox_pass);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuMaterialTextbox_user);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(421, 366);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.BackColor = System.Drawing.Color.Transparent;
            this.BTN_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_cancel.BackgroundImage")));
            this.BTN_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_cancel.Location = new System.Drawing.Point(369, 5);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.OffColor = System.Drawing.Color.Gray;
            this.BTN_cancel.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.BTN_cancel.Size = new System.Drawing.Size(43, 25);
            this.BTN_cancel.TabIndex = 5;
            this.BTN_cancel.Value = true;
            this.BTN_cancel.OnValueChange += new System.EventHandler(this.BTN_cancel_OnValueChange);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(282, 153);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(102, 25);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "DAV COOP";
            // 
            // bunifuMaterialTextbox_pass
            // 
            this.bunifuMaterialTextbox_pass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuMaterialTextbox_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox_pass.HintForeColor = System.Drawing.Color.Transparent;
            this.bunifuMaterialTextbox_pass.HintText = "";
            this.bunifuMaterialTextbox_pass.isPassword = false;
            this.bunifuMaterialTextbox_pass.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox_pass.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox_pass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox_pass.LineThickness = 3;
            this.bunifuMaterialTextbox_pass.Location = new System.Drawing.Point(75, 272);
            this.bunifuMaterialTextbox_pass.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuMaterialTextbox_pass.Name = "bunifuMaterialTextbox_pass";
            this.bunifuMaterialTextbox_pass.Size = new System.Drawing.Size(309, 44);
            this.bunifuMaterialTextbox_pass.TabIndex = 2;
            this.bunifuMaterialTextbox_pass.Text = "Pass";
            this.bunifuMaterialTextbox_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMaterialTextbox_pass_KeyDown);
            this.bunifuMaterialTextbox_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextbox_pass_KeyPress);
            // 
            // bunifuMaterialTextbox_user
            // 
            this.bunifuMaterialTextbox_user.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuMaterialTextbox_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox_user.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox_user.HintForeColor = System.Drawing.Color.Transparent;
            this.bunifuMaterialTextbox_user.HintText = "";
            this.bunifuMaterialTextbox_user.isPassword = false;
            this.bunifuMaterialTextbox_user.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox_user.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox_user.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox_user.LineThickness = 3;
            this.bunifuMaterialTextbox_user.Location = new System.Drawing.Point(75, 187);
            this.bunifuMaterialTextbox_user.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuMaterialTextbox_user.Name = "bunifuMaterialTextbox_user";
            this.bunifuMaterialTextbox_user.Size = new System.Drawing.Size(309, 44);
            this.bunifuMaterialTextbox_user.TabIndex = 1;
            this.bunifuMaterialTextbox_user.Text = "User";
            this.bunifuMaterialTextbox_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMaterialTextbox_user_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::barcode.Properties.Resources.profile_avatar;
            this.pictureBox1.Location = new System.Drawing.Point(141, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 366);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bARCODEDataSet_LOGIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminloginBindingSource)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox_pass;
        private BARCODEDataSet_LOGIN bARCODEDataSet_LOGIN;
        private System.Windows.Forms.BindingSource adminloginBindingSource;
        private BARCODEDataSet_LOGINTableAdapters.adminloginTableAdapter adminloginTableAdapter;
        private BARCODEDataSet_LOGINTableAdapters.TableAdapterManager tableAdapterManager;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuiOSSwitch BTN_cancel;
    }
}

