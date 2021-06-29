using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCacDaiLi
{
    // A singleton structure to provide forms
    class FormProvider
    {

        public static Form GetForm(Type classType)
        {
            if (formStorage.ContainsKey(classType))
            {
                return formStorage[classType];
            }

            Form newForm = null;
            if (classType == typeof(FormMain))
            {
                newForm = new FormMain();
                newForm.FormClosed += (object sender, System.Windows.Forms.FormClosedEventArgs e) => formStorage.Remove(typeof(FormMain));
            }
            else if (classType == typeof(FormLogIn))
            {
                newForm = new FormLogIn();
                newForm.FormClosed += (object sender, System.Windows.Forms.FormClosedEventArgs e) => formStorage.Remove(typeof(FormLogIn));
            }
            else if (classType == typeof(FormQuanLyDaiLy))
            {
                newForm = new FormQuanLyDaiLy();
                newForm.FormClosed += (object sender, System.Windows.Forms.FormClosedEventArgs e) => formStorage.Remove(typeof(FormQuanLyDaiLy));
            }
            else if (classType == typeof(FormPhieuXuatHang))
            {
                newForm = new FormPhieuXuatHang();
                newForm.FormClosed += (object sender, System.Windows.Forms.FormClosedEventArgs e) => formStorage.Remove(typeof(FormPhieuXuatHang));
            }
            else 
                return null;

            
            formStorage[classType] = newForm;
            return newForm;
        }

        private static Dictionary<Type, Form> formStorage = new Dictionary<Type, Form>();
    }
}
