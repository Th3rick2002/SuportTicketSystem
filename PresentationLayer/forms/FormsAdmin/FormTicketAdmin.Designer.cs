namespace PresentationLayer.forms.FormsAdmin
{
    partial class FormTicketAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicketAdmin));
            buttonAssingAgent = new Button();
            dataGridViewTicket = new DataGridView();
            NameTicket = new DataGridViewTextBoxColumn();
            DescriptionTicket = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Categorie = new DataGridViewTextBoxColumn();
            Tag = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            pictureBoxTicket = new PictureBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            labelClient = new Label();
            buttonDelete = new Button();
            textBox1 = new TextBox();
            textBoxTicket = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTicket).BeginInit();
            SuspendLayout();
            // 
            // buttonAssingAgent
            // 
            buttonAssingAgent.BackColor = Color.FromArgb(235, 239, 242);
            buttonAssingAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonAssingAgent.ForeColor = Color.Black;
            buttonAssingAgent.Location = new Point(954, 375);
            buttonAssingAgent.Margin = new Padding(5);
            buttonAssingAgent.Name = "buttonAssingAgent";
            buttonAssingAgent.Size = new Size(161, 47);
            buttonAssingAgent.TabIndex = 55;
            buttonAssingAgent.Text = "Asignar agente";
            buttonAssingAgent.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTicket
            // 
            dataGridViewTicket.BackgroundColor = Color.FromArgb(235, 239, 242);
            dataGridViewTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTicket.Columns.AddRange(new DataGridViewColumn[] { NameTicket, DescriptionTicket, Priority, Status, Categorie, Tag, FirstName });
            dataGridViewTicket.Location = new Point(35, 154);
            dataGridViewTicket.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTicket.Name = "dataGridViewTicket";
            dataGridViewTicket.RowHeadersWidth = 51;
            dataGridViewTicket.Size = new Size(869, 531);
            dataGridViewTicket.TabIndex = 54;
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
            Priority.Width = 90;
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
            // pictureBoxTicket
            // 
            pictureBoxTicket.BackColor = Color.FromArgb(207, 206, 242);
            pictureBoxTicket.Image = (Image)resources.GetObject("pictureBoxTicket.Image");
            pictureBoxTicket.Location = new Point(35, 12);
            pictureBoxTicket.Name = "pictureBoxTicket";
            pictureBoxTicket.Size = new Size(112, 92);
            pictureBoxTicket.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTicket.TabIndex = 53;
            pictureBoxTicket.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(235, 239, 242);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(954, 270);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(161, 47);
            btnUpdate.TabIndex = 52;
            btnUpdate.Text = "Actualizar ";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(235, 239, 242);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(954, 169);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 49);
            btnAdd.TabIndex = 51;
            btnAdd.Text = "Agregar ";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.BackColor = Color.FromArgb(207, 206, 242);
            labelClient.Font = new Font("Berlin Sans FB", 26.25F, FontStyle.Bold);
            labelClient.ForeColor = Color.Black;
            labelClient.Location = new Point(178, 30);
            labelClient.Margin = new Padding(5, 0, 5, 0);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(401, 56);
            labelClient.TabIndex = 50;
            labelClient.Text = "PANEL DE TICKET\r\n";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(235, 239, 242);
            buttonDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.Black;
            buttonDelete.Location = new Point(954, 471);
            buttonDelete.Margin = new Padding(5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(161, 47);
            buttonDelete.TabIndex = 56;
            buttonDelete.Text = "Eliminar ";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(207, 206, 242);
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(922, 116);
            textBox1.TabIndex = 57;
            // 
            // textBoxTicket
            // 
            textBoxTicket.BackColor = Color.FromArgb(207, 206, 242);
            textBoxTicket.Dock = DockStyle.Right;
            textBoxTicket.Location = new Point(922, 0);
            textBoxTicket.Multiline = true;
            textBoxTicket.Name = "textBoxTicket";
            textBoxTicket.Size = new Size(207, 731);
            textBoxTicket.TabIndex = 58;
            // 
            // FormTicketAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            ClientSize = new Size(1129, 731);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAssingAgent);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(pictureBoxTicket);
            Controls.Add(labelClient);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewTicket);
            Controls.Add(textBoxTicket);
            Name = "FormTicketAdmin";
            Text = "FormTicketAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTicket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAssingAgent;
        private DataGridView dataGridViewTicket;
        private DataGridViewTextBoxColumn NameTicket;
        private DataGridViewTextBoxColumn DescriptionTicket;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Categorie;
        private DataGridViewTextBoxColumn Tag;
        private DataGridViewTextBoxColumn FirstName;
        private PictureBox pictureBoxTicket;
        private Button btnUpdate;
        private Button btnAdd;
        private Label labelClient;
        private Button buttonDelete;
        private TextBox textBox1;
        private TextBox textBoxTicket;
    }
}