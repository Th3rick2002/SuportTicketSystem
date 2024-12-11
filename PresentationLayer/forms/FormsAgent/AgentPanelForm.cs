using BussisnesLayer.Services.agentService;
using BussisnesLayer.Services.TicketService;
using DataAccessLayer.Repositories;
using System.Data;

namespace PresentationLayer.forms
{
   
    public partial class AgentPanelForm : Form
    {
        private ticketService _TicketService;
        
        public AgentPanelForm()
        {
            InitializeComponent();
            _TicketService = new ticketService();
            LoadTicketData();

        }

        private void AgentPanelForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Asegurarse de que _TicketService no sea null
                if (_TicketService != null)
                {
                    LoadTicketData();
                }
                else
                {
                    MessageBox.Show("El servicio de tickets no está inicializado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tickets: " + ex.Message);
            }
        }

        public void LoadTicketData()
        {
            try
            {
                // Recargar los tickets desde el servicio
                var tickets = _TicketService.GetTickets();

                // Asignar la lista de tickets al DataGridView
                dataGridViewTickets.DataSource = tickets;

                // Ocultar columnas innecesarias
                foreach (var column in new[] { "IdCategorie", "IdTag", "IdAgent", "IdClient" })
                {
                    if (dataGridViewTickets.Columns.Contains(column))
                    {
                        dataGridViewTickets.Columns[column].Visible = false;
                    }
                }

                // Refrescar la vista del DataGridView
                dataGridViewTickets.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tickets: " + ex.Message);
            }
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
            // Aquí puedes implementar la lógica para iniciar un ticket si es necesario
        }


    }
}