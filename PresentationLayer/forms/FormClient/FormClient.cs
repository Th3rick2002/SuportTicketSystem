using BussisnesLayer.Services;
using BussisnesLayer.Services.TicketService;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;
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
    public partial class FormClient : Form
    {
        private ticketService _TicketService;
        private Client _Client;
        private ITicketRepository _TicketRepository;
        private FormClient parentForm;

        public FormClient(Client client)
        {
            _Client = client;
            _TicketService = new ticketService();
            _TicketRepository = new TicketRepository();
            InitializeComponent();
            LoadTicketData();
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var formModal = new AddTicketClient(this, _TicketRepository, _Client);

            // Si el formulario de agregar ticket se cierra correctamente, recargar los datos
            if (formModal.ShowDialog(this) == DialogResult.OK)
            {
                LoadTicketData();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
