using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void adminloginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminloginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bARCODEDataSet_LOGIN);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bARCODEDataSet_LOGIN.adminlogin' table. You can move, or remove it, as needed.
            this.adminloginTableAdapter.Fill(this.bARCODEDataSet_LOGIN.adminlogin);

        }

        private void bunifuMaterialTextbox_pass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BTN_cancel_OnValueChange(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox_pass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bunifuMaterialTextbox_user_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bunifuMaterialTextbox_pass.Focus();
            }
        }

        private void bunifuMaterialTextbox_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=(localdb)\XLA_BARCODE;Initial Catalog=BARCODE;Integrated Security=True";
                    conn.Open();
                    string taikhoan = bunifuMaterialTextbox_user.Text;
                    string matkhau = bunifuMaterialTextbox_pass.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from adminlogin where username = '" + taikhoan + "' and pass = '" + matkhau + "' ";
                    cmd.Connection = conn;

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read() == true)
                    {
                        MessageBox.Show("LOGIN Thành công nhó !");
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Sai rồi bạn ơi @.@");
                    }
                }
                catch (Exception ex) { }
            }
        }
    }
}
