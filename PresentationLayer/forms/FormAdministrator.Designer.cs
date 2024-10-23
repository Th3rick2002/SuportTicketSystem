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
            labelID = new Label();
            labelName = new Label();
            labelPriority = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBoxState = new ComboBox();
            comboBoxAgent = new ComboBox();
            dataGridViewAdministrator = new DataGridView();
            btnSave = new Button();
            btnDelete = new Button();
            label1 = new Label();
            labelAdministrator = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdministrator).BeginInit();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelID.Location = new Point(41, 113);
            labelID.Name = "labelID";
            labelID.Size = new Size(25, 23);
            labelID.TabIndex = 1;
            labelID.Text = "Id";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelName.Location = new Point(41, 172);
            labelName.Name = "labelName";
            labelName.Size = new Size(73, 23);
            labelName.TabIndex = 2;
            labelName.Text = "Nombre";
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPriority.Location = new Point(41, 235);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(88, 23);
            labelPriority.TabIndex = 3;
            labelPriority.Text = "Propiedad";
            // 
            // labelState
            // 
            
            // 
            // labelAgent
            // 
           
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(158, 113);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 6;
            label7.Text = "#";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(158, 172);
            label8.Name = "label8";
            label8.Size = new Size(18, 20);
            label8.TabIndex = 7;
            label8.Text = "#";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(158, 235);
            label9.Name = "label9";
            label9.Size = new Size(18, 20);
            label9.TabIndex = 8;
            label9.Text = "#";
            // 
            // comboBoxState
            // 
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(158, 285);
            comboBoxState.Margin = new Padding(3, 4, 3, 4);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(138, 28);
            comboBoxState.TabIndex = 9;
            // 
            // comboBoxAgent
            // 
            comboBoxAgent.FormattingEnabled = true;
            comboBoxAgent.Location = new Point(158, 343);
            comboBoxAgent.Margin = new Padding(3, 4, 3, 4);
            comboBoxAgent.Name = "comboBoxAgent";
            comboBoxAgent.Size = new Size(138, 28);
            comboBoxAgent.TabIndex = 10;
            // 
            // dataGridViewAdministrator
            // 
            dataGridViewAdministrator.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdministrator.Location = new Point(329, 80);
            dataGridViewAdministrator.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAdministrator.Name = "dataGridViewAdministrator";
            dataGridViewAdministrator.RowHeadersWidth = 51;
            dataGridViewAdministrator.Size = new Size(688, 421);
            dataGridViewAdministrator.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(41, 424);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 77);
            btnSave.TabIndex = 12;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(179, 424);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 77);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(352, 12);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 0;
            // 
            // labelAdministrator
            // 
            labelAdministrator.AutoSize = true;
            labelAdministrator.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdministrator.Location = new Point(380, 35);
            labelAdministrator.Name = "labelAdministrator";
            labelAdministrator.Size = new Size(350, 41);
            labelAdministrator.TabIndex = 15;
            labelAdministrator.Text = "Panel de Administrador";
            // 
            // FormAdministrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 600);
            Controls.Add(labelAdministrator);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(dataGridViewAdministrator);
            Controls.Add(comboBoxAgent);
            Controls.Add(comboBoxState);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);

            Controls.Add(labelPriority);
            Controls.Add(labelName);
            Controls.Add(labelID);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdministrator";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdministrator).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelID;
        private Label labelName;
        private Label labelPriority;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBoxState;
        private ComboBox comboBoxAgent;
        private DataGridView dataGridViewAdministrator;
        private Button btnSave;
        private Button btnDelete;
        private Label label1;
        private Label labelAdministrator;
    }
}