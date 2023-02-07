using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using AForge.Video.DirectShow;
using AForge.Video;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;

namespace barcode
{
    public partial class UserControl1 : UserControl
    {
        int pos_panelchoose = 0;
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;
        decimal tongtien;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton_START_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[0].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
            conn.Open();
            listView_TAODON.LabelEdit = true;
            tongtien = 0;
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox_showcam.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox_StockImage.Image = (Bitmap)eventArgs.Frame.Clone();
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {

            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in FilterInfoCollection)
            {
                comboBox_camera.Items.Add(item.Name);
                comboBox_camera.SelectedIndex = 0;
            }
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
                        foreach (ListViewItem lvi in listView_TAODON.Items)
                            if (lvi.SubItems[4].Text == codeqr.ToString())
                            {
                                flag = true;
                            }

                        if (flag == false)
                        {
                            SqlConnection conn = new SqlConnection();
                            conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
                            conn.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandText = "select * from KHO1 where code = '" + codeqr + "' ";
                            cmd.Connection = conn;

                            SqlDataReader rd = cmd.ExecuteReader();

                            if (rd.Read() == true)
                            {
                                thanhtien = Convert.ToDecimal(rd[3]);


                                ListViewItem item = new ListViewItem();
                                item.Text = listView_TAODON.Items.Count.ToString();

                                item.SubItems.Add(rd[1].ToString());
                                item.SubItems.Add("1");
                                item.SubItems.Add(rd[3].ToString());
                                item.SubItems.Add(rd[5].ToString());
                                item.SubItems.Add(rd[4].ToString());
                                item.SubItems.Add(DateTime.Now.ToString());
                                item.SubItems.Add(thanhtien.ToString());
                                listView_TAODON.Items.Add(item);

                            }


                        }
                        listView_TAODON.Update();
                        tongtien = 0;
                        tinhtien();
                    }

                }
                catch (Exception ex) { }

            }
            
        }

        private void listView_TAODON_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listView_TAODON.SelectedItems[0].SubItems[2].Text = textBox_update.Text;
            int soluong = Convert.ToInt32(textBox_update.Text);
            string tmp = listView_TAODON.SelectedItems[0].SubItems[3].ToString();
            decimal gia = decimal.Parse(Regex.Match(tmp, @"-?\d{1,3}(,\d{3})*(\.\d+)?").Value) * 100;
            decimal thanhtien = Convert.ToDecimal(soluong * gia);
            listView_TAODON.SelectedItems[0].SubItems[7].Text = thanhtien.ToString();
            tinhtien();
        }
        public void tinhtien()
        {

            for (int i = 0; i < listView_TAODON.Items.Count; i++)
            {

                int soluong = Int32.Parse(Regex.Match(listView_TAODON.Items[i].SubItems[2].ToString(), @"-?\d{1,3}(,\d{3})*(\.\d+)?").Value);
                int gia = Int32.Parse(Regex.Match(listView_TAODON.Items[i].SubItems[3].ToString(), @"-?\d{1,3}(,\d{3})*(\.\d+)?").Value)*100;
                tongtien = Convert.ToDecimal(soluong * gia) + tongtien;
                label_TONGTIEN.Text = tongtien.ToString();
            }
        }

    }
}
