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
            numericUpDown1.Value = GlobalConstants.MaxSoLuongDaiLyMoiQuan;
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            string querySoLuongDaiLyMax = @"
                    select MAX(soLuongDaiLy.SoLuongDaiLyMoiQuan) as SoLuongDaiLyMax
                    from(
                    select dsq.TENQ, COUNT(dl.TENDAILY) as SoLuongDaiLyMoiQuan
                    from DANHSACHQUAN as dsq left join DAILY as dl on dsq.TENQ = dl.QUAN
                    group by dsq.TENQ ) soLuongDaiLy
                    ";
            decimal dtSLDLMax = decimal.Parse(DatabaseHelper.GetDataTable(querySoLuongDaiLyMax).Rows[0][0].ToString());

            numericUpDown1.Minimum = dtSLDLMax;

        }
    }
}
