using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barcode
{
    public partial class SCANFORM : UserControl
    {
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;
        decimal tongtien;
        string tenkhach, diachi, gmail;
        int stt_cam = 0;
        public SCANFORM()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton_START_Click(object sender, EventArgs e)
        {

        }

        private void SCANFORM_Load(object sender, EventArgs e)
        {
            timer2.Start();
            panel_SHOWWHOADON.Location = new Point(data_mua.Location.X+32, 451);
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in FilterInfoCollection)
            {
                comboBox_camera.Items.Add(item.Name);
                
            }
        }

        private void BUTTON_START_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[stt_cam].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
            conn.Open();
           
            tongtien = 0;
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox_showcam.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox_StockImage.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox_showcam.Image != null)
            {

                Bitmap stockimg = new Bitmap(pictureBox_showcam.Image);
                var img4 = new Image<Bgr, byte>(stockimg);
                var img5 = new Image<Bgr, byte>(stockimg);
                var img6 = new Image<Bgr, byte>(stockimg);
                //Tien xu ly

                //RGB => GrayScale
                Image<Gray, byte> grayscale_img = new Image<Gray, byte>(stockimg);
                pictureBox_GrayScale.Image = (Bitmap)grayscale_img.Bitmap;

                //EdgeDetection using sobel for GrayScale
                Image<Gray, float> edgedetection_sobel = grayscale_img.Sobel(1, 1, 3);
                pictureBox_EdgeDetectiom.Image = edgedetection_sobel.Bitmap;

                //Binary
                var Binary_img = edgedetection_sobel.ThresholdBinary(new Gray(19), new Gray(255));
                pictureBox_BinaryImg.Image = Binary_img.Bitmap;

                //Erode and Dilation
                var Dilation_img = Binary_img.Dilate(3);
                pictureBox_Dilation.Image = Dilation_img.Bitmap;
                var Erode_img = Dilation_img.Erode(3);


                var Finish1_img = Erode_img.Convert<Gray, byte>();

                pictureBox_Erode.Image = Erode_img.Bitmap;


                //ve khung
                VectorOfVectorOfPoint contour = new VectorOfVectorOfPoint();
                Mat h = new Mat();
                CvInvoke.FindContours(Finish1_img, contour, h, Emgu.CV.CvEnum.RetrType.External, ChainApproxMethod.ChainApproxSimple);
                Dictionary<int, double> dict = new Dictionary<int, double>();
                double max = 0;
                int max_pos = 0;
                for (int i = 0; i < contour.Size; i++)
                {

                    double area = CvInvoke.ContourArea(contour[i], true);
                    dict.Add(i, area);

                    Rectangle rect = CvInvoke.BoundingRectangle(contour[i]);
                    CvInvoke.Rectangle(img4, rect, new MCvScalar(255, 0, 0), 3);
                    pictureBox_Detect.Image = img4.Bitmap;

                    double dientich = rect.Width * rect.Height;
                    if (dientich > max)
                    {
                        max_pos = i;
                        max = dientich;
                    }

                }
                Rectangle rect2 = CvInvoke.BoundingRectangle(contour[max_pos]);
                CvInvoke.Rectangle(img5, rect2, new MCvScalar(255, 0, 0), 3);
                pictureBox_test.Image = img5.Bitmap;
                pictureBox4_DetectBarcode.Image = img5.Bitmap;

                Rectangle barcode_box = CvInvoke.BoundingRectangle(contour[max_pos]);
                barcode_box.Width = barcode_box.Width + Convert.ToInt32(barcode_box.Width * 0.15);
                barcode_box.Height = barcode_box.Height + Convert.ToInt32(barcode_box.Height * 0.15);
                img6.ROI = barcode_box;
                var img_crop = img6.Copy();
                img6.ROI = Rectangle.Empty;
                try
                {
                    ZXing.BarcodeReader reader = new ZXing.BarcodeReader();
                    var result = reader.Decode(img_crop.Bitmap);

                    if (result != null)
                    {
                        bool flag = false;
                        decimal thanhtien = 0;
                        Label_result.Text = result.ToString();
                        Int64 codeqr = Convert.ToInt64(result.ToString());
                        if(CHECK_DATAGRIDVIEW() == false || CHECK_DATAGRIDVIEW() == null)
                        {
                            SqlConnection conn = new SqlConnection();
                            conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
                            conn.Open();

                            SqlCommand cmd = new SqlCommand("select * from KHO1 where code = + '" + Label_result.Text + "' ", conn);
                            SqlDataReader rd = cmd.ExecuteReader();
                            Console.Beep(10000, 350);
                            while (rd.Read())
                            {
                                var index = data_mua.Rows.Add();
                                data_mua.Rows[index].Cells[0].Value = index.ToString();
                                data_mua.Rows[index].Cells[1].Value = rd.GetValue(1).ToString(); //TEN
                                data_mua.Rows[index].Cells[2].Value = rd.GetValue(3).ToString(); //GIA
                                data_mua.Rows[index].Cells[3].Value = "1"; //GIA
                                data_mua.Rows[index].Cells[4].Value = rd.GetValue(4).ToString();//NGAYNHAP
                                data_mua.Rows[index].Cells[5].Value = DateTime.Now.ToString(); ;//NGAYXUAT
                                data_mua.Rows[index].Cells[6].Value = rd.GetValue(5).ToString();//CODE

                                int soluong = Convert.ToInt32(data_mua.Rows[index].Cells[3].Value.ToString());
                                decimal gia = decimal.Parse(data_mua.Rows[index].Cells[2].Value.ToString());
                                thanhtien = Convert.ToDecimal(soluong * gia);
                                data_mua.Rows[index].Cells[7].Value = thanhtien.ToString();
                                tinhtongtien();
                            }
                        }


                     
                    }

                }
                catch (Exception ex) { }

            }
            

        }
        bool CHECK_DATAGRIDVIEW()
        {
            bool flag = false;
            data_mua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                for (int i = 0; i < data_mua.Rows.Count-1; i++)
                {

                    if (data_mua.Rows[i].Cells[6].Value.ToString() == Label_result.Text)
                    {
                        flag = true;

                    }
                }
            }
            catch(Exception ex) { }
            return flag;
        }

        private void data_mua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_mua_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

            }
        }

        private void data_mua_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            bool flag = false;
            decimal thanhtien = 0;

            int soluong = Convert.ToInt32(data_mua.Rows[index].Cells[3].Value.ToString());
            decimal gia = decimal.Parse(data_mua.Rows[index].Cells[2].Value.ToString());
            thanhtien = Convert.ToDecimal(soluong * gia);
            data_mua.Rows[index].Cells[7].Value = thanhtien.ToString();
            tinhtongtien();
        }

        private void tinhtongtien()
        {
            decimal tongtien = 0;
            for(int i = 0; i < data_mua.Rows.Count-1; i++)
            {
                tongtien = tongtien + decimal.Parse(data_mua.Rows[i].Cells[7].Value.ToString());
                label_TONGTIEN.Text = tongtien.ToString();
            }
        }

        private void BUTTON_XUATHOADON_Click(object sender, EventArgs e)
        {
            FORM_HOADON hoadon = new FORM_HOADON();
            hoadon.tenkhachhang = txb_KHACH_ten.Text;
            hoadon.diachi = txb_KHACH_diachi.Text;
            hoadon.gmail = txb_KHACH_EMAIL.Text;
            hoadon.data_money = data_mua;
            hoadon.money = label_TONGTIEN.Text;
            hoadon.ShowDialog();
            tableLayoutPanel2.Controls.Add(data_mua);

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
            conn.Open();
            for(int i = 0; i < data_mua.Rows.Count-1; i++)
            {
                string code = data_mua.Rows[i].Cells[6].Value.ToString();
                SqlCommand cmd = new SqlCommand("select * from KHO1 where code = + '" + code+ "' ", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                int temp = 0;
                if(rd.Read())
                {
                        string id = rd.GetString(0).ToString();
                        string ten = rd.GetValue(1).ToString();

                        string gia = rd.GetValue(3).ToString();
                        string ngaynhap = rd.GetValue(4).ToString();

                        
                        int soluong_trongkho = Convert.ToInt32(rd.GetValue(2).ToString());
                        int soluong_dangban = Convert.ToInt32(data_mua.Rows[i].Cells[3].Value.ToString());
                        int soluong = soluong_trongkho - soluong_dangban;
                        string soluong_ = soluong.ToString();
                        string command = "update KHO1 set id = '"+id+"',tensp =  '" + ten + "',soluong = '" + soluong_ + "',gia =' " + gia + "', ngaynhap = '" + ngaynhap + "' where code = '" + code + "'   ";
                        SqlDataAdapter adapter = new SqlDataAdapter(command, conn);

                        DataTable dataTable2 = new DataTable();
                        adapter.Fill(dataTable2);

                }
            }
        }
        bool flag_showhoadon = true;
        private void BTN_SHOW_PANELHOADON_Click(object sender, EventArgs e)
        {
            flag_showhoadon = !flag_showhoadon;
            timer2.Start();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (flag_showhoadon == false)
            {
                panel_SHOWWHOADON.Height -= 9;
                int pos_btn_showhoadon = BTN_SHOW_PANELHOADON.Location.Y -9;
                BTN_SHOW_PANELHOADON.Location = new Point(data_mua.Location.X, pos_btn_showhoadon);
                if (panel_SHOWWHOADON.Height < 1)
                {
                    timer2.Stop();
                    BTN_SHOW_PANELHOADON.Image = System.Drawing.Image.FromFile(@"D:\STUDY\Nam3-HK2\XLA\PROJECT\c#2\IMG\FORM3_LOGIN\down.png");
                }
            }
            if (flag_showhoadon == true)
            {
                panel_SHOWWHOADON.Height += 9;
                int pos_btn_showhoadon = BTN_SHOW_PANELHOADON.Location.Y +9;
                BTN_SHOW_PANELHOADON.Location = new Point(data_mua.Location.X+10, pos_btn_showhoadon);
                if (panel_SHOWWHOADON.Height > 115)
                {
                    timer2.Stop();
                    BTN_SHOW_PANELHOADON.Image = System.Drawing.Image.FromFile(@"D:\STUDY\Nam3-HK2\XLA\PROJECT\c#2\IMG\FORM3_LOGIN\up-arrow.png");
                }
            }
        }

        private void comboBox_camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            stt_cam = comboBox_camera.SelectedIndex;
        }

        private void txb_KHACH_ten_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txb_KHACH_diachi.Focus();
            }
        }

        private void txb_KHACH_diachi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_KHACH_EMAIL.Focus();
            }
        }
    }
}