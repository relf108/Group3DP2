using System.Windows.Forms;

namespace PHPSales {

    public static class ExtentionMethods
    {

        public static void LoadForm(this Form currentForm, Form form)
        {
            PHPApplication.Instance.LoadForm(form);
        }

    }

}
