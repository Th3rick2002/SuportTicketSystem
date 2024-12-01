using CommonLayer.Entities;
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
        private administrador _administrador;

        public DashboardAdmin(administrador administrador)
        {
            _administrador = administrador;
            InitializeComponent();
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
            openChildForm(new FormClientAdmin(_administrador));
        }

        private void FormAdmin_AgentButton_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAgentAdmin());
        }

        private void FormAdmin_TicketsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTicketAdmin(_administrador));
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
