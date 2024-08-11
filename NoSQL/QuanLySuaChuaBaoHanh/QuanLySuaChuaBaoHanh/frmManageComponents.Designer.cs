namespace QuanLySuaChuaBaoHanh
{
	partial class frmManageComponents
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
			this.components = new System.ComponentModel.Container();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgvDSLK = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.txtTenLK_Find = new System.Windows.Forms.TextBox();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbbHang = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtGia = new System.Windows.Forms.TextBox();
			this.txtTenLK = new System.Windows.Forms.TextBox();
			this.txtMaLK = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSLK)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgvDSLK);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(3, 289);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1027, 493);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Danh Sách Linh Kiện";
			// 
			// dgvDSLK
			// 
			this.dgvDSLK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSLK.Location = new System.Drawing.Point(9, 38);
			this.dgvDSLK.Name = "dgvDSLK";
			this.dgvDSLK.RowHeadersWidth = 51;
			this.dgvDSLK.RowTemplate.Height = 24;
			this.dgvDSLK.Size = new System.Drawing.Size(1009, 596);
			this.dgvDSLK.TabIndex = 0;
			this.dgvDSLK.SelectionChanged += new System.EventHandler(this.dgvDSLK_SelectionChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Controls.Add(this.txtTenLK_Find);
			this.groupBox1.Controls.Add(this.btnLamMoi);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnSua);
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Controls.Add(this.btnXoa);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 181);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1026, 82);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chức Năng";
			// 
			// button5
			// 
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(912, 34);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(108, 39);
			this.button5.TabIndex = 8;
			this.button5.Text = "Tìm kiếm";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// txtTenLK_Find
			// 
			this.txtTenLK_Find.Location = new System.Drawing.Point(630, 41);
			this.txtTenLK_Find.Name = "txtTenLK_Find";
			this.txtTenLK_Find.Size = new System.Drawing.Size(275, 27);
			this.txtTenLK_Find.TabIndex = 10;
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLamMoi.Location = new System.Drawing.Point(349, 34);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(108, 39);
			this.btnLamMoi.TabIndex = 14;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(552, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Tên LK";
			// 
			// btnSua
			// 
			this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(121, 34);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(108, 39);
			this.btnSua.TabIndex = 13;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(235, 34);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(108, 39);
			this.btnThem.TabIndex = 11;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(7, 34);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(108, 39);
			this.btnXoa.TabIndex = 12;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbbHang);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtGia);
			this.groupBox2.Controls.Add(this.txtTenLK);
			this.groupBox2.Controls.Add(this.txtMaLK);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(3, 18);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1027, 157);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông Tin Linh Kiện";
			// 
			// cbbHang
			// 
			this.cbbHang.FormattingEnabled = true;
			this.cbbHang.Location = new System.Drawing.Point(629, 36);
			this.cbbHang.Name = "cbbHang";
			this.cbbHang.Size = new System.Drawing.Size(287, 28);
			this.cbbHang.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(561, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Hãng";
			// 
			// txtGia
			// 
			this.txtGia.Location = new System.Drawing.Point(629, 96);
			this.txtGia.Name = "txtGia";
			this.txtGia.Size = new System.Drawing.Size(287, 27);
			this.txtGia.TabIndex = 8;
			// 
			// txtTenLK
			// 
			this.txtTenLK.Location = new System.Drawing.Point(104, 97);
			this.txtTenLK.Name = "txtTenLK";
			this.txtTenLK.Size = new System.Drawing.Size(286, 27);
			this.txtTenLK.TabIndex = 6;
			// 
			// txtMaLK
			// 
			this.txtMaLK.Location = new System.Drawing.Point(104, 44);
			this.txtMaLK.Name = "txtMaLK";
			this.txtMaLK.Size = new System.Drawing.Size(286, 27);
			this.txtMaLK.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(575, 104);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 20);
			this.label9.TabIndex = 2;
			this.label9.Text = "Giá";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(24, 103);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 20);
			this.label10.TabIndex = 1;
			this.label10.Text = "Tên LK";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(29, 47);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(58, 20);
			this.label11.TabIndex = 0;
			this.label11.Text = "Mã LK";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(734, 519);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 91);
			this.label1.TabIndex = 9;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// frmManageComponents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1033, 794);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmManageComponents";
			this.Text = "frmManageComponents";
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSLK)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox txtTenLK_Find;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtGia;
		private System.Windows.Forms.TextBox txtTenLK;
		private System.Windows.Forms.TextBox txtMaLK;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbbHang;
		private System.Windows.Forms.DataGridView dgvDSLK;
		private System.Windows.Forms.ImageList imageList1;
	}
}