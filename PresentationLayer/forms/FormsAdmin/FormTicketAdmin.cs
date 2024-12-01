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

            dataGridViewTicket.Columns["IdCategorie"].Visible = false;
            dataGridViewTicket.Columns["IdTag"].Visible = false;
            dataGridViewTicket.Columns["IdAgent"].Visible = false;
            dataGridViewTicket.Columns["IdClient"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addTicket addTicket = new addTicket(_administrador);
            addTicket.ShowDialog();
            LoadTickets();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = new Ticket();

                if (dataGridViewTicket.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow selectedRow = dataGridViewTicket.SelectedRows[0];
                int ticketId = Convert.ToInt32(selectedRow.Cells["IdTicket"].Value);
                _TicketService.DeleteTicket(ticketId);
                MessageBox.Show("Ticket eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTickets();
            }
            catch
            {
                MessageBox.Show("Error al eliminar el ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadTickets()
        {
            var tickets = _TicketService.GetTickets();

            dataGridViewTicket.DataSource = null;

            dataGridViewTicket.DataSource = tickets;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
                categorie = Convert.ToInt32(selectedRow.Cells["IdCategorie"].Value),
                tag = Convert.ToInt32(selectedRow.Cells["IdTag"].Value),
                IdAgent = selectedRow.Cells["IdAgent"].Value == DBNull.Value ? (int?)null : Convert.ToInt32(selectedRow.Cells["IdAgent"].Value)
            };

            editTicket editTicket = new editTicket(_administrador, selectedTicket);
            editTicket.ShowDialog();
            LoadTickets();
        }
    }
}
