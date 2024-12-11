using BussisnesLayer.Services.agentService;
using BussisnesLayer.Services.userService;
using CommonLayer.Entities;
using System.Data;

namespace PresentationLayer.forms.FormsAdmin
{
    public partial class FormClientAdmin : Form
    {
        private clientService _clientService;

        public FormClientAdmin()
        {
            InitializeComponent();
            _clientService = new clientService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            registerForm registerForm = new registerForm();
            registerForm.ShowDialog();
            LoadClients();
        }

        private void FormClientAdmin_Load(object sender, EventArgs e)
        {
            DataTable clients = _clientService.GetAllClients();

            dataGridViewClients.DataSource = clients;
            dataGridViewClients.Columns["Id"].Visible = false;
            dataGridViewClients.Columns["Password"].Visible = false;
            dataGridViewClients.Columns["IdRol"].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewClients.SelectedRows[0];

            Client client = new Client
            {
                IdClient = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                FirstName = selectedRow.Cells["FirstName"].Value.ToString(),
                LastName = selectedRow.Cells["LastName"].Value.ToString(),
                Email = selectedRow.Cells["Email"].Value.ToString(),
                Password = selectedRow.Cells["Password"].Value.ToString()
            };

            updateClientForm updateClientForm = new updateClientForm(client);
            updateClientForm.ShowDialog();
            LoadClients();
        }

        private void LoadClients()
        {
            var clients = _clientService.GetAllClients();
            dataGridViewClients.DataSource = null;
            dataGridViewClients.DataSource = clients;

            dataGridViewClients.Columns["Password"].Visible = false;
            dataGridViewClients.Columns["Id"].Visible = false;
            dataGridViewClients.Columns["IdRol"].Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el cliente seleccionado
            DataGridViewRow selectedRow = dataGridViewClients.CurrentRow;
            int clientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            // Confirmar la eliminación
            DialogResult dialogResult = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este cliente?",
                "Confirmación de eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Eliminar el cliente utilizando el servicio
                    _clientService.DeleteClient(clientId);

                    // Recargar los clientes en el DataGridView
                    LoadClients();

                    // Notificar al usuario
                    MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
