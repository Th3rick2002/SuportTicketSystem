namespace PresentationLayer.forms
{
    partial class FormClient
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
            btnExit = new Button();
            btnAdd = new Button();
            dataGridViewClient = new DataGridView();
            lblClient = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(1039, 310);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(161, 47);
            btnExit.TabIndex = 39;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAdd.Location = new Point(1039, 214);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 49);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClient
            // 
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.Location = new Point(134, 123);
            dataGridViewClient.Margin = new Padding(4, 5, 4, 5);
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.RowHeadersWidth = 51;
            dataGridViewClient.Size = new Size(860, 484);
            dataGridViewClient.TabIndex = 37;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClient.Location = new Point(501, 26);
            lblClient.Margin = new Padding(4, 0, 4, 0);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(247, 41);
            lblClient.TabIndex = 29;
            lblClient.Text = "Panel De Cliente";
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 690);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewClient);
            Controls.Add(lblClient);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormClient";
            Text = "RequestForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExit;
        private Button btnAdd;
        private DataGridView dataGridViewClient;
        private Label lblClient;
    }
}