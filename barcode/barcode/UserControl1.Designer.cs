namespace barcode
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox_camera = new System.Windows.Forms.ComboBox();
            this.pictureBox_showcam = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listView_TAODON = new System.Windows.Forms.ListView();
            this.columnHeader_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_TENSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_SOLUONG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_GIA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CODE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_NGAYNHAP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_THANHTIEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_NGAYMUA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox_test = new System.Windows.Forms.PictureBox();
            this.label_TONGTIEN = new System.Windows.Forms.Label();
            this.bunifuFlatButton_xuathoadon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Label_result = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox_update = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton_START = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox4_DetectBarcode = new System.Windows.Forms.PictureBox();
            this.pictureBox_Detect = new System.Windows.Forms.PictureBox();
            this.pictureBox_Erode = new System.Windows.Forms.PictureBox();
            this.pictureBox_Dilation = new System.Windows.Forms.PictureBox();
            this.pictureBox_BinaryImg = new System.Windows.Forms.PictureBox();
            this.pictureBox_EdgeDetectiom = new System.Windows.Forms.PictureBox();
            this.pictureBox_GrayScale = new System.Windows.Forms.PictureBox();
            this.pictureBox_StockImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showcam)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_test)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_DetectBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Detect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Erode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dilation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BinaryImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EdgeDetectiom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GrayScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_StockImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1418, 728);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.comboBox_camera);
            this.tabPage1.Controls.Add(this.pictureBox_showcam);
            this.tabPage1.Controls.Add(this.bunifuFlatButton_START);
            this.tabPage1.Controls.Add(this.bunifuImageButton1);
            this.tabPage1.Controls.Add(this.Label_result);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.label_TONGTIEN);
            this.tabPage1.Controls.Add(this.bunifuFlatButton_xuathoadon);
            this.tabPage1.Controls.Add(this.textBox_update);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1410, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create order";
            // 
            // comboBox_camera
            // 
            this.comboBox_camera.FormattingEnabled = true;
            this.comboBox_camera.Location = new System.Drawing.Point(3, 108);
            this.comboBox_camera.Name = "comboBox_camera";
            this.comboBox_camera.Size = new System.Drawing.Size(118, 21);
            this.comboBox_camera.TabIndex = 10;
            // 
            // pictureBox_showcam
            // 
            this.pictureBox_showcam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_showcam.Location = new System.Drawing.Point(3, 5);
            this.pictureBox_showcam.Name = "pictureBox_showcam";
            this.pictureBox_showcam.Size = new System.Drawing.Size(118, 100);
            this.pictureBox_showcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_showcam.TabIndex = 11;
            this.pictureBox_showcam.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel2.Controls.Add(this.listView_TAODON, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_test, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1410, 448);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // listView_TAODON
            // 
            this.listView_TAODON.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_TAODON.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_STT,
            this.columnHeader_TENSP,
            this.columnHeader_SOLUONG,
            this.columnHeader_GIA,
            this.columnHeader_CODE,
            this.columnHeader_NGAYNHAP,
            this.columnHeader_THANHTIEN,
            this.columnHeader_NGAYMUA});
            this.listView_TAODON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_TAODON.HideSelection = false;
            this.listView_TAODON.HotTracking = true;
            this.listView_TAODON.HoverSelection = true;
            this.listView_TAODON.LabelEdit = true;
            this.listView_TAODON.Location = new System.Drawing.Point(583, 3);
            this.listView_TAODON.Name = "listView_TAODON";
            this.listView_TAODON.Size = new System.Drawing.Size(824, 442);
            this.listView_TAODON.TabIndex = 13;
            this.listView_TAODON.UseCompatibleStateImageBehavior = false;
            this.listView_TAODON.View = System.Windows.Forms.View.Details;
            this.listView_TAODON.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_TAODON_MouseDoubleClick);
            // 
            // columnHeader_STT
            // 
            this.columnHeader_STT.Text = "STT";
            // 
            // columnHeader_TENSP
            // 
            this.columnHeader_TENSP.Text = "TÊN";
            this.columnHeader_TENSP.Width = 146;
            // 
            // columnHeader_SOLUONG
            // 
            this.columnHeader_SOLUONG.Text = "SỐ LƯỢNG";
            this.columnHeader_SOLUONG.Width = 70;
            // 
            // columnHeader_GIA
            // 
            this.columnHeader_GIA.Text = "GIÁ";
            this.columnHeader_GIA.Width = 70;
            // 
            // columnHeader_CODE
            // 
            this.columnHeader_CODE.Text = "CODE";
            this.columnHeader_CODE.Width = 96;
            // 
            // columnHeader_NGAYNHAP
            // 
            this.columnHeader_NGAYNHAP.Text = "NGÀY NHẬP";
            this.columnHeader_NGAYNHAP.Width = 99;
            // 
            // columnHeader_THANHTIEN
            // 
            this.columnHeader_THANHTIEN.Text = "Ngày mua";
            this.columnHeader_THANHTIEN.Width = 130;
            // 
            // columnHeader_NGAYMUA
            // 
            this.columnHeader_NGAYMUA.Text = "Thành tiền";
            this.columnHeader_NGAYMUA.Width = 155;
            // 
            // pictureBox_test
            // 
            this.pictureBox_test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_test.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_test.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_test.Name = "pictureBox_test";
            this.pictureBox_test.Size = new System.Drawing.Size(574, 442);
            this.pictureBox_test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_test.TabIndex = 12;
            this.pictureBox_test.TabStop = false;
            // 
            // label_TONGTIEN
            // 
            this.label_TONGTIEN.AutoSize = true;
            this.label_TONGTIEN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_TONGTIEN.Location = new System.Drawing.Point(1243, 462);
            this.label_TONGTIEN.Name = "label_TONGTIEN";
            this.label_TONGTIEN.Size = new System.Drawing.Size(19, 13);
            this.label_TONGTIEN.TabIndex = 17;
            this.label_TONGTIEN.Text = "==";
            // 
            // bunifuFlatButton_xuathoadon
            // 
            this.bunifuFlatButton_xuathoadon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_xuathoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_xuathoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton_xuathoadon.BorderRadius = 0;
            this.bunifuFlatButton_xuathoadon.ButtonText = "Xuất hóa đơn";
            this.bunifuFlatButton_xuathoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton_xuathoadon.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_xuathoadon.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_xuathoadon.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton_xuathoadon.Iconimage")));
            this.bunifuFlatButton_xuathoadon.Iconimage_right = null;
            this.bunifuFlatButton_xuathoadon.Iconimage_right_Selected = null;
            this.bunifuFlatButton_xuathoadon.Iconimage_Selected = null;
            this.bunifuFlatButton_xuathoadon.IconMarginLeft = 0;
            this.bunifuFlatButton_xuathoadon.IconMarginRight = 0;
            this.bunifuFlatButton_xuathoadon.IconRightVisible = false;
            this.bunifuFlatButton_xuathoadon.IconRightZoom = 0D;
            this.bunifuFlatButton_xuathoadon.IconVisible = false;
            this.bunifuFlatButton_xuathoadon.IconZoom = 90D;
            this.bunifuFlatButton_xuathoadon.IsTab = false;
            this.bunifuFlatButton_xuathoadon.Location = new System.Drawing.Point(185, 536);
            this.bunifuFlatButton_xuathoadon.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton_xuathoadon.Name = "bunifuFlatButton_xuathoadon";
            this.bunifuFlatButton_xuathoadon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_xuathoadon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton_xuathoadon.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_xuathoadon.selected = false;
            this.bunifuFlatButton_xuathoadon.Size = new System.Drawing.Size(277, 73);
            this.bunifuFlatButton_xuathoadon.TabIndex = 16;
            this.bunifuFlatButton_xuathoadon.Text = "Xuất hóa đơn";
            this.bunifuFlatButton_xuathoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton_xuathoadon.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton_xuathoadon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Label_result
            // 
            this.Label_result.AutoSize = true;
            this.Label_result.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_result.Location = new System.Drawing.Point(3, 578);
            this.Label_result.Name = "Label_result";
            this.Label_result.Size = new System.Drawing.Size(19, 13);
            this.Label_result.TabIndex = 14;
            this.Label_result.Text = "==";
            // 
            // textBox_update
            // 
            this.textBox_update.Location = new System.Drawing.Point(675, 458);
            this.textBox_update.Name = "textBox_update";
            this.textBox_update.Size = new System.Drawing.Size(100, 20);
            this.textBox_update.TabIndex = 15;
            // 
            // bunifuFlatButton_START
            // 
            this.bunifuFlatButton_START.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_START.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_START.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton_START.BorderRadius = 0;
            this.bunifuFlatButton_START.ButtonText = "START";
            this.bunifuFlatButton_START.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton_START.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_START.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_START.Iconimage = null;
            this.bunifuFlatButton_START.Iconimage_right = null;
            this.bunifuFlatButton_START.Iconimage_right_Selected = null;
            this.bunifuFlatButton_START.Iconimage_Selected = null;
            this.bunifuFlatButton_START.IconMarginLeft = 0;
            this.bunifuFlatButton_START.IconMarginRight = 0;
            this.bunifuFlatButton_START.IconRightVisible = false;
            this.bunifuFlatButton_START.IconRightZoom = 0D;
            this.bunifuFlatButton_START.IconVisible = false;
            this.bunifuFlatButton_START.IconZoom = 70D;
            this.bunifuFlatButton_START.IsTab = false;
            this.bunifuFlatButton_START.Location = new System.Drawing.Point(209, 355);
            this.bunifuFlatButton_START.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton_START.Name = "bunifuFlatButton_START";
            this.bunifuFlatButton_START.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_START.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton_START.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_START.selected = false;
            this.bunifuFlatButton_START.Size = new System.Drawing.Size(277, 73);
            this.bunifuFlatButton_START.TabIndex = 9;
            this.bunifuFlatButton_START.Text = "START";
            this.bunifuFlatButton_START.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton_START.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton_START.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton_START.Click += new System.EventHandler(this.bunifuFlatButton_START_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1410, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Live-Cam";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4_DetectBarcode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_Detect, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_Erode, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_Dilation, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_BinaryImg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_EdgeDetectiom, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_GrayScale, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_StockImage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1404, 696);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox10.Location = new System.Drawing.Point(939, 467);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(462, 226);
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox4_DetectBarcode
            // 
            this.pictureBox4_DetectBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4_DetectBarcode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4_DetectBarcode.Location = new System.Drawing.Point(471, 467);
            this.pictureBox4_DetectBarcode.Name = "pictureBox4_DetectBarcode";
            this.pictureBox4_DetectBarcode.Size = new System.Drawing.Size(462, 226);
            this.pictureBox4_DetectBarcode.TabIndex = 7;
            this.pictureBox4_DetectBarcode.TabStop = false;
            // 
            // pictureBox_Detect
            // 
            this.pictureBox_Detect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Detect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_Detect.Location = new System.Drawing.Point(3, 467);
            this.pictureBox_Detect.Name = "pictureBox_Detect";
            this.pictureBox_Detect.Size = new System.Drawing.Size(462, 226);
            this.pictureBox_Detect.TabIndex = 6;
            this.pictureBox_Detect.TabStop = false;
            // 
            // pictureBox_Erode
            // 
            this.pictureBox_Erode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Erode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_Erode.Location = new System.Drawing.Point(939, 235);
            this.pictureBox_Erode.Name = "pictureBox_Erode";
            this.pictureBox_Erode.Size = new System.Drawing.Size(462, 226);
            this.pictureBox_Erode.TabIndex = 5;
            this.pictureBox_Erode.TabStop = false;
            // 
            // pictureBox_Dilation
            // 
            this.pictureBox_Dilation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Dilation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_Dilation.Location = new System.Drawing.Point(471, 235);
            this.pictureBox_Dilation.Name = "pictureBox_Dilation";
            this.pictureBox_Dilation.Size = new System.Drawing.Size(462, 226);
            this.pictureBox_Dilation.TabIndex = 4;
            this.pictureBox_Dilation.TabStop = false;
            // 
            // pictureBox_BinaryImg
            // 
            this.pictureBox_BinaryImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_BinaryImg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_BinaryImg.Location = new System.Drawing.Point(3, 235);
            this.pictureBox_BinaryImg.Name = "pictureBox_BinaryImg";
            this.pictureBox_BinaryImg.Size = new System.Drawing.Size(462, 226);
            this.pictureBox_BinaryImg.TabIndex = 3;
            this.pictureBox_BinaryImg.TabStop = false;
            // 
            // pictureBox_EdgeDetectiom
            // 
            this.pictureBox_EdgeDetectiom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_EdgeDetectiom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_EdgeDetectiom.Location = new System.Drawing.Point(939, 3);
            this.pictureBox_EdgeDetectiom.Name = "pictureBox_EdgeDetectiom";
            this.pictureBox_EdgeDetectiom.Size = new System.Drawing.Size(462, 226);
            this.pictureBox_EdgeDetectiom.TabIndex = 2;
            this.pictureBox_EdgeDetectiom.TabStop = false;
            // 
            // pictureBox_GrayScale
            // 
            this.pictureBox_GrayScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_GrayScale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_GrayScale.Location = new System.Drawing.Point(471, 3);
            this.pictureBox_GrayScale.Name = "pictureBox_GrayScale";
            this.pictureBox_GrayScale.Size = new System.Drawing.Size(462, 226);
            this.pictureBox_GrayScale.TabIndex = 1;
            this.pictureBox_GrayScale.TabStop = false;
            // 
            // pictureBox_StockImage
            // 
            this.pictureBox_StockImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_StockImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_StockImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_StockImage.Name = "pictureBox_StockImage";
            this.pictureBox_StockImage.Size = new System.Drawing.Size(462, 226);
            this.pictureBox_StockImage.TabIndex = 0;
            this.pictureBox_StockImage.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(583, 525);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(138, 66);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 19;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1418, 728);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showcam)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_test)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_DetectBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Detect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Erode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dilation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BinaryImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EdgeDetectiom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GrayScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_StockImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox_camera;
        private System.Windows.Forms.PictureBox pictureBox_showcam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.ListView listView_TAODON;
        private System.Windows.Forms.ColumnHeader columnHeader_STT;
        private System.Windows.Forms.ColumnHeader columnHeader_TENSP;
        public System.Windows.Forms.ColumnHeader columnHeader_SOLUONG;
        private System.Windows.Forms.ColumnHeader columnHeader_GIA;
        private System.Windows.Forms.ColumnHeader columnHeader_CODE;
        private System.Windows.Forms.ColumnHeader columnHeader_NGAYNHAP;
        private System.Windows.Forms.ColumnHeader columnHeader_THANHTIEN;
        private System.Windows.Forms.ColumnHeader columnHeader_NGAYMUA;
        private System.Windows.Forms.PictureBox pictureBox_test;
        private System.Windows.Forms.Label label_TONGTIEN;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_xuathoadon;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_result;
        private System.Windows.Forms.TextBox textBox_update;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_START;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox4_DetectBarcode;
        private System.Windows.Forms.PictureBox pictureBox_Detect;
        private System.Windows.Forms.PictureBox pictureBox_Erode;
        private System.Windows.Forms.PictureBox pictureBox_Dilation;
        private System.Windows.Forms.PictureBox pictureBox_BinaryImg;
        private System.Windows.Forms.PictureBox pictureBox_EdgeDetectiom;
        private System.Windows.Forms.PictureBox pictureBox_GrayScale;
        private System.Windows.Forms.PictureBox pictureBox_StockImage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
