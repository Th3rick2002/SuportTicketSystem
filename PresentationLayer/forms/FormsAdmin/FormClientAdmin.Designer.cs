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
            dataGridViewClients = new DataGridView();
            pictureBox1 = new PictureBox();
            btnAdd = new Button();
            textBoxCustomer = new TextBox();
            textBoxCouster = new TextBox();
            label1 = new Label();
            btnUpdate = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewClients.BackgroundColor = Color.FromArgb(235, 239, 242);
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.GridColor = Color.Black;
            dataGridViewClients.Location = new Point(14, 119);
            dataGridViewClients.Margin = new Padding(3, 4, 3, 4);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.Size = new Size(890, 596);
            dataGridViewClients.TabIndex = 48;
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
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 29);
            label1.Name = "label1";
            label1.Size = new Size(477, 52);
            label1.TabIndex = 52;
            label1.Text = "PANEL DE CLIENTE  ";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(235, 239, 242);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(936, 351);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(161, 47);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Actualizar ";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(235, 239, 242);
            buttonDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.Black;
            buttonDelete.Location = new Point(936, 460);
            buttonDelete.Margin = new Padding(5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(161, 47);
            buttonDelete.TabIndex = 49;
            buttonDelete.Text = "Eliminar ";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
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
            Controls.Add(dataGridViewClients);
            Controls.Add(textBoxCouster);
            Controls.Add(textBoxCustomer);
            Name = "FormClientAdmin";
            Text = "FormClientAdmin";
            Load += FormClientAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClients;
        private PictureBox pictureBox1;
        private Button btnAdd;
        private TextBox textBoxCustomer;
        private TextBox textBoxCouster;
        private Label label1;
        private Button btnUpdate;
        private Button buttonDelete;
    }
}