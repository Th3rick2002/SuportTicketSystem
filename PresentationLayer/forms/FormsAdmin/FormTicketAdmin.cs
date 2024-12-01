using BussisnesLayer.Services.TicketService;
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
    public partial class FormTicketAdmin : Form
    {
        private administrador _administrador;
        private ticketService _TicketService;

        public FormTicketAdmin(administrador administrador)
        {
            _administrador = administrador;
            _TicketService = new ticketService();
            InitializeComponent();
        }

        private void FormTicketAdmin_Load(object sender, EventArgs e)
        {
            var tickets = _TicketService.GetTickets();

            dataGridViewTicket.DataSource = tickets;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addTicket addTicket = new addTicket(_administrador);
            addTicket.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();

            if (dataGridViewTicket.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewTicket.SelectedRows[0];

            Ticket selectedTicket = new Ticket
            {
                IdTicket = Convert.ToInt32(selectedRow.Cells["IdTicket"].Value),
                NameTicket = selectedRow.Cells["NameTicket"].Value?.ToString() ?? string.Empty,
                DescriptionTicket = selectedRow.Cells["DescriptionTicket"].Value?.ToString() ?? string.Empty,
                Priority = selectedRow.Cells["Priority"].Value?.ToString() ?? string.Empty,
                Status = selectedRow.Cells["Status"].Value?.ToString() ?? string.Empty,
                categorie = Convert.ToInt32(selectedRow.Cells["Categorie"].Value),  // Verifica que el nombre sea 'Categorie'
                tag = Convert.ToInt32(selectedRow.Cells["Tag"].Value),            // Verifica que el nombre sea 'Tag'
                IdClient = Convert.ToInt32(selectedRow.Cells["Client"].Value),    // Verifica que el nombre sea 'Client'
                IdAgent = selectedRow.Cells["Agent"].Value == DBNull.Value || selectedRow.Cells["Agent"].Value.ToString() == "Sin asignar"
                ? (int?)null
                : Convert.ToInt32(selectedRow.Cells["Agent"].Value)  // Verifica el valor de la celda de "Agent"
            };
            ProcessSelectedTicket(selectedTicket);
            //MessageBox.Show($"{selectedTicket}");

            //_TicketService.DeleteTicket(selectedTicket);
        }

        private void ProcessSelectedTicket(Ticket ticket)
        {
            // Procesar el objeto Ticket como desees
            MessageBox.Show($"Ticket seleccionado:\n" +
                             $"ID: {ticket.IdTicket}\n" +
                             $"Nombre: {ticket.NameTicket}\n" +
                             $"Descripción: {ticket.DescriptionTicket}\n" +
                             $"Prioridad: {ticket.Priority}\n" +
                             $"Estado: {ticket.Status}\n" +
                             $"Categoria: {ticket.categorie}\n" +
                             $"Tag: {ticket.tag}\n" +
                             $"Cliente ID: {ticket.IdClient}\n" +
                             $"Agente ID: {ticket.IdAgent?.ToString() ?? "N/A"}",
                             "Ticket Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
