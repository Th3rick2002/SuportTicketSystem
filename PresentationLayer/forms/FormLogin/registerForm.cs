using BussisnesLayer.Services.userService;
using CommonLayer.Entities;
using PresentationLayer.Validations.ValidationsUsers;
using FluentValidation.Results;

namespace PresentationLayer.forms
{
    public partial class registerForm : Form
    {
        private readonly clientService _clientService;
        private readonly ErrorProvider _errorProvider;
        public registerForm()
        {
            InitializeComponent();
            _clientService = new clientService();
            _errorProvider = errorProviderRegisterClient;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Crear instancia del cliente
            Client client = new Client
            {
                FirstName = textBoxName.Text,
                LastName = textBoxLastName.Text,
                Email = textBoxEmail.Text,
                Password = textBoxPasword.Text,
                VerifyPassword = textBoxVerifyPassword.Text // Este campo se debe agregar a la clase `Client`
            };

            // Validar cliente
            ClientValidator validator = new ClientValidator();
            ValidationResult results = validator.Validate(client);

            if (!results.IsValid)
            {
                DisplayValidationErrors(results);
                return;
            }

            // Verificar si el correo ya está registrado
            if (_clientService.VerifyEmailExist(client.Email))
            {
                MessageBox.Show("El correo ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insertar cliente
            _clientService.InsertClient(client);
            MessageBox.Show("Usuario registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void DisplayValidationErrors(ValidationResult results)
        {
            // Limpiar errores previos
            _errorProvider.Clear();

            foreach (var error in results.Errors)
            {
                Control? control = GetControlByPropertyName(error.PropertyName);
                if (control != null)
                {
                    _errorProvider.SetError(control, error.ErrorMessage);
                }
            }
        }
        //controladores de propiedades

        private Control? GetControlByPropertyName(string propertyName)
        {
            return propertyName switch
            {
                nameof(Client.FirstName) => textBoxName,
                nameof(Client.LastName) => textBoxLastName,
                nameof(Client.Email) => textBoxEmail,
                nameof(Client.Password) => textBoxPasword,
                nameof(Client.VerifyPassword) => textBoxVerifyPassword,
                _ => null
            };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

