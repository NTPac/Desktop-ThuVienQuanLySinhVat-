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
    public partial class frmCNA : Form
    {
        AccountMod acc = new AccountMod();
        public frmCNA()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)  //nut de tao tai khoan mới
        {
            if (txbPassword.Text.Equals(txbPasswordConfirm.Text) == false || txbPassword.Text == null || txbUserName.Text == null)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (acc.AddData(txbUserName.Text, txbPassword.Text))
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnExit_Click(object sender, EventArgs e) // quay lai man hinh dang nhap
        {
            this.Hide();
        }
    }
}
