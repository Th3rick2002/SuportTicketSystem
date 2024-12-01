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

namespace PresentationLayer.forms.FormsAdmin
{
    public partial class editTicket : Form
    {
        private administrador _administrador;
        private Ticket _ticket;
        private ticketService _ticketService;
        private CategoryService _categoryService;
        private tagService _tagService;
        private agentService _agentService;

        public editTicket(administrador administrador, Ticket ticket)
        {
            InitializeComponent();
            _administrador = administrador;
            _ticket = ticket;
            _categoryService = new CategoryService();
            _tagService = new tagService();
            _ticketService = new ticketService();
            _agentService = new agentService();
        }

        private void editTicket_Load(object sender, EventArgs e)
        {
            nameTicketTextBox.Text = _ticket.NameTicket;
            DescriptionTicketTextBox.Text = _ticket.DescriptionTicket;

            var priorities = new List<string> { "baja", "media", "alta" };
            comboBoxPriority.DataSource = priorities;
            comboBoxPriority.SelectedItem = _ticket.Priority;

            var categories = _categoryService.GetAllCategories();
            comboBoxCategories.DataSource = categories;
            comboBoxCategories.DisplayMember = "NameCategorie";
            comboBoxCategories.ValueMember = "Id";
            comboBoxCategories.SelectedValue = _ticket.categorie;

            var tags = _tagService.GetAllTags();
            comboBoxTags.DataSource = tags;
            comboBoxTags.DisplayMember = "NameTag";
            comboBoxTags.ValueMember = "Id";
            comboBoxTags.SelectedValue = _ticket.tag;

            DataTable agentsDataTable = _agentService.GetAllAgents();
            comboBoxAgent.DataSource = agentsDataTable;
            comboBoxAgent.DisplayMember = "FirstName";
            comboBoxAgent.ValueMember = "Id";

            if (_ticket.IdAgent != null && agentsDataTable.AsEnumerable().Any(row => row.Field<int>("Id") == _ticket.IdAgent))
            {
                comboBoxAgent.SelectedValue = _ticket.IdAgent;
            }
            else
            {
                comboBoxAgent.SelectedIndex = -1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                _ticket.NameTicket = nameTicketTextBox.Text;
                _ticket.DescriptionTicket = DescriptionTicketTextBox.Text;
                _ticket.Priority = comboBoxPriority.SelectedItem.ToString();
                _ticket.Status = "activo";
                _ticket.categorie = (int)comboBoxCategories.SelectedValue;
                _ticket.tag = (int)comboBoxTags.SelectedValue;

                DataRowView selectedAgent = (DataRowView)comboBoxAgent.SelectedItem;
                _ticket.IdAgent = (int)selectedAgent["Id"];

                _ticketService.UpdateTicketByAdmin(_ticket);

                MessageBox.Show("Ticket actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
