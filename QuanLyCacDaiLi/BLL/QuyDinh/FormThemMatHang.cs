using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCacDaiLi
{
    public partial class FormThemMatHang : Form
    {
        public delegate void ThemMatHangDelegate(string tenMatHang, decimal donGia, string donViTinh);
        public ThemMatHangDelegate ThemMatHangEvent;

        public FormThemMatHang()
        {
            InitializeComponent();
        }

        private void textBoxTenDaiLyData_Validating(object sender, CancelEventArgs e)
        {
            var query = $"select TENMATHANG from MATHANG where TENMATHANG = N'{textBoxTenMatHangData.Text}'";

            if (DatabaseHelper.GetDataTable(query).Rows.Count != 0)
            {
                e.Cancel = true;

                MessageBox.Show("Tên mặt hàng đã tồn tại, vui lòng nhập tên khác ! ", "Lỗi");
            }
        }

        private void buttonThemDaiLy_Click(object sender, EventArgs e)
        {
            if (ValidifyFields())
            {
                ThemMatHangEvent.Invoke(textBoxTenMatHangData.Text,
                    numericUpDownDonGiaData.Value,
                    textBoxDonViTinhData.Text);

                Close();
            }
        }
        
        // Check if fields is valid
        // Return true if valid and false otherwise
        private bool ValidifyFields()
        {
            if (textBoxTenMatHangData.Text == ""
                || textBoxDonViTinhData.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Lỗi");
                return false;
            }

            return true;
        }
    }
}
