
namespace QuanLyCacDaiLi
{
    partial class FormXemPhieuXuatHang
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
            this.dataGridViewDSPhieuXuat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSPhieuXuat)).BeginInit();
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
            this.textBoxTitle.Size = new System.Drawing.Size(914, 91);
            this.textBoxTitle.TabIndex = 11;
            this.textBoxTitle.TabStop = false;
            this.textBoxTitle.Text = "Danh Sách Phiếu Xuất Hàng";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewDSPhieuXuat
            // 
            this.dataGridViewDSPhieuXuat.AllowUserToAddRows = false;
            this.dataGridViewDSPhieuXuat.AllowUserToDeleteRows = false;
            this.dataGridViewDSPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSPhieuXuat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDSPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDSPhieuXuat.Location = new System.Drawing.Point(0, 91);
            this.dataGridViewDSPhieuXuat.Name = "dataGridViewDSPhieuXuat";
            this.dataGridViewDSPhieuXuat.ReadOnly = true;
            this.dataGridViewDSPhieuXuat.RowHeadersWidth = 51;
            this.dataGridViewDSPhieuXuat.RowTemplate.Height = 29;
            this.dataGridViewDSPhieuXuat.Size = new System.Drawing.Size(914, 359);
            this.dataGridViewDSPhieuXuat.TabIndex = 12;
            // 
            // FormXemPhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.dataGridViewDSPhieuXuat);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "FormXemPhieuXuatHang";
            this.Text = "Xem Phiếu Xuất Hàng";
            this.Load += new System.EventHandler(this.FormXemPhieuXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.DataGridView dataGridViewDSPhieuXuat;
    }
}