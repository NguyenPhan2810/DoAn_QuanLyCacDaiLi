using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCacDaiLi
{
    public partial class FormThemDaiLy : Form
    {
        public delegate void ThemDaiLyDelegate(string tenDaiLy, int loai, string quan);
        public ThemDaiLyDelegate ThemDaiLyEvent;

        public FormThemDaiLy()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ValidifyName();
        }

        private void buttonThemDaiLy_Click(object sender, EventArgs e)
        {
            if (ValidifyName())
            {
                ThemDaiLyEvent.Invoke(textBoxTenDaiLyData.Text, int.Parse(comboBoxLoaiDaiLyData.Text), comboBoxQuanData.Text);
                Close();
            }
        }

        // Check if giving name is valid
        // Return true if valid and false otherwise
        private bool ValidifyName()
        {
            string query = $"select TENDAILY from DAILY where TENDAILY = '{textBoxTenDaiLyData}'";

            var dt = DatabaseHelper.GetDataTable(query);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tên đã bị trùng, vui lòng chọn tên khác.", "Lỗi");
                return false;
            }

            return true;
        }
    }
}
