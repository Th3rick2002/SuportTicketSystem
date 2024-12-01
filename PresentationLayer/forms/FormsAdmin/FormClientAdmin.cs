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

        }

        private void FormClientAdmin_Load(object sender, EventArgs e)
        {
            DataTable clients = _clientService.GetAllClients();

            dataGridViewAgents.DataSource = clients;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
