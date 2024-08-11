using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace QuanLySuaChuaBaoHanh
{
    public partial class frmLogin : Form
    {
        private UserDTO _userDTO = new UserDTO();
        private UserBLL _userBLL;
        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            _userBLL = new UserBLL();
            string userID = _userBLL.checkLogin(txtUName.Text, txtPWord.Text);
            if(txtUName.Text == "")
            {
                MessageBox.Show("Tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUName.Focus();
                return;
            }
            if (txtPWord.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPWord.Focus();
                return;
            }
            if (userID == "-1")
            {
                MessageBox.Show("Vui lòng kiểm tra lại tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUName.Focus();
                return;
            }
            if (userID == "1")
            {
                MessageBox.Show("Vui lòng kiểm tra lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPWord.Focus();
                return;
            }

            if (userID != "1" && userID != "-1")
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _userDTO = _userBLL.getUser(userID);
                frmMain frmMain = new frmMain(_userDTO);
                frmMain.Show();
            }
        }

        private void picShowpass_Click(object sender, EventArgs e)
        {
            picHidePass.BringToFront();
            txtPWord.PasswordChar = '•';
        }

        private void picHidePass_Click(object sender, EventArgs e)
        {
            picShowpass.BringToFront();
            txtPWord.PasswordChar = '\0';
        }

        private void lbDangKy_Click(object sender, EventArgs e)
        {
            frmSignup frmSignup = new frmSignup();
            frmSignup.Show();
        }

        private void lbForget_Click(object sender, EventArgs e)
        {
            frmPasswordForgot frmPasswordForgot = new frmPasswordForgot();
            frmPasswordForgot.Show();
        }
    }
}
