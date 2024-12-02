using BussisnesLayer.Services.agentService;
using BussisnesLayer.Services.userService;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.forms.FormsAdmin
{
    public partial class addAgent : Form
    {
        private agentService _agentService;
        public addAgent()
        {
            InitializeComponent();
            _agentService = new agentService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();

            agent.FirstName = textBoxName.Text;
            agent.LastName = textBoxLastName.Text;
            agent.Email = textBoxEmail.Text;
            agent.Password = textBoxPasword.Text;

            if (agent.Password != textBoxVerifyPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            else if (_agentService.VerifyEmailExist(agent.Email))
            {
                MessageBox.Show("El correo ya esta registrado");
                return;
            }
            else
            {
                _agentService.InsertAgent(agent);

                MessageBox.Show("Usuario registrado exitosamente");
                this.Close();
            }
        }
    }
}
