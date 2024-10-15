namespace PresentationLayer.forms
{
    partial class AgentForm
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
            btnEliminar = new Button();
            btnGuardar = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(147, 261);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 58);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(31, 261);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 58);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(283, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(602, 316);
            dataGridView1.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 217);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(133, 179);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 22;
            label9.Text = "#";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(133, 132);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 21;
            label8.Text = "#";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(133, 88);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 20;
            label7.Text = "#";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 225);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 18;
            label5.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 179);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 17;
            label4.Text = "Propiedad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 132);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 16;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-27, 118);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 15;
            label2.Text = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 14;
            label1.Text = "Panel de Agente";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 88);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 28;
            label10.Text = "Id";
            // 
            // AgentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 450);
            Controls.Add(label10);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgentForm";
            Text = "AgentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
    }
}