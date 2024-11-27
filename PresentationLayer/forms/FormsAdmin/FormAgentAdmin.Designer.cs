namespace PresentationLayer.forms.FormsAdmin
{
    partial class FormAgentAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgentAdmin));
            buttonDelete = new Button();
            dataGridViewTicket = new DataGridView();
            NameTicket = new DataGridViewTextBoxColumn();
            DescriptionTicket = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Categorie = new DataGridViewTextBoxColumn();
            Tag = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            pictureAgent = new PictureBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureAgent).BeginInit();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(235, 239, 242);
            buttonDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.Black;
            buttonDelete.Location = new Point(940, 450);
            buttonDelete.Margin = new Padding(4, 5, 4, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(161, 47);
            buttonDelete.TabIndex = 55;
            buttonDelete.Text = "Eliminar ";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTicket
            // 
            dataGridViewTicket.BackgroundColor = Color.FromArgb(235, 239, 242);
            dataGridViewTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTicket.Columns.AddRange(new DataGridViewColumn[] { NameTicket, DescriptionTicket, Priority, Status, Categorie, Tag, FirstName });
            dataGridViewTicket.Location = new Point(24, 145);
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
            // pictureAgent
            // 
            pictureAgent.BackColor = Color.FromArgb(207, 206, 242);
            pictureAgent.BorderStyle = BorderStyle.Fixed3D;
            pictureAgent.Image = (Image)resources.GetObject("pictureAgent.Image");
            pictureAgent.Location = new Point(940, 33);
            pictureAgent.Name = "pictureAgent";
            pictureAgent.Size = new Size(161, 154);
            pictureAgent.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureAgent.TabIndex = 53;
            pictureAgent.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(235, 239, 242);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(940, 354);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
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
            btnAdd.Location = new Point(940, 253);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 49);
            btnAdd.TabIndex = 51;
            btnAdd.Text = "Agregar ";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(207, 206, 242);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1129, 111);
            textBox1.TabIndex = 56;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(207, 206, 242);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Right;
            textBox2.Location = new Point(911, 111);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 619);
            textBox2.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(207, 206, 242);
            label1.Font = new Font("Berlin Sans FB", 26.25F, FontStyle.Bold);
            label1.Location = new Point(53, 22);
            label1.Name = "label1";
            label1.Size = new Size(426, 56);
            label1.TabIndex = 58;
            label1.Text = "PANEL DE AGENTE";
            // 
            // FormAgentAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            ClientSize = new Size(1129, 730);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(pictureAgent);
            Controls.Add(textBox2);
            Controls.Add(dataGridViewTicket);
            Controls.Add(textBox1);
            Name = "FormAgentAdmin";
            Text = "FormAgentAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureAgent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDelete;
        private DataGridView dataGridViewTicket;
        private DataGridViewTextBoxColumn NameTicket;
        private DataGridViewTextBoxColumn DescriptionTicket;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Categorie;
        private DataGridViewTextBoxColumn Tag;
        private DataGridViewTextBoxColumn FirstName;
        private PictureBox pictureAgent;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
    }
}