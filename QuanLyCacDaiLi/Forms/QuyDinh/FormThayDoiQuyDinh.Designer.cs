
namespace QuanLyCacDaiLi
{
    partial class FormThayDoiQuyDinh
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxSoDaiLyMax = new System.Windows.Forms.TextBox();
            this.numericUpDownSoDaiLyMaxData = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonXacNhanSoDaiLyMax = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewLoaiDaiLy = new System.Windows.Forms.DataGridView();
            this.LoaiDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNoMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonXoaLoaiDaiLy = new System.Windows.Forms.Button();
            this.buttonThemLoaiDaiLy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewMatHang = new System.Windows.Forms.DataGridView();
            this.TenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonXoaMatHang = new System.Windows.Forms.Button();
            this.buttonThemMatHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoDaiLyMaxData)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiDaiLy)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.textBoxTitle.Size = new System.Drawing.Size(954, 91);
            this.textBoxTitle.TabIndex = 10;
            this.textBoxTitle.Text = "Quy Định";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSoDaiLyMax
            // 
            this.textBoxSoDaiLyMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSoDaiLyMax.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSoDaiLyMax.Location = new System.Drawing.Point(6, 26);
            this.textBoxSoDaiLyMax.Name = "textBoxSoDaiLyMax";
            this.textBoxSoDaiLyMax.Size = new System.Drawing.Size(225, 28);
            this.textBoxSoDaiLyMax.TabIndex = 11;
            this.textBoxSoDaiLyMax.Text = "Số đại lý tối đa mỗi quận";
            // 
            // numericUpDownSoDaiLyMaxData
            // 
            this.numericUpDownSoDaiLyMaxData.Location = new System.Drawing.Point(237, 27);
            this.numericUpDownSoDaiLyMaxData.Name = "numericUpDownSoDaiLyMaxData";
            this.numericUpDownSoDaiLyMaxData.Size = new System.Drawing.Size(58, 27);
            this.numericUpDownSoDaiLyMaxData.TabIndex = 12;
            this.numericUpDownSoDaiLyMaxData.ValueChanged += new System.EventHandler(this.numericUpDownSoDaiLyMaxData_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(954, 617);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.buttonXacNhanSoDaiLyMax);
            this.groupBox1.Controls.Add(this.textBoxSoDaiLyMax);
            this.groupBox1.Controls.Add(this.numericUpDownSoDaiLyMaxData);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 80);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số Lượng Đại Lý Tối Đa Mỗi Quận";
            // 
            // buttonXacNhanSoDaiLyMax
            // 
            this.buttonXacNhanSoDaiLyMax.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonXacNhanSoDaiLyMax.Location = new System.Drawing.Point(301, 25);
            this.buttonXacNhanSoDaiLyMax.Name = "buttonXacNhanSoDaiLyMax";
            this.buttonXacNhanSoDaiLyMax.Size = new System.Drawing.Size(120, 29);
            this.buttonXacNhanSoDaiLyMax.TabIndex = 13;
            this.buttonXacNhanSoDaiLyMax.Text = "Xác Nhận";
            this.buttonXacNhanSoDaiLyMax.UseVisualStyleBackColor = true;
            this.buttonXacNhanSoDaiLyMax.Click += new System.EventHandler(this.buttonXacNhanSoDaiLyMax_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(3, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(920, 191);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại Đại Lý";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 23);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewLoaiDaiLy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonXoaLoaiDaiLy);
            this.splitContainer1.Panel2.Controls.Add(this.buttonThemLoaiDaiLy);
            this.splitContainer1.Size = new System.Drawing.Size(914, 165);
            this.splitContainer1.SplitterDistance = 628;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridViewLoaiDaiLy
            // 
            this.dataGridViewLoaiDaiLy.AllowUserToAddRows = false;
            this.dataGridViewLoaiDaiLy.AllowUserToDeleteRows = false;
            this.dataGridViewLoaiDaiLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoaiDaiLy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLoaiDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiDaiLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiDaiLy,
            this.TienNoMax});
            this.dataGridViewLoaiDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLoaiDaiLy.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLoaiDaiLy.Name = "dataGridViewLoaiDaiLy";
            this.dataGridViewLoaiDaiLy.RowHeadersWidth = 51;
            this.dataGridViewLoaiDaiLy.RowTemplate.Height = 29;
            this.dataGridViewLoaiDaiLy.Size = new System.Drawing.Size(628, 165);
            this.dataGridViewLoaiDaiLy.TabIndex = 0;
            this.dataGridViewLoaiDaiLy.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaiDaiLy_CellValidated);
            this.dataGridViewLoaiDaiLy.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewLoaiDaiLy_CellValidating);
            // 
            // LoaiDaiLy
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.LoaiDaiLy.DefaultCellStyle = dataGridViewCellStyle1;
            this.LoaiDaiLy.HeaderText = "Loại Đại Lý";
            this.LoaiDaiLy.MinimumWidth = 6;
            this.LoaiDaiLy.Name = "LoaiDaiLy";
            this.LoaiDaiLy.ReadOnly = true;
            // 
            // TienNoMax
            // 
            this.TienNoMax.HeaderText = "Tiền Nợ Cho Phép";
            this.TienNoMax.MinimumWidth = 6;
            this.TienNoMax.Name = "TienNoMax";
            // 
            // buttonXoaLoaiDaiLy
            // 
            this.buttonXoaLoaiDaiLy.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonXoaLoaiDaiLy.Location = new System.Drawing.Point(2, 40);
            this.buttonXoaLoaiDaiLy.Name = "buttonXoaLoaiDaiLy";
            this.buttonXoaLoaiDaiLy.Size = new System.Drawing.Size(164, 29);
            this.buttonXoaLoaiDaiLy.TabIndex = 1;
            this.buttonXoaLoaiDaiLy.Text = "Xoá Loại Đại Lý";
            this.buttonXoaLoaiDaiLy.UseVisualStyleBackColor = true;
            this.buttonXoaLoaiDaiLy.Click += new System.EventHandler(this.buttonXoaLoaiDaiLy_Click);
            // 
            // buttonThemLoaiDaiLy
            // 
            this.buttonThemLoaiDaiLy.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonThemLoaiDaiLy.Location = new System.Drawing.Point(3, 5);
            this.buttonThemLoaiDaiLy.Name = "buttonThemLoaiDaiLy";
            this.buttonThemLoaiDaiLy.Size = new System.Drawing.Size(164, 29);
            this.buttonThemLoaiDaiLy.TabIndex = 1;
            this.buttonThemLoaiDaiLy.Text = "Thêm Loại Đại Lý";
            this.buttonThemLoaiDaiLy.UseVisualStyleBackColor = true;
            this.buttonThemLoaiDaiLy.Click += new System.EventHandler(this.buttonThemLoaiDaiLy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.splitContainer2);
            this.groupBox3.Location = new System.Drawing.Point(3, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(923, 308);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mặt Hàng";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 23);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridViewMatHang);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonXoaMatHang);
            this.splitContainer2.Panel2.Controls.Add(this.buttonThemMatHang);
            this.splitContainer2.Size = new System.Drawing.Size(917, 282);
            this.splitContainer2.SplitterDistance = 633;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridViewMatHang
            // 
            this.dataGridViewMatHang.AllowUserToAddRows = false;
            this.dataGridViewMatHang.AllowUserToDeleteRows = false;
            this.dataGridViewMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMatHang,
            this.DonGia,
            this.DonViTinh});
            this.dataGridViewMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatHang.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMatHang.Name = "dataGridViewMatHang";
            this.dataGridViewMatHang.RowHeadersWidth = 51;
            this.dataGridViewMatHang.RowTemplate.Height = 29;
            this.dataGridViewMatHang.Size = new System.Drawing.Size(633, 282);
            this.dataGridViewMatHang.TabIndex = 0;
            // 
            // TenMatHang
            // 
            this.TenMatHang.HeaderText = "Tên Mặt Hàng";
            this.TenMatHang.MinimumWidth = 6;
            this.TenMatHang.Name = "TenMatHang";
            this.TenMatHang.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            // 
            // buttonXoaMatHang
            // 
            this.buttonXoaMatHang.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonXoaMatHang.Location = new System.Drawing.Point(3, 41);
            this.buttonXoaMatHang.Name = "buttonXoaMatHang";
            this.buttonXoaMatHang.Size = new System.Drawing.Size(164, 29);
            this.buttonXoaMatHang.TabIndex = 1;
            this.buttonXoaMatHang.Text = "Xoá Mặt Hàng";
            this.buttonXoaMatHang.UseVisualStyleBackColor = true;
            this.buttonXoaMatHang.Click += new System.EventHandler(this.buttonXoaMatHang_Click);
            // 
            // buttonThemMatHang
            // 
            this.buttonThemMatHang.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonThemMatHang.Location = new System.Drawing.Point(4, 6);
            this.buttonThemMatHang.Name = "buttonThemMatHang";
            this.buttonThemMatHang.Size = new System.Drawing.Size(164, 29);
            this.buttonThemMatHang.TabIndex = 1;
            this.buttonThemMatHang.Text = "Thêm Mặt Hàng";
            this.buttonThemMatHang.UseVisualStyleBackColor = true;
            this.buttonThemMatHang.Click += new System.EventHandler(this.buttonThemMatHang_Click);
            // 
            // FormThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 708);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "FormThayDoiQuyDinh";
            this.Text = "FormThayDoiQuyDinh";
            this.Load += new System.EventHandler(this.FormThayDoiQuyDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoDaiLyMaxData)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiDaiLy)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxSoDaiLyMax;
        private System.Windows.Forms.NumericUpDown numericUpDownSoDaiLyMaxData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonXacNhanSoDaiLyMax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewLoaiDaiLy;
        private System.Windows.Forms.Button buttonThemLoaiDaiLy;
        private System.Windows.Forms.Button buttonXoaLoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNoMax;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridViewMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.Button buttonXoaMatHang;
        private System.Windows.Forms.Button buttonThemMatHang;
    }
}