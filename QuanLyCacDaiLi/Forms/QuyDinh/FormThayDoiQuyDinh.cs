using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCacDaiLi
{
    public partial class FormThayDoiQuyDinh : Form
    {
        public FormThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void FormThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            numericUpDownSoDaiLyMaxData.Value = GlobalConstants.MaxSoLuongDaiLyMoiQuan;

            LoadLoaiDaiLy();
        }

        private void numericUpDownSoDaiLyMaxData_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDownSoDaiLyMaxData_ValueChanged(object sender, EventArgs e)
        {
            string querySoLuongDaiLyMax = @"
                    select MAX(soLuongDaiLy.SoLuongDaiLyMoiQuan) as SoLuongDaiLyMax
                    from(
                    select dsq.TENQ, COUNT(dl.TENDAILY) as SoLuongDaiLyMoiQuan
                    from DANHSACHQUAN as dsq left join DAILY as dl on dsq.TENQ = dl.QUAN
                    group by dsq.TENQ ) soLuongDaiLy
                    ";
            decimal dtSLDLMax = decimal.Parse(DatabaseHelper.GetDataTable(querySoLuongDaiLyMax).Rows[0][0].ToString());

            numericUpDownSoDaiLyMaxData.Minimum = dtSLDLMax;

            buttonXacNhanSoDaiLyMax.Enabled = numericUpDownSoDaiLyMaxData.Value != GlobalConstants.MaxSoLuongDaiLyMoiQuan;
        }

        private void buttonXacNhanSoDaiLyMax_Click(object sender, EventArgs e)
        {
            GlobalConstants.MaxSoLuongDaiLyMoiQuan = (uint)numericUpDownSoDaiLyMaxData.Value;
            buttonXacNhanSoDaiLyMax.Enabled = false;
        }

        private void buttonThemLoaiDaiLy_Click(object sender, EventArgs e)
        {
            int loai = 1 + int.Parse(dataGridViewLoaiDaiLy[LoaiDaiLy.Name, dataGridViewLoaiDaiLy.Rows.Count - 1].Value.ToString());
            int tienNo = 0;
            AddRowDataGridViewLoaiDaiLy(loai.ToString(), tienNo.ToString());

            DatabaseHelper.ExecuteQuery($"INSERT INTO LOAIDAILY VALUES({loai.ToString()}, {tienNo.ToString()})");
        }

        // Chỉ được xoá khi không có đại lý nào có loại này
        private void buttonXoaLoaiDaiLy_Click(object sender, EventArgs e)
        {
            if (dataGridViewLoaiDaiLy.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 dòng để xoá.", "Thông báo");
                return;
            }

            string message = $"Bạn có chắc muốn xoá {dataGridViewLoaiDaiLy.SelectedRows.Count} loại đại lý?";
            DialogResult dialogResult = MessageBox.Show(message, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // XOÁ!
                List<string> loaiDaiLyKhongTheXoa = new List<string>();
                for (int i = 0; i < dataGridViewLoaiDaiLy.SelectedRows.Count; ++i)
                {
                    var loaiDaiLy = dataGridViewLoaiDaiLy.SelectedRows[i].Cells[LoaiDaiLy.Name].Value.ToString();

                    if (DatabaseHelper.GetDataTable($"select dl.LOAI from DAILY as dl where dl.LOAI = {loaiDaiLy}").Rows.Count == 0)
                    {
                        DatabaseHelper.ExecuteQuery($"delete from LOAIDAILY where LOAI = {loaiDaiLy}");

                        dataGridViewLoaiDaiLy.Rows.Remove(dataGridViewLoaiDaiLy.SelectedRows[i]);

                        i--;
                    }
                    else
                    {
                        loaiDaiLyKhongTheXoa.Add(loaiDaiLy);
                    }
                }

                if (loaiDaiLyKhongTheXoa.Count > 0)
                {
                    var thongbaoKhongTheXoa = "Không thể xoá loại ";
                    for(int i = 0; i < loaiDaiLyKhongTheXoa.Count; ++i)
                    {
                        thongbaoKhongTheXoa += loaiDaiLyKhongTheXoa[i];
                        if (i != loaiDaiLyKhongTheXoa.Count - 1)
                            thongbaoKhongTheXoa += ", ";
                    }
                    thongbaoKhongTheXoa += " vì tồn tại đại lý loại này ! ";

                    MessageBox.Show(thongbaoKhongTheXoa, "Lỗi");
                }
            }
        }

        private void LoadLoaiDaiLy()
        {
            string query = "select LOAI, TIENNOMAX from LOAIDAILY";
            var dt = DatabaseHelper.GetDataTable(query);

            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                AddRowDataGridViewLoaiDaiLy(dt.Rows[i]["LOAI"].ToString(), dt.Rows[i]["TIENNOMAX"].ToString());
            }
        }

        private void AddRowDataGridViewLoaiDaiLy(string loai, string tienNoMax)
        {
            var newRow = dataGridViewLoaiDaiLy.Rows[dataGridViewLoaiDaiLy.Rows.Add()];

            newRow.Cells[LoaiDaiLy.Name].Value = loai;
            newRow.Cells[TienNoMax.Name].Value = tienNoMax;
        }

        private void dataGridViewLoaiDaiLy_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridViewLoaiDaiLy.Columns[e.ColumnIndex].Name == TienNoMax.Name)
            {
                // Kiểm tra tiền nợ hợp lệ
                DataGridViewTextBoxCell tienNoMax = (DataGridViewTextBoxCell)dataGridViewLoaiDaiLy[e.ColumnIndex, e.RowIndex];

                uint tienNo = 0;
                if (tienNoMax.EditedFormattedValue.ToString() != ""
                    && (!uint.TryParse(tienNoMax.EditedFormattedValue.ToString(), out tienNo)))
                {
                    e.Cancel = true;
                    MessageBox.Show("Vui lòng nhập đúng tiền nợ hợp lệ", "Lỗi");
                }
            }
        }

        private void dataGridViewLoaiDaiLy_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLoaiDaiLy.Columns[e.ColumnIndex].Name == TienNoMax.Name)
            {
                var cellTienNo = dataGridViewLoaiDaiLy[e.ColumnIndex, e.RowIndex];
                var cellLoaiDaiLy = dataGridViewLoaiDaiLy[LoaiDaiLy.Name, e.RowIndex];

                // Cập nhật tiền nợ

                DatabaseHelper.ExecuteQuery($"update LOAIDAILY set TIENNOMAX = {cellTienNo.Value.ToString()} where LOAI = {cellLoaiDaiLy.Value.ToString()}");
            }
        }
    }
}
