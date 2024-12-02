using BussisnesLayer.Services.userService;
using CommonLayer.Entities;

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

