using BussisnesLayer.Services.agentService;
using BussisnesLayer.Services.userService;
using CommonLayer.Entities;
using PresentationLayer.Validations.ValidationsAgent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;

namespace PresentationLayer.forms.FormsAdmin
{
    public partial class registerAgentAdmin : Form
    {
        private readonly agentService _agentService = new agentService();
        private readonly AgentValidator _validator = new AgentValidator();
        private readonly ErrorProvider _registerAgentErrorProvider = new ErrorProvider();
        public bool EditMode { get; set; } = false;
        public Agent AgentData { get; set; }

        public registerAgentAdmin()
        {
            InitializeComponent();
            ConfigureErrorProvider();
        }

        private void ConfigureErrorProvider()
        {
            _registerAgentErrorProvider.ContainerControl = this;
            _registerAgentErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void registerAgentAdmin_Load(object sender, EventArgs e)
        {
            ConfigureFormForMode();
        }

        private void ConfigureFormForMode()
        {
            labelRegisterNewAgent.Text = EditMode ? "Editar Agente" : "Registrar Nuevo Agente";

            if (EditMode && AgentData != null)
            {
                SetAgentData(AgentData);
                DisablePasswordFields();
            }
            else
            {
                textBoxPaswordAgent.Enabled = true;
                textBoxVerifyPasswordAgent.Enabled = true;
            }
        }

        private void DisablePasswordFields()
        {
            textBoxPaswordAgent.Text = "********";
            textBoxVerifyPasswordAgent.Text = "********";
            textBoxPaswordAgent.Enabled = false;
            textBoxVerifyPasswordAgent.Enabled = false;
        }

        private void btnSaveAgent_Click(object sender, EventArgs e)
        {
            _registerAgentErrorProvider.Clear();
            var agent = CreateAgentFromForm();

            // Usar FluentValidation para validar el agente
            ValidationResult validationResult = _validator.Validate(agent);

            if (!validationResult.IsValid)
            {
                ShowValidationErrors(validationResult);
                return;
            }

            // Guardar o actualizar el agente
            if (EditMode)
            {
                agent.IdAgent = AgentData.IdAgent;
                _agentService.UpdateAgent(agent);
                MessageBox.Show("Agente actualizado exitosamente.");
            }
            else
            {
                _agentService.InsertAgent(agent);
                MessageBox.Show("Agente registrado exitosamente.");
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private Agent CreateAgentFromForm()
        {
            return new Agent
            {
                FirstName = textBoxNameAgent.Text,
                LastName = textBoxLastNameAgent.Text,
                Email = textBoxEmailAgent.Text,
                Password = EditMode ? AgentData.Password : textBoxPaswordAgent.Text
            };
        }

        private void ShowValidationErrors(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Agent.FirstName):
                        _registerAgentErrorProvider.SetError(textBoxNameAgent, error.ErrorMessage);
                        break;
                    case nameof(Agent.LastName):
                        _registerAgentErrorProvider.SetError(textBoxLastNameAgent, error.ErrorMessage);
                        break;
                    case nameof(Agent.Email):
                        _registerAgentErrorProvider.SetError(textBoxEmailAgent, error.ErrorMessage);
                        break;
                    case nameof(Agent.Password):
                        _registerAgentErrorProvider.SetError(textBoxPaswordAgent, error.ErrorMessage);
                        break;
                }
            }
        }

        private void SetAgentData(Agent agent)
        {
            textBoxNameAgent.Text = agent.FirstName;
            textBoxLastNameAgent.Text = agent.LastName;
            textBoxEmailAgent.Text = agent.Email;
        }

        private void btnExitAgent_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}