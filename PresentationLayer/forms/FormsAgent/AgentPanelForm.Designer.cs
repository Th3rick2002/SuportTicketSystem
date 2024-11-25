namespace PresentationLayer.forms
{
    partial class AgentPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentPanelForm));
            dataGridViewAgent = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            NameTicket = new DataGridViewTextBoxColumn();
            DescriptionTicket = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Categorie = new DataGridViewTextBoxColumn();
            Tag = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgent).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAgent
            // 
            dataGridViewAgent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgent.Columns.AddRange(new DataGridViewColumn[] { NameTicket, DescriptionTicket, Priority, Status, Categorie, Tag, FirstName });
            dataGridViewAgent.Location = new Point(245, 131);
            dataGridViewAgent.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAgent.Name = "dataGridViewAgent";
            dataGridViewAgent.RowHeadersWidth = 51;
            dataGridViewAgent.Size = new Size(928, 535);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 39);
            label1.Name = "label1";
            label1.Size = new Size(603, 69);
            label1.TabIndex = 26;
            label1.Text = "PANEL DE AGENTE";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(157, 178, 191);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(97, 215);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 72);
            button1.TabIndex = 27;
            button1.Text = "Empezar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(157, 178, 191);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(97, 349);
            button2.Margin = new Padding(3, 4, 3, 11);
            button2.Name = "button2";
            button2.Size = new Size(86, 72);
            button2.TabIndex = 28;
            button2.Text = "Finalizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(157, 178, 191);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(97, 480);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 72);
            button3.TabIndex = 29;
            button3.Text = "Cerrar sesión";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // NameTicket
            // 
            NameTicket.HeaderText = "Nombre Ticket";
            NameTicket.MinimumWidth = 6;
            NameTicket.Name = "NameTicket";
            NameTicket.Width = 125;
            // 
            // DescriptionTicket
            // 
            DescriptionTicket.HeaderText = "Descripcion Ticket";
            DescriptionTicket.MinimumWidth = 6;
            DescriptionTicket.Name = "DescriptionTicket";
            DescriptionTicket.Width = 125;
            // 
            // Priority
            // 
            Priority.HeaderText = "Prioridad";
            Priority.MinimumWidth = 6;
            Priority.Name = "Priority";
            Priority.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Estado";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // Categorie
            // 
            Categorie.HeaderText = "Categoria";
            Categorie.MinimumWidth = 6;
            Categorie.Name = "Categorie";
            Categorie.Width = 125;
            // 
            // Tag
            // 
            Tag.HeaderText = "Etiqueta";
            Tag.MinimumWidth = 6;
            Tag.Name = "Tag";
            Tag.Width = 125;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Agente";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.Width = 125;
            // 
            // AgentPanelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 109, 130);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1210, 697);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridViewAgent);
            Controls.Add(label2);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgentPanelForm";
            Text = "AgentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewAgent;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn NameTicket;
        private DataGridViewTextBoxColumn DescriptionTicket;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Categorie;
        private DataGridViewTextBoxColumn Tag;
        private DataGridViewTextBoxColumn FirstName;
    }
}