using BussisnesLayer.Services.agentService;
using BussisnesLayer.Services.categoryService;
using BussisnesLayer.Services.tagService;
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

namespace PresentationLayer.forms
{
    public partial class addTicket : Form
    {
        private administrador _administrador;
        private ticketService _ticketService;
        private CategoryService _categoryService;
        private tagService _tagService;
        private agentService _agentService;
        public addTicket(administrador administrador)
        {
            InitializeComponent();
            _administrador = administrador;
            _categoryService = new CategoryService();
            _tagService = new tagService();
            _ticketService = new ticketService();
            _agentService = new agentService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();

            ticket.NameTicket = nameTicketTextBox.Text;
            ticket.DescriptionTicket = DescriptionTicketTextBox.Text;
            ticket.Priority = comboBoxPriority.SelectedItem.ToString();
            ticket.Status = "activo";
            ticket.categorie = (int)comboBoxCategories.SelectedValue;
            ticket.tag = (int)comboBoxTags.SelectedValue;
            ticket.IdClient = _administrador.Id;
            DataRowView selectedAgent = (DataRowView)comboBoxAgent.SelectedItem;
            ticket.IdAgent = (int)selectedAgent["Id"];

            try
            {
                _ticketService.AddTicked(ticket);

                MessageBox.Show("El ticket ha sido creado exitosamente");

                this.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al crear el ticket");
            }
        }

        private void addTicket_Load(object sender, EventArgs e)
        {

            var priorities = new List<string> { "baja", "media", "alta" };
            comboBoxPriority.DataSource = priorities;
            comboBoxPriority.SelectedIndex = -1;

            var categories = _categoryService.GetAllCategories();

            comboBoxCategories.DataSource = categories;
            comboBoxCategories.DisplayMember = "NameCategorie";
            comboBoxCategories.ValueMember = "Id";
            comboBoxCategories.SelectedIndex = -1;

            var tags = _tagService.GetAllTags();
            comboBoxTags.DataSource = tags;
            comboBoxTags.DisplayMember = "NameTag";
            comboBoxTags.ValueMember = "Id";
            comboBoxTags.SelectedIndex = -1;

            DataTable agentsDataTable = _agentService.GetAllAgents();
            comboBoxAgent.DataSource = agentsDataTable;
            comboBoxAgent.DisplayMember = "FirstName";
            comboBoxAgent.ValueMember = "Id";
            comboBoxAgent.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
