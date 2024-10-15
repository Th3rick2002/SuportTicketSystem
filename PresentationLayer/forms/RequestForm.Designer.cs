namespace PresentationLayer.forms
{
    partial class RequestForm
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
            label5 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(167, 261);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 58);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(51, 261);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 58);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(303, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(602, 316);
            dataGridView1.TabIndex = 37;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(153, 217);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 225);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 32;
            label5.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 29;
            label1.Text = "Solicitud de Ticket";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 40;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 84);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 42;
            label2.Text = "Nombre del ticket";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 155);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 43;
            label3.Text = "Descripcion del ticket";
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "RequestForm";
            Text = "RequestForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
    }
}