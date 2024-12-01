using BussisnesLayer.Services;
using BussisnesLayer.Services.categoryService;
using BussisnesLayer.Services.tagService;
using BussisnesLayer.Services.TicketService;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using FluentValidation.Results;
using PresentationLayer.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.forms
{
    public partial class AddTicketClient : Form
    {
        private ErrorProvider validationErrorTicketProvider = new ErrorProvider();
        private FormClient formClient;
        public Client _client;
        private ticketService _ticketService;
        private CategoryService _categoryService;
        private tagService _tagService;

        public AddTicketClient(FormClient formClient, ITicketRepository ticketRepository, Client client)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += AddTicketClient_Load;
            this.formClient = formClient;
            _client = client;
            _categoryService = new CategoryService();
            _tagService = new tagService();
            _ticketService = new ticketService();
        }


        private void AddTicketClient_Load(object? sender, EventArgs e)
        {
            validationErrorTicketProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            var priorities = new List<string> { "baja", "media", "alta" };
            comboBoxPriority.DataSource = priorities;
            comboBoxPriority.SelectedIndex = -1;

            var categories = _categoryService.GetAllCategories();
            var tags = _tagService.GetAllTags();

            comboBoxCategories.DataSource = categories;
            comboBoxCategories.DisplayMember = "NameCategorie";
            comboBoxCategories.ValueMember = "Id";
            comboBoxCategories.SelectedIndex = -1;

            comboBoxTags.DataSource = tags;
            comboBoxTags.DisplayMember = "NameTag";
            comboBoxTags.ValueMember = "Id";
            comboBoxTags.SelectedIndex = -1;
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
            ticket.IdClient = _client.IdClient;
            ticket.IdAgent = null;

            try
            {
                _ticketService.AddTicked(ticket);

                MessageBox.Show("El ticket ha sido creado exitosamente");
            }catch
            {
                MessageBox.Show("Ha ocurrido un error al crear el ticket");
            }

        }

        private void DisplayValidatorErrors(ValidationResult result)
        {
            validationErrorTicketProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Ticket.NameTicket):
                        validationErrorTicketProvider.SetError(nameTicketTextBox, error.ErrorMessage);
                        break;
                    case nameof(Ticket.DescriptionTicket):
                        validationErrorTicketProvider.SetError(DescriptionTicketTextBox, error.ErrorMessage);
                        break;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
