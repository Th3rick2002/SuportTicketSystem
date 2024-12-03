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
            buttonDeleteAgent = new Button();
            pictureAgent = new PictureBox();
            btnUpdateAgent = new Button();
            btnAddAgent = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            dataGridViewAgents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureAgent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgents).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteAgent
            // 
            buttonDeleteAgent.BackColor = Color.FromArgb(235, 239, 242);
            buttonDeleteAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            buttonDeleteAgent.ForeColor = Color.Black;
            buttonDeleteAgent.Location = new Point(940, 450);
            buttonDeleteAgent.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteAgent.Name = "buttonDeleteAgent";
            buttonDeleteAgent.Size = new Size(161, 47);
            buttonDeleteAgent.TabIndex = 55;
            buttonDeleteAgent.Text = "Eliminar ";
            buttonDeleteAgent.UseVisualStyleBackColor = false;
            buttonDeleteAgent.Click += buttonDeleteAgent_Click;
            // 
            // pictureAgent
            // 
            pictureAgent.BackColor = Color.FromArgb(207, 206, 242);
            pictureAgent.BorderStyle = BorderStyle.Fixed3D;
            pictureAgent.Image = (Image)resources.GetObject("pictureAgent.Image");
            pictureAgent.Location = new Point(949, 35);
            pictureAgent.Name = "pictureAgent";
            pictureAgent.Size = new Size(152, 141);
            pictureAgent.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureAgent.TabIndex = 53;
            pictureAgent.TabStop = false;
            // 
            // btnUpdateAgent
            // 
            btnUpdateAgent.BackColor = Color.FromArgb(235, 239, 242);
            btnUpdateAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdateAgent.ForeColor = Color.Black;
            btnUpdateAgent.Location = new Point(940, 354);
            btnUpdateAgent.Margin = new Padding(4, 5, 4, 5);
            btnUpdateAgent.Name = "btnUpdateAgent";
            btnUpdateAgent.Size = new Size(161, 47);
            btnUpdateAgent.TabIndex = 52;
            btnUpdateAgent.Text = "Actualizar ";
            btnUpdateAgent.UseVisualStyleBackColor = false;
            btnUpdateAgent.Click += btnUpdateAgent_Click;
            // 
            // btnAddAgent
            // 
            btnAddAgent.BackColor = Color.FromArgb(235, 239, 242);
            btnAddAgent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAddAgent.ForeColor = Color.Black;
            btnAddAgent.Location = new Point(940, 253);
            btnAddAgent.Margin = new Padding(4, 5, 4, 5);
            btnAddAgent.Name = "btnAddAgent";
            btnAddAgent.Size = new Size(161, 49);
            btnAddAgent.TabIndex = 51;
            btnAddAgent.Text = "Agregar ";
            btnAddAgent.UseVisualStyleBackColor = false;
            btnAddAgent.Click += btnAddAgent_Click;
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
            // dataGridViewAgents
            // 
            dataGridViewAgents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewAgents.BackgroundColor = Color.FromArgb(235, 239, 242);
            dataGridViewAgents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgents.Location = new Point(12, 120);
            dataGridViewAgents.Name = "dataGridViewAgents";
            dataGridViewAgents.RowHeadersWidth = 51;
            dataGridViewAgents.Size = new Size(890, 596);
            dataGridViewAgents.TabIndex = 59;
            // 
            // FormAgentAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 167, 242);
            ClientSize = new Size(1129, 730);
            Controls.Add(dataGridViewAgents);
            Controls.Add(label1);
            Controls.Add(buttonDeleteAgent);
            Controls.Add(btnUpdateAgent);
            Controls.Add(btnAddAgent);
            Controls.Add(pictureAgent);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormAgentAdmin";
            Text = "FormAgentAdmin";
            Load += FormAgentAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureAgent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDeleteAgent;
        private PictureBox pictureAgent;
        private Button btnUpdateAgent;
        private Button btnAddAgent;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private DataGridView dataGridViewAgents;
    }
}