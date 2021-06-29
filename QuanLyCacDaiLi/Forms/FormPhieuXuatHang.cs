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

        private void dataGridViewMatHang_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMatHang.Columns[e.ColumnIndex].Name == MatHang.Name)
            {
                // Lấy thông tin đơn vị tính và đơn giá
                DataGridViewComboBoxCell cellMatHang = (DataGridViewComboBoxCell)dataGridViewMatHang[e.ColumnIndex, e.RowIndex];

                if (cellMatHang.Value != null)
                {
                    var dtMatHang = DatabaseHelper.GetDataTable("select TENMATHANG, DONGIA, DONVITINH from MATHANG");

                    for (int i = 0; i < dtMatHang.Rows.Count; ++i)
                    {
                        if (dtMatHang.Rows[i][dtMatHang.Columns["TENMATHANG"]].ToString() == cellMatHang.Value.ToString())
                        {
                            dataGridViewMatHang[DonViTinh.Name, e.RowIndex].Value = dtMatHang.Rows[i][dtMatHang.Columns["DONVITINH"]].ToString();
                            dataGridViewMatHang[DonGia.Name, e.RowIndex].Value = dtMatHang.Rows[i][dtMatHang.Columns["DONGIA"]].ToString();

                            break;
                        }
                    }

                    // Tính thành tiền
                    TinhThanhTien(e.RowIndex);
                }
            }
            else if (dataGridViewMatHang.Columns[e.ColumnIndex].Name == SoLuong.Name)
            {
                // Tính thành tiền
                TinhThanhTien(e.RowIndex);
            }
        }

        private void dataGridViewMatHang_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridViewMatHang.Columns[e.ColumnIndex].Name == SoLuong.Name)
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
            if (columnName == SoLuong.Name)
            {
                var cellMatHang = (DataGridViewComboBoxCell)dataGridViewMatHang[MatHang.Name, e.RowIndex];
                if (cellMatHang.Value is null)
                {
                    MessageBox.Show("Vui lòng chọn mặt hàng trước", "Lỗi");
                }
            }
            else if (columnName == MatHang.Name)
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
            XoaMatHang();
        }

        private void buttonXuatPhieu_Click(object sender, EventArgs e)
        {
            XuatPhieu();
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

            dataGridViewMatHang["STT", dataGridViewMatHang.Rows.Count - 1].Value = dataGridViewMatHang.Rows.Count;
        }

        private void XoaMatHang()
        {
            var selectedRow = dataGridViewMatHang.SelectedRows;

            if (selectedRow.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 dòng để xoá.", "Thông báo");
                return;
            }

            int lastSelectedRow = selectedRow[selectedRow.Count - 1].Index;

            for (int i = 0; i < selectedRow.Count; ++i)
            {
                dataGridViewMatHang.Rows.Remove(selectedRow[i]);
            }

            // Reassign STT
            for(int i = lastSelectedRow; i < dataGridViewMatHang.Rows.Count; ++i)
            {
                dataGridViewMatHang["STT", i].Value = i + 1;
            }
        }

        private void OptionForCellMatHang()
        {
            var dtTatCaMatHang = DatabaseHelper.GetDataTable("select TENMATHANG from MATHANG");

            // Only show options to leftover MatHang
            List<string> tenMatHangDaTontai = new List<string>(dataGridViewMatHang.Rows.Count);
            for (int i = 0; i < dataGridViewMatHang.Rows.Count; ++i)
            {
                var existedItem = dataGridViewMatHang[MatHang.Name, i].Value;
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

        private void TinhThanhTien(int rowIndex)
        {

            var cellSoLuong = (DataGridViewTextBoxCell)dataGridViewMatHang[SoLuong.Name, rowIndex];
            var cellDonGia = (DataGridViewTextBoxCell)dataGridViewMatHang[DonGia.Name, rowIndex];

            if (cellSoLuong.Value == null || cellDonGia == null)
            {
                return;
            }

            var cellThanhTien = (DataGridViewTextBoxCell)dataGridViewMatHang[ThanhTien.Name, rowIndex];

            cellThanhTien.Value = uint.Parse(cellSoLuong.Value.ToString()) * uint.Parse(cellDonGia.Value.ToString());
        }


        private void XuatPhieu()
        {
            // Kiểm tra điều kiện
            // Kiểm tra datagrid có dữ liệu không
            if (dataGridViewMatHang.Rows.Count <= 0)
            {
                MessageBox.Show($"Vui lòng thêm mặt hàng", "Lỗi");
                return;
            }
            // Kiểm tra datagrid có đầy đủ dữ liệu không
            for (int j = 0; j < dataGridViewMatHang.Columns.Count; ++j)
            {
                for (int i = 0; i < dataGridViewMatHang.Rows.Count; ++i)
                {
                    if (dataGridViewMatHang[j, i].Value is null)
                    {
                        MessageBox.Show($"Vui lòng điền đầy đủ mặt hàng", "Lỗi");
                        return;
                    }
                }
            }

            // Kiểm tra tiền nợ
            uint tongThanhTien = 0;

            for (int i = 0; i < dataGridViewMatHang.Rows.Count; ++i)
                tongThanhTien += uint.Parse(dataGridViewMatHang[ThanhTien.Name, i].Value.ToString());

            var query = @$"select LOAIDAILY.LOAI, TIENNO, TIENNOMAX 
                           from DAILY join LOAIDAILY on DAILY.LOAI = LOAIDAILY.LOAI
                           where DAILY.TENDAILY = '{comboBoxTenDaiLyData.SelectedItem.ToString()}'";
            var dtDaiLyJoinLoaiDaiLy = DatabaseHelper.GetDataTable(query);

            uint tienNo = uint.Parse(dtDaiLyJoinLoaiDaiLy.Rows[0]["TIENNO"].ToString()) + tongThanhTien;

            var loai = uint.Parse(dtDaiLyJoinLoaiDaiLy.Rows[0]["LOAI"].ToString());

            var hanMuc = uint.Parse(dtDaiLyJoinLoaiDaiLy.Rows[0]["TIENNOMAX"].ToString());

            if (tienNo > hanMuc)
            {
                MessageBox.Show($"Số tiền nợ đã vượt quá hạn mức {tienNo - hanMuc} đồng", "Lỗi");
                return;
            }


            // Có thể xuất phiếu
            bool succeeded = false;
            try
            {
                // Cập nhật tiền nợ
                DatabaseHelper.ExecuteQuery($"update DAILY set TIENNO = {tienNo} where DAILY.TENDAILY = '{comboBoxTenDaiLyData.SelectedItem.ToString()}'");

                var maPhieuXuat = 1 + uint.Parse(DatabaseHelper.GetDataTable("SELECT COUNT(MaPhieuXuat) FROM DSPHIEUXUAT").Rows[0].ItemArray[0].ToString());
                var tenDaiLy = comboBoxTenDaiLyData.SelectedItem.ToString();
                var ngayLapPhieu = dateTimePickerNgayLapPhieuData.Value.ToString("yyyy'-'MM'-'dd");
                // Cập nhật danh sách phiếu xuất
                DatabaseHelper.ExecuteQuery($@"INSERT DSPHIEUXUAT
                                               VALUES ({maPhieuXuat},
                                               N'{tenDaiLy}',
                                               '{ngayLapPhieu}',
                                               {tongThanhTien})
                                               ");

                // Cập nhật danh sách mặt hàng đã bán
                for (int i = 0; i < dataGridViewMatHang.Rows.Count; ++i)
                {
                    var tenMatHang = dataGridViewMatHang[MatHang.Name, i].Value.ToString();
                    var soLuong = dataGridViewMatHang[SoLuong.Name, i].Value.ToString();
                    var donGia = dataGridViewMatHang[DonGia.Name, i].Value.ToString();
                    var donViTinh = dataGridViewMatHang[DonViTinh.Name, i].Value.ToString();

                    query = $@"
                                INSERT DSMATHANGDABAN
                                VALUES ({maPhieuXuat},
                                N'{tenDaiLy}',
                                N'{tenMatHang}',
                                '{ngayLapPhieu}',
                                {soLuong},
                                {donGia},
                                N'{donViTinh}')
                            ";
                    DatabaseHelper.ExecuteQuery(query);
                }

                succeeded = true;
            }
            catch
            {
                succeeded = false;
                throw;
            }
            
            if (succeeded)
            {
                MessageBox.Show("Đã xuất phiếu thành công.", "Thông báo");

                dataGridViewMatHang.Rows.Clear();
            }
        }
    }
}
