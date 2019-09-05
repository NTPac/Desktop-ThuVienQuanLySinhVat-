using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVienSinhVat
{
    public partial class frmLogin : Form
    {
        AccountMod acc = new AccountMod();


        public frmLogin()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, EventArgs e) //nut dang nhap
        {
            if (txbUserName.Text != "" &&(acc.GetID(txbUserName.Text, txbPassword.Text)))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLibrary f = new frmLibrary(txbUserName.Text);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnCreate_Click(object sender, EventArgs e) //mo man hinh tao tai khoan mới
        {
            frmCNA f = new frmCNA();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)  //thoat
        {
            Application.Exit();
        }
    }
}
