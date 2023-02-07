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

namespace barcode
{
    public partial class KHO : UserControl
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        string comm;
        int status_btn = 1;
        int[] check = {0,0,0,0,0,0};
        int[] check_stock = { 0, 0, 0, 0, 0, 0 };
        public KHO()
        {
            InitializeComponent();
            CustomizeDesing();
        }



        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {


        }

        private void BTN_search_Click(object sender, EventArgs e)
        {
            ShowSubmuenu(panel_subsearch);
        }


        public void CustomizeDesing()
        {
            panel_subadd.Visible = false;
            panel_subdelete.Visible = false;
            panel_subedit.Visible = false;
            panel_subsearch.Visible = false;
        }
        public void hidesubmenu()
        {
            if(panel_subadd.Visible == true)    panel_subsearch.Visible = false;
            if(panel_subdelete.Visible == true) panel_subdelete.Visible = false;
            if(panel_subedit.Visible == true)   panel_subedit.Visible = false;
            if(panel_subsearch.Visible == true) panel_subsearch.Visible = false;
        }
        public void ShowSubmuenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else submenu.Visible = false;
        }

        private void bunifuiOSSwitch1_OnValueChange_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
            conn.Open();
            adapter = new SqlDataAdapter("select * from KHO1 ", conn);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DatagridView_KHO.AutoGenerateColumns = false;
            DatagridView_KHO.DataSource = dataTable;
        }

        private void button_SEARCH_Click(object sender, EventArgs e)
        {
            ShowSubmuenu(panel_subsearch);
            status_btn = 1;

        }
        void POS_IMG()
        {
            
            panel_IMGEDIT.Location =    new Point(button_EDIT.Location.X+15, button_EDIT.Location.Y);
            panel_IMGADD.Location =     new Point(button_ADD.Location.X +15, button_ADD.Location.Y);
            panel_IMGDELETE.Location =  new Point(button_DELETE.Location.X+12, button_DELETE.Location.Y);
        }

        private void KHO_Load(object sender, EventArgs e)
        {
            POS_IMG();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            POS_IMG();
        }

        private void button_ADD_Click(object sender, EventArgs e)
        {
            ShowSubmuenu(panel_subadd);
            status_btn = 2;

        }

        private void button_EDIT_Click(object sender, EventArgs e)
        {
            ShowSubmuenu(panel_subedit);
            status_btn = 3;
        }

        private void button_DELETE_Click(object sender, EventArgs e)
        {
            ShowSubmuenu(panel_subdelete);
            status_btn = 4;
        }

        private void txb_search_ten_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection conn = new SqlConnection();
            //    conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
            //    conn.Open();
            //    string tensp = txb_search_ten.Text;
            //    string code = txb_search_code.Text;
            //    check_emty();
            //    adapter = new SqlDataAdapter(comm, conn);

            //    DataTable dataTable = new DataTable();
            //    adapter.Fill(dataTable);
            //    DatagridView_KHO.AutoGenerateColumns = false;
            //    DatagridView_KHO.DataSource = dataTable;
            //}
            //catch (Exception ex) { }
        }
        private string check_emty()
        {
            string COMM;
            
            if(string.IsNullOrEmpty(txb_search_ten.Text) == false)
            {
                comm = "select * from KHO1 where tensp = + '" + txb_search_ten.Text + "' ";
            }
            if (string.IsNullOrEmpty(txb_search_code.Text) == false)
            {
                comm = "select * from KHO1 where tensp = + '" + txb_search_ten.Text + "' and code = '" + txb_search_code.Text + "'";
            }
            if (string.IsNullOrEmpty(DATEPICKER_SEARCH.ToString()) == false)
            {
                DATEPICKER_SEARCH.Format = DateTimePickerFormat.Custom;
                DATEPICKER_SEARCH.FormatCustom = "yyyy-MM-dd";
                comm = "select * from KHO1 where  ngaynhap = '" + DATEPICKER_SEARCH.Value.ToString("MM/dd/yyyy") + "'";
            }
            if (string.IsNullOrEmpty(DATEPICKER_SEARCH.ToString()) == false && string.IsNullOrEmpty(DATEPICKER2_SEARCH.ToString()) == false)
            {
                DATEPICKER_SEARCH.Format = DateTimePickerFormat.Custom;
                DATEPICKER_SEARCH.FormatCustom = "yyyy-MM-dd";
                DATEPICKER2_SEARCH.Format = DateTimePickerFormat.Custom;
                DATEPICKER2_SEARCH.FormatCustom = "yyyy-MM-dd";
                comm = "select * from KHO1 where  ngaynhap = '" + DATEPICKER_SEARCH.Value.ToString("MM/dd/yyyy") + "'";
            }
            if (string.IsNullOrEmpty(txb_search_ten.Text) == true || string.IsNullOrEmpty(txb_search_code.Text) == false)
            {
                comm = "select * from KHO1 where  code = '" + txb_search_code.Text + "'";
            }

            return comm;
        }
        private string check_textbox_search()
        {
            string CC = "select * from KHO1 where";


            foreach (Control c in panel_subsearch.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Name == "txb_search_ten" && string.IsNullOrEmpty(c.Text) == false && check[0] != 1  && string.IsNullOrEmpty(txb_search_code.Text) == true)
                    {
                        CC += " tensp = '" + c.Text + "' ";
                        check[0] = 1;
                    }else if (c.Name == "txb_search_ten" && string.IsNullOrEmpty(c.Text) == false && check[0] != 1 && string.IsNullOrEmpty(txb_search_code.Text) == false)
                    {
                        CC += " and tensp = '" + c.Text + "' ";
                        check[0] = 1;
                    }
                    if (c.Name == "txb_search_code" && string.IsNullOrEmpty(c.Text) == false && check[5] != 1)
                    {
                        CC += " code = " + c.Text + " ";
                        check[5] = 1;
                    }
                }
            }
            
            if (string.IsNullOrEmpty(DATEPICKER_SEARCH.ToString()) == false && string.IsNullOrEmpty(DATEPICKER2_SEARCH.ToString()) == true)
            {
                DATEPICKER_SEARCH.Format = DateTimePickerFormat.Custom;
                DATEPICKER_SEARCH.FormatCustom = "yyyy-MM-dd";
                if(Comparing_2array(check) == true)
                {
                    CC += " and ngaynhap = '" + DATEPICKER_SEARCH.Value.ToString("MM/dd/yyyy") + "'";
                }
                else
                {
                    CC += " ngaynhap = '" + DATEPICKER_SEARCH.Value.ToString("MM/dd/yyyy") + "'";
                }
            } else
            if (string.IsNullOrEmpty(DATEPICKER_SEARCH.ToString()) == false && string.IsNullOrEmpty(DATEPICKER2_SEARCH.ToString()) == false)
            {
                DATEPICKER_SEARCH.Format = DateTimePickerFormat.Custom;
                DATEPICKER_SEARCH.FormatCustom = "yyyy-MM-dd";
                DATEPICKER2_SEARCH.Format = DateTimePickerFormat.Custom;
                DATEPICKER2_SEARCH.FormatCustom = "yyyy-MM-dd";
                if (Comparing_2array(check) == true)
                {
                    CC += " and  ngaynhap between  '" + DATEPICKER_SEARCH.Value.ToString("MM/dd/yyyy") + "' and '" + DATEPICKER2_SEARCH.Value.ToString("MM/dd/yyyy") + "'";
                }
                else
                {
                    CC += "  ngaynhap between  '" + DATEPICKER_SEARCH.Value.ToString("MM/dd/yyyy") + "' and '" + DATEPICKER2_SEARCH.Value.ToString("MM/dd/yyyy") + "'";
                }

            }
            return CC;
        }
        bool Comparing_2array(int[] a)
        {
            bool hasDuplicate = false;
            foreach (var numberA in a)
            {

                    if (numberA != 0 )
                    {
                        hasDuplicate = true;
                    }

            }
            return hasDuplicate;
        }
        int[] default_arr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
            return a;
        }

        private void DATEPICKER_SEARCH_onValueChanged(object sender, EventArgs e)
        {
            DATEPICKER_SEARCH.Format = DateTimePickerFormat.Custom;
            DATEPICKER_SEARCH.FormatCustom = "yyyy-MM-dd";
            string datesearch = DATEPICKER_SEARCH.ToString();
        }

        private void DatagridView_KHO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (status_btn)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
                    conn.Open();
                    adapter = new SqlDataAdapter("delete from KHO1 where code = '"+DatagridView_KHO.Rows[e.RowIndex].Cells[5].Value.ToString()+"'", conn);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DatagridView_KHO.AutoGenerateColumns = false;
                    DatagridView_KHO.DataSource = dataTable;
                    refesh_DATABASE_KHO();
                    break;
            }
        }

        public void refesh_DATABASE_KHO()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
            conn.Open();
            adapter = new SqlDataAdapter("select * from KHO1 ", conn);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DatagridView_KHO.AutoGenerateColumns = false;
            DatagridView_KHO.DataSource = dataTable;
        }

        private void BTN_CHECKADD_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (Control c in panel_subadd.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(c.Text) == true)
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin tại ô " + c.Name);
                        flag = false;
                    }
                }
                if(flag == true)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
                        conn.Open();


                        int id = DatagridView_KHO.RowCount;
                        string ten = txb_add_ten.Text;
                        string soluong = txb_add_soluong.Text;
                        string gia = txb_add_gia.Text;
                        string ngaynhap = DatePicker_add.Value.ToString("MM/dd/yyyy");
                        string code = txb_add_code.Text;
                        string commm = "insert into KHO1(id, tensp, soluong, gia, ngaynhap, code) values(" + id + ",'" + ten + "'," + soluong + "," + gia + ",'" + ngaynhap + "',' " + code + "')  ";
                        adapter = new SqlDataAdapter(commm, conn);

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DatagridView_KHO.AutoGenerateColumns = false;
                        DatagridView_KHO.DataSource = dataTable;
                    }
                    catch (Exception ex) { }
                }
            }
        }

        private void BTN_SEARCH_Click_1(object sender, EventArgs e)
        {
            check = default_arr(check);
            string CC = "select * from KHO1 where";
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
                conn.Open();
                string cmd = check_textbox_search();
                
                adapter = new SqlDataAdapter(cmd, conn);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DatagridView_KHO.AutoGenerateColumns = false;
                DatagridView_KHO.DataSource = dataTable;
            }
            catch (Exception ex) { }

        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
            conn.Open();
            adapter = new SqlDataAdapter("select * from KHO1 where tensp = + '" + txb_edit_ten.Text + "' ", conn);


            string ten = txb_edit_ten.Text;
            string soluong = txb_edit_soluong.Text;
            string gia = txb_edit_gia.Text;
            string ngaynhap = txb_edit_ngaynhap.Text;
            string code = txb_edit_code.Text;

            string command = "update KHO1 set tensp =  '" + ten+"',soluong = '"+soluong+ "',gia =' " + gia + "', ngaynhap = '" + ngaynhap + "' where code = '" + code + "'   ";
            adapter = new SqlDataAdapter(command, conn);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DatagridView_KHO.AutoGenerateColumns = false;
            DatagridView_KHO.DataSource = dataTable;
            refesh_DATABASE_KHO();
        }

        private void txb_edit_ten_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
                conn.Open();
                adapter = new SqlDataAdapter("select * from KHO1 where tensp = + '" + txb_edit_ten.Text + "' ", conn);

                SqlCommand cmd = new SqlCommand("select * from KHO1 where tensp = + '" + txb_edit_ten.Text + "' ", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txb_edit_soluong.Text = reader.GetValue(2).ToString();
                    txb_edit_gia.Text = reader.GetValue(3).ToString();
                    txb_edit_ngaynhap.Text = reader.GetValue(4).ToString();
                    txb_edit_code.Text = reader.GetValue(5).ToString();

                }
            }
        }

        private void DatagridView_KHO_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                switch (status_btn)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        bool flag = true;
                            if (flag == true)
                            {
                                //SqlConnection conn = new SqlConnection();
                                //conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
                                //conn.Open();
                                //DatePicker_add.Format = DateTimePickerFormat.Custom;
                                //DatePicker_add.FormatCustom = "yyyy-MM-dd";

                                //int id = DatagridView_KHO.RowCount;
                                //string ten = DatagridView_KHO.Rows[id].Cells[1].ToString();
                                //string soluong = DatagridView_KHO.Rows[id].Cells[2].ToString();
                                //string gia = DatagridView_KHO.Rows[id].Cells[3].ToString();
                                //string ngaynhap = DatagridView_KHO.Rows[id].Cells[4].ToString();
                                //string code = DatagridView_KHO.Rows[id].Cells[5].ToString();
                                //adapter = new SqlDataAdapter("insert into KHO1(id, tensp, soluong, gia, ngaynhap, code) values(" + id + ",'" + ten + "'," + soluong + "," + gia + "," + ngaynhap + "," + code + ")  ", conn);

                                //DataTable dataTable = new DataTable();
                                //adapter.Fill(dataTable);
                                //DatagridView_KHO.AutoGenerateColumns = false;
                                //DatagridView_KHO.DataSource = dataTable;
                            }
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
        }
        bool flag_MINI = true;
        private void BTN_MINI_Click(object sender, EventArgs e)
        {
            timer2.Start();
            flag_MINI = !flag_MINI;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            panel_CONTROL.Dock = DockStyle.Left;
            if (flag_MINI == false)
            {
                panel_CONTROL.Width = panel_CONTROL.Width - 35 ;
                int POS_BTN_MINI = BTN_MINI.Location.X - 35;
                BTN_MINI.Location = new Point(POS_BTN_MINI, 410);
                if (panel_CONTROL.Width < 1)
                {
                    BTN_MINI.Location = new Point(0, 410);
                    BTN_MINI.Image = System.Drawing.Image.FromFile(@"D:\STUDY\Nam3-HK2\XLA\PROJECT\c#2\IMG\FORM3_LOGIN\chevron_out.png");
                    timer2.Stop();
                }

            }

            if (flag_MINI == true)
            {
                panel_CONTROL.Width = panel_CONTROL.Width + 35;
                int POS_BTN_MINI = BTN_MINI.Location.X + 35;
                BTN_MINI.Location = new Point(POS_BTN_MINI, 410);
                if (panel_CONTROL.Width > 301)
                {
                    panel_CONTROL.Dock = DockStyle.Left;

                    panel_CONTROL.Width = 300;
                    DatagridView_KHO.Dock = DockStyle.Fill;

                    BTN_MINI.Image = System.Drawing.Image.FromFile(@"D:\STUDY\Nam3-HK2\XLA\PROJECT\c#2\IMG\FORM3_LOGIN\chevron.png");
                    BTN_MINI.Location = new Point(315, 410);
                    timer2.Stop();
                }
            }
        }

        private void bunifuiOSSwitch1_OnValueChange_2(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
            conn.Open();
            adapter = new SqlDataAdapter("select * from KHO1 ", conn);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DatagridView_KHO.AutoGenerateColumns = false;
            DatagridView_KHO.DataSource = dataTable;
        }

        private void DatePicker_add_onValueChanged(object sender, EventArgs e)
        {

        }
    }
}
