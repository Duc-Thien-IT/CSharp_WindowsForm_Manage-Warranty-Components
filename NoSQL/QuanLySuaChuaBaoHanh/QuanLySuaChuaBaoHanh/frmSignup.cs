using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLySuaChuaBaoHanh
{
    public partial class frmSignup : Form
    {
        public UserBLL _userBLL;
        public frmSignup()
        {
            InitializeComponent();
        }
        private void frmSignup_Load(object sender, EventArgs e)
        {
            //txtUName.Focus();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            _userBLL = new UserBLL();
            int checkSignup = _userBLL.checkSingup(txtAccount.Text, txtSDT.Text);
            if (checkEmpty())
            {
                string selectedRole = rdioNV.Checked ? rdioNV.Text : rdioQL.Text;
                string selectedPhai = rdioNam.Checked ? rdioNam.Text : rdioNu.Text;
                if (checkSignup == 1)
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAccount.Focus();
                    return;
                }
                if(checkSignup == 2)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                    return;
                }
                if(checkSignup == 0)
                {
                    string chkCreate = _userBLL.createUser(txtAccount.Text, txtPass.Text,txtHoTen.Text, dtNgaySinh.Text, selectedRole, txtDiaChi.Text, selectedPhai, txtSDT.Text);
                    if (chkCreate == "1")
                    {
                        MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Lỗi xảy ra: " + chkCreate, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
        private void picShowpass_Click(object sender, EventArgs e)
        {
            picHidePass.BringToFront();
            txtPass.PasswordChar = '•';
        }

        private void picHidePass_Click(object sender, EventArgs e)
        {
            picShowpass.BringToFront();
            txtPass.PasswordChar = '\0';
        }

        private void picShowCFP_Click(object sender, EventArgs e)
        {
            picHideCFP.BringToFront();
            txtCFP.PasswordChar = '•';
        }

        private void picHideCFP_Click(object sender, EventArgs e)
        {
            picShowCFP.BringToFront();
            txtCFP.PasswordChar = '\0';
        }
        public bool checkEmpty()
        {
            if (string.IsNullOrEmpty(txtAccount.Text))
            {
                MessageBox.Show("Tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAccount.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return false; 
            }
            if (txtPass.TextLength < 6)
            {
                MessageBox.Show("Mật khẩu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCFP.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCFP.Focus();
                return false;
            }
            if(txtCFP.Equals(txtPass))
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCFP.Focus();
                return false;
            }

            if(!rdioQL.Checked && !rdioNV.Checked) 
            {
                MessageBox.Show("Vui lòng chọn chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }
            if (!rdioNam.Checked && !rdioNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }
            if(txtSDT.TextLength > 10 && txtSDT.TextLength < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }

       
    }
}
