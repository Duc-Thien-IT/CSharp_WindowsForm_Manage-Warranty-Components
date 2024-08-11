namespace QuanLySuaChuaBaoHanh
{
	partial class frmManageStaff
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtID_TimKiem = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dtgDSNV = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtNgaySinh = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtAcc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtPhai = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgDSNV)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtID_TimKiem);
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.btnXoa);
			this.groupBox1.Controls.Add(this.btnSua);
			this.groupBox1.Controls.Add(this.btnLamMoi);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 223);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1093, 91);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chức Năng";
			// 
			// txtID_TimKiem
			// 
			this.txtID_TimKiem.Location = new System.Drawing.Point(649, 47);
			this.txtID_TimKiem.Name = "txtID_TimKiem";
			this.txtID_TimKiem.Size = new System.Drawing.Size(232, 27);
			this.txtID_TimKiem.TabIndex = 8;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimKiem.Location = new System.Drawing.Point(891, 40);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(108, 39);
			this.btnTimKiem.TabIndex = 8;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(12, 43);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(108, 39);
			this.btnXoa.TabIndex = 12;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(198, 40);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(108, 39);
			this.btnSua.TabIndex = 13;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLamMoi.Location = new System.Drawing.Point(405, 43);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(108, 39);
			this.btnLamMoi.TabIndex = 14;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(566, 50);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 20);
			this.label9.TabIndex = 2;
			this.label9.Text = "Account";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dtgDSNV);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(0, 337);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1029, 450);
			this.groupBox3.TabIndex = 20;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Danh Sách Nhân Viên";
			// 
			// dtgDSNV
			// 
			this.dtgDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgDSNV.Location = new System.Drawing.Point(24, 41);
			this.dtgDSNV.Name = "dtgDSNV";
			this.dtgDSNV.RowHeadersWidth = 51;
			this.dtgDSNV.RowTemplate.Height = 24;
			this.dtgDSNV.Size = new System.Drawing.Size(975, 465);
			this.dtgDSNV.TabIndex = 0;
			this.dtgDSNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDSNV_CellClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtNgaySinh);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtPass);
			this.groupBox2.Controls.Add(this.txtAcc);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtDiaChi);
			this.groupBox2.Controls.Add(this.txtPhai);
			this.groupBox2.Controls.Add(this.txtHoTen);
			this.groupBox2.Controls.Add(this.txtID);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(3, 7);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1080, 198);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông Tin Nhân Viên";
			// 
			// txtNgaySinh
			// 
			this.txtNgaySinh.Location = new System.Drawing.Point(624, 120);
			this.txtNgaySinh.Name = "txtNgaySinh";
			this.txtNgaySinh.Size = new System.Drawing.Size(347, 27);
			this.txtNgaySinh.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(523, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Ngày Sinh";
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(125, 163);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(347, 27);
			this.txtPass.TabIndex = 14;
			// 
			// txtAcc
			// 
			this.txtAcc.Location = new System.Drawing.Point(125, 120);
			this.txtAcc.Name = "txtAcc";
			this.txtAcc.Size = new System.Drawing.Size(347, 27);
			this.txtAcc.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(79, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(566, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Phái";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(624, 33);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(347, 27);
			this.txtDiaChi.TabIndex = 9;
			// 
			// txtPhai
			// 
			this.txtPhai.Location = new System.Drawing.Point(624, 75);
			this.txtPhai.Name = "txtPhai";
			this.txtPhai.Size = new System.Drawing.Size(347, 27);
			this.txtPhai.TabIndex = 7;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(125, 75);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(347, 27);
			this.txtHoTen.TabIndex = 6;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(125, 33);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(347, 27);
			this.txtID.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(544, 36);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 20);
			this.label7.TabIndex = 4;
			this.label7.Text = "Địa Chỉ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(35, 127);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(70, 20);
			this.label10.TabIndex = 1;
			this.label10.Text = "Account";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(41, 78);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(64, 20);
			this.label11.TabIndex = 0;
			this.label11.Text = "Họ Tên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(704, 520);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 91);
			this.label1.TabIndex = 18;
			// 
			// frmManageStaff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1033, 794);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmManageStaff";
			this.Text = "frmManageStaff";
			this.Load += new System.EventHandler(this.frmManageStaff_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgDSNV)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtID_TimKiem;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dtgDSNV;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtPhai;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtAcc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNgaySinh;
		private System.Windows.Forms.Label label5;
	}
}