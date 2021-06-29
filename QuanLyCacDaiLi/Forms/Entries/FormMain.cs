using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCacDaiLi
{
    public enum LevelOfAccess
    {
        None = 0,
        Admin = 1,
        User = 2
    }

    public partial class FormMain : Form
    {
        // LevelOfAccess = 1 means admin and 2 means user
        private LevelOfAccess levelOfAccess = LevelOfAccess.None;

        public FormMain()
        {
            InitializeComponent();

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.GetForm(typeof(FormLogIn)).Close();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormProvider.GetForm(typeof(FormLogIn)).Show();
            FormProvider.GetForm(typeof(FormMain)).Hide();
            FormProvider.GetForm(typeof(FormPhieuXuatHang)).Hide();
            FormProvider.GetForm(typeof(FormQuanLyDaiLy)).Hide();
        }

        public void SetAccountName(string accountName)
        {
            textBoxTitle.Text = $"Xin chào {accountName}";
            this.Text = accountName;
        }

        private void buttonQuanLyDaiLy_Click(object sender, EventArgs e)
        {
            FormProvider.GetForm(typeof(FormQuanLyDaiLy)).Show();
        }

        private void buttonLapPhieuXuatHang_Click(object sender, EventArgs e)
        {
            FormProvider.GetForm(typeof(FormPhieuXuatHang)).Show();
        }

        private void buttonLapHoaPhieuThuTien_Click(object sender, EventArgs e)
        {
            FormProvider.GetForm(typeof(FormPhieuThuTien)).Show();
        }

        private void buttonLapBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            FormProvider.GetForm(typeof(FormBaoCaoDoanhSo)).Show();
        }

        private void buttonLapBaoCaoCongNoDaiLy_Click(object sender, EventArgs e)
        {
            FormProvider.GetForm(typeof(FormBaoCaoCongNoDaiLy)).Show();
        }

        public void SetLevelOfAccess(LevelOfAccess loa)
        {
            levelOfAccess = loa;

            switch (levelOfAccess)
            {
                case LevelOfAccess.None:
                    break;
                case LevelOfAccess.Admin:
                    buttonQuanLyDaiLy.Visible = true;
                    buttonLapPhieuXuatHang.Visible = true;
                    buttonLapHoaPhieuThuTien.Visible = true;
                    buttonThayDoiQuyDinh.Visible = true;
                    buttonLapBaoCaoCongNoDaiLy.Visible = true;
                    buttonLapBaoCaoDoanhSo.Visible = true;
                    break;

                case LevelOfAccess.User:
                    buttonQuanLyDaiLy.Visible = false;
                    buttonLapPhieuXuatHang.Visible = true;
                    buttonLapHoaPhieuThuTien.Visible = false;
                    buttonThayDoiQuyDinh.Visible = false;
                    buttonLapBaoCaoCongNoDaiLy.Visible = false;
                    buttonLapBaoCaoDoanhSo.Visible = false;
                    break;

                default:
                    break;
            }
        }
    }
}
