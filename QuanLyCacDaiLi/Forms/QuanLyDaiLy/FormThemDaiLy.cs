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
        public delegate void ThemDaiLyDelegate(string tenDaiLy, string sdt, string quan, 
            string email, int loai, string diachi, DateTime ngaytiepnhan);
        public ThemDaiLyDelegate ThemDaiLyEvent;

        public FormThemDaiLy()
        {
            InitializeComponent();
        }

        private void FormThemDaiLy_Load(object sender, EventArgs e)
        {
            // Load danh sách quận dựa trên số lượng đại lý tối đa mỗi quận
            string query = @$"select dsq.TENQ
                              from DANHSACHQUAN as dsq left join DAILY as dl on dsq.TENQ = dl.QUAN
                              group by dsq.TENQ
                              having COUNT(dl.TENDAILY) < {GlobalConstants.MaxSoLuongDaiLyMoiQuan}";

            var dt = DatabaseHelper.GetDataTable(query);

            string[] dsTenQuan = new string[dt.Rows.Count];
            for(int i = 0; i < dsTenQuan.Length; ++i)
            {
                dsTenQuan[i] = dt.Rows[i][0].ToString();
            }

            comboBoxQuanData.DataSource = dsTenQuan;

            // Init index
            comboBoxQuanData.SelectedIndex = 0;
            comboBoxLoaiDaiLyData.SelectedIndex = 0;
        }

        private void textBoxTenDaiLyData_Leave(object sender, EventArgs e)
        {
            ValidifyTenDaiLy();
        }

        private void buttonThemDaiLy_Click(object sender, EventArgs e)
        {
            if (ValidifyFields())
            {
                ThemDaiLyEvent.Invoke(textBoxTenDaiLyData.Text,
                    textBoxSoDienThoaiData.Text,
                    comboBoxQuanData.Text,
                    textBoxEmailData.Text,
                    int.Parse(comboBoxLoaiDaiLyData.Text),
                    textBoxDiaChiData.Text,
                    dateTimePickerNgayTiepNhanData.Value);

                Close();
            }
        }

        // Check if fields is valid
        // Return true if valid and false otherwise
        private bool ValidifyFields()
        {
            if (textBoxTenDaiLyData.Text == "" ||
                textBoxSoDienThoaiData.Text == "" ||
                comboBoxQuanData.Text == "" ||
                textBoxEmailData.Text == "" ||
                textBoxDiaChiData.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Lỗi");
                return false;
            }   

            return true;
        }

        private bool ValidifyTenDaiLy()
        {
            string query = $"select TENDAILY from DAILY where TENDAILY = '{textBoxTenDaiLyData.Text}'";

            var dt = DatabaseHelper.GetDataTable(query);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tên đã bị trùng, vui lòng chọn tên khác ! ", "Lỗi");
                textBoxTenDaiLyData.Focus();
                return false;
            }

            return true;
        }
    }
}
