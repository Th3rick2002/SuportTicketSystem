﻿namespace PresentationLayer.forms
{
    partial class AgentPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentPanelForm));
            dataGridViewAgent = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgent).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAgent
            // 
            dataGridViewAgent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewAgent.Location = new Point(214, 98);
            dataGridViewAgent.Name = "dataGridViewAgent";
            dataGridViewAgent.RowHeadersWidth = 51;
            dataGridViewAgent.Size = new Size(754, 401);
            dataGridViewAgent.TabIndex = 25;
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
            label1.Font = new Font("Source Serif Pro", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 29);
            label1.Name = "label1";
            label1.Size = new Size(445, 66);
            label1.TabIndex = 26;
            label1.Text = "PANEL DE AGENTE";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(157, 178, 191);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(85, 161);
            button1.Name = "button1";
            button1.Size = new Size(75, 54);
            button1.TabIndex = 27;
            button1.Text = "Empezar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(157, 178, 191);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(85, 262);
            button2.Margin = new Padding(3, 3, 3, 8);
            button2.Name = "button2";
            button2.Size = new Size(75, 54);
            button2.TabIndex = 28;
            button2.Text = "Finalizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(157, 178, 191);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(85, 360);
            button3.Name = "button3";
            button3.Size = new Size(75, 54);
            button3.TabIndex = 29;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre Ticket";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Descripcion Ticket";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Prioridad";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Estado";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Categoria";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Etiqueta";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Agente";
            Column7.Name = "Column7";
            // 
            // AgentPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 109, 130);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1059, 523);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridViewAgent);
            Controls.Add(label2);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "AgentPanelForm";
            Text = "AgentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewAgent;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}