using BussisnesLayer.Services;
using BussisnesLayer.Services.categoryService;
using BussisnesLayer.Services.tagService;
using BussisnesLayer.Services.TicketService;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using FluentValidation.Results;
using PresentationLayer.Validations;
using PresentationLayer.Validations.ValidationsClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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
        private TicketRepository _ticketRepository;
        private FormClient parentForm;

        public AddTicketClient(FormClient formClient, ITicketRepository ticketRepository, Client client)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += AddTicketClient_Load;
            this.formClient = formClient;
            this.parentForm = formClient;
            _client = client;
            _categoryService = new CategoryService();
            _tagService = new tagService();
            _ticketService = new ticketService();
            _ticketRepository = new TicketRepository();
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
            // Crear el objeto Ticket con los datos del formulario
            Ticket ticket = new Ticket
            {
                NameTicket = nameTicketTextBox.Text,
                DescriptionTicket = DescriptionTicketTextBox.Text,
                Priority = comboBoxPriority.SelectedItem?.ToString(),
                Status = "activo",
                categorie = comboBoxCategories.SelectedIndex != -1 ? (int)comboBoxCategories.SelectedValue : 0,
                tag = comboBoxTags.SelectedIndex != -1 ? (int)comboBoxTags.SelectedValue : 0,
                IdClient = _client.IdClient,
                IdAgent = null
            };

            // Validar ticket
            var validator = new TicketValidator();
            var validationResult = validator.Validate(ticket);

            if (!validationResult.IsValid)
            {
                DisplayValidatorErrors(validationResult);
                return;
            }

            try
            {
                // Llamar al servicio para agregar el ticket
                _ticketService.AddTicked(ticket);
                MessageBox.Show("El ticket ha sido creado exitosamente.");

                // Indicar que el formulario debe actualizar los tickets
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al crear el ticket: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var formModal = new AddTicketClient(parentForm, _ticketRepository, _client);
            if (formModal.ShowDialog(this) == DialogResult.OK)
            {
                LoadTicketData();
            }
        }


        private void LoadTicketData()
        {
            // Implementar lógica para cargar los datos actualizados.
        }
        private void DisplayValidatorErrors(ValidationResult result)
        {
            // Limpiar errores previos
            validationErrorTicketProvider.Clear();

            // Mostrar errores solo si hay fallos en la validación
            foreach (var error in result.Errors)
            {
                var control = GetControlByPropertyName(error.PropertyName);
                if (control != null)
                {
                    validationErrorTicketProvider.SetError(control, error.ErrorMessage);
                }
            }
        }

        // Obtiene el control asociado a una propiedad por nombre
        private Control? GetControlByPropertyName(string propertyName)
        {
            return propertyName switch
            {
                nameof(Ticket.NameTicket) => nameTicketTextBox,
                nameof(Ticket.DescriptionTicket) => DescriptionTicketTextBox,
                nameof(Ticket.Priority) => comboBoxPriority,
                nameof(Ticket.categorie) => comboBoxCategories,
                nameof(Ticket.tag) => comboBoxTags,
                _ => null
            };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
