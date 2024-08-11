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
    public partial class frmManageComponents : Form
    {
        private string selectedComponentId;

        public frmManageComponents()
        {
            InitializeComponent();
            LoadView();
            LoadComponentsToDataGridView();
            LoadHangToComboBox();
        }

        private void LoadView()
        {
            //txtMaLK.Visible = false;
        }

        private void ConfigureDataGridView()
        {
            dgvDSLK.Columns["Id"].Visible = false;
        }

        private void LoadComponentsToDataGridView()
        {
            try
            {
                ConponentBLL componentBLL = new ConponentBLL();
                List<ConponentDTO> components = componentBLL.GetAllProducts();
                dgvDSLK.DataSource = components;
                ConfigureDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu linh kiện: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHangToComboBox()
        {
            List<string> hangList = new List<string> { "Intel", "Samsung", "Asus" };
            cbbHang.DataSource = hangList;
        }

        private void ClearInputFields()
        {
            txtMaLK.Clear();
            txtTenLK.Clear();
            cbbHang.SelectedIndex = -1; 
            txtGia.Clear();
            txtTenLK_Find.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenLK = txtTenLK.Text.Trim();
            string hang = cbbHang.SelectedItem?.ToString().Trim(); 
            string gia = txtGia.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenLK) || string.IsNullOrWhiteSpace(hang) || string.IsNullOrWhiteSpace(gia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConponentDTO newComponent = new ConponentDTO
            {
                TenLK = tenLK,
                Hang = hang,
                Gia = gia
            };

            ConponentBLL componentBLL = new ConponentBLL();
            componentBLL.AddProduct(newComponent);
            MessageBox.Show("Thêm linh kiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputFields();
            LoadComponentsToDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedComponentId))
            {
                MessageBox.Show("Vui lòng chọn linh kiện cần cập nhật từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenLK = txtTenLK.Text.Trim();
            string hang = cbbHang.SelectedItem?.ToString().Trim(); // Get selected item
            string gia = txtGia.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenLK) || string.IsNullOrWhiteSpace(hang) || string.IsNullOrWhiteSpace(gia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConponentDTO updatedComponent = new ConponentDTO
            {
                Id = selectedComponentId,
                TenLK = tenLK,
                Hang = hang,
                Gia = gia
            };

            ConponentBLL componentBLL = new ConponentBLL();
            componentBLL.UpdateProduct(updatedComponent);
            MessageBox.Show("Cập nhật linh kiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadComponentsToDataGridView();
            ClearInputFields();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSLK.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một linh kiện để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvDSLK.SelectedRows[0];
            string componentId = selectedRow.Cells["Id"].Value.ToString();

            var confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa linh kiện này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.No)
            {
                return;
            }

            try
            {
                ConponentBLL componentBLL = new ConponentBLL();
                bool success = componentBLL.DeleteProduct(componentId);

                if (success)
                {
                    MessageBox.Show("Xóa linh kiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadComponentsToDataGridView();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy linh kiện với ID đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa linh kiện: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tenLK = txtTenLK_Find.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenLK))
            {
                MessageBox.Show("Vui lòng nhập tên linh kiện để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ConponentBLL componentBLL = new ConponentBLL();
                List<ConponentDTO> components = componentBLL.GetProductsByName(tenLK);

                if (components.Count > 0)
                {
                    dgvDSLK.DataSource = new BindingList<ConponentDTO>(components);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy linh kiện với tên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDSLK.DataSource = new BindingList<ConponentDTO>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm linh kiện: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadComponentsToDataGridView();
        }

        private void dgvDSLK_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSLK.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDSLK.SelectedRows[0];

                // Check if cells exist and have values before accessing them
                string id = selectedRow.Cells["Id"].Value?.ToString();
                string maLK = selectedRow.Cells["MaLK"].Value?.ToString();
                string tenLK = selectedRow.Cells["TenLK"].Value?.ToString();
                string hang = selectedRow.Cells["Hang"].Value?.ToString();
                string gia = selectedRow.Cells["Gia"].Value?.ToString();

                if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(maLK) && !string.IsNullOrEmpty(tenLK) && !string.IsNullOrEmpty(hang) && !string.IsNullOrEmpty(gia))
                {
                    txtMaLK.Text = maLK;
                    txtTenLK.Text = tenLK;
                    cbbHang.Text = hang;
                    txtGia.Text = gia;

                    selectedComponentId = id;
                }
                else
                {
                    ClearInputFields();
                }
            }
        }
    }
}
