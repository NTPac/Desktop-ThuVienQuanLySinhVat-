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

namespace ThuVienSinhVat
{
    public partial class frmLibrary : Form
    {
        frmLogin frm = new frmLogin();

        libraryMod f = new libraryMod();

        public frmLibrary(string x)
        {
            InitializeComponent();
            label7.Text = x;
        }
        void loaddata()  //hàm load du liệu
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = f.GetData();
            dgvLibrary.DataSource = dtDS;
            binhding();
        }
        private void FrmLibrary_Load(object sender, EventArgs e)
        {
            loaddata();

        }
        private void binhding() //hàm truyen dữ liệu từ dgvLibrary vao text box
        {
            txbId.DataBindings.Clear();
            _ = txbId.DataBindings.Add("Text", dgvLibrary.DataSource, "id");
            txbTen.DataBindings.Clear();
            txbTen.DataBindings.Add("Text", dgvLibrary.DataSource, "Ten");
            txbLoai.DataBindings.Clear();
            txbLoai.DataBindings.Add("Text", dgvLibrary.DataSource, "Loai");
            txbSl.DataBindings.Clear();
            txbSl.DataBindings.Add("Text", dgvLibrary.DataSource, "Soluong");
            txbMt.DataBindings.Clear();
            txbMt.DataBindings.Add("Text", dgvLibrary.DataSource, "mota");
        }
        private void BtnAdd_Click(object sender, EventArgs e) //them
        {
            if (f.AddData(txbTen.Text,txbLoai.Text,txbSl.Text,txbMt.Text,label7.Text))
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            loaddata();
        }

        private void BtnEdit_Click(object sender, EventArgs e) //sửa
        {
            if(f.UpdData(txbTen.Text,txbLoai.Text,txbSl.Text,txbMt.Text,label7.Text,Convert.ToInt32(txbId.Text)))
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            loaddata();
        }

        private void BtnDelete_Click(object sender, EventArgs e) //xóa
        {
            if (f.DelData(txbId.Text))
                MessageBox.Show("xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            loaddata();
        }

        private void BtnSearch_Click(object sender, EventArgs e) //tìm kiếm
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = f.searchData(txbTen.Text);
            dgvLibrary.DataSource = dtDS;
            binhding();
        }

        private void BtnLoop_Click(object sender, EventArgs e) //truyền lại dữ liệu
        {
            loaddata();
        }

        private void BtnPrint_Click(object sender, EventArgs e) // in
        {
            try
            {
                printDocument1.Print();
            }
            catch
            {
                MessageBox.Show("In không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e) //hàm in
        {
            Bitmap bm = new Bitmap(this.dgvLibrary.Width, this.dgvLibrary.Height);
            dgvLibrary.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvLibrary.Width, this.dgvLibrary.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
