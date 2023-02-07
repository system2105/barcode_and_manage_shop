using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barcode
{
    public partial class FORM_HOADON : Form
    {
        public string tenkhachhang, diachi, gmail, money;
        public DataGridView data_money;
        public FORM_HOADON()
        {
            InitializeComponent();
        }

        private void FORM_HOADON_Load(object sender, EventArgs e)
        {
            label_tenkhach.Text = tenkhachhang;
            label_diachi.Text = diachi;
            label_gmail.Text = gmail;
            label_time.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label_summoney.Text = money;
            panel_tinhtien.Controls.Add(data_money);
            data_money.Dock = DockStyle.Fill;

        }
        void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel_haodonMAIN = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }
        Bitmap memoryimg;
        void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagarea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagarea.Width / 2) - (panel_haodonMAIN.Width / 2), panel_haodonMAIN.Location.Y);
        }

        private void panel_haodonMAIN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_PRINTF_Click(object sender, EventArgs e)
        {
            Print(panel_haodonMAIN);
        }
    }
}
