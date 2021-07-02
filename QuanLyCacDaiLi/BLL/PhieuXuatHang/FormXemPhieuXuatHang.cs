using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCacDaiLi
{
    public partial class FormXemPhieuXuatHang : Form
    {
        public FormXemPhieuXuatHang()
        {
            InitializeComponent();
        }

        private void FormXemPhieuXuatHang_Load(object sender, EventArgs e)
        {
            var query = @"select 
                         MaPhieuXuat as 'Mã Phiếu Xuất',
                         TenDaiLy as 'Tên Đại Lý',
                         NgayLapPhieu as 'Ngày Lập Phiếu',
                         ThanhTien as 'Thành Tiền'
                         from DSPHIEUXUAT";

            var dt = DatabaseHelper.GetDataTable(query);

            dataGridViewDSPhieuXuat.DataSource = dt;
        }
    }
}
