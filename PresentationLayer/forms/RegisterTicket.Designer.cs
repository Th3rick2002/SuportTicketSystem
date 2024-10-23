namespace PresentationLayer.forms
{
    partial class RegisterTicket
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
            labelDescripcionTiket = new Label();
            labelNameTicket = new Label();
            textBoxDescripcionTiket = new TextBox();
            textBoxNameTicket = new TextBox();
            comboBoxPriority = new ComboBox();
            labelPriority = new Label();
            LabelRegisterTicket = new Label();
            btnExit = new Button();
            btnSave = new Button();
            labeltag = new Label();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            comboBoxTag = new ComboBox();
            SuspendLayout();
            // 
            // labelDescripcionTiket
            // 
            labelDescripcionTiket.AutoSize = true;
            labelDescripcionTiket.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelDescripcionTiket.Location = new Point(245, 179);
            labelDescripcionTiket.Margin = new Padding(4, 0, 4, 0);
            labelDescripcionTiket.Name = "labelDescripcionTiket";
            labelDescripcionTiket.Size = new Size(173, 23);
            labelDescripcionTiket.TabIndex = 49;
            labelDescripcionTiket.Text = "Descripcion del ticket";
            // 
            // labelNameTicket
            // 
            labelNameTicket.AutoSize = true;
            labelNameTicket.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelNameTicket.Location = new Point(257, 115);
            labelNameTicket.Margin = new Padding(4, 0, 4, 0);
            labelNameTicket.Name = "labelNameTicket";
            labelNameTicket.Size = new Size(148, 23);
            labelNameTicket.TabIndex = 48;
            labelNameTicket.Text = "Nombre del ticket";
            // 
            // textBoxDescripcionTiket
            // 
            textBoxDescripcionTiket.Location = new Point(474, 175);
            textBoxDescripcionTiket.Margin = new Padding(4, 5, 4, 5);
            textBoxDescripcionTiket.Name = "textBoxDescripcionTiket";
            textBoxDescripcionTiket.Size = new Size(172, 30);
            textBoxDescripcionTiket.TabIndex = 47;
            // 
            // textBoxNameTicket
            // 
            textBoxNameTicket.Location = new Point(474, 110);
            textBoxNameTicket.Margin = new Padding(4, 5, 4, 5);
            textBoxNameTicket.Name = "textBoxNameTicket";
            textBoxNameTicket.Size = new Size(172, 30);
            textBoxNameTicket.TabIndex = 46;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Location = new Point(474, 246);
            comboBoxPriority.Margin = new Padding(4, 5, 4, 5);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(172, 31);
            comboBoxPriority.TabIndex = 45;
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPriority.Location = new Point(292, 246);
            labelPriority.Margin = new Padding(4, 0, 4, 0);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(79, 23);
            labelPriority.TabIndex = 44;
            labelPriority.Text = "Prioridad";
            // 
            // LabelRegisterTicket
            // 
            LabelRegisterTicket.AutoSize = true;
            LabelRegisterTicket.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRegisterTicket.Location = new Point(274, 21);
            LabelRegisterTicket.Margin = new Padding(4, 0, 4, 0);
            LabelRegisterTicket.Name = "LabelRegisterTicket";
            LabelRegisterTicket.Size = new Size(276, 41);
            LabelRegisterTicket.TabIndex = 50;
            LabelRegisterTicket.Text = "Registro De Ticket";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(250, 441);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 33);
            btnExit.TabIndex = 51;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(584, 430);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 33);
            btnSave.TabIndex = 52;
            btnSave.Text = "Guardar ";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // labeltag
            // 
            labeltag.AutoSize = true;
            labeltag.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labeltag.Location = new Point(295, 387);
            labeltag.Margin = new Padding(4, 0, 4, 0);
            labeltag.Name = "labeltag";
            labeltag.Size = new Size(73, 23);
            labeltag.TabIndex = 53;
            labeltag.Text = "Etiqueta";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelCategory.Location = new Point(289, 313);
            labelCategory.Margin = new Padding(4, 0, 4, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(84, 23);
            labelCategory.TabIndex = 54;
            labelCategory.Text = "Categoria";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(474, 313);
            comboBoxCategory.Margin = new Padding(4, 5, 4, 5);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(172, 31);
            comboBoxCategory.TabIndex = 55;
            // 
            // comboBoxTag
            // 
            comboBoxTag.FormattingEnabled = true;
            comboBoxTag.Location = new Point(474, 379);
            comboBoxTag.Margin = new Padding(4, 5, 4, 5);
            comboBoxTag.Name = "comboBoxTag";
            comboBoxTag.Size = new Size(172, 31);
            comboBoxTag.TabIndex = 56;
            // 
            // RegisterTicket
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 518);
            Controls.Add(comboBoxTag);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelCategory);
            Controls.Add(labeltag);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(LabelRegisterTicket);
            Controls.Add(labelDescripcionTiket);
            Controls.Add(labelNameTicket);
            Controls.Add(textBoxDescripcionTiket);
            Controls.Add(textBoxNameTicket);
            Controls.Add(comboBoxPriority);
            Controls.Add(labelPriority);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegisterTicket";
            Text = "RegisterTicket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDescripcionTiket;
        private Label labelNameTicket;
        private TextBox textBoxDescripcionTiket;
        private TextBox textBoxNameTicket;
        private ComboBox comboBoxPriority;
        private Label labelPriority;
        private Label LabelRegisterTicket;
        private Button btnExit;
        private Button btnSave;
        private Label labeltag;
        private Label labelCategory;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxTag;
    }
}