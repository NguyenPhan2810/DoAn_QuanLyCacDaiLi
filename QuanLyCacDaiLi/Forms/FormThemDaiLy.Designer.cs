
namespace QuanLyCacDaiLi
{
    partial class FormThemDaiLy
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxLoai = new System.Windows.Forms.TextBox();
            this.textBoxQuan = new System.Windows.Forms.TextBox();
            this.textBoxTenDaiLyData = new System.Windows.Forms.TextBox();
            this.comboBoxLoaiDaiLyData = new System.Windows.Forms.ComboBox();
            this.comboBoxQuanData = new System.Windows.Forms.ComboBox();
            this.buttonThemDaiLy = new System.Windows.Forms.Button();
            this.textBoxSoDienThoaiData = new System.Windows.Forms.TextBox();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.textBoxEmailData = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDiaChiData = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayTiepNhanData = new System.Windows.Forms.DateTimePicker();
            this.textBoxNgayTiepNhan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(-1, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Tên đại lý";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxLoai
            // 
            this.textBoxLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoai.Enabled = false;
            this.textBoxLoai.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxLoai.Location = new System.Drawing.Point(-1, 194);
            this.textBoxLoai.Name = "textBoxLoai";
            this.textBoxLoai.ReadOnly = true;
            this.textBoxLoai.Size = new System.Drawing.Size(190, 32);
            this.textBoxLoai.TabIndex = 1;
            this.textBoxLoai.TabStop = false;
            this.textBoxLoai.Text = "Loại đại lý";
            this.textBoxLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxQuan
            // 
            this.textBoxQuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuan.Enabled = false;
            this.textBoxQuan.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxQuan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxQuan.Location = new System.Drawing.Point(-1, 103);
            this.textBoxQuan.Name = "textBoxQuan";
            this.textBoxQuan.ReadOnly = true;
            this.textBoxQuan.Size = new System.Drawing.Size(190, 32);
            this.textBoxQuan.TabIndex = 2;
            this.textBoxQuan.TabStop = false;
            this.textBoxQuan.Text = "Quận";
            this.textBoxQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTenDaiLyData
            // 
            this.textBoxTenDaiLyData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTenDaiLyData.Location = new System.Drawing.Point(195, 6);
            this.textBoxTenDaiLyData.Name = "textBoxTenDaiLyData";
            this.textBoxTenDaiLyData.Size = new System.Drawing.Size(405, 39);
            this.textBoxTenDaiLyData.TabIndex = 0;
            this.textBoxTenDaiLyData.Leave += new System.EventHandler(this.textBoxTenDaiLyData_Leave);
            // 
            // comboBoxLoaiDaiLyData
            // 
            this.comboBoxLoaiDaiLyData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoaiDaiLyData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxLoaiDaiLyData.FormattingEnabled = true;
            this.comboBoxLoaiDaiLyData.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxLoaiDaiLyData.Location = new System.Drawing.Point(195, 191);
            this.comboBoxLoaiDaiLyData.Name = "comboBoxLoaiDaiLyData";
            this.comboBoxLoaiDaiLyData.Size = new System.Drawing.Size(405, 40);
            this.comboBoxLoaiDaiLyData.TabIndex = 4;
            // 
            // comboBoxQuanData
            // 
            this.comboBoxQuanData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuanData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxQuanData.FormattingEnabled = true;
            this.comboBoxQuanData.Items.AddRange(new object[] {
            "Quận 1",
            "Quận 2",
            "Quận 3",
            "Quận 4",
            "Quận 5",
            "Quận 6",
            "Quận 7",
            "Quận 8",
            "Quận 9",
            "Quận 10",
            "Quận 11",
            "Quận 12",
            "Quận Bình Thạnh",
            "Quận Thủ Đức",
            "Quận Gò Vấp",
            "Quận Phú Nhuận",
            "Quận Tân Bình",
            "Quận Tân Phú",
            "Quận Bình Tân",
            "Huyện Nhà Bè",
            "Huyện Hóc Môn",
            "Huyện Bình Chán",
            "Huyện Củ Chi",
            "Huyện Cần Giờ"});
            this.comboBoxQuanData.Location = new System.Drawing.Point(195, 100);
            this.comboBoxQuanData.Name = "comboBoxQuanData";
            this.comboBoxQuanData.Size = new System.Drawing.Size(405, 40);
            this.comboBoxQuanData.TabIndex = 2;
            // 
            // buttonThemDaiLy
            // 
            this.buttonThemDaiLy.Location = new System.Drawing.Point(239, 335);
            this.buttonThemDaiLy.Name = "buttonThemDaiLy";
            this.buttonThemDaiLy.Size = new System.Drawing.Size(127, 46);
            this.buttonThemDaiLy.TabIndex = 7;
            this.buttonThemDaiLy.Text = "Thêm";
            this.buttonThemDaiLy.UseVisualStyleBackColor = true;
            this.buttonThemDaiLy.Click += new System.EventHandler(this.buttonThemDaiLy_Click);
            // 
            // textBoxSoDienThoaiData
            // 
            this.textBoxSoDienThoaiData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSoDienThoaiData.Location = new System.Drawing.Point(195, 51);
            this.textBoxSoDienThoaiData.Name = "textBoxSoDienThoaiData";
            this.textBoxSoDienThoaiData.Size = new System.Drawing.Size(405, 39);
            this.textBoxSoDienThoaiData.TabIndex = 1;
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSoDienThoai.Enabled = false;
            this.textBoxSoDienThoai.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSoDienThoai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(-1, 58);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.ReadOnly = true;
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(190, 32);
            this.textBoxSoDienThoai.TabIndex = 7;
            this.textBoxSoDienThoai.TabStop = false;
            this.textBoxSoDienThoai.Text = "Số điện thoại";
            this.textBoxSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEmailData
            // 
            this.textBoxEmailData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmailData.Location = new System.Drawing.Point(195, 146);
            this.textBoxEmailData.Name = "textBoxEmailData";
            this.textBoxEmailData.Size = new System.Drawing.Size(405, 39);
            this.textBoxEmailData.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxEmail.Location = new System.Drawing.Point(12, 149);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(177, 32);
            this.textBoxEmail.TabIndex = 9;
            this.textBoxEmail.TabStop = false;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDiaChiData
            // 
            this.textBoxDiaChiData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDiaChiData.Location = new System.Drawing.Point(195, 237);
            this.textBoxDiaChiData.Name = "textBoxDiaChiData";
            this.textBoxDiaChiData.Size = new System.Drawing.Size(405, 39);
            this.textBoxDiaChiData.TabIndex = 5;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiaChi.Enabled = false;
            this.textBoxDiaChi.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDiaChi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxDiaChi.Location = new System.Drawing.Point(12, 240);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.ReadOnly = true;
            this.textBoxDiaChi.Size = new System.Drawing.Size(177, 32);
            this.textBoxDiaChi.TabIndex = 11;
            this.textBoxDiaChi.TabStop = false;
            this.textBoxDiaChi.Text = "Địa chỉ";
            this.textBoxDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePickerNgayTiepNhanData
            // 
            this.dateTimePickerNgayTiepNhanData.CalendarFont = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerNgayTiepNhanData.Location = new System.Drawing.Point(195, 283);
            this.dateTimePickerNgayTiepNhanData.Name = "dateTimePickerNgayTiepNhanData";
            this.dateTimePickerNgayTiepNhanData.Size = new System.Drawing.Size(405, 27);
            this.dateTimePickerNgayTiepNhanData.TabIndex = 6;
            // 
            // textBoxNgayTiepNhan
            // 
            this.textBoxNgayTiepNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNgayTiepNhan.Enabled = false;
            this.textBoxNgayTiepNhan.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNgayTiepNhan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxNgayTiepNhan.Location = new System.Drawing.Point(12, 279);
            this.textBoxNgayTiepNhan.Name = "textBoxNgayTiepNhan";
            this.textBoxNgayTiepNhan.ReadOnly = true;
            this.textBoxNgayTiepNhan.Size = new System.Drawing.Size(177, 32);
            this.textBoxNgayTiepNhan.TabIndex = 14;
            this.textBoxNgayTiepNhan.TabStop = false;
            this.textBoxNgayTiepNhan.Text = "Ngày tiếp nhận";
            this.textBoxNgayTiepNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormThemDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 393);
            this.Controls.Add(this.textBoxNgayTiepNhan);
            this.Controls.Add(this.dateTimePickerNgayTiepNhanData);
            this.Controls.Add(this.textBoxDiaChiData);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.textBoxEmailData);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSoDienThoaiData);
            this.Controls.Add(this.textBoxSoDienThoai);
            this.Controls.Add(this.buttonThemDaiLy);
            this.Controls.Add(this.comboBoxQuanData);
            this.Controls.Add(this.comboBoxLoaiDaiLyData);
            this.Controls.Add(this.textBoxTenDaiLyData);
            this.Controls.Add(this.textBoxQuan);
            this.Controls.Add(this.textBoxLoai);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormThemDaiLy";
            this.Text = "Thêm đại lý";
            this.Load += new System.EventHandler(this.FormThemDaiLy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxLoai;
        private System.Windows.Forms.TextBox textBoxQuan;
        private System.Windows.Forms.TextBox textBoxTenDaiLyData;
        private System.Windows.Forms.ComboBox comboBoxLoaiDaiLyData;
        private System.Windows.Forms.ComboBox comboBoxQuanData;
        private System.Windows.Forms.Button buttonThemDaiLy;
        private System.Windows.Forms.TextBox textBoxSoDienThoaiData;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.TextBox textBoxEmailData;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDiaChiData;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTiepNhanData;
        private System.Windows.Forms.TextBox han;
        private System.Windows.Forms.TextBox textBoxNgayTiepNhan;
    }
}