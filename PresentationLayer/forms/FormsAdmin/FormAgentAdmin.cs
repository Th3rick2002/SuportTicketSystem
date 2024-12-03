using BussisnesLayer.Services.agentService;
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

namespace PresentationLayer.forms.FormsAdmin
{
    public partial class FormAgentAdmin : Form
    {
        private agentService _agentService;

        public FormAgentAdmin()
        {
            InitializeComponent();
            _agentService = new agentService();
        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            registerAgentAdmin registerAgentForm = new registerAgentAdmin();
            if (registerAgentForm.ShowDialog() == DialogResult.OK)
            {
                LoadAgents();
            }
        }

        private void FormAgentAdmin_Load(object sender, EventArgs e)
        {
            if (_agentService == null)
            {
                MessageBox.Show("El servicio de agentes no se ha inicializado correctamente.");
                return;
            }

            LoadAgents();
        }

        private void LoadAgents()
        {
            if (dataGridViewAgents == null)
            {
                MessageBox.Show("El DataGridView de agentes no se ha inicializado.");
                return;
            }

            DataTable agents = _agentService.GetAllAgents();

            if (agents == null || agents.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron agentes.");
                return;
            }

            dataGridViewAgents.DataSource = agents;

            if (dataGridViewAgents.Columns.Contains("Password"))
            {
                dataGridViewAgents.Columns["Password"].Visible = false;
            }
            if (dataGridViewAgents.Columns.Contains("Id"))
            {
                dataGridViewAgents.Columns["Id"].Visible = false;
            }
        }

        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            if (dataGridViewAgents.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debes seleccionar un agente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var selectedRow = dataGridViewAgents.CurrentRow;

                registerAgentAdmin formRegister = new registerAgentAdmin
                {
                    EditMode = true,  // Usando la propiedad EditMode
                    AgentData = new Agent
                    {
                        IdAgent = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                        FirstName = selectedRow.Cells["FirstName"].Value.ToString(),
                        LastName = selectedRow.Cells["LastName"].Value.ToString(),
                        Email = selectedRow.Cells["Email"].Value.ToString()
                    }
                };

                formRegister.labelRegisterNewAgent.Text = "Editar Agente";

                if (formRegister.ShowDialog() == DialogResult.OK)
                {
                    LoadAgents();
                }
            }
        }

        private void buttonDeleteAgent_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewAgents.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar un agente para eliminar.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = dataGridViewAgents.CurrentRow;
            int agentId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este agente?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                _agentService.DeleteAgent(agentId);
                LoadAgents();
                MessageBox.Show("Agente eliminado exitosamente.");
            }
        }
    }
}
