﻿using System;
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
            FormProvider.GetFormLogIn().Close();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormProvider.GetFormLogIn().Show();
            FormProvider.GetFormMain().Hide();
        }

        public void SetAccountName(string accountName)
        {
            textBoxTitle.Text = $"Xin chào {accountName}";
            this.Text = accountName;
        }

        public void SetLevelOfAccess(LevelOfAccess loa)
        {
            levelOfAccess = loa;

            switch (levelOfAccess)
            {
                case LevelOfAccess.None:
                    break;
                case LevelOfAccess.Admin:

                    buttonTraCuuDaiLy.Visible = true;
                    buttonLapBaoCaoThang.Visible = true;
                    buttonLapPhieuXuatHang.Visible = true;
                    buttonLapHoaPhieuThuTien.Visible = true;
                    buttonThayDoiQuyDinh.Visible = true;

                    break;
                case LevelOfAccess.User:

                    buttonTraCuuDaiLy.Visible = false;
                    buttonLapBaoCaoThang.Visible = false;
                    buttonLapPhieuXuatHang.Visible = true;
                    buttonLapHoaPhieuThuTien.Visible = false;
                    buttonThayDoiQuyDinh.Visible = false;

                    break;
                default:
                    break;
            }
        }
    }
}
