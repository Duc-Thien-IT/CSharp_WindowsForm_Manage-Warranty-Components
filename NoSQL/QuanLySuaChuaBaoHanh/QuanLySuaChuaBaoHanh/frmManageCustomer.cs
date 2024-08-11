using DTO;
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

namespace QuanLySuaChuaBaoHanh
{
	public partial class frmManageCustomer : Form
	{
		
		public frmManageCustomer()
		{
            
            InitializeComponent();
            LoadView();
            //ConfigureDataGridView();
            LoadCustomersToDataGridView(); 
        }
        private void LoadView()
        {
            txtMaKhachHang.Visible = false;
        }
        private void ConfigureDataGridView()
        {
            dataGridView_Customer.Columns["Id"].Visible = false;
            //DataGridView grid = new DataGridView();


            //dataGridView_Customer.Columns.Clear();

            //dataGridView_Customer.Columns.Add("MaKH", "Mã Khách Hàng");
            //dataGridView_Customer.Columns.Add("TenKH", "Tên Khách Hàng");
            //dataGridView_Customer.Columns.Add("DiaChi", "Địa Chỉ");
            //dataGridView_Customer.Columns.Add("Phai", "Giới Tính");
            //dataGridView_Customer.Columns.Add("SDT", "Số Điện Thoại");

            //dataGridView_Customer.Columns["MaKH"].Width = 120;
            //dataGridView_Customer.Columns["TenKH"].Width = 150;
            //dataGridView_Customer.Columns["DiaChi"].Width = 200;
            //dataGridView_Customer.Columns["Phai"].Width = 80;
            //dataGridView_Customer.Columns["SDT"].Width = 120;
            //grid = dataGridView_Customer;
            //return grid;
        }
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép nhập số và phím xóa (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ
            }
        }
        private void ClearInputFields()
        {
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtSearchPhoneNumber.Clear();
            rdioNam.Checked = false;
            rdioNu.Checked = false;
        }
        private void LoadCustomersToDataGridView()
        {
            try
            {


                CustomerBLL customerBLL = new CustomerBLL();
                List<CustomerDTO> customers = customerBLL.GetAllCustomers();
                dataGridView_Customer.DataSource = customers;
                ConfigureDataGridView();

                //dataGridView_Customer.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    
    private string selectedCustomerId;
        //private void btn_AddCustomer_Click(object sender, EventArgs e)
        //{
        //    string maKhachHang = txtMaKhachHang.Text.Trim();
        //    string tenKhachHang = txtTenKhachHang.Text.Trim();
        //    string diaChi = txtDiaChi.Text.Trim();
        //    string gioiTinh = rdioNam.Checked ? "Nam" : "Nữ"; 
        //    string soDienThoai = txtSoDienThoai.Text.Trim();


        //    if (string.IsNullOrWhiteSpace(maKhachHang) || string.IsNullOrWhiteSpace(tenKhachHang) ||
        //        string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(soDienThoai))
        //    {
        //        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }  
        //    CustomerDTO newCustomer = new CustomerDTO
        //    {
        //        MaKhachHang = maKhachHang,
        //        TenKhachHang = tenKhachHang,
        //        DiaChi = diaChi,
        //        GioiTinh = gioiTinh,
        //        SDT = soDienThoai,
        //        PBH = new List<string>()
        //    };       
        //    CustomerBLL customerBLL = new CustomerBLL();
        //    customerBLL.AddCustomer(newCustomer);     
        //    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    ClearInputFields();
        //    LoadCustomersToDataGridView();
        //}
        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
                
                    string tenKhachHang = txtTenKhachHang.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim();
                    string gioiTinh = rdioNam.Checked ? "Nam" : "Nữ";
                    string soDienThoai = txtSoDienThoai.Text.Trim();

                   
                    if (string.IsNullOrWhiteSpace(tenKhachHang) ||
                        string.IsNullOrWhiteSpace(diaChi) ||
                        string.IsNullOrWhiteSpace(soDienThoai))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (soDienThoai.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại phải có đúng 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!soDienThoai.All(char.IsDigit))
                    {
                        MessageBox.Show("Số điện thoại chỉ được chứa các ký tự số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    CustomerDTO newCustomer = new CustomerDTO
                    {
                        TenKhachHang = tenKhachHang,
                        DiaChi = diaChi,
                        GioiTinh = gioiTinh,
                        SDT = soDienThoai,
                        PBH = new List<WarrantyDTO>() // Đổi kiểu danh sách sang List<WarrantyDTO>
                    };


            CustomerBLL customerBLL = new CustomerBLL();
                customerBLL.AddCustomer(newCustomer);        
                newCustomer = customerBLL.GetCustomerById(newCustomer.Id);
                newCustomer.GenerateMaKhachHang();
                customerBLL.UpdateCustomer(newCustomer);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputFields();
                LoadCustomersToDataGridView();
        }



        private void btn_UpdateCustomer_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrWhiteSpace(selectedCustomerId))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKhachHang = txtMaKhachHang.Text.Trim();
            string tenKhachHang = txtTenKhachHang.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string gioiTinh = rdioNam.Checked ? "Nam" : "Nữ";
            string soDienThoai = txtSoDienThoai.Text.Trim();

            if (string.IsNullOrWhiteSpace(maKhachHang) || string.IsNullOrWhiteSpace(tenKhachHang) ||
                string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (soDienThoai.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!soDienThoai.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa các ký tự số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
      
            CustomerDTO updatedCustomer = new CustomerDTO
            {
                Id = selectedCustomerId,
                MaKhachHang = maKhachHang,
                TenKhachHang = tenKhachHang,
                DiaChi = diaChi,
                GioiTinh = gioiTinh,
                SDT = soDienThoai
            };
       
            CustomerBLL customerBLL = new CustomerBLL();
            customerBLL.UpdateCustomer(updatedCustomer);
          
            MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            LoadCustomersToDataGridView();
            ClearInputFields();
        }





        private void btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridView_Customer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

    
            var selectedRow = dataGridView_Customer.SelectedRows[0];
            string customerId = selectedRow.Cells["Id"].Value.ToString(); 

      
            var confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.No)
            {
                return;
            }

            try
            {
              
                CustomerBLL customerBLL = new CustomerBLL();
                bool success = customerBLL.DeleteCustomer(customerId);

                if (success)
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomersToDataGridView(); 
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng với ID đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
             
                MessageBox.Show($"Đã xảy ra lỗi khi xóa khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TimSDT_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtSearchPhoneNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CustomerBLL customerBLL = new CustomerBLL();
                CustomerDTO customer = customerBLL.GetCustomerByPhoneNumber(phoneNumber);

                if (customer != null)
                {
                    var customers = new List<CustomerDTO> { customer };
                    dataGridView_Customer.DataSource = new BindingList<CustomerDTO>(customers);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng với số điện thoại này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_Customer.DataSource = new BindingList<CustomerDTO>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView_Customer_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Customer.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_Customer.SelectedRows[0];

             
                string id = selectedRow.Cells["Id"].Value.ToString(); 
                string maKhachHang = selectedRow.Cells["MaKhachHang"].Value.ToString();
                string tenKhachHang = selectedRow.Cells["TenKhachHang"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChi"].Value.ToString();
                string gioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                string soDienThoai = selectedRow.Cells["SDT"].Value.ToString();

              
                txtMaKhachHang.Text = maKhachHang;
                txtTenKhachHang.Text = tenKhachHang;
                txtDiaChi.Text = diaChi;
                txtSoDienThoai.Text = soDienThoai;
                rdioNam.Checked = gioiTinh == "Nam";
                rdioNu.Checked = gioiTinh == "Nữ";

               
                selectedCustomerId = id;
            }
        }



       

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            
            ClearInputFields();
            
            LoadCustomersToDataGridView();

        }
    }
}

      


