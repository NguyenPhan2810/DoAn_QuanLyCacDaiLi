
namespace QuanLyCacDaiLi
{
    partial class FormQuanLyDaiLy
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxTimDaiLyData = new System.Windows.Forms.TextBox();
            this.textBoxTimDaiLy = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.dataGridViewDanhSachDaiLy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTimDaiLyData);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTimDaiLy);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTitle);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewDanhSachDaiLy);
            this.splitContainer1.Size = new System.Drawing.Size(782, 476);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 11;
            // 
            // textBoxTimDaiLyData
            // 
            this.textBoxTimDaiLyData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTimDaiLyData.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTimDaiLyData.Location = new System.Drawing.Point(146, 194);
            this.textBoxTimDaiLyData.Name = "textBoxTimDaiLyData";
            this.textBoxTimDaiLyData.Size = new System.Drawing.Size(422, 39);
            this.textBoxTimDaiLyData.TabIndex = 12;
            this.textBoxTimDaiLyData.TextChanged += new System.EventHandler(this.textBoxTimDaiLy_TextChanged);
            // 
            // textBoxTimDaiLy
            // 
            this.textBoxTimDaiLy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTimDaiLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.textBoxTimDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTimDaiLy.Enabled = false;
            this.textBoxTimDaiLy.Font = new System.Drawing.Font("Nunito SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTimDaiLy.Location = new System.Drawing.Point(5, 193);
            this.textBoxTimDaiLy.Name = "textBoxTimDaiLy";
            this.textBoxTimDaiLy.Size = new System.Drawing.Size(135, 37);
            this.textBoxTimDaiLy.TabIndex = 11;
            this.textBoxTimDaiLy.Text = "Tìm đại lý";
            this.textBoxTimDaiLy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.textBoxTitle.Size = new System.Drawing.Size(782, 91);
            this.textBoxTitle.TabIndex = 9;
            this.textBoxTitle.Text = "Danh Sách Các Đại Lý";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewDanhSachDaiLy
            // 
            this.dataGridViewDanhSachDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDanhSachDaiLy.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDanhSachDaiLy.Name = "dataGridViewDanhSachDaiLy";
            this.dataGridViewDanhSachDaiLy.RowHeadersWidth = 51;
            this.dataGridViewDanhSachDaiLy.RowTemplate.Height = 29;
            this.dataGridViewDanhSachDaiLy.Size = new System.Drawing.Size(782, 236);
            this.dataGridViewDanhSachDaiLy.TabIndex = 1;
            // 
            // TraCuuDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(782, 476);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "TraCuuDaiLy";
            this.Text = "TraCuuDaiLy";
            this.Load += new System.EventHandler(this.TraCuuDaiLy_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachDaiLy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachDaiLy;
        private System.Windows.Forms.TextBox textBoxTimDaiLyData;
        private System.Windows.Forms.TextBox textBoxTimDaiLy;
    }
}