using BussisnesLayer.Services;
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
        public bool editMode = false;
        private TicketService _ticketService;

        public Ticket Ticket { get; set; }
        public Ticket TicketData { get; set; }

        private ErrorProvider validationErrorTicketProvider = new ErrorProvider();
        private FormClient formClient;

        public AddTicketClient(FormClient formClient, ITicketRepository ticketRepository)
        {
            InitializeComponent();
            TicketData = new Ticket();
            Ticket = new Ticket();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += AddTicketClient_Load;
            _ticketService = new TicketService();
            this.formClient = formClient;
        }


        private void AddTicketClient_Load(object? sender, EventArgs e)
        {
            if (editMode)
            {
                Labeladdicket.Text = "Editar Ticket";
            }
            else
            {
                Labeladdicket.Text = "Agregar Ticket";
            }
            validationErrorTicketProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (editMode)
            {
                string nameTicket = nameTicketTextBox.Text;
                string descriptionTicket = DescriptionTicketTextBox.Text;


                Ticket ticket = new Ticket()
                {
                    NameTicket = nameTicket,
                    DescriptionTicket = descriptionTicket
                };

                _ticketService.UpdateTicketByAdmin(ticket);
                this.DialogResult = DialogResult.OK;
                editMode = false;
            }
            else
            {
                Ticket ticket = new Ticket();
                ticket.NameTicket = nameTicketTextBox.Text;
                ticket.DescriptionTicket = DescriptionTicketTextBox.Text;

                TicketValidator ticketValidator = new TicketValidator();
                ValidationResult result = ticketValidator.Validate(ticket);

                if (!result.IsValid)
                {
                    DisplayValidatorErrors(result);
                }
                else
                {
                    _ticketService.AddTicked(ticket);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

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
