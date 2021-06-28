using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCacDaiLi
{
    // A singleton structure to provide forms
    class FormProvider
    {
        public static FormMain GetFormMain()
        {
            if (formMain == null)
            {
                formMain = new FormMain();
                formMain.FormClosed += (object sender, System.Windows.Forms.FormClosedEventArgs e) => formMain = null;
            }

            return formMain;
        }
        public static FormLogIn GetFormLogIn()
        {
            if (formLogIn == null)
            {
                formLogIn = new FormLogIn();
                formLogIn.FormClosed += (object sender, System.Windows.Forms.FormClosedEventArgs e) => formLogIn = null;
            }

            return formLogIn;
        }
        public static FormQuanLyDaiLy GetFormQuanLyDaiLy()
        {
            if (formQuanLyDaiLy == null)
            {
                formQuanLyDaiLy = new FormQuanLyDaiLy();
                formQuanLyDaiLy.FormClosed += (object sender, System.Windows.Forms.FormClosedEventArgs e) => formQuanLyDaiLy = null;
            }

            return formQuanLyDaiLy;
        }

        private static FormMain formMain = null;
        private static FormLogIn formLogIn = null;
        private static FormQuanLyDaiLy formQuanLyDaiLy = null;
    }
}
