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
    public partial class updateClientForm : Form
    {
        private Client _client;
        private clientService _clientService;
        public updateClientForm(Client client)
        {
            InitializeComponent();
            _client = client;
            _clientService = new clientService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _client.FirstName = textBoxName.Text;
                _client.LastName = textBoxLastName.Text;
                _client.Email = textBoxEmail.Text;
                _client.Password = textBoxPasword.Text;

                _clientService.UpdateClient(_client);
                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el Cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateClientForm_Load(object sender, EventArgs e)
        {
            textBoxName.Text = _client.FirstName;
            textBoxLastName.Text = _client.LastName;
            textBoxEmail.Text = _client.Email;
            textBoxPasword.Text = _client.Password;
            textBoxVerifyPassword.Text = _client.Password;


        }
    }
}
