using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCacDaiLi
{
    public partial class FormBaoCaoCongNoDaiLy : Form
    {
        public FormBaoCaoCongNoDaiLy()
        {
            InitializeComponent();
        }

        private void FormBaoCaoCongNoDaiLy_Load(object sender, EventArgs e)
        {
            SetUpDate();
        }

        private void SetUpDate()
        {
            numericUpDownNam.Value = DateTime.Now.Year;
            numericUpDownThang.Value = DateTime.Now.Month;
        }

        private void buttonLapBaoCao_Click(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void LoadThongTin()
        {

            var queryTongTienNo = $@"
select DL.TENDAILY, (ISNULL(tempTongTienNo2.TongTienNo, 0) -  ISNULL(tempTongTienTra.TongTienTra, 0)) as TongTienNo
from DAILY as DL 
left join 
(
	select TenDaiLy, SUM(ThanhTien) as TongTienNo
	from(
		select * from DSPHIEUXUAT as PX where PX.NgayLapPhieu < '{numericUpDownNam.Value.ToString()}-{numericUpDownThang.Value.ToString()}-01'
	) tempTongTienNo
	group by TenDaiLy
) tempTongTienNo2 on tempTongTienNo2.TenDaiLy = DL.TENDAILY 
left join
(
select TenDaiLy, SUM(SoTienThu) as TongTienTra
from(
	select * from DSPHIEUTHUTIEN as PT where PT.NgayThuTien < '{numericUpDownNam.Value.ToString()}-{numericUpDownThang.Value.ToString()}-01'
) tempTongTienTra
group by TenDaiLy
) tempTongTienTra on tempTongTienTra.TenDaiLy = DL.TENDAILY";

            var queryTienNoTrongThang = $@"
select DL.TENDAILY, (ISNULL(tempTongTienNo2.TienNoTrongThang, 0) -  ISNULL(tempTongTienTra.TienTraTrongThang, 0)) as TienNoTrongThang
from DAILY as DL 
left join 
(
	select TenDaiLy, SUM(ThanhTien) as TienNoTrongThang
	from(
		select * from DSPHIEUXUAT as PX 
		where year(PX.NgayLapPhieu) = {numericUpDownNam.Value.ToString()}
		and month(PX.NgayLapPhieu) = {numericUpDownThang.Value.ToString()}
	) tempTongTienNo
	group by TenDaiLy
) tempTongTienNo2 on tempTongTienNo2.TenDaiLy = DL.TENDAILY 
left join
(
select TenDaiLy, SUM(SoTienThu) as TienTraTrongThang
from(
	select * from DSPHIEUTHUTIEN as PT
		where year(PT.NgayThuTien) = {numericUpDownNam.Value.ToString()}
		and month(PT.NgayThuTien) = {numericUpDownThang.Value.ToString()}
) tempTongTienTra
group by TenDaiLy
) tempTongTienTra on tempTongTienTra.TenDaiLy = DL.TENDAILY";

            var dtTongTienNo = DatabaseHelper.GetDataTable(queryTongTienNo);
            var dtTienNoTrongThang = DatabaseHelper.GetDataTable(queryTienNoTrongThang);

            dataGridViewThongTin.Rows.Clear();
            for (int i = 0; i < dtTongTienNo.Rows.Count; ++i)
            {
                var tenDaiLy = dtTongTienNo.Rows[i]["TenDaiLy"].ToString();
                var noDau = int.Parse(dtTongTienNo.Rows[i]["TongTienNo"].ToString());
                var tienNoTrongThang = int.Parse(dtTienNoTrongThang.Rows[i]["TienNoTrongThang"].ToString());

                var newRow = dataGridViewThongTin.Rows[dataGridViewThongTin.Rows.Add()];
                newRow.Cells[STT.Name].Value = i + 1;
                newRow.Cells[TenDaiLy.Name].Value = tenDaiLy;
                newRow.Cells[NoDau.Name].Value = noDau;
                newRow.Cells[PhatSinh.Name].Value = tienNoTrongThang;
                newRow.Cells[NoCuoi.Name].Value = noDau + tienNoTrongThang;
            }

            return;
        }
    }
}
