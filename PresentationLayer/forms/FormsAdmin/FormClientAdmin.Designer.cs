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
            buttonDelete = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTicket
            // 
            dataGridViewTicket.BackgroundColor = Color.FromArgb(235, 239, 242);
            dataGridViewTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTicket.Columns.AddRange(new DataGridViewColumn[] { NameTicket, DescriptionTicket, Priority, Status, Categorie, Tag, FirstName });
            dataGridViewTicket.GridColor = Color.Black;
            dataGridViewTicket.Location = new Point(12, 156);
            dataGridViewTicket.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTicket.Name = "dataGridViewTicket";
            dataGridViewTicket.RowHeadersWidth = 51;
            dataGridViewTicket.Size = new Size(880, 531);
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
            pictureBox1.BackColor = Color.FromArgb(207, 206, 242);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(936, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(235, 239, 242);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(936, 380);
            btnUpdate.Margin = new Padding(5, 5, 5, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(161, 47);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Actualizar ";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(235, 239, 242);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(936, 259);
            btnAdd.Margin = new Padding(5, 5, 5, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 49);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "Agregar ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(235, 239, 242);
            buttonDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.Black;
            buttonDelete.Location = new Point(936, 508);
            buttonDelete.Margin = new Padding(5, 5, 5, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(161, 47);
            buttonDelete.TabIndex = 49;
            buttonDelete.Text = "Eliminar ";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(207, 206, 242);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Right;
            textBox2.Location = new Point(911, 0);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 731);
            textBox2.TabIndex = 51;
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
            textBox1.Size = new Size(911, 111);
            textBox1.TabIndex = 50;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(207, 206, 242);
            label1.Font = new Font("Berlin Sans FB", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 29);
            label1.Name = "label1";
            label1.Size = new Size(452, 56);
            label1.TabIndex = 52;
            label1.Text = "PANEL DE CLIENTE  ";
            // 
            // FormClientAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            ClientSize = new Size(1129, 731);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewTicket);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
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
        private DataGridViewTextBoxColumn NameTicket;
        private DataGridViewTextBoxColumn DescriptionTicket;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Categorie;
        private DataGridViewTextBoxColumn Tag;
        private DataGridViewTextBoxColumn FirstName;
        private Button buttonDelete;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}