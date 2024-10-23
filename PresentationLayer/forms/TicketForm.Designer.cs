namespace PresentationLayer.forms
{
    partial class TicketForm
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
            lblName = new Label();
            btnAgent = new Label();
            btnState = new Label();
            btnPriority = new Label();
            comboBoxState = new ComboBox();
            comboBoxAgent = new ComboBox();
            textBoxPriority = new TextBox();
            textBoxName = new TextBox();
            labelAddTicket = new Label();
            btnSave = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(198, 96);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre ";
            // 
            // btnAgent
            // 
            btnAgent.AutoSize = true;
            btnAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAgent.Location = new Point(198, 331);
            btnAgent.Name = "btnAgent";
            btnAgent.Size = new Size(65, 23);
            btnAgent.TabIndex = 1;
            btnAgent.Text = "Agente";
            // 
            // btnState
            // 
            btnState.AutoSize = true;
            btnState.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnState.Location = new Point(198, 257);
            btnState.Name = "btnState";
            btnState.Size = new Size(61, 23);
            btnState.TabIndex = 2;
            btnState.Text = "Estado";
            // 
            // btnPriority
            // 
            btnPriority.AutoSize = true;
            btnPriority.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnPriority.Location = new Point(197, 176);
            btnPriority.Name = "btnPriority";
            btnPriority.Size = new Size(79, 23);
            btnPriority.TabIndex = 3;
            btnPriority.Text = "Prioridad";
            // 
            // comboBoxState
            // 
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(205, 283);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(302, 28);
            comboBoxState.TabIndex = 4;
            // 
            // comboBoxAgent
            // 
            comboBoxAgent.FormattingEnabled = true;
            comboBoxAgent.Location = new Point(205, 357);
            comboBoxAgent.Name = "comboBoxAgent";
            comboBoxAgent.Size = new Size(302, 28);
            comboBoxAgent.TabIndex = 5;
            // 
            // textBoxPriority
            // 
            textBoxPriority.Location = new Point(205, 202);
            textBoxPriority.Name = "textBoxPriority";
            textBoxPriority.Size = new Size(302, 27);
            textBoxPriority.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(205, 122);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(302, 27);
            textBoxName.TabIndex = 7;
            // 
            // labelAddTicket
            // 
            labelAddTicket.AutoSize = true;
            labelAddTicket.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddTicket.Location = new Point(205, 23);
            labelAddTicket.Margin = new Padding(4, 0, 4, 0);
            labelAddTicket.Name = "labelAddTicket";
            labelAddTicket.Size = new Size(227, 41);
            labelAddTicket.TabIndex = 51;
            labelAddTicket.Text = "Agregar Ticket";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(194, 433);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 52;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(413, 433);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 53;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 509);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(labelAddTicket);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPriority);
            Controls.Add(comboBoxAgent);
            Controls.Add(comboBoxState);
            Controls.Add(btnPriority);
            Controls.Add(btnState);
            Controls.Add(btnAgent);
            Controls.Add(lblName);
            Name = "TicketForm";
            Text = "TicketForm1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label btnAgent;
        private Label btnState;
        private Label btnPriority;
        private ComboBox comboBoxState;
        private ComboBox comboBoxAgent;
        private TextBox textBoxPriority;
        private TextBox textBoxName;
        private Label labelAddTicket;
        private Button btnSave;
        private Button btnExit;
    }
}