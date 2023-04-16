namespace tp2SimulacionFINAL
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelDistribucion = new Label();
            comboBoxDistribucion = new ComboBox();
            labelTamañoMuestra = new Label();
            textBoxTamañoMuestra = new TextBox();
            labelParametro1 = new Label();
            textBoxParametro1 = new TextBox();
            textBoxParametro2 = new TextBox();
            labelParametro2 = new Label();
            label1 = new Label();
            buttonGenerarMuestra = new Button();
            dataGridViewMuestra = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMuestra).BeginInit();
            SuspendLayout();
            // 
            // labelDistribucion
            // 
            labelDistribucion.AutoSize = true;
            labelDistribucion.Location = new Point(12, 147);
            labelDistribucion.Name = "labelDistribucion";
            labelDistribucion.Size = new Size(89, 20);
            labelDistribucion.TabIndex = 0;
            labelDistribucion.Text = "Distribucion";
            // 
            // comboBoxDistribucion
            // 
            comboBoxDistribucion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDistribucion.FormattingEnabled = true;
            comboBoxDistribucion.Location = new Point(113, 147);
            comboBoxDistribucion.Name = "comboBoxDistribucion";
            comboBoxDistribucion.Size = new Size(151, 28);
            comboBoxDistribucion.TabIndex = 1;
            comboBoxDistribucion.SelectedValueChanged += comboBoxDistribucion_SelectedValueChanged;
            // 
            // labelTamañoMuestra
            // 
            labelTamañoMuestra.AutoSize = true;
            labelTamañoMuestra.Location = new Point(12, 96);
            labelTamañoMuestra.Name = "labelTamañoMuestra";
            labelTamañoMuestra.Size = new Size(121, 20);
            labelTamañoMuestra.TabIndex = 2;
            labelTamañoMuestra.Text = "Tamaño Muestra:";
            // 
            // textBoxTamañoMuestra
            // 
            textBoxTamañoMuestra.Location = new Point(139, 96);
            textBoxTamañoMuestra.Name = "textBoxTamañoMuestra";
            textBoxTamañoMuestra.Size = new Size(125, 27);
            textBoxTamañoMuestra.TabIndex = 3;
            // 
            // labelParametro1
            // 
            labelParametro1.AutoSize = true;
            labelParametro1.Location = new Point(12, 201);
            labelParametro1.Name = "labelParametro1";
            labelParametro1.Size = new Size(85, 20);
            labelParametro1.TabIndex = 4;
            labelParametro1.Text = "Parametro1";
            // 
            // textBoxParametro1
            // 
            textBoxParametro1.Location = new Point(113, 198);
            textBoxParametro1.Name = "textBoxParametro1";
            textBoxParametro1.Size = new Size(90, 27);
            textBoxParametro1.TabIndex = 5;
            // 
            // textBoxParametro2
            // 
            textBoxParametro2.Location = new Point(113, 243);
            textBoxParametro2.Name = "textBoxParametro2";
            textBoxParametro2.Size = new Size(90, 27);
            textBoxParametro2.TabIndex = 6;
            // 
            // labelParametro2
            // 
            labelParametro2.AutoSize = true;
            labelParametro2.Location = new Point(12, 246);
            labelParametro2.Name = "labelParametro2";
            labelParametro2.Size = new Size(85, 20);
            labelParametro2.TabIndex = 7;
            labelParametro2.Text = "Parametro2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(181, 23);
            label1.Name = "label1";
            label1.Size = new Size(382, 41);
            label1.TabIndex = 8;
            label1.Text = "SUPER TRABAJO PRACTICO";
            // 
            // buttonGenerarMuestra
            // 
            buttonGenerarMuestra.Location = new Point(151, 507);
            buttonGenerarMuestra.Name = "buttonGenerarMuestra";
            buttonGenerarMuestra.Size = new Size(113, 46);
            buttonGenerarMuestra.TabIndex = 9;
            buttonGenerarMuestra.Text = "Generar";
            buttonGenerarMuestra.UseVisualStyleBackColor = true;
            buttonGenerarMuestra.Click += buttonGenerarMuestra_Click;
            // 
            // dataGridViewMuestra
            // 
            dataGridViewMuestra.AllowUserToAddRows = false;
            dataGridViewMuestra.AllowUserToDeleteRows = false;
            dataGridViewMuestra.AllowUserToOrderColumns = true;
            dataGridViewMuestra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMuestra.Location = new Point(289, 96);
            dataGridViewMuestra.Name = "dataGridViewMuestra";
            dataGridViewMuestra.ReadOnly = true;
            dataGridViewMuestra.RowHeadersWidth = 51;
            dataGridViewMuestra.RowTemplate.Height = 29;
            dataGridViewMuestra.Size = new Size(161, 457);
            dataGridViewMuestra.TabIndex = 10;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 565);
            Controls.Add(dataGridViewMuestra);
            Controls.Add(buttonGenerarMuestra);
            Controls.Add(label1);
            Controls.Add(labelParametro2);
            Controls.Add(textBoxParametro2);
            Controls.Add(textBoxParametro1);
            Controls.Add(labelParametro1);
            Controls.Add(textBoxTamañoMuestra);
            Controls.Add(labelTamañoMuestra);
            Controls.Add(comboBoxDistribucion);
            Controls.Add(labelDistribucion);
            Name = "FormPrincipal";
            Text = "Tp2 - Grupo 9";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMuestra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDistribucion;
        private ComboBox comboBoxDistribucion;
        private Label labelTamañoMuestra;
        private TextBox textBoxTamañoMuestra;
        private Label labelParametro1;
        private TextBox textBoxParametro1;
        private TextBox textBoxParametro2;
        private Label labelParametro2;
        private Label label1;
        private Button buttonGenerarMuestra;
        private DataGridView dataGridViewMuestra;
    }
}