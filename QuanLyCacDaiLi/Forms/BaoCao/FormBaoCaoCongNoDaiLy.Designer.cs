
namespace QuanLyCacDaiLi
{
    partial class FormBaoCaoCongNoDaiLy
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
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.buttonLapBaoCao = new System.Windows.Forms.Button();
            this.textBoxThang = new System.Windows.Forms.TextBox();
            this.numericUpDownThang = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNam = new System.Windows.Forms.NumericUpDown();
            this.textBoxNam = new System.Windows.Forms.TextBox();
            this.dataGridViewThongTin = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTin)).BeginInit();
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
            this.textBoxTitle.Size = new System.Drawing.Size(918, 91);
            this.textBoxTitle.TabIndex = 13;
            this.textBoxTitle.TabStop = false;
            this.textBoxTitle.Text = "Báo Cáo Công Nợ Đại Lý";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.groupBoxDate.Controls.Add(this.buttonLapBaoCao);
            this.groupBoxDate.Controls.Add(this.textBoxThang);
            this.groupBoxDate.Controls.Add(this.numericUpDownThang);
            this.groupBoxDate.Controls.Add(this.numericUpDownNam);
            this.groupBoxDate.Controls.Add(this.textBoxNam);
            this.groupBoxDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDate.Location = new System.Drawing.Point(0, 91);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(918, 81);
            this.groupBoxDate.TabIndex = 20;
            this.groupBoxDate.TabStop = false;
            // 
            // buttonLapBaoCao
            // 
            this.buttonLapBaoCao.Font = new System.Drawing.Font("Nunito", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLapBaoCao.Location = new System.Drawing.Point(330, 25);
            this.buttonLapBaoCao.Name = "buttonLapBaoCao";
            this.buttonLapBaoCao.Size = new System.Drawing.Size(130, 35);
            this.buttonLapBaoCao.TabIndex = 18;
            this.buttonLapBaoCao.Text = "Lập Báo Cáo";
            this.buttonLapBaoCao.UseVisualStyleBackColor = true;
            this.buttonLapBaoCao.Click += new System.EventHandler(this.buttonLapBaoCao_Click);
            // 
            // textBoxThang
            // 
            this.textBoxThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.textBoxThang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxThang.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxThang.Location = new System.Drawing.Point(-62, 26);
            this.textBoxThang.Name = "textBoxThang";
            this.textBoxThang.ReadOnly = true;
            this.textBoxThang.Size = new System.Drawing.Size(141, 32);
            this.textBoxThang.TabIndex = 17;
            this.textBoxThang.TabStop = false;
            this.textBoxThang.Text = "Tháng";
            this.textBoxThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownThang
            // 
            this.numericUpDownThang.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownThang.Location = new System.Drawing.Point(85, 25);
            this.numericUpDownThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThang.Name = "numericUpDownThang";
            this.numericUpDownThang.Size = new System.Drawing.Size(55, 35);
            this.numericUpDownThang.TabIndex = 0;
            this.numericUpDownThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownNam
            // 
            this.numericUpDownNam.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownNam.Location = new System.Drawing.Point(216, 25);
            this.numericUpDownNam.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownNam.Name = "numericUpDownNam";
            this.numericUpDownNam.Size = new System.Drawing.Size(81, 35);
            this.numericUpDownNam.TabIndex = 1;
            this.numericUpDownNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // textBoxNam
            // 
            this.textBoxNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.textBoxNam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNam.Font = new System.Drawing.Font("Nunito SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNam.Location = new System.Drawing.Point(156, 26);
            this.textBoxNam.Name = "textBoxNam";
            this.textBoxNam.ReadOnly = true;
            this.textBoxNam.Size = new System.Drawing.Size(54, 32);
            this.textBoxNam.TabIndex = 17;
            this.textBoxNam.TabStop = false;
            this.textBoxNam.Text = "Năm";
            this.textBoxNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridViewThongTin
            // 
            this.dataGridViewThongTin.AllowUserToAddRows = false;
            this.dataGridViewThongTin.AllowUserToDeleteRows = false;
            this.dataGridViewThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThongTin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDaiLy,
            this.NoDau,
            this.PhatSinh,
            this.NoCuoi});
            this.dataGridViewThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewThongTin.Location = new System.Drawing.Point(0, 172);
            this.dataGridViewThongTin.Name = "dataGridViewThongTin";
            this.dataGridViewThongTin.ReadOnly = true;
            this.dataGridViewThongTin.RowHeadersWidth = 51;
            this.dataGridViewThongTin.RowTemplate.Height = 29;
            this.dataGridViewThongTin.Size = new System.Drawing.Size(918, 399);
            this.dataGridViewThongTin.TabIndex = 21;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // TenDaiLy
            // 
            this.TenDaiLy.HeaderText = "Tên Đại Lý";
            this.TenDaiLy.MinimumWidth = 6;
            this.TenDaiLy.Name = "TenDaiLy";
            this.TenDaiLy.ReadOnly = true;
            // 
            // NoDau
            // 
            this.NoDau.HeaderText = "Nợ Đầu";
            this.NoDau.MinimumWidth = 6;
            this.NoDau.Name = "NoDau";
            this.NoDau.ReadOnly = true;
            // 
            // PhatSinh
            // 
            this.PhatSinh.HeaderText = "Phát Sinh";
            this.PhatSinh.MinimumWidth = 6;
            this.PhatSinh.Name = "PhatSinh";
            this.PhatSinh.ReadOnly = true;
            // 
            // NoCuoi
            // 
            this.NoCuoi.HeaderText = "Nợ Cuối";
            this.NoCuoi.MinimumWidth = 6;
            this.NoCuoi.Name = "NoCuoi";
            this.NoCuoi.ReadOnly = true;
            // 
            // FormBaoCaoCongNoDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 571);
            this.Controls.Add(this.dataGridViewThongTin);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "FormBaoCaoCongNoDaiLy";
            this.Text = "FormBaoCaoCongNoDaiLy";
            this.Load += new System.EventHandler(this.FormBaoCaoCongNoDaiLy_Load);
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.Button buttonLapBaoCao;
        private System.Windows.Forms.TextBox textBoxThang;
        private System.Windows.Forms.NumericUpDown numericUpDownThang;
        private System.Windows.Forms.NumericUpDown numericUpDownNam;
        private System.Windows.Forms.TextBox textBoxNam;
        private System.Windows.Forms.DataGridView dataGridViewThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCuoi;
    }
}