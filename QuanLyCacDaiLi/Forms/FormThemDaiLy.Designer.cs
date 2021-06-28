
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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tên đại lý";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxLoai
            // 
            this.textBoxLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoai.Enabled = false;
            this.textBoxLoai.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxLoai.Location = new System.Drawing.Point(12, 57);
            this.textBoxLoai.Name = "textBoxLoai";
            this.textBoxLoai.ReadOnly = true;
            this.textBoxLoai.Size = new System.Drawing.Size(125, 32);
            this.textBoxLoai.TabIndex = 1;
            this.textBoxLoai.Text = "Loại đại lý";
            this.textBoxLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxQuan
            // 
            this.textBoxQuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuan.Enabled = false;
            this.textBoxQuan.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxQuan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxQuan.Location = new System.Drawing.Point(12, 103);
            this.textBoxQuan.Name = "textBoxQuan";
            this.textBoxQuan.ReadOnly = true;
            this.textBoxQuan.Size = new System.Drawing.Size(125, 32);
            this.textBoxQuan.TabIndex = 2;
            this.textBoxQuan.Text = "Quận";
            this.textBoxQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTenDaiLyData
            // 
            this.textBoxTenDaiLyData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTenDaiLyData.Location = new System.Drawing.Point(143, 9);
            this.textBoxTenDaiLyData.Name = "textBoxTenDaiLyData";
            this.textBoxTenDaiLyData.Size = new System.Drawing.Size(405, 39);
            this.textBoxTenDaiLyData.TabIndex = 3;
            this.textBoxTenDaiLyData.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBoxLoaiDaiLyData
            // 
            this.comboBoxLoaiDaiLyData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoaiDaiLyData.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxLoaiDaiLyData.FormattingEnabled = true;
            this.comboBoxLoaiDaiLyData.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxLoaiDaiLyData.Location = new System.Drawing.Point(143, 54);
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
            this.comboBoxQuanData.Location = new System.Drawing.Point(143, 100);
            this.comboBoxQuanData.Name = "comboBoxQuanData";
            this.comboBoxQuanData.Size = new System.Drawing.Size(405, 40);
            this.comboBoxQuanData.TabIndex = 5;
            // 
            // buttonThemDaiLy
            // 
            this.buttonThemDaiLy.Location = new System.Drawing.Point(238, 168);
            this.buttonThemDaiLy.Name = "buttonThemDaiLy";
            this.buttonThemDaiLy.Size = new System.Drawing.Size(127, 46);
            this.buttonThemDaiLy.TabIndex = 6;
            this.buttonThemDaiLy.Text = "Thêm";
            this.buttonThemDaiLy.UseVisualStyleBackColor = true;
            this.buttonThemDaiLy.Click += new System.EventHandler(this.buttonThemDaiLy_Click);
            // 
            // FormThemDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 247);
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
    }
}