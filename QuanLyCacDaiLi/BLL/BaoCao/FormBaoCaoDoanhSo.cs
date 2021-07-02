using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCacDaiLi
{
    public partial class FormBaoCaoDoanhSo : Form
    {
        public FormBaoCaoDoanhSo()
        {
            InitializeComponent();
        }

        private void FormBaoCaoDoanhSo_Load(object sender, EventArgs e)
        {
            SetUpDate();
        }

        private void buttonLapBaoCao_Click(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void SetUpDate()
        {
            numericUpDownNam.Value = DateTime.Now.Year;
            numericUpDownThang.Value = DateTime.Now.Month;
        }

        private void LoadThongTin()
        {
            var query = $@"
                        select TenDaiLy, SoPhieuXuat, TongTriGia, (TongTriGia / SoPhieuXuat) as TyLe
                        from (
                            select DL.TENDAILY as TenDaiLy, COUNT(PX.MaPhieuXuat) as SoPhieuXuat, SUM(ThanhTien) as TongTriGia
                            from DAILY as DL left join DSPHIEUXUAT as PX on DL.TENDAILY = PX.TENDAILY
                            where month(PX.NgayLapPhieu) = {numericUpDownThang.Value} and year(PX.NgayLapPhieu) = {numericUpDownNam.Value}
                            group by DL.TENDAILY) tempTable";
            var dt = DatabaseHelper.GetDataTable(query);

            dataGridViewThongTin.Rows.Clear();
            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                var newRow = dataGridViewThongTin.Rows[dataGridViewThongTin.Rows.Add()];
                newRow.Cells[STT.Name].Value = i + 1;
                newRow.Cells[TenDaiLy.Name].Value = dt.Rows[i]["TenDaiLy"].ToString();
                newRow.Cells[SoPhieuXuat.Name].Value = dt.Rows[i]["SoPhieuXuat"].ToString();
                newRow.Cells[TongTriGia.Name].Value = dt.Rows[i]["TongTriGia"].ToString();
                newRow.Cells[TyLe.Name].Value = dt.Rows[i]["TyLe"].ToString();
            }

            return;
        }
    }
}
