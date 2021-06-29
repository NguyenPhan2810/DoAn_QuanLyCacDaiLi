
namespace QuanLyCacDaiLi
{
    partial class FormPhieuThuTien
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxDaiLyData = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayThuTienData = new System.Windows.Forms.DateTimePicker();
            this.textBoxNgayLapPhieu = new System.Windows.Forms.TextBox();
            this.textBoxDaiLy = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxDiaChiData = new System.Windows.Forms.TextBox();
            this.textBoxDienThoai = new System.Windows.Forms.TextBox();
            this.textBoxDienThoaiData = new System.Windows.Forms.TextBox();
            this.textBoxEmailData = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSoTienThu = new System.Windows.Forms.TextBox();
            this.numericUpDownSoTienThu = new System.Windows.Forms.NumericUpDown();
            this.buttonXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoTienThu)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Font = new System.Drawing.Font("Nunito", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxTitle.Location = new System.Drawing.Point(0, 0);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(892, 91);
            this.textBoxTitle.TabIndex = 11;
            this.textBoxTitle.TabStop = false;
            this.textBoxTitle.Text = "Phiếu Thu Tiền";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxDaiLyData
            // 
            this.comboBoxDaiLyData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDaiLyData.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDaiLyData.FormattingEnabled = true;
            this.comboBoxDaiLyData.Location = new System.Drawing.Point(263, 94);
            this.comboBoxDaiLyData.Name = "comboBoxDaiLyData";
            this.comboBoxDaiLyData.Size = new System.Drawing.Size(559, 40);
            this.comboBoxDaiLyData.TabIndex = 0;
            this.comboBoxDaiLyData.SelectedIndexChanged += new System.EventHandler(this.comboBoxDaiLyData_SelectedIndexChanged);
            // 
            // dateTimePickerNgayThuTienData
            // 
            this.dateTimePickerNgayThuTienData.CalendarFont = new System.Drawing.Font("Nunito", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerNgayThuTienData.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerNgayThuTienData.Location = new System.Drawing.Point(263, 274);
            this.dateTimePickerNgayThuTienData.Name = "dateTimePickerNgayThuTienData";
            this.dateTimePickerNgayThuTienData.Size = new System.Drawing.Size(559, 39);
            this.dateTimePickerNgayThuTienData.TabIndex = 4;
            // 
            // textBoxNgayLapPhieu
            // 
            this.textBoxNgayLapPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.textBoxNgayLapPhieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNgayLapPhieu.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNgayLapPhieu.Location = new System.Drawing.Point(116, 279);
            this.textBoxNgayLapPhieu.Name = "textBoxNgayLapPhieu";
            this.textBoxNgayLapPhieu.ReadOnly = true;
            this.textBoxNgayLapPhieu.Size = new System.Drawing.Size(141, 32);
            this.textBoxNgayLapPhieu.TabIndex = 15;
            this.textBoxNgayLapPhieu.TabStop = false;
            this.textBoxNgayLapPhieu.Text = "Ngày thu tiền";
            this.textBoxNgayLapPhieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDaiLy
            // 
            this.textBoxDaiLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.textBoxDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDaiLy.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDaiLy.Location = new System.Drawing.Point(116, 97);
            this.textBoxDaiLy.Name = "textBoxDaiLy";
            this.textBoxDaiLy.ReadOnly = true;
            this.textBoxDaiLy.Size = new System.Drawing.Size(141, 32);
            this.textBoxDaiLy.TabIndex = 13;
            this.textBoxDaiLy.TabStop = false;
            this.textBoxDaiLy.Text = "Đại Lý";
            this.textBoxDaiLy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.textBoxDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiaChi.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDiaChi.Location = new System.Drawing.Point(116, 143);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.ReadOnly = true;
            this.textBoxDiaChi.Size = new System.Drawing.Size(141, 32);
            this.textBoxDiaChi.TabIndex = 16;
            this.textBoxDiaChi.TabStop = false;
            this.textBoxDiaChi.Text = "Địa Chỉ";
            this.textBoxDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDiaChiData
            // 
            this.textBoxDiaChiData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDiaChiData.Location = new System.Drawing.Point(263, 140);
            this.textBoxDiaChiData.Name = "textBoxDiaChiData";
            this.textBoxDiaChiData.ReadOnly = true;
            this.textBoxDiaChiData.Size = new System.Drawing.Size(559, 39);
            this.textBoxDiaChiData.TabIndex = 1;
            this.textBoxDiaChiData.TabStop = false;
            // 
            // textBoxDienThoai
            // 
            this.textBoxDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.textBoxDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDienThoai.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDienThoai.Location = new System.Drawing.Point(116, 188);
            this.textBoxDienThoai.Name = "textBoxDienThoai";
            this.textBoxDienThoai.ReadOnly = true;
            this.textBoxDienThoai.Size = new System.Drawing.Size(141, 32);
            this.textBoxDienThoai.TabIndex = 16;
            this.textBoxDienThoai.TabStop = false;
            this.textBoxDienThoai.Text = "Điện Thoại";
            this.textBoxDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDienThoaiData
            // 
            this.textBoxDienThoaiData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDienThoaiData.Location = new System.Drawing.Point(263, 185);
            this.textBoxDienThoaiData.Name = "textBoxDienThoaiData";
            this.textBoxDienThoaiData.ReadOnly = true;
            this.textBoxDienThoaiData.Size = new System.Drawing.Size(559, 39);
            this.textBoxDienThoaiData.TabIndex = 2;
            this.textBoxDienThoaiData.TabStop = false;
            // 
            // textBoxEmailData
            // 
            this.textBoxEmailData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmailData.Location = new System.Drawing.Point(263, 230);
            this.textBoxEmailData.Name = "textBoxEmailData";
            this.textBoxEmailData.ReadOnly = true;
            this.textBoxEmailData.Size = new System.Drawing.Size(559, 39);
            this.textBoxEmailData.TabIndex = 3;
            this.textBoxEmailData.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(116, 233);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(141, 32);
            this.textBoxEmail.TabIndex = 18;
            this.textBoxEmail.TabStop = false;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSoTienThu
            // 
            this.textBoxSoTienThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.textBoxSoTienThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSoTienThu.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSoTienThu.Location = new System.Drawing.Point(116, 321);
            this.textBoxSoTienThu.Name = "textBoxSoTienThu";
            this.textBoxSoTienThu.ReadOnly = true;
            this.textBoxSoTienThu.Size = new System.Drawing.Size(141, 32);
            this.textBoxSoTienThu.TabIndex = 18;
            this.textBoxSoTienThu.TabStop = false;
            this.textBoxSoTienThu.Text = "Số Tiền Thu";
            this.textBoxSoTienThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownSoTienThu
            // 
            this.numericUpDownSoTienThu.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownSoTienThu.Location = new System.Drawing.Point(263, 319);
            this.numericUpDownSoTienThu.Name = "numericUpDownSoTienThu";
            this.numericUpDownSoTienThu.Size = new System.Drawing.Size(559, 39);
            this.numericUpDownSoTienThu.TabIndex = 5;
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonXacNhan.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonXacNhan.ForeColor = System.Drawing.Color.Black;
            this.buttonXacNhan.Location = new System.Drawing.Point(349, 389);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(205, 49);
            this.buttonXacNhan.TabIndex = 6;
            this.buttonXacNhan.Text = "Xác Nhận";
            this.buttonXacNhan.UseVisualStyleBackColor = false;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // FormPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.buttonXacNhan);
            this.Controls.Add(this.numericUpDownSoTienThu);
            this.Controls.Add(this.textBoxEmailData);
            this.Controls.Add(this.textBoxSoTienThu);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxDienThoaiData);
            this.Controls.Add(this.textBoxDienThoai);
            this.Controls.Add(this.textBoxDiaChiData);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.comboBoxDaiLyData);
            this.Controls.Add(this.dateTimePickerNgayThuTienData);
            this.Controls.Add(this.textBoxNgayLapPhieu);
            this.Controls.Add(this.textBoxDaiLy);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "FormPhieuThuTien";
            this.Load += new System.EventHandler(this.FormPhieuThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoTienThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayThuTienData;
        private System.Windows.Forms.TextBox textBoxNgayLapPhieu;
        private System.Windows.Forms.TextBox textBoxDaiLy;
        private System.Windows.Forms.ComboBox comboBoxDaiLyData;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxDiaChiData;
        private System.Windows.Forms.TextBox textBoxDienThoai;
        private System.Windows.Forms.TextBox textBoxDienThoaiData;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxEmailData;
        private System.Windows.Forms.TextBox textBoxSoTienThu;
        private System.Windows.Forms.NumericUpDown numericUpDownSoTienThu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonXacNhan;
    }
}