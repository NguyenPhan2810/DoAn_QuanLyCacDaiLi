
namespace QuanLyCacDaiLi
{
    partial class QuanLyDaiLy
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.groupBoxDataDaily = new System.Windows.Forms.GroupBox();
            this.groupBoxTimDaiLy = new System.Windows.Forms.GroupBox();
            this.textBoxTimDaiLy = new System.Windows.Forms.TextBox();
            this.textBoxTimDaiLyData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBoxTimDaiLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BackColor = System.Drawing.Color.DimGray;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxTitle);
            this.splitContainerMain.Panel1MinSize = 200;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.splitContainerMain.Panel2.Controls.Add(this.groupBoxDataDaily);
            this.splitContainerMain.Panel2.Controls.Add(this.groupBoxTimDaiLy);
            this.splitContainerMain.Size = new System.Drawing.Size(878, 672);
            this.splitContainerMain.SplitterDistance = 332;
            this.splitContainerMain.SplitterWidth = 10;
            this.splitContainerMain.TabIndex = 11;
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
            this.textBoxTitle.Size = new System.Drawing.Size(878, 91);
            this.textBoxTitle.TabIndex = 9;
            this.textBoxTitle.Text = "Quản Lý Các Đại Lý";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxDataDaily
            // 
            this.groupBoxDataDaily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataDaily.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDataDaily.Location = new System.Drawing.Point(0, 76);
            this.groupBoxDataDaily.Name = "groupBoxDataDaily";
            this.groupBoxDataDaily.Size = new System.Drawing.Size(878, 254);
            this.groupBoxDataDaily.TabIndex = 14;
            this.groupBoxDataDaily.TabStop = false;
            this.groupBoxDataDaily.Text = "Các đại lý";
            // 
            // groupBoxTimDaiLy
            // 
            this.groupBoxTimDaiLy.Controls.Add(this.textBoxTimDaiLy);
            this.groupBoxTimDaiLy.Controls.Add(this.textBoxTimDaiLyData);
            this.groupBoxTimDaiLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTimDaiLy.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTimDaiLy.Name = "groupBoxTimDaiLy";
            this.groupBoxTimDaiLy.Size = new System.Drawing.Size(878, 76);
            this.groupBoxTimDaiLy.TabIndex = 13;
            this.groupBoxTimDaiLy.TabStop = false;
            // 
            // textBoxTimDaiLy
            // 
            this.textBoxTimDaiLy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTimDaiLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.textBoxTimDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTimDaiLy.Enabled = false;
            this.textBoxTimDaiLy.Font = new System.Drawing.Font("Nunito SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTimDaiLy.Location = new System.Drawing.Point(0, 26);
            this.textBoxTimDaiLy.Name = "textBoxTimDaiLy";
            this.textBoxTimDaiLy.Size = new System.Drawing.Size(118, 32);
            this.textBoxTimDaiLy.TabIndex = 11;
            this.textBoxTimDaiLy.Text = "Tìm đại lý";
            this.textBoxTimDaiLy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTimDaiLyData
            // 
            this.textBoxTimDaiLyData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTimDaiLyData.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTimDaiLyData.Location = new System.Drawing.Point(124, 23);
            this.textBoxTimDaiLyData.Name = "textBoxTimDaiLyData";
            this.textBoxTimDaiLyData.Size = new System.Drawing.Size(422, 39);
            this.textBoxTimDaiLyData.TabIndex = 12;
            this.textBoxTimDaiLyData.TextChanged += new System.EventHandler(this.textBoxTimDaiLy_TextChanged);
            // 
            // QuanLyDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(878, 672);
            this.Controls.Add(this.splitContainerMain);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "QuanLyDaiLy";
            this.Text = "TraCuuDaiLy";
            this.Load += new System.EventHandler(this.TraCuuDaiLy_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBoxTimDaiLy.ResumeLayout(false);
            this.groupBoxTimDaiLy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxTimDaiLyData;
        private System.Windows.Forms.TextBox textBoxTimDaiLy;
        private System.Windows.Forms.GroupBox groupBoxDataDaily;
        private System.Windows.Forms.GroupBox groupBoxTimDaiLy;
    }
}