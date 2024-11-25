using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.forms
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.ResetLoginForm();
                loginForm.Show();
            }

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditTicket addEditTicket = new AddEditTicket();
            addEditTicket.ShowDialog();
        }
    }
}
