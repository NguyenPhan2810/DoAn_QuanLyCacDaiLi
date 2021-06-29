using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCacDaiLi
{
    public partial class FormPhieuThuTien : Form
    {
        public FormPhieuThuTien()
        {
            InitializeComponent();
        }

        private void FormPhieuThuTien_Load(object sender, EventArgs e)
        {
            LoadDaiLyComboBox();
        }

        // Prepare TenDaiLy for users to pick from
        private void LoadDaiLyComboBox()
        {
            var dt = DatabaseHelper.GetDataTable("select TENDAILY from DAILY");

            object[] listData = new object[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; ++i)
                listData[i] = dt.Rows[i]["TENDAILY"];

            comboBoxDaiLyData.Items.AddRange(listData);
            comboBoxDaiLyData.SelectedIndex = 0;
        }

        private void comboBoxDaiLyData_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tenDaiLy = comboBoxDaiLyData.SelectedItem.ToString();

            var query = $@"select DIACHI, DIENTHOAI, EMAIL, TIENNO
                           from DAILY
                           where DAILY.TENDAILY = N'{tenDaiLy}'";

            var dt = DatabaseHelper.GetDataTable(query);

            var diaChi = dt.Rows[0]["DIACHI"].ToString();
            var dienThoai = dt.Rows[0]["DIENTHOAI"].ToString();
            var email = dt.Rows[0]["EMAIL"].ToString();
            var tienNo = dt.Rows[0]["TIENNO"].ToString();

            textBoxDiaChiData.Text = diaChi;
            textBoxDienThoaiData.Text = dienThoai;
            textBoxEmailData.Text = email;
            numericUpDownSoTienThu.Maximum = decimal.Parse(tienNo);
            numericUpDownSoTienThu.Value = numericUpDownSoTienThu.Maximum;
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            bool succeeded = false;
            decimal tienNoMoi = 0;
            try
            {// Lấy thông tin đại lý
                var tenDaiLy = comboBoxDaiLyData.SelectedItem.ToString();

                var queryThongTinDaiLy = $@"select TIENNO
                           from DAILY
                           where DAILY.TENDAILY = N'{tenDaiLy}'";

                var dt = DatabaseHelper.GetDataTable(queryThongTinDaiLy);

                var tienNo = dt.Rows[0]["TIENNO"].ToString();
                var maPhieuThu = DatabaseHelper.GetDataTable($"SELECT COUNT(MaPhieuThu) + 1 FROM DSPHIEUTHUTIEN").Rows[0][0].ToString();

                // Cập nhật phiếu thu
                var queryUpdatePhieuThu = $@"
                        INSERT DSPHIEUTHUTIEN
                        VALUES ({maPhieuThu},
                                N'{tenDaiLy}',
                                '{dateTimePickerNgayThuTienData.Value.ToString("yyyy'-'MM'-'dd")}',
                                10000)";
                DatabaseHelper.ExecuteQuery(queryUpdatePhieuThu);

                // Cập nhật tiền nợ
                tienNoMoi = decimal.Parse(tienNo) - numericUpDownSoTienThu.Value;
                var queryUpdateTienNo = $@"
                            update DAILY
                            set TIENNO = {tienNoMoi}
                            where DAILY.TENDAILY = N'{tenDaiLy}'";
                DatabaseHelper.ExecuteQuery(queryUpdateTienNo);

                succeeded = true;
            }
            catch (Exception ex)
            {
                succeeded = false;
                throw ex;
            }

            if (succeeded)
            {
                // Cập nhật tiền nợ
                numericUpDownSoTienThu.Maximum = tienNoMoi;

                MessageBox.Show("Thu tiền thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thu tiền thất bại ! ", "Lỗi");
            }
        }
    }
}
