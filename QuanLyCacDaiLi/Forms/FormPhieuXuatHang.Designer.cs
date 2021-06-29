
namespace QuanLyCacDaiLi
{
    partial class FormPhieuXuatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.buttonXoaMatHang = new System.Windows.Forms.Button();
            this.buttonXuatPhieu = new System.Windows.Forms.Button();
            this.buttonThemMatHang = new System.Windows.Forms.Button();
            this.comboBoxTenDaiLyData = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayLapPhieuData = new System.Windows.Forms.DateTimePicker();
            this.textBoxNgayLapPhieu = new System.Windows.Forms.TextBox();
            this.textBoxTenDaiLy = new System.Windows.Forms.TextBox();
            this.dataGridViewMatHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).BeginInit();
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
            this.textBoxTitle.Size = new System.Drawing.Size(1227, 91);
            this.textBoxTitle.TabIndex = 10;
            this.textBoxTitle.TabStop = false;
            this.textBoxTitle.Text = "Phiếu Xuất Hàng";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.buttonXoaMatHang);
            this.groupBoxThongTin.Controls.Add(this.buttonXuatPhieu);
            this.groupBoxThongTin.Controls.Add(this.buttonThemMatHang);
            this.groupBoxThongTin.Controls.Add(this.comboBoxTenDaiLyData);
            this.groupBoxThongTin.Controls.Add(this.dateTimePickerNgayLapPhieuData);
            this.groupBoxThongTin.Controls.Add(this.textBoxNgayLapPhieu);
            this.groupBoxThongTin.Controls.Add(this.textBoxTenDaiLy);
            this.groupBoxThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxThongTin.Location = new System.Drawing.Point(0, 91);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(1227, 132);
            this.groupBoxThongTin.TabIndex = 11;
            this.groupBoxThongTin.TabStop = false;
            // 
            // buttonXoaMatHang
            // 
            this.buttonXoaMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonXoaMatHang.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonXoaMatHang.ForeColor = System.Drawing.Color.Red;
            this.buttonXoaMatHang.Location = new System.Drawing.Point(213, 88);
            this.buttonXoaMatHang.Name = "buttonXoaMatHang";
            this.buttonXoaMatHang.Size = new System.Drawing.Size(201, 38);
            this.buttonXoaMatHang.TabIndex = 2;
            this.buttonXoaMatHang.Text = "Xoá mặt hàng";
            this.buttonXoaMatHang.UseVisualStyleBackColor = true;
            this.buttonXoaMatHang.Click += new System.EventHandler(this.buttonXoaMatHang_Click);
            // 
            // buttonXuatPhieu
            // 
            this.buttonXuatPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXuatPhieu.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonXuatPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonXuatPhieu.Location = new System.Drawing.Point(1014, 88);
            this.buttonXuatPhieu.Name = "buttonXuatPhieu";
            this.buttonXuatPhieu.Size = new System.Drawing.Size(201, 38);
            this.buttonXuatPhieu.TabIndex = 2;
            this.buttonXuatPhieu.Text = "Xuất Phiếu";
            this.buttonXuatPhieu.UseVisualStyleBackColor = true;
            this.buttonXuatPhieu.Click += new System.EventHandler(this.buttonXuatPhieu_Click);
            // 
            // buttonThemMatHang
            // 
            this.buttonThemMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonThemMatHang.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonThemMatHang.ForeColor = System.Drawing.Color.Green;
            this.buttonThemMatHang.Location = new System.Drawing.Point(6, 88);
            this.buttonThemMatHang.Name = "buttonThemMatHang";
            this.buttonThemMatHang.Size = new System.Drawing.Size(201, 38);
            this.buttonThemMatHang.TabIndex = 2;
            this.buttonThemMatHang.Text = "Thêm mặt hàng";
            this.buttonThemMatHang.UseVisualStyleBackColor = true;
            this.buttonThemMatHang.Click += new System.EventHandler(this.buttonThemMatHang_Click);
            // 
            // comboBoxTenDaiLyData
            // 
            this.comboBoxTenDaiLyData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTenDaiLyData.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTenDaiLyData.FormattingEnabled = true;
            this.comboBoxTenDaiLyData.Location = new System.Drawing.Point(114, 26);
            this.comboBoxTenDaiLyData.Name = "comboBoxTenDaiLyData";
            this.comboBoxTenDaiLyData.Size = new System.Drawing.Size(339, 40);
            this.comboBoxTenDaiLyData.TabIndex = 0;
            // 
            // dateTimePickerNgayLapPhieuData
            // 
            this.dateTimePickerNgayLapPhieuData.CalendarFont = new System.Drawing.Font("Nunito", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerNgayLapPhieuData.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerNgayLapPhieuData.Location = new System.Drawing.Point(644, 32);
            this.dateTimePickerNgayLapPhieuData.Name = "dateTimePickerNgayLapPhieuData";
            this.dateTimePickerNgayLapPhieuData.Size = new System.Drawing.Size(275, 28);
            this.dateTimePickerNgayLapPhieuData.TabIndex = 1;
            // 
            // textBoxNgayLapPhieu
            // 
            this.textBoxNgayLapPhieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNgayLapPhieu.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNgayLapPhieu.Location = new System.Drawing.Point(479, 29);
            this.textBoxNgayLapPhieu.Name = "textBoxNgayLapPhieu";
            this.textBoxNgayLapPhieu.ReadOnly = true;
            this.textBoxNgayLapPhieu.Size = new System.Drawing.Size(159, 32);
            this.textBoxNgayLapPhieu.TabIndex = 1;
            this.textBoxNgayLapPhieu.TabStop = false;
            this.textBoxNgayLapPhieu.Text = "Ngày lập phiếu";
            this.textBoxNgayLapPhieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTenDaiLy
            // 
            this.textBoxTenDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTenDaiLy.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTenDaiLy.Location = new System.Drawing.Point(3, 29);
            this.textBoxTenDaiLy.Name = "textBoxTenDaiLy";
            this.textBoxTenDaiLy.ReadOnly = true;
            this.textBoxTenDaiLy.Size = new System.Drawing.Size(105, 32);
            this.textBoxTenDaiLy.TabIndex = 0;
            this.textBoxTenDaiLy.TabStop = false;
            this.textBoxTenDaiLy.Text = "Tên đại lý  ";
            this.textBoxTenDaiLy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridViewMatHang
            // 
            this.dataGridViewMatHang.AllowUserToAddRows = false;
            this.dataGridViewMatHang.AllowUserToOrderColumns = true;
            this.dataGridViewMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MatHang,
            this.DonViTinh,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dataGridViewMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatHang.Location = new System.Drawing.Point(0, 223);
            this.dataGridViewMatHang.Name = "dataGridViewMatHang";
            this.dataGridViewMatHang.RowHeadersWidth = 51;
            this.dataGridViewMatHang.RowTemplate.Height = 29;
            this.dataGridViewMatHang.Size = new System.Drawing.Size(1227, 496);
            this.dataGridViewMatHang.TabIndex = 12;
            this.dataGridViewMatHang.TabStop = false;
            this.dataGridViewMatHang.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellEnter);
            this.dataGridViewMatHang.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellValidated);
            this.dataGridViewMatHang.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewMatHang_CellValidating);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.Frozen = true;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 60;
            // 
            // MatHang
            // 
            dataGridViewCellStyle1.NullValue = "Chọn mặt hàng";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MatHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.MatHang.HeaderText = "Mặt Hàng";
            this.MatHang.MinimumWidth = 300;
            this.MatHang.Name = "MatHang";
            // 
            // DonViTinh
            // 
            this.DonViTinh.FillWeight = 0.001529475F;
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.MinimumWidth = 120;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // SoLuong
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.SoLuong.FillWeight = 0.1F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 100;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.FillWeight = 1F;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 100;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.FillWeight = 1F;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 150;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // FormPhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 719);
            this.Controls.Add(this.dataGridViewMatHang);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.textBoxTitle);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormPhieuXuatHang";
            this.Text = "Phiếu Xuất Hàng";
            this.Load += new System.EventHandler(this.FormPhieuXuatHang_Load);
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.TextBox textBoxNgayLapPhieu;
        private System.Windows.Forms.TextBox textBoxTenDaiLy;
        private System.Windows.Forms.DataGridView dataGridViewMatHang;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLapPhieuData;
        private System.Windows.Forms.ComboBox comboBoxTenDaiLyData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonXoaMatHang;
        private System.Windows.Forms.Button buttonThemMatHang;
        private System.Windows.Forms.Button buttonXuatPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn MatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}