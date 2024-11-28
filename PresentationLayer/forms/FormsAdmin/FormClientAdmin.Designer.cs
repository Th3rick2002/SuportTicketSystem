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
            textBoxCustomer = new TextBox();
            textBoxCouster = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            btnUpdate.Margin = new Padding(5);
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
            btnAdd.Location = new Point(936, 233);
            btnAdd.Margin = new Padding(5);
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
            buttonDelete.Margin = new Padding(5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(161, 47);
            buttonDelete.TabIndex = 49;
            buttonDelete.Text = "Eliminar ";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.BackColor = Color.FromArgb(207, 206, 242);
            textBoxCustomer.BorderStyle = BorderStyle.None;
            textBoxCustomer.Dock = DockStyle.Right;
            textBoxCustomer.Location = new Point(911, 0);
            textBoxCustomer.Margin = new Padding(3, 4, 3, 4);
            textBoxCustomer.Multiline = true;
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.Size = new Size(218, 731);
            textBoxCustomer.TabIndex = 51;
            // 
            // textBoxCouster
            // 
            textBoxCouster.BackColor = Color.FromArgb(207, 206, 242);
            textBoxCouster.BorderStyle = BorderStyle.None;
            textBoxCouster.Dock = DockStyle.Top;
            textBoxCouster.Location = new Point(0, 0);
            textBoxCouster.Margin = new Padding(3, 4, 3, 4);
            textBoxCouster.Multiline = true;
            textBoxCouster.Name = "textBoxCouster";
            textBoxCouster.Size = new Size(911, 111);
            textBoxCouster.TabIndex = 50;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 239, 242);
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(936, 233);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(161, 49);
            button1.TabIndex = 45;
            button1.Text = "Agregar ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(235, 239, 242);
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(936, 380);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(161, 47);
            button2.TabIndex = 46;
            button2.Text = "Actualizar ";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(235, 239, 242);
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(936, 508);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(161, 47);
            button3.TabIndex = 49;
            button3.Text = "Eliminar ";
            button3.UseVisualStyleBackColor = false;
            // 
            // FormClientAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            ClientSize = new Size(1129, 731);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttonDelete);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewTicket);
            Controls.Add(textBoxCouster);
            Controls.Add(textBoxCustomer);
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
        private TextBox textBoxCustomer;
        private TextBox textBoxCouster;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}