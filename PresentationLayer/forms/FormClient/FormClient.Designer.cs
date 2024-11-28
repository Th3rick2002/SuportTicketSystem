namespace PresentationLayer.forms
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            btnExit = new Button();
            btnAdd = new Button();
            lblClient = new Label();
            pictureBoxCustomer = new PictureBox();
            FirstName = new DataGridViewTextBoxColumn();
            Tag = new DataGridViewTextBoxColumn();
            Categorie = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            DescriptionTicket = new DataGridViewTextBoxColumn();
            NameTicket = new DataGridViewTextBoxColumn();
            dataGridViewCustomer = new DataGridView();
            textBoxCustomer = new TextBox();
            CustomertextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(235, 239, 242);
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(1110, 392);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(161, 47);
            btnExit.TabIndex = 39;
            btnExit.Text = "Cerrar sesión";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(235, 239, 242);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(1110, 270);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 49);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Agregar ticket";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = Color.FromArgb(207, 206, 242);
            lblClient.Font = new Font("Arial", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblClient.ForeColor = Color.Black;
            lblClient.Location = new Point(13, 17);
            lblClient.Margin = new Padding(4, 0, 4, 0);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(400, 46);
            lblClient.TabIndex = 29;
            lblClient.Text = "PANEL DE CLIENTE";
            // 
            // pictureBoxCustomer
            // 
            pictureBoxCustomer.BackColor = Color.FromArgb(207, 206, 242);
            pictureBoxCustomer.BackgroundImageLayout = ImageLayout.None;
            pictureBoxCustomer.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxCustomer.Image = (Image)resources.GetObject("pictureBoxCustomer.Image");
            pictureBoxCustomer.Location = new Point(1110, 27);
            pictureBoxCustomer.Name = "pictureBoxCustomer";
            pictureBoxCustomer.Size = new Size(161, 154);
            pictureBoxCustomer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCustomer.TabIndex = 42;
            pictureBoxCustomer.TabStop = false;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Agente";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.Width = 125;
            // 
            // Tag
            // 
            Tag.HeaderText = "Etiqueta";
            Tag.MinimumWidth = 6;
            Tag.Name = "Tag";
            Tag.Width = 125;
            // 
            // Categorie
            // 
            Categorie.HeaderText = "Categoria";
            Categorie.MinimumWidth = 6;
            Categorie.Name = "Categorie";
            Categorie.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Estado";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // Priority
            // 
            Priority.HeaderText = "Prioridad";
            Priority.MinimumWidth = 6;
            Priority.Name = "Priority";
            Priority.Width = 125;
            // 
            // DescriptionTicket
            // 
            DescriptionTicket.HeaderText = "Descripcion Ticket";
            DescriptionTicket.MinimumWidth = 6;
            DescriptionTicket.Name = "DescriptionTicket";
            DescriptionTicket.Width = 125;
            // 
            // NameTicket
            // 
            NameTicket.HeaderText = "Nombre Ticket";
            NameTicket.MinimumWidth = 6;
            NameTicket.Name = "NameTicket";
            NameTicket.Width = 125;
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.BackgroundColor = Color.FromArgb(207, 206, 242);
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Columns.AddRange(new DataGridViewColumn[] { NameTicket, DescriptionTicket, Priority, Status, Categorie, Tag, FirstName });
            dataGridViewCustomer.Location = new Point(66, 121);
            dataGridViewCustomer.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 51;
            dataGridViewCustomer.Size = new Size(929, 562);
            dataGridViewCustomer.TabIndex = 43;
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.BackColor = Color.FromArgb(207, 206, 242);
            textBoxCustomer.Dock = DockStyle.Right;
            textBoxCustomer.Location = new Point(1064, 0);
            textBoxCustomer.Multiline = true;
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.Size = new Size(256, 749);
            textBoxCustomer.TabIndex = 44;
            // 
            // CustomertextBox
            // 
            CustomertextBox.BackColor = Color.FromArgb(207, 206, 242);
            CustomertextBox.Dock = DockStyle.Top;
            CustomertextBox.Location = new Point(0, 0);
            CustomertextBox.Multiline = true;
            CustomertextBox.Name = "CustomertextBox";
            CustomertextBox.Size = new Size(1064, 83);
            CustomertextBox.TabIndex = 45;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            ClientSize = new Size(1320, 749);
            Controls.Add(lblClient);
            Controls.Add(CustomertextBox);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(pictureBoxCustomer);
            Controls.Add(textBoxCustomer);
            Controls.Add(dataGridViewCustomer);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormClient";
            Text = "RequestForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExit;
        private Button btnAdd;
        private Label lblClient;
        private TextBox textBox2;
        private PictureBox pictureBoxCustomer;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Tag;
        private DataGridViewTextBoxColumn Categorie;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn DescriptionTicket;
        private DataGridViewTextBoxColumn NameTicket;
        private DataGridView dataGridViewCustomer;
        private TextBox textBoxCustomer;
        private TextBox CustomertextBox;
    }
}