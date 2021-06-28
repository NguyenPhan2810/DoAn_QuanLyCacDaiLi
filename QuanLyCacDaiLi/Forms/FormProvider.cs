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
                formMain = new FormMain();

            return formMain;
        }
        public static FormLogIn GetFormLogIn()
        {
            if (formLogIn == null)
                formLogIn = new FormLogIn();

            return formLogIn;
        }

        private static FormMain formMain = null;
        private static FormLogIn formLogIn = null;
    }
}
