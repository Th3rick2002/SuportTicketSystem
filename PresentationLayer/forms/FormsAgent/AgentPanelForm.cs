using BussisnesLayer.Services.TicketService;
using DataAccessLayer.Repositories;

namespace PresentationLayer.forms
{
    public partial class AgentPanelForm : Form
    {
        private TicketRepository _TicketRepository;
        private ticketService _TicketService;
        public AgentPanelForm()
        {
            InitializeComponent();
            _TicketService = new ticketService();
            LoadTicketData();

        }


        public void LoadTicketData()
        {
            var tickets = _TicketService.GetTickets();

            dataGridViewTickets.DataSource = tickets;
            dataGridViewTickets.Refresh();
        }






        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.ResetLoginForm(); // Restablece los campos del login
                loginForm.Show();
            }

            // Cerrar el formulario de agentes
            this.Close();
        }

        private void StartTicket_Click(object sender, EventArgs e)
        {

        }
    }
}