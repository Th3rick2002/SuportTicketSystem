namespace PresentationLayer.forms
{
    partial class FormAgent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFinish = new Button();
            btnStart = new Button();
            dataGridViewAgent = new DataGridView();
            label2 = new Label();
            labelAgent = new Label();
            labelIdTicket = new Label();
            texIdLabel = new Label();
            btnExit = new Button();
            LabelNombre = new Label();
            labelNombreTicket = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgent).BeginInit();
            SuspendLayout();
            // 
            // btnFinish
            // 
            btnFinish.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnFinish.Location = new Point(784, 213);
            btnFinish.Margin = new Padding(3, 4, 3, 4);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(127, 47);
            btnFinish.TabIndex = 27;
            btnFinish.Text = "Finalizar";
            btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnStart.Location = new Point(784, 365);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(127, 47);
            btnStart.TabIndex = 26;
            btnStart.Text = "Empezar";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAgent
            // 
            dataGridViewAgent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgent.Location = new Point(44, 92);
            dataGridViewAgent.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAgent.Name = "dataGridViewAgent";
            dataGridViewAgent.RowHeadersWidth = 51;
            dataGridViewAgent.Size = new Size(688, 421);
            dataGridViewAgent.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-31, 157);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 15;
            label2.Text = "Id";
            // 
            // labelAgent
            // 
            labelAgent.AutoSize = true;
            labelAgent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAgent.Location = new Point(417, 12);
            labelAgent.Name = "labelAgent";
            labelAgent.Size = new Size(247, 41);
            labelAgent.TabIndex = 14;
            labelAgent.Text = "Panel de Agente";
            // 
            // labelIdTicket
            // 
            labelIdTicket.AutoSize = true;
            labelIdTicket.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelIdTicket.Location = new Point(861, 116);
            labelIdTicket.Name = "labelIdTicket";
            labelIdTicket.Size = new Size(55, 23);
            labelIdTicket.TabIndex = 28;
            labelIdTicket.Text = "label3";
            // 
            // texIdLabel
            // 
            texIdLabel.AutoSize = true;
            texIdLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            texIdLabel.Location = new Point(784, 116);
            texIdLabel.Name = "texIdLabel";
            texIdLabel.Size = new Size(36, 23);
            texIdLabel.TabIndex = 29;
            texIdLabel.Text = "ID :";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(784, 286);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(127, 47);
            btnExit.TabIndex = 30;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            LabelNombre.Location = new Point(784, 165);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(82, 23);
            LabelNombre.TabIndex = 31;
            LabelNombre.Text = "Nombre :";
            // 
            // labelNombreTicket
            // 
            labelNombreTicket.AutoSize = true;
            labelNombreTicket.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelNombreTicket.Location = new Point(861, 165);
            labelNombreTicket.Name = "labelNombreTicket";
            labelNombreTicket.Size = new Size(55, 23);
            labelNombreTicket.TabIndex = 32;
            labelNombreTicket.Text = "label3";
            // 
            // FormAgent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 600);
            Controls.Add(labelNombreTicket);
            Controls.Add(LabelNombre);
            Controls.Add(btnExit);
            Controls.Add(texIdLabel);
            Controls.Add(labelIdTicket);
            Controls.Add(btnFinish);
            Controls.Add(btnStart);
            Controls.Add(dataGridViewAgent);
            Controls.Add(label2);
            Controls.Add(labelAgent);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAgent";
            Text = "AgentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFinish;
        private Button btnStart;
        private DataGridView dataGridViewAgent;
        private Label label2;
        private Label labelAgent;
        private Label labelIdTicket;
        private Label texIdLabel;
        private Button btnExit;
        private Label LabelNombre;
        private Label labelNombreTicket;
    }
}