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
    public partial class registerAgentAdmin : Form
    {
        private agentService agentService;
        public registerAgentAdmin()
        {
            InitializeComponent();
            agentService = new agentService();
            
        }

        private void labelRegisterNewAgent_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAgent_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();

            agent.FirstName = textBoxNameAgent.Text;
            agent.LastName = textBoxLastNameAgent.Text;
            agent.Email = textBoxEmailAgent.Text;
            agent.Password = textBoxPaswordAgent.Text;

            if (agent.Password != textBoxVerifyPasswordAgent.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            else if (agentService.VerifyEmailExist(agent.Email))
            {
                MessageBox.Show("El correo ya esta registrado");
                return;
            }
            else
            {
                agentService.InsertAgent(agent);

                MessageBox.Show("Usuario registrado exitosamente");
                this.Close();
            }
        }
    }
}
