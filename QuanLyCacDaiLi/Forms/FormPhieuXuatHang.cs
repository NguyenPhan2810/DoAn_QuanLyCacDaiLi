using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;

namespace QuanLyCacDaiLi
{
    public partial class FormPhieuXuatHang : Form
    {
        public FormPhieuXuatHang()
        {
            InitializeComponent();
        }

        private void FormPhieuXuatHang_Load(object sender, EventArgs e)
        {
            LoadTenDaiLyComboBox();
        }

        // Prepare TenDaiLy for users to pick from
        private void LoadTenDaiLyComboBox()
        {
            var dt = DatabaseHelper.GetDataTable("select TENDAILY from DAILY");

            object[] listData = new object[dt.Rows.Count];

            for(int i = 0; i < dt.Rows.Count; ++i)
                listData[i] = dt.Rows[i]["TENDAILY"];

            comboBoxTenDaiLyData.Items.AddRange(listData);
            comboBoxTenDaiLyData.SelectedIndex = 0;
        }



        private void dataGridViewMatHang_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridViewMatHang.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                DataGridViewTextBoxCell cellSoLuong = (DataGridViewTextBoxCell)dataGridViewMatHang[e.ColumnIndex, e.RowIndex];

                uint soluong = 0;
                if (cellSoLuong.EditedFormattedValue.ToString() != ""
                    && (!uint.TryParse(cellSoLuong.EditedFormattedValue.ToString(), out soluong)
                        || soluong == 0))
                {
                    e.Cancel = true;
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ", "Lỗi");
                }
            }
        }

        private void dataGridViewMatHang_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var columnName = dataGridViewMatHang.Columns[e.ColumnIndex].Name;
            if (columnName == "SoLuong")
            {
                var cellMatHang = (DataGridViewComboBoxCell)dataGridViewMatHang["MatHang", e.RowIndex];
                if (cellMatHang.Value is null)
                {
                    MessageBox.Show("Vui lòng chọn mặt hàng trước", "Lỗi");
                }
            }
            else if (columnName == "MatHang")
            {
                OptionForCellMatHang();
            }
        }

        private void buttonThemMatHang_Click(object sender, EventArgs e)
        {
            ThemMatHang();
        }

        private void buttonXoaMatHang_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewMatHang.SelectedRows;

            if (selectedRow.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 dòng để xoá.", "Thông báo");
                return;
            }

            for(int i = 0; i < selectedRow.Count; ++i)
            {
                dataGridViewMatHang.Rows.Remove(selectedRow[i]);
            }
        }

        private void ThemMatHang()
        {
            var dtTatCaMatHang = DatabaseHelper.GetDataTable("select TENMATHANG from MATHANG");

            // Check if any MatHang left
            if (dataGridViewMatHang.Rows.Count >= dtTatCaMatHang.Rows.Count)
            {
                MessageBox.Show("Không còn mặt hàng nào khác.", "Thông báo");
                return;
            }

            // Add another row
            dataGridViewMatHang.Rows.Add();
        }

        private void OptionForCellMatHang()
        {
            var dtTatCaMatHang = DatabaseHelper.GetDataTable("select TENMATHANG from MATHANG");

            // Only show options to leftover MatHang
            List<string> tenMatHangDaTontai = new List<string>(dataGridViewMatHang.Rows.Count);
            for (int i = 0; i < dataGridViewMatHang.Rows.Count; ++i)
            {
                var existedItem = dataGridViewMatHang["MatHang", i].Value;
                if (existedItem is null)
                {
                    continue;
                }

                tenMatHangDaTontai.Add(existedItem.ToString());
            }

            List<string> tenMatHang = new List<string>(dtTatCaMatHang.Rows.Count);
            for (int i = 0; i < dtTatCaMatHang.Rows.Count; ++i)
                tenMatHang.Add(dtTatCaMatHang.Rows[i]["TENMATHANG"].ToString());

            List<string> tenMatHangHopLe = tenMatHang.Except(tenMatHangDaTontai).ToList();
            DataGridViewComboBoxCell cellMatHang = (DataGridViewComboBoxCell)dataGridViewMatHang.CurrentCell;
            if (cellMatHang.Value != null)
            {
                tenMatHangHopLe.Add(cellMatHang.Value.ToString());
            }
            cellMatHang.DataSource = tenMatHangHopLe;
        }

    }
}
