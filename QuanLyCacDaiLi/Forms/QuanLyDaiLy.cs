using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCacDaiLi
{
    public partial class QuanLyDaiLy : Form
    {
        private string findingName;
        private DataGridViewComboBoxColumn dataGridViewDanhSachDaiLy;

        public QuanLyDaiLy()
        {
            InitializeComponent();

            dataGridViewDanhSachDaiLy = new DataGridViewComboBoxColumn();
            groupBoxDataDaily.Contains((Control)dataGridViewDanhSachDaiLy);
        }

        private void TraCuuDaiLy_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {
            string query = @"select STT as 'Số thứ tự',
                                    TENDAILY as 'Tên đại lý',
                                    LOAI as 'Loại',
                                    QUAN as 'Quận',
                                    TIENNO as 'Tiền nợ' 
                             from DAILY";

            if (findingName != "" && findingName != null)
                query += $" where DAILY.TENDAILY like '%{findingName}%'";

            var dt = DatabaseHelper.GetDataTable(query);

            dataGridViewDanhSachDaiLy.DataSource = dt;

        }

        private void textBoxTimDaiLy_TextChanged(object sender, EventArgs e)
        {
            findingName = textBoxTimDaiLyData.Text;

            LoadTable();
        }
    }
}
