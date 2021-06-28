
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.groupBoxDanhSachDaiLy = new System.Windows.Forms.GroupBox();
            this.dataGridViewDanhSachDaiLy = new System.Windows.Forms.DataGridView();
            this.groupBoxTimDaiLy = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTimDaiLyData = new System.Windows.Forms.TextBox();
            this.textBoxTimDaiLy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxDanhSachDaiLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachDaiLy)).BeginInit();
            this.groupBoxTimDaiLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Gray;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTitle);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxDanhSachDaiLy);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxTimDaiLy);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(992, 695);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.SplitterWidth = 20;
            this.splitContainer1.TabIndex = 11;
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
            this.textBoxTitle.Size = new System.Drawing.Size(992, 91);
            this.textBoxTitle.TabIndex = 9;
            this.textBoxTitle.Text = "Danh Sách Các Đại Lý";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxDanhSachDaiLy
            // 
            this.groupBoxDanhSachDaiLy.Controls.Add(this.dataGridViewDanhSachDaiLy);
            this.groupBoxDanhSachDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSachDaiLy.Location = new System.Drawing.Point(0, 60);
            this.groupBoxDanhSachDaiLy.Name = "groupBoxDanhSachDaiLy";
            this.groupBoxDanhSachDaiLy.Size = new System.Drawing.Size(992, 515);
            this.groupBoxDanhSachDaiLy.TabIndex = 3;
            this.groupBoxDanhSachDaiLy.TabStop = false;
            this.groupBoxDanhSachDaiLy.Text = "Danh sách đại lý";
            // 
            // dataGridViewDanhSachDaiLy
            // 
            this.dataGridViewDanhSachDaiLy.AllowUserToAddRows = false;
            this.dataGridViewDanhSachDaiLy.AllowUserToDeleteRows = false;
            this.dataGridViewDanhSachDaiLy.AllowUserToOrderColumns = true;
            this.dataGridViewDanhSachDaiLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachDaiLy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDanhSachDaiLy.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDanhSachDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDanhSachDaiLy.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewDanhSachDaiLy.Name = "dataGridViewDanhSachDaiLy";
            this.dataGridViewDanhSachDaiLy.ReadOnly = true;
            this.dataGridViewDanhSachDaiLy.RowHeadersWidth = 51;
            this.dataGridViewDanhSachDaiLy.RowTemplate.Height = 29;
            this.dataGridViewDanhSachDaiLy.Size = new System.Drawing.Size(986, 489);
            this.dataGridViewDanhSachDaiLy.TabIndex = 1;
            // 
            // groupBoxTimDaiLy
            // 
            this.groupBoxTimDaiLy.Controls.Add(this.button1);
            this.groupBoxTimDaiLy.Controls.Add(this.textBoxTimDaiLyData);
            this.groupBoxTimDaiLy.Controls.Add(this.textBoxTimDaiLy);
            this.groupBoxTimDaiLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTimDaiLy.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTimDaiLy.Name = "groupBoxTimDaiLy";
            this.groupBoxTimDaiLy.Size = new System.Drawing.Size(992, 60);
            this.groupBoxTimDaiLy.TabIndex = 2;
            this.groupBoxTimDaiLy.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(822, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thêm đại lý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTimDaiLyData
            // 
            this.textBoxTimDaiLyData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTimDaiLyData.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTimDaiLyData.Location = new System.Drawing.Point(153, 15);
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
            this.textBoxTimDaiLy.Location = new System.Drawing.Point(12, 17);
            this.textBoxTimDaiLy.Name = "textBoxTimDaiLy";
            this.textBoxTimDaiLy.Size = new System.Drawing.Size(135, 37);
            this.textBoxTimDaiLy.TabIndex = 11;
            this.textBoxTimDaiLy.Text = "Tìm đại lý";
            this.textBoxTimDaiLy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormQuanLyDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(992, 695);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormQuanLyDaiLy";
            this.Text = "TraCuuDaiLy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuanLyDaiLy_FormClosed);
            this.Load += new System.EventHandler(this.TraCuuDaiLy_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxDanhSachDaiLy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachDaiLy)).EndInit();
            this.groupBoxTimDaiLy.ResumeLayout(false);
            this.groupBoxTimDaiLy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachDaiLy;
        private System.Windows.Forms.TextBox textBoxTimDaiLyData;
        private System.Windows.Forms.TextBox textBoxTimDaiLy;
        private System.Windows.Forms.GroupBox groupBoxTimDaiLy;
        private System.Windows.Forms.GroupBox groupBoxDanhSachDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDaiLy;
        private System.Windows.Forms.DataGridViewComboBoxColumn Loai;
        private System.Windows.Forms.DataGridViewComboBoxColumn Quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private System.Windows.Forms.Button button1;
    }
}