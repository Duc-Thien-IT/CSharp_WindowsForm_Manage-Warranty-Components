using BLL;
using DTO;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using static DTO.ChiTietPBHDTO;

namespace QuanLySuaChuaBaoHanh
{
	public partial class frmManageWarranty : Form
	{
		public UserDTO _userDTO = new UserDTO();
		public CustomerDTO _KHDTO = new CustomerDTO();
		private WarrantyBLL _warrantyBLL;
		private UserBLL _userBLL;
        private CustomerBLL _customerBLL;
        private ConponentBLL _conponentBLL;
        public frmManageWarranty(UserDTO userDTO)
		{
            InitializeComponent();
            _warrantyBLL = new WarrantyBLL();
            _customerBLL = new CustomerBLL();
            _conponentBLL = new ConponentBLL();
            LoadComponents();
            LoadWarrantyPeriods();
            LoadPhoneNumbers();
            LoadRepairOrWarrantyStatus();
            cb_SDT.KeyDown += cb_SDT_KeyDown;

            this.Load += new System.EventHandler(this.frmManageWarranty_Load);
            _userDTO = userDTO;
        }
        private void LoadWarrantyPeriods()
        {
            var warrantyPeriods = new List<string> { "6 Tháng", "12 Tháng", "24 Tháng" };
            comboBox4.DataSource = warrantyPeriods;
        }
        private void LoadRepairOrWarrantyStatus()
        {
            var statuses = new List<string> { "Sửa Chữa", "Bảo Hành" };
            comboBox3.DataSource = statuses;
        }
        private void LoadComponents()
        {
            var components = _conponentBLL.GetAllProducts();
            comboBox2.DataSource = components;
            comboBox2.DisplayMember = "TenLK"; 
            comboBox2.ValueMember = "MaLK"; 
        }
        private void LoadPhoneNumbers()
		{
            var phoneNumbers = _customerBLL.GetAllPhoneNumbers(); 
            cb_SDT.DataSource = phoneNumbers;
        }

		private void cb_SDT_SelectedIndexChanged(object sender, EventArgs e)
		{
            string selectedPhoneNumber = cb_SDT.SelectedItem.ToString();
            var customer = _warrantyBLL.GetCustomerByPhoneNumber(selectedPhoneNumber).FirstOrDefault();
            DisplayCustomerInfo(customer);
            if (customer != null)
            {
                var warrantyCodes = _warrantyBLL.GetWarrantyCodesByPhoneNumber(selectedPhoneNumber);
                comboBox1.DataSource = warrantyCodes;
            }
            else
            {
                comboBox1.DataSource = null; 
            }
        }

		private void DisplayCustomerInfo(CustomerDTO customer)
		{
            if (customer != null)
            {
                _KHDTO = customer;
                txtTenKH.Text = customer.TenKhachHang;
                dateTimePicker1.Value = DateTime.Now; 
            }
            else
            {
                txtTenKH.Text = "";
                dateTimePicker1.Value = DateTime.Now; 
            }
        }

		private string GenerateWarrantyCode()
		{
            const string prefix = "BH";
            string objectId = ObjectId.GenerateNewId().ToString();
            string lastThreeIdChars = objectId.Substring(objectId.Length - 3);

            return prefix + lastThreeIdChars;
        }

		private void cb_SDT_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				string enteredPhoneNumber = cb_SDT.Text;

				if (!string.IsNullOrEmpty(enteredPhoneNumber))
				{
					var customers = _warrantyBLL.GetCustomerByPhoneNumber(enteredPhoneNumber);
					var customer = customers.FirstOrDefault();
					DisplayCustomerInfo(customer);
				}
				else
				{
					MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}

				e.SuppressKeyPress = true;
			}
		}

		private void Create_PBH_Click(object sender, EventArgs e)
		{
            string userId = _userDTO?.Id;
            string customerId = _KHDTO?.Id; // Giả định _KHDTO chứa thông tin khách hàng

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(customerId))
            {
                MessageBox.Show("User or Customer information is missing.");
                return;
            }

            try
            {
                // Tạo mã bảo hành mới
                string warrantyCode = GenerateWarrantyCode();

                // Tạo phiếu bảo hành mới
                var warranty = new WarrantyDTO
                {
                    MaPBH = warrantyCode,
                    NgayLapPhieu = dateTimePicker1.Value, // Lấy ngày từ dateTimePicker1
                    TongTien = 0 // Bạn có thể cập nhật điều này dựa trên logic của bạn
                };

                // Hiển thị mã bảo hành trên form
                txtMaPBH.Text = warrantyCode;

                // Thêm bảo hành vào cơ sở dữ liệu
                _warrantyBLL.AddWarranty(warranty, customerId);

                // Kiểm tra và chỉ thêm nếu phiếu bảo hành chưa tồn tại
                var existingWarranty = _warrantyBLL.GetWarrantyByCode(warrantyCode, customerId); // Bạn cần tạo phương thức này
                if (existingWarranty == null)
                {
                    // Cập nhật User và Customer
                    _warrantyBLL.AddCustomerToUser(userId, customerId);
                    _warrantyBLL.AddWarrantyToCustomer(customerId, warranty); // Gọi phương thức đã cập nhật
                }
                else
                {
                    MessageBox.Show("Phiếu bảo hành này đã tồn tại.");
                }

                // Thông báo thành công
                MessageBox.Show("Phiếu bảo hành đã được tạo thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        
        private void frmManageWarranty_Load(object sender, EventArgs e)
		{
            LoadPhoneNumbers();
            if (_userDTO != null)
            {
                txtNameStaff.Text = _userDTO.HoTen;
            }
            else
            {
                txtNameStaff.Text = "Thông tin không có sẵn";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem is ConponentDTO selectedComponent)
            {
                textBox4.Text = selectedComponent.Gia; // Hiển thị giá sản phẩm
            }
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    string customerId = _KHDTO.Id; // ID khách hàng đã có
        //    string maPBH = comboBox1.SelectedItem.ToString(); // Lấy mã bảo hành từ comboBox1

        //    // Tạo mã chi tiết bảo hành ngẫu nhiên
        //    string maCTPBH = "CT" + Guid.NewGuid().ToString().Substring(0, 3); // Tạo mã ngẫu nhiên

        //    // Tạo đối tượng chi tiết bảo hành
        //    var chiTiet = new ChiTietPBH
        //    {
        //        MaCTPBH = maCTPBH,
        //        MaLK = comboBox2.SelectedItem.ToString(), // Mã linh kiện từ comboBox2
        //        ThoiGianBH = comboBox4.SelectedItem.ToString(), // Thời gian bảo hành từ comboBox4
        //        GiaTien = textBox4.Text, // Giá tiền từ textBox4
        //        TrangThai = comboBox3.SelectedItem.ToString()
                
        //    };
        //    // Gọi phương thức trong WarrantyBLL để thêm chi tiết bảo hành
        //    _warrantyBLL.AddChiTietPBH(customerId, maPBH, chiTiet);

        //    MessageBox.Show("Chi tiết bảo hành đã được thêm thành công.");
        //}
        }
    }
