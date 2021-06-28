using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLyCacDaiLi
{
    public partial class FormQuanLyDaiLy : Form
    {
        private string findingName;

        public FormQuanLyDaiLy()
        {
            InitializeComponent();
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
                             from DAILY ";

            if (findingName != "" && findingName != null)
                query += $"where DAILY.TENDAILY like '%{findingName}%'";

            var dt = DatabaseHelper.GetDataTable(query);

            dataGridViewDanhSachDaiLy.DataSource = dt;
        }

        private void textBoxTimDaiLy_TextChanged(object sender, EventArgs e)
        {
            findingName = textBoxTimDaiLyData.Text;

            LoadTable();
        }

        private void FormQuanLyDaiLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.GetFormMain().Show();
        }
    }
}
