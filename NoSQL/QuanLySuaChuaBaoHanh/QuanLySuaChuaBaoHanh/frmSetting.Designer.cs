namespace QuanLySuaChuaBaoHanh
{
	partial class frmSetting
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
			this.btnBackup = new System.Windows.Forms.Button();
			this.btnRestore = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBackup
			// 
			this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBackup.Location = new System.Drawing.Point(22, 44);
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.Size = new System.Drawing.Size(206, 44);
			this.btnBackup.TabIndex = 0;
			this.btnBackup.Text = "Sao Lưu Dữ Liệu";
			this.btnBackup.UseVisualStyleBackColor = true;
			this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
			// 
			// btnRestore
			// 
			this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestore.Location = new System.Drawing.Point(22, 124);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(206, 44);
			this.btnRestore.TabIndex = 1;
			this.btnRestore.Text = "Phục Hồi Dữ Liệu";
			this.btnRestore.UseVisualStyleBackColor = true;
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Red;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(775, 622);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(206, 44);
			this.button3.TabIndex = 2;
			this.button3.Text = "Đăng Xuất";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// frmSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1033, 794);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnRestore);
			this.Controls.Add(this.btnBackup);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmSetting";
			this.Text = "frmSetting";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnBackup;
		private System.Windows.Forms.Button btnRestore;
		private System.Windows.Forms.Button button3;
	}
}