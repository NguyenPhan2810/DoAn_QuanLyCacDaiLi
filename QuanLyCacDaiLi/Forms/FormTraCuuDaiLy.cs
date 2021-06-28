using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCacDaiLi
{
    public partial class FormTraCuuDaiLy : Form
    {
        private string findingName;

        public FormTraCuuDaiLy()
        {
            InitializeComponent();
        }

        private void TraCuuDaiLy_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {
            string query = "select STT, TENDAILY, LOAI, QUAN, TIENNO "
                          + "from DAILY ";

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
    }
}
