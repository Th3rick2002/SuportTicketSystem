namespace PresentationLayer.forms
{
    partial class FormAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrator));
            dataGridViewAdmin = new DataGridView();
            btnUpdate = new Button();
            LabelNombre = new Label();
            btnAdd = new Button();
            labelIdAdmin = new Label();
            btnDelete = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            labelAgent = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmin).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAdmin
            // 
            dataGridViewAdmin.BackgroundColor = Color.FromArgb(235, 239, 242);
            dataGridViewAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdmin.Location = new Point(11, 79);
            dataGridViewAdmin.Name = "dataGridViewAdmin";
            dataGridViewAdmin.RowHeadersWidth = 51;
            dataGridViewAdmin.Size = new Size(744, 466);
            dataGridViewAdmin.TabIndex = 41;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(235, 239, 242);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(26, 293);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(184, 44);
            btnUpdate.TabIndex = 42;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.BackColor = Color.DarkSlateGray;
            LabelNombre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            LabelNombre.ForeColor = Color.MintCream;
            LabelNombre.Location = new Point(29, 406);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(0, 19);
            LabelNombre.TabIndex = 47;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(235, 239, 242);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(26, 218);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(184, 43);
            btnAdd.TabIndex = 46;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // labelIdAdmin
            // 
            labelIdAdmin.AutoSize = true;
            labelIdAdmin.BackColor = Color.DarkSlateGray;
            labelIdAdmin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelIdAdmin.ForeColor = Color.MintCream;
            labelIdAdmin.Location = new Point(101, 83);
            labelIdAdmin.Name = "labelIdAdmin";
            labelIdAdmin.Size = new Size(0, 19);
            labelIdAdmin.TabIndex = 44;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(235, 239, 242);
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(29, 359);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(186, 44);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(207, 206, 242);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(labelIdAdmin);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(LabelNombre);
            panel2.Controls.Add(btnUpdate);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(761, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 556);
            panel2.TabIndex = 57;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(207, 206, 242);
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(45, 32);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 116);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 56;
            pictureBox2.TabStop = false;
            // 
            // labelAgent
            // 
            labelAgent.AutoSize = true;
            labelAgent.BackColor = Color.FromArgb(207, 206, 242);
            labelAgent.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold);
            labelAgent.ForeColor = Color.Black;
            labelAgent.Location = new Point(10, 26);
            labelAgent.Name = "labelAgent";
            labelAgent.Size = new Size(414, 39);
            labelAgent.TabIndex = 40;
            labelAgent.Text = "Panel de Administracion";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(207, 206, 242);
            panel1.Controls.Add(labelAgent);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 74);
            panel1.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(101, 60);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.MintCream;
            label3.Location = new Point(29, 406);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 47;
            // 
            // FormAdministrator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            ClientSize = new Size(988, 548);
            Controls.Add(dataGridViewAdmin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAdministrator";
            Text = "AdminForm";
            Load += FormAdministrator_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmin).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Label label6;
        private DataGridView dataGridViewAdmin;
        private Button btnUpdate;
        private Label LabelNombre;
        private Button btnAdd;
        private Label labelIdAdmin;
        private Button btnDelete;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label labelAgent;
        private Panel panel1;
        private Label label1;
        private Label label3;
    }
}