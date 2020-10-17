using PHPSales.Forms;
using System.Windows.Forms;

namespace PHPSales
{

    /// <summary>
    /// Defines the running application and manages open forms
    /// </summary>
    class PHPApplication : ApplicationContext
    {

        private Form currentForm;

        public static PHPApplication Instance { get; private set; }
        public bool IsAdmin { get; set; }

        public PHPApplication()
        {
            if (Instance != null) return;
            Instance = this;
            LoadForm(new LoginForm());
        }
        
        /// Closes the current open form and opens the new specified form
        public void LoadForm(Form form)
        {
            form.FormClosed += CurrentForm_FormClosed;
            form.Show();
            if (currentForm != null)
            {
                currentForm.FormClosed -= CurrentForm_FormClosed;
                currentForm.Close();
                currentForm.Dispose();
            }
            currentForm = form;
        }

        private void CurrentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExitThread();
        }

    }

}
