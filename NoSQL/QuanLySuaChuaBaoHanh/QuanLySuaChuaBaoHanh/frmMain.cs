using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DTO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace QuanLySuaChuaBaoHanh
{
    public partial class frmMain : Form
    {
        public UserDTO _userDTO = new UserDTO();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllispe

        );
        public frmMain(UserDTO userDTO)
        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Hide();

            lblTitle.Text = "Quản Lý Nhân Viên";
            this.pnlFormLoader.Controls.Clear();
            frmManageStaff FrmManageStaff = new frmManageStaff() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmManageStaff.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmManageStaff);
            FrmManageStaff.Show();
            _userDTO = userDTO;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            checkRole();
        }
        private void btnQLNV_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnQLNV.Height;
            pnlNav.Top = btnQLNV.Top;
            pnlNav.Left = btnQLNV.Left;
            btnQLNV.BackColor = Color.PaleTurquoise;

            lblTitle.Text = "Quản Lý Nhân Viên";
            this.pnlFormLoader.Controls.Clear();
            frmManageStaff FrmManageStaff = new frmManageStaff() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmManageStaff.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmManageStaff);
            FrmManageStaff.Show();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnQLKH.Height;
            pnlNav.Top = btnQLKH.Top;
            pnlNav.Left = btnQLKH.Left;
            btnQLKH.BackColor = Color.PaleTurquoise;

            lblTitle.Text = "Quản Lý Khách Hàng";
            this.pnlFormLoader.Controls.Clear();
            frmManageCustomer FrmManageCustomer = new frmManageCustomer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmManageCustomer.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmManageCustomer);
            FrmManageCustomer.Show();
        }

        private void btnQLLK_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnQLLK.Height;
            pnlNav.Top = btnQLLK.Top;
            pnlNav.Left = btnQLLK.Left;
            btnQLLK.BackColor = Color.PaleTurquoise;

            lblTitle.Text = "Quản Lý Linh Kiện Điện Tử";
            this.pnlFormLoader.Controls.Clear();
            frmManageComponents FrmManageComponents = new frmManageComponents() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmManageComponents.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmManageComponents);
            FrmManageComponents.Show();
        }

        private void btnPBH_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnPBH.Height;
            pnlNav.Top = btnPBH.Top;
            pnlNav.Left = btnPBH.Left;
            btnPBH.BackColor = Color.PaleTurquoise;

            lblTitle.Text = "Quản Lý Phiếu Bảo Hành";
            this.pnlFormLoader.Controls.Clear();
            frmManageWarranty FrmManageWarranty = new frmManageWarranty(_userDTO) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			FrmManageWarranty.FormBorderStyle = FormBorderStyle.None;
			this.pnlFormLoader.Controls.Add(FrmManageWarranty);
			FrmManageWarranty.Show();
		}

        private void btnCD_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnCD.Height;
            pnlNav.Top = btnCD.Top;
            pnlNav.Left = btnCD.Left;
            btnCD.BackColor = Color.PaleTurquoise;

            lblTitle.Text = "Cài Đặt";
            this.pnlFormLoader.Controls.Clear();
            frmSetting FrmSetting = new frmSetting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSetting.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmSetting);
            FrmSetting.Show();
        }

        private void btnQLNV_Leave(object sender, EventArgs e)
        {
            btnQLNV.BackColor = Color.LightSkyBlue;
        }

        private void btnQLKH_Leave(object sender, EventArgs e)
        {
            btnQLKH.BackColor = Color.LightSkyBlue;
        }

        private void btnQLLK_Leave(object sender, EventArgs e)
        {
            btnQLLK.BackColor = Color.LightSkyBlue;   
        }

        private void btnPBH_Leave(object sender, EventArgs e)
        {
            btnPBH.BackColor = Color.LightSkyBlue;
        }

        private void btnCD_Leave(object sender, EventArgs e)
        {
            btnCD.BackColor = Color.LightSkyBlue;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void checkRole()
        {
            lbRole.Text = _userDTO.Role;
            lbUsername.Text = "Xin chào, " + _userDTO.HoTen;
            if (_userDTO.Role == "Nhân Viên")
            {
                btnQLNV.Hide();
            }
        }

     
    }
}
