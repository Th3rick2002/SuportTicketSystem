namespace PresentationLayer.forms.FormsAdmin
{
    partial class FormClientAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientAdmin));
            dataGridViewTicket = new DataGridView();
            NameTicket = new DataGridViewTextBoxColumn();
            DescriptionTicket = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Categorie = new DataGridViewTextBoxColumn();
            Tag = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblClient = new Label();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTicket
            // 
            dataGridViewTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTicket.Columns.AddRange(new DataGridViewColumn[] { NameTicket, DescriptionTicket, Priority, Status, Categorie, Tag, FirstName });
            dataGridViewTicket.Location = new Point(36, 152);
            dataGridViewTicket.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTicket.Name = "dataGridViewTicket";
            dataGridViewTicket.RowHeadersWidth = 51;
            dataGridViewTicket.Size = new Size(869, 531);
            dataGridViewTicket.TabIndex = 48;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(82, 109, 130);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(936, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(157, 178, 191);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(936, 442);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(161, 47);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Actualizar ";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(157, 178, 191);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(936, 341);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 49);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "Agregar ";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = Color.Transparent;
            lblClient.Font = new Font("Arial", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblClient.ForeColor = Color.GhostWhite;
            lblClient.Location = new Point(68, 62);
            lblClient.Margin = new Padding(4, 0, 4, 0);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(400, 46);
            lblClient.TabIndex = 44;
            lblClient.Text = "PANEL DE CLIENTE";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(157, 178, 191);
            buttonDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.Black;
            buttonDelete.Location = new Point(936, 547);
            buttonDelete.Margin = new Padding(4, 5, 4, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(161, 47);
            buttonDelete.TabIndex = 49;
            buttonDelete.Text = "Eliminar ";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // FormClientAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 109, 130);
            ClientSize = new Size(1129, 730);
            Controls.Add(buttonDelete);
            Controls.Add(dataGridViewTicket);
            Controls.Add(pictureBox1);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblClient);
            Name = "FormClientAdmin";
            Text = "FormClientAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTicket;
        private PictureBox pictureBox1;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lblClient;
        private DataGridViewTextBoxColumn NameTicket;
        private DataGridViewTextBoxColumn DescriptionTicket;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Categorie;
        private DataGridViewTextBoxColumn Tag;
        private DataGridViewTextBoxColumn FirstName;
        private Button buttonDelete;
    }
}