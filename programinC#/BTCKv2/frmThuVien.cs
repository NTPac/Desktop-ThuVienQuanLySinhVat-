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
using System.Data.Sql;

namespace BTCKv2
{
    public partial class frmThuVien : Form
    {
        string connstr = "Data Source=.\\SQLEXPRESS;Initial Catalog=BTCKV2;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        public frmThuVien()
        {
            InitializeComponent();

            loadThuVien();
        }
        void loadThuVien()
        {
            DataTable data = new DataTable();
            SqlConnection x = new SqlConnection(connstr);
            cmd.CommandText = ("select * from ThuVienSV");
            cmd.CommandType = cmd.CommandText;
            cmd.Connection = x.
             x.Open();


             SqlDataAdapter adapter = new SqlDataAdapter(command);

             adapter.Fill(data);

        }
        private void FrmThuVien_Load(object sender, EventArgs e)
        {
            
        }
    }
}
