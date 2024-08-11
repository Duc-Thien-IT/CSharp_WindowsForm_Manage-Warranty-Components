using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QuanLySuaChuaBaoHanh
{
    public partial class frmPasswordForgot : Form
    {
        public UserBLL _userBLL;
        public frmPasswordForgot()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
        }

        

        private void frmPasswordForgot_Load(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(checkEmpty())
            {
                string chkForgotPass = _userBLL.forgotPWord(txtAccount.Text, txtPWord.Text);
                if(chkForgotPass =="-1")
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (chkForgotPass == "1")
                {
                    MessageBox.Show("Tạo mật khẩu mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                    MessageBox.Show("Lỗi xảy ra: " + chkForgotPass, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;    
            }    
        }
        public bool checkEmpty()
        {
            if (string.IsNullOrEmpty(txtAccount.Text))
            {
                MessageBox.Show("Tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAccount.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPWord.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPWord.Focus();
                return false;
            }
            if(txtPWord.TextLength <6)
            {
                MessageBox.Show("Mật khẩu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPWord.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCFPass.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCFPass.Focus();
                return false;
            }
            if(txtCFPass.Equals(txtPWord.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCFPass.Focus();
                return false;
            }

            return true;
        }

        private void picHidePass_Click(object sender, EventArgs e)
        {
            picShowpass.BringToFront();
            txtPWord.PasswordChar = '\0';
        }

        private void picShowpass_Click(object sender, EventArgs e)
        {
            picHidePass.BringToFront();
            txtPWord.PasswordChar = '•';
        }

        private void picHideCFP_Click(object sender, EventArgs e)
        {
            picShowCFP.BringToFront();
            txtCFPass.PasswordChar = '\0';
        }

        private void picShowCFP_Click(object sender, EventArgs e)
        {
            picShowCFP.BringToFront();
            txtCFPass.PasswordChar = '•';
        }
    }
}
