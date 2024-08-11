namespace QuanLySuaChuaBaoHanh
{
	partial class frmManageCustomer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Customer = new System.Windows.Forms.DataGridView();
            this.btn_TimSDT = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_UpdateCustomer = new System.Windows.Forms.Button();
            this.btn_DeleteCustomer = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdioNu = new System.Windows.Forms.RadioButton();
            this.rdioNam = new System.Windows.Forms.RadioButton();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_Customer);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 247);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(772, 388);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Khách Hàng";
            // 
            // dataGridView_Customer
            // 
            this.dataGridView_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Customer.Location = new System.Drawing.Point(18, 33);
            this.dataGridView_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Customer.Name = "dataGridView_Customer";
            this.dataGridView_Customer.RowHeadersWidth = 51;
            this.dataGridView_Customer.RowTemplate.Height = 24;
            this.dataGridView_Customer.Size = new System.Drawing.Size(740, 378);
            this.dataGridView_Customer.TabIndex = 0;
            this.dataGridView_Customer.SelectionChanged += new System.EventHandler(this.dataGridView_Customer_SelectionChanged);
            // 
            // btn_TimSDT
            // 
            this.btn_TimSDT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimSDT.Location = new System.Drawing.Point(668, 32);
            this.btn_TimSDT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimSDT.Name = "btn_TimSDT";
            this.btn_TimSDT.Size = new System.Drawing.Size(81, 32);
            this.btn_TimSDT.TabIndex = 8;
            this.btn_TimSDT.Text = "Tìm kiếm";
            this.btn_TimSDT.UseVisualStyleBackColor = true;
            this.btn_TimSDT.Click += new System.EventHandler(this.btn_TimSDT_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(304, 35);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(96, 32);
            this.btn_Reset.TabIndex = 14;
            this.btn_Reset.Text = "Làm Mới";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click_1);
            // 
            // btn_UpdateCustomer
            // 
            this.btn_UpdateCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateCustomer.Location = new System.Drawing.Point(104, 35);
            this.btn_UpdateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UpdateCustomer.Name = "btn_UpdateCustomer";
            this.btn_UpdateCustomer.Size = new System.Drawing.Size(81, 32);
            this.btn_UpdateCustomer.TabIndex = 13;
            this.btn_UpdateCustomer.Text = "Sửa";
            this.btn_UpdateCustomer.UseVisualStyleBackColor = true;
            this.btn_UpdateCustomer.Click += new System.EventHandler(this.btn_UpdateCustomer_Click);
            // 
            // btn_DeleteCustomer
            // 
            this.btn_DeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteCustomer.Location = new System.Drawing.Point(9, 35);
            this.btn_DeleteCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DeleteCustomer.Name = "btn_DeleteCustomer";
            this.btn_DeleteCustomer.Size = new System.Drawing.Size(81, 32);
            this.btn_DeleteCustomer.TabIndex = 12;
            this.btn_DeleteCustomer.Text = "Xóa";
            this.btn_DeleteCustomer.UseVisualStyleBackColor = true;
            this.btn_DeleteCustomer.Click += new System.EventHandler(this.btn_DeleteCustomer_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCustomer.Location = new System.Drawing.Point(204, 35);
            this.btn_AddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(81, 32);
            this.btn_AddCustomer.TabIndex = 11;
            this.btn_AddCustomer.Text = "Thêm";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txtSoDienThoai);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtTenKhachHang);
            this.groupBox2.Controls.Add(this.txtMaKhachHang);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(810, 145);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Khách Hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdioNu);
            this.groupBox4.Controls.Add(this.rdioNam);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(411, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 63);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giới tính";
            // 
            // rdioNu
            // 
            this.rdioNu.AutoSize = true;
            this.rdioNu.Location = new System.Drawing.Point(162, 28);
            this.rdioNu.Name = "rdioNu";
            this.rdioNu.Size = new System.Drawing.Size(55, 29);
            this.rdioNu.TabIndex = 0;
            this.rdioNu.TabStop = true;
            this.rdioNu.Text = "Nữ";
            this.rdioNu.UseVisualStyleBackColor = true;
            // 
            // rdioNam
            // 
            this.rdioNam.AutoSize = true;
            this.rdioNam.Location = new System.Drawing.Point(43, 28);
            this.rdioNam.Name = "rdioNam";
            this.rdioNam.Size = new System.Drawing.Size(70, 29);
            this.rdioNam.TabIndex = 0;
            this.rdioNam.TabStop = true;
            this.rdioNam.Text = "Nam";
            this.rdioNam.UseVisualStyleBackColor = true;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(94, 118);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(261, 23);
            this.txtSoDienThoai.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số ĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(468, 31);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(264, 23);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(94, 72);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(261, 23);
            this.txtTenKhachHang.TabIndex = 6;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(94, 29);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(261, 23);
            this.txtMaKhachHang.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 77);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên KH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã KH";
            // 
            // txtSearchPhoneNumber
            // 
            this.txtSearchPhoneNumber.Location = new System.Drawing.Point(487, 38);
            this.txtSearchPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchPhoneNumber.Name = "txtSearchPhoneNumber";
            this.txtSearchPhoneNumber.Size = new System.Drawing.Size(175, 23);
            this.txtSearchPhoneNumber.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số ĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 73);
            this.label1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddCustomer);
            this.groupBox1.Controls.Add(this.txtSearchPhoneNumber);
            this.groupBox1.Controls.Add(this.btn_TimSDT);
            this.groupBox1.Controls.Add(this.btn_DeleteCustomer);
            this.groupBox1.Controls.Add(this.btn_UpdateCustomer);
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(820, 74);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // frmManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(775, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManageCustomer";
            this.Text = "frmManageCustomer";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btn_TimSDT;
		private System.Windows.Forms.Button btn_Reset;
		private System.Windows.Forms.Button btn_UpdateCustomer;
		private System.Windows.Forms.Button btn_DeleteCustomer;
		private System.Windows.Forms.Button btn_AddCustomer;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtSearchPhoneNumber;
		private System.Windows.Forms.TextBox txtTenKhachHang;
		private System.Windows.Forms.TextBox txtMaKhachHang;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView_Customer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSoDienThoai;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdioNu;
        private System.Windows.Forms.RadioButton rdioNam;
    }
}