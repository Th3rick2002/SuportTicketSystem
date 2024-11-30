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

namespace PresentationLayer.forms
{
    public partial class registerForm : Form
    {
        private clientService clientService;
        public registerForm()
        {
            InitializeComponent();
            clientService = new clientService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();

            client.FirstName = textBoxName.Text;
            client.LastName = textBoxLastName.Text;
            client.Email = textBoxEmail.Text;
            client.Password = textBoxPasword.Text;
            
            if(client.Password != textBoxVerifyPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            else if (clientService.VerifyEmailExist(client.Email))
            {
                MessageBox.Show("El correo ya esta registrado");
                return;
            }
            else
            {
                clientService.InsertClient(client);

                MessageBox.Show("Usuario registrado exitosamente");
                this.Close();
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

