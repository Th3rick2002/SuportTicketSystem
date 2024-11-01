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
            
        }


    }
}
