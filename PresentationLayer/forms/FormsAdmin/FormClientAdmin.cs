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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Agent agent = new Agent();

                if (dataGridViewClients.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow selectedRow = dataGridViewClients.SelectedRows[0];
                int clientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                _clientService.DeleteClient(clientId);
                MessageBox.Show("Cliente eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClients();
            }
            catch
            {
                MessageBox.Show("Error al eliminar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
