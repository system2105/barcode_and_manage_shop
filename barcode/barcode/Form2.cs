using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using OpenCvSharp.Tracking;
using OpenCvSharp.XPhoto;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace barcode
{
    
    public partial class Form2 : Form
    {
        int pos_panelchoose = 0;
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;
        decimal tongtien;
        int nguong;

        UserControl1 CREATEORDER = new UserControl1();
        KHO showkho = new KHO();
        SCANFORM SCANFORM_2 = new SCANFORM();
        public Form2()
        {
            InitializeComponent();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bARCODEDataKHO.KHO1' table. You can move, or remove it, as needed.
            this.kHO1TableAdapter.Fill(this.bARCODEDataKHO.KHO1);
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in FilterInfoCollection)
            {

            }

        }
        private void bunifuFlatButton_taodon_Click(object sender, EventArgs e)
        {
            pos_panelchoose = 1;
            position_panelchosse();
            SCANFORM_2.Dock = DockStyle.Fill;
            panel_container.Controls.Add(SCANFORM_2);
            panel_container.Controls.Remove(showkho);
        }

        private void bunifuFlatButton_kho_Click(object sender, EventArgs e)
        {
            pos_panelchoose = 2;
            position_panelchosse();

            panel_container.Controls.Remove(SCANFORM_2);
            showkho.Dock = DockStyle.Fill;
            panel_container.Controls.Add(showkho);
           
            
        }

        public void position_panelchosse()
        {
            switch (pos_panelchoose)
            {
                case 1:
                    bunifuGradientPanel_choose.Location = new Point(0, 183);
                    break;
                case 2:
                    bunifuGradientPanel_choose.Location = new Point(0, 248);
                    break;
                case 3:
                    bunifuGradientPanel_choose.Location = new Point(0, 311);
                    break;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            pos_panelchoose = 3;
            position_panelchosse();
        }

        private void bunifuFlatButton_taodon_MouseHover(object sender, EventArgs e)
        {
            pos_panelchoose = 1;
            position_panelchosse();
        }

        private void bunifuFlatButton_kho_MouseHover(object sender, EventArgs e)
        {
            pos_panelchoose = 2;
            position_panelchosse();
        }

        private void bunifuFlatButton2_MouseHover(object sender, EventArgs e)
        {
            pos_panelchoose = 3;
            position_panelchosse();
        }

        private void bunifuFlatButton2_Enter(object sender, EventArgs e)
        {
            pos_panelchoose = 3;
            position_panelchosse();
        }

        private void bunifuFlatButton2_MouseMove(object sender, MouseEventArgs e)
        {
            pos_panelchoose = 3;
            position_panelchosse();
        }







        private void kHO1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHO1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bARCODEDataKHO);

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void BUTTON_CANCEL_OnValueChange(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
