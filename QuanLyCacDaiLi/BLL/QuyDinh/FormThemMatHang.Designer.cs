
namespace QuanLyCacDaiLi
{
    partial class FormThemMatHang
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
            this.textBoxDonViTinhData = new System.Windows.Forms.TextBox();
            this.textBoxDonViTinh = new System.Windows.Forms.TextBox();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.buttonThemDaiLy = new System.Windows.Forms.Button();
            this.textBoxTenMatHangData = new System.Windows.Forms.TextBox();
            this.textBoxTenMatHang = new System.Windows.Forms.TextBox();
            this.numericUpDownDonGiaData = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonGiaData)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDonViTinhData
            // 
            this.textBoxDonViTinhData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDonViTinhData.Location = new System.Drawing.Point(215, 71);
            this.textBoxDonViTinhData.Name = "textBoxDonViTinhData";
            this.textBoxDonViTinhData.Size = new System.Drawing.Size(405, 39);
            this.textBoxDonViTinhData.TabIndex = 21;
            // 
            // textBoxDonViTinh
            // 
            this.textBoxDonViTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDonViTinh.Enabled = false;
            this.textBoxDonViTinh.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDonViTinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxDonViTinh.Location = new System.Drawing.Point(32, 74);
            this.textBoxDonViTinh.Name = "textBoxDonViTinh";
            this.textBoxDonViTinh.ReadOnly = true;
            this.textBoxDonViTinh.Size = new System.Drawing.Size(177, 32);
            this.textBoxDonViTinh.TabIndex = 27;
            this.textBoxDonViTinh.TabStop = false;
            this.textBoxDonViTinh.Text = "Đơn Vị Tính";
            this.textBoxDonViTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDonGia.Enabled = false;
            this.textBoxDonGia.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDonGia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxDonGia.Location = new System.Drawing.Point(19, 112);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.ReadOnly = true;
            this.textBoxDonGia.Size = new System.Drawing.Size(190, 32);
            this.textBoxDonGia.TabIndex = 25;
            this.textBoxDonGia.TabStop = false;
            this.textBoxDonGia.Text = "Đơn Giá";
            this.textBoxDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonThemDaiLy
            // 
            this.buttonThemDaiLy.Location = new System.Drawing.Point(296, 177);
            this.buttonThemDaiLy.Name = "buttonThemDaiLy";
            this.buttonThemDaiLy.Size = new System.Drawing.Size(127, 46);
            this.buttonThemDaiLy.TabIndex = 26;
            this.buttonThemDaiLy.Text = "Thêm";
            this.buttonThemDaiLy.UseVisualStyleBackColor = true;
            this.buttonThemDaiLy.Click += new System.EventHandler(this.buttonThemDaiLy_Click);
            // 
            // textBoxTenMatHangData
            // 
            this.textBoxTenMatHangData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTenMatHangData.Location = new System.Drawing.Point(215, 26);
            this.textBoxTenMatHangData.Name = "textBoxTenMatHangData";
            this.textBoxTenMatHangData.Size = new System.Drawing.Size(405, 39);
            this.textBoxTenMatHangData.TabIndex = 15;
            this.textBoxTenMatHangData.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTenDaiLyData_Validating);
            // 
            // textBoxTenMatHang
            // 
            this.textBoxTenMatHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTenMatHang.Enabled = false;
            this.textBoxTenMatHang.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTenMatHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxTenMatHang.Location = new System.Drawing.Point(19, 29);
            this.textBoxTenMatHang.Name = "textBoxTenMatHang";
            this.textBoxTenMatHang.ReadOnly = true;
            this.textBoxTenMatHang.Size = new System.Drawing.Size(190, 32);
            this.textBoxTenMatHang.TabIndex = 16;
            this.textBoxTenMatHang.TabStop = false;
            this.textBoxTenMatHang.Text = "Tên Mặt Hàng";
            this.textBoxTenMatHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownDonGiaData
            // 
            this.numericUpDownDonGiaData.Location = new System.Drawing.Point(215, 116);
            this.numericUpDownDonGiaData.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDownDonGiaData.Name = "numericUpDownDonGiaData";
            this.numericUpDownDonGiaData.Size = new System.Drawing.Size(176, 27);
            this.numericUpDownDonGiaData.TabIndex = 28;
            // 
            // FormThemMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 247);
            this.Controls.Add(this.numericUpDownDonGiaData);
            this.Controls.Add(this.textBoxDonViTinhData);
            this.Controls.Add(this.textBoxDonViTinh);
            this.Controls.Add(this.textBoxDonGia);
            this.Controls.Add(this.buttonThemDaiLy);
            this.Controls.Add(this.textBoxTenMatHangData);
            this.Controls.Add(this.textBoxTenMatHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormThemMatHang";
            this.Text = "Thêm Mặt Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonGiaData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDonViTinhData;
        private System.Windows.Forms.TextBox textBoxDonViTinh;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.Button buttonThemDaiLy;
        private System.Windows.Forms.TextBox textBoxTenMatHangData;
        private System.Windows.Forms.TextBox textBoxTenMatHang;
        private System.Windows.Forms.NumericUpDown numericUpDownDonGiaData;
        private System.Windows.Forms.TextBox textBoxTenMatHa;
    }
}