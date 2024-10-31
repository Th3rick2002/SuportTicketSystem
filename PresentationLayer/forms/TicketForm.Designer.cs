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
            categoryLabel = new Label();
            btnState = new Label();
            btnPriority = new Label();
            comboBoxState = new ComboBox();
            comboBoxCategory = new ComboBox();
            textBoxPriority = new TextBox();
            textBoxName = new TextBox();
            labelAddTicket = new Label();
            saveButton = new Button();
            btnExit = new Button();
            textBoxPrioridad = new TextBox();
            labelPrioridad = new Label();
            comboBoxAgent = new ComboBox();
            comboBoxTag = new ComboBox();
            labelTag = new Label();
            labelAgent = new Label();
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
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            categoryLabel.Location = new Point(205, 397);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(84, 23);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Categoria";
            // 
            // btnState
            // 
            btnState.AutoSize = true;
            btnState.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnState.Location = new Point(198, 316);
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
            btnPriority.Size = new Size(98, 23);
            btnPriority.TabIndex = 3;
            btnPriority.Text = "Descripcion";
            // 
            // comboBoxState
            // 
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(205, 342);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(302, 28);
            comboBoxState.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(205, 423);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(302, 28);
            comboBoxCategory.TabIndex = 5;
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
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            saveButton.Location = new Point(201, 625);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 52;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(413, 625);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 53;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // textBoxPrioridad
            // 
            textBoxPrioridad.Location = new Point(205, 267);
            textBoxPrioridad.Name = "textBoxPrioridad";
            textBoxPrioridad.Size = new Size(302, 27);
            textBoxPrioridad.TabIndex = 55;
            // 
            // labelPrioridad
            // 
            labelPrioridad.AutoSize = true;
            labelPrioridad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPrioridad.Location = new Point(197, 241);
            labelPrioridad.Name = "labelPrioridad";
            labelPrioridad.Size = new Size(79, 23);
            labelPrioridad.TabIndex = 54;
            labelPrioridad.Text = "Prioridad";
            // 
            // comboBoxAgent
            // 
            comboBoxAgent.FormattingEnabled = true;
            comboBoxAgent.Location = new Point(205, 576);
            comboBoxAgent.Name = "comboBoxAgent";
            comboBoxAgent.Size = new Size(302, 28);
            comboBoxAgent.TabIndex = 59;
            // 
            // comboBoxTag
            // 
            comboBoxTag.FormattingEnabled = true;
            comboBoxTag.Location = new Point(205, 495);
            comboBoxTag.Name = "comboBoxTag";
            comboBoxTag.Size = new Size(302, 28);
            comboBoxTag.TabIndex = 58;
            // 
            // labelTag
            // 
            labelTag.AutoSize = true;
            labelTag.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelTag.Location = new Point(205, 469);
            labelTag.Name = "labelTag";
            labelTag.Size = new Size(73, 23);
            labelTag.TabIndex = 57;
            labelTag.Text = "Etiqueta";
            // 
            // labelAgent
            // 
            labelAgent.AutoSize = true;
            labelAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelAgent.Location = new Point(205, 550);
            labelAgent.Name = "labelAgent";
            labelAgent.Size = new Size(65, 23);
            labelAgent.TabIndex = 56;
            labelAgent.Text = "Agente";
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 801);
            Controls.Add(comboBoxAgent);
            Controls.Add(comboBoxTag);
            Controls.Add(labelTag);
            Controls.Add(labelAgent);
            Controls.Add(textBoxPrioridad);
            Controls.Add(labelPrioridad);
            Controls.Add(btnExit);
            Controls.Add(saveButton);
            Controls.Add(labelAddTicket);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPriority);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxState);
            Controls.Add(btnPriority);
            Controls.Add(btnState);
            Controls.Add(categoryLabel);
            Controls.Add(lblName);
            Name = "TicketForm";
            Text = "TicketForm1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label categoryLabel;
        private Label btnState;
        private Label btnPriority;
        private ComboBox comboBoxState;
        private ComboBox comboBoxCategory;
        private TextBox textBoxPriority;
        private TextBox textBoxName;
        private Label labelAddTicket;
        private Button saveButton;
        private Button btnExit;
        private TextBox textBoxPrioridad;
        private Label labelPrioridad;
        private ComboBox comboBoxAgent;
        private ComboBox comboBoxTag;
        private Label labelTag;
        private Label labelAgent;
    }
}