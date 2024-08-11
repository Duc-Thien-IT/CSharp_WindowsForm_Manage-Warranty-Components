using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using System.Security.Principal;

namespace QuanLySuaChuaBaoHanh
{
	public partial class frmManageStaff : Form
	{
		private StaffBLL _staffBLL;

		public frmManageStaff()
		{
			InitializeComponent();
			_staffBLL = new StaffBLL();
			dtgDSNV.CellClick += dtgDSNV_CellClick;
			label4.Enabled = false;
			txtID.Enabled = false;

			this.Load += frmManageStaff_Load;
		}

		private void frmManageStaff_Load(object sender, EventArgs e)
		{
			LoadStaffData();
		}

		private void LoadStaffData()
		{
			try
			{
				var staffList = _staffBLL.GetAllStaff();
				dtgDSNV.DataSource = staffList;

				//if (dtgDSNV.Columns["Role"] != null)
				//{
				//	dtgDSNV.Columns["Role"].Visible = false;
				//}
				//if (dtgDSNV.Columns["trangthai"] != null)
				//{
				//	dtgDSNV.Columns["trangthai"].Visible = false;
				//}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}");
			}
		}

		private void dtgDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dtgDSNV.Rows[e.RowIndex];

				txtID.Text = row.Cells["Id"].Value.ToString();
				txtAcc.Text = row.Cells["Account"].Value.ToString();
				txtPass.Text = row.Cells["PassWord"].Value.ToString();
				txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
				txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
				txtNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
				txtPhai.Text = row.Cells["Phai"].Value.ToString();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				string id = txtID.Text.Trim();
				string account = txtAcc.Text.Trim();
				string password = txtPass.Text.Trim();
				string diaChi = txtDiaChi.Text.Trim();
				string hoTen = txtHoTen.Text.Trim();
				string ngaySinh = txtNgaySinh.Text.Trim();
				string phai = txtPhai.Text.Trim();

				// Validate inputs
				if (string.IsNullOrWhiteSpace(id) ||
					string.IsNullOrWhiteSpace(account) ||
					string.IsNullOrWhiteSpace(password) ||
					string.IsNullOrWhiteSpace(diaChi) ||
					string.IsNullOrWhiteSpace(hoTen) ||
					string.IsNullOrWhiteSpace(ngaySinh) ||
					string.IsNullOrWhiteSpace(phai))
				{
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				var updatedUser = new UserDTO
				{
					Id = id,
					Account = account,
					PassWord = password,
					DiaChi = diaChi,
					HoTen = hoTen,
					NgaySinh = ngaySinh,
					Phai = phai,
				};

				bool updateSuccess = _staffBLL.UpdateStaff(updatedUser);

				if (updateSuccess)
				{
					MessageBox.Show("Cập nhật nhân viên thành công.");
					LoadStaffData();
				}
				else
				{
					MessageBox.Show("Cập nhật nhân viên thất bại.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				string staffId = txtID.Text;

				if (string.IsNullOrWhiteSpace(staffId))
				{
					MessageBox.Show("Vui lòng chọn nhân viên cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				var confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmation == DialogResult.No)
				{
					return;
				}

				bool deleteSuccess = _staffBLL.DeleteStaff(staffId);

				if (deleteSuccess)
				{
					MessageBox.Show("Xóa nhân viên thành công.");
					LoadStaffData();
				}
				else
				{
					MessageBox.Show("Xóa nhân viên thất bại.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}");
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			ResetTextBoxes();
			LoadStaffData();
		}

		private void ResetTextBoxes()
		{
			txtID.Text = string.Empty;
			txtAcc.Text = string.Empty;
			txtPass.Text = string.Empty;
			txtDiaChi.Text = string.Empty;
			txtHoTen.Text = string.Empty;
			txtNgaySinh.Text = string.Empty;
			txtPhai.Text = string.Empty;
			txtID_TimKiem.Text = string.Empty;
			txtID_TimKiem.Focus();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			try
			{
				string accountName = txtID_TimKiem.Text.Trim();

				if (string.IsNullOrWhiteSpace(accountName))
				{
					MessageBox.Show("Vui lòng nhập tài khoản để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				var searchResults = _staffBLL.SearchStaff(accountName);

				dtgDSNV.DataSource = searchResults;

				//if (dtgDSNV.Columns["Role"] != null)
				//{
				//	dtgDSNV.Columns["Role"].Visible = false;
				//}
				//if (dtgDSNV.Columns["trangthai"] != null)
				//{
				//	dtgDSNV.Columns["trangthai"].Visible = false;
				//}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi tìm kiếm thông tin nhân viên: {ex.Message}");
			}
		}


	}
}
