using PresentationLayer.forms.FormsAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.forms.FormAgent
{
    public partial class DashboardAdmin : Form
    {

        public DashboardAdmin()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("Formulario DashboardAdmin inicializado");
        }

        private Form? activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            principalPictureBox.Controls.Add(childForm);
            principalPictureBox.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void Homebutton_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }
        private void AdminButton_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAdministrator());
        }

        private void FormAdmin_ClientButton_Click(object sender, EventArgs e)
        {
            openChildForm(new FormClientAdmin());
        }

        private void FormAdmin_AgentButton_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAgentAdmin());
        }

        private void FormAdmin_TicketsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTicketAdmin());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
