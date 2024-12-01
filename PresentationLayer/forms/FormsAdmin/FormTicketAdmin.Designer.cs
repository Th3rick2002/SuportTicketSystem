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
            buttonAssingAgent.Location = new Point(827, 344);
            buttonAssingAgent.Margin = new Padding(4);
            buttonAssingAgent.Name = "buttonAssingAgent";
            buttonAssingAgent.Size = new Size(141, 35);
            buttonAssingAgent.TabIndex = 55;
            buttonAssingAgent.Text = "Asignar agente";
            buttonAssingAgent.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTicket
            // 
            dataGridViewTicket.BackgroundColor = Color.FromArgb(235, 239, 242);
            dataGridViewTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTicket.Cursor = Cursors.Hand;
            dataGridViewTicket.Location = new Point(12, 93);
            dataGridViewTicket.Name = "dataGridViewTicket";
            dataGridViewTicket.RowHeadersWidth = 51;
            dataGridViewTicket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTicket.Size = new Size(788, 443);
            dataGridViewTicket.TabIndex = 54;
            // 
            // pictureBoxTicket
            // 
            pictureBoxTicket.BackColor = Color.FromArgb(207, 206, 242);
            pictureBoxTicket.Image = (Image)resources.GetObject("pictureBoxTicket.Image");
            pictureBoxTicket.Location = new Point(827, 45);
            pictureBoxTicket.Margin = new Padding(3, 2, 3, 2);
            pictureBoxTicket.Name = "pictureBoxTicket";
            pictureBoxTicket.Size = new Size(129, 95);
            pictureBoxTicket.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTicket.TabIndex = 53;
            pictureBoxTicket.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(235, 239, 242);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(827, 265);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(141, 35);
            btnUpdate.TabIndex = 52;
            btnUpdate.Text = "Actualizar ";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(235, 239, 242);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(827, 189);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 37);
            btnAdd.TabIndex = 51;
            btnAdd.Text = "Agregar ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.BackColor = Color.FromArgb(207, 206, 242);
            labelClient.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold);
            labelClient.ForeColor = Color.Black;
            labelClient.Location = new Point(31, 22);
            labelClient.Margin = new Padding(4, 0, 4, 0);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(333, 39);
            labelClient.TabIndex = 50;
            labelClient.Text = "PANEL DE TICKET\r\n";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(235, 239, 242);
            buttonDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.Black;
            buttonDelete.Location = new Point(827, 416);
            buttonDelete.Margin = new Padding(4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(141, 35);
            buttonDelete.TabIndex = 56;
            buttonDelete.Text = "Eliminar ";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(207, 206, 242);
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(806, 88);
            textBox1.TabIndex = 57;
            // 
            // textBoxTicket
            // 
            textBoxTicket.BackColor = Color.FromArgb(207, 206, 242);
            textBoxTicket.Dock = DockStyle.Right;
            textBoxTicket.Location = new Point(806, 0);
            textBoxTicket.Margin = new Padding(3, 2, 3, 2);
            textBoxTicket.Multiline = true;
            textBoxTicket.Name = "textBoxTicket";
            textBoxTicket.Size = new Size(182, 548);
            textBoxTicket.TabIndex = 58;
            // 
            // FormTicketAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            ClientSize = new Size(988, 548);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAssingAgent);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(pictureBoxTicket);
            Controls.Add(labelClient);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewTicket);
            Controls.Add(textBoxTicket);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTicketAdmin";
            Text = "FormTicketAdmin";
            Load += FormTicketAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTicket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAssingAgent;
        private DataGridView dataGridViewTicket;
        private PictureBox pictureBoxTicket;
        private Button btnUpdate;
        private Button btnAdd;
        private Label labelClient;
        private Button buttonDelete;
        private TextBox textBox1;
        private TextBox textBoxTicket;
    }
}