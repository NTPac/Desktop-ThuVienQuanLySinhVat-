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

namespace BTCKv2
{
    public partial class frmRegister : Form
    {
        SqlCommand cmd = new SqlCommand();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if ((txtPassword.Text == txbPasswordConfirm.Text) & txbUserName.Text != null)
            {
                try
                {
                    string connstr = @"Data Source=.\SQLEXPRESS;Initial Catalog=BTCKV2;Integrated Security=True";
                    SqlConnection x = new SqlConnection(connstr);
                    cmd.CommandText = "INSERT INTO Account VALUES('" + txbUserName + "','" + txtPassword + "') ";
                    cmd.CommandType = CommandType.Text;
                }
                catch(Exception ex)
                {
                    string x;
                    x = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("vui long nhap lai");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
