using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCacDaiLi
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            DatabaseHelper.Init();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPasswordData.PasswordChar = '\0';
            }
            else
            {
                textBoxPasswordData.PasswordChar = '*';
            }
        }

        private void textBoxUsernameData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 /* Enter key */)
            {
                LogIn();
            }
        }

        private void textBoxPasswordData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 /* Enter key */)
            {
                LogIn();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void LogIn()
        {
            var username = textBoxUsernameData.Text;
            var password = textBoxPasswordData.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Lỗi");
                return;
            }

            var dt = DatabaseHelper.GetDataTable("Select * from PHANQUYEN where TaiKhoan = '" + username + "' and MatKhau = '" + password + "'");
            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0].ItemArray;
                var formMain = FormProvider.GetForm(typeof(FormMain)) as FormMain;
                formMain.SetLevelOfAccess((LevelOfAccess)row[row.Length - 1]);
                formMain.SetAccountName((string)row[1]);
                formMain.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Lỗi");
                textBoxUsernameData.Focus();
            }
        }
    }
}
