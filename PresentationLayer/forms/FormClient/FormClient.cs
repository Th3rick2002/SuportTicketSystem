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
        private TicketRepository _TicketRepository;
        private ticketService _TicketService;
        private Client _Client;

       
        public FormClient(Client client)
        {
            _Client = client;
            _TicketService = new ticketService();
            InitializeComponent();  
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
                loginForm.ResetLoginForm();
                loginForm.Show();
            }

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var formModal = new AddTicketClient(this, _TicketRepository, _Client)
            {
                
            };

            if (formModal.ShowDialog(this) == DialogResult.OK)
            {
                LoadTicketData();
            }
        }
    }
}
