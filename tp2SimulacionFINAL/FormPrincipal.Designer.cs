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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            comboBoxCantIntervalos = new ComboBox();
            labelCantidadIntervalos = new Label();
            dataGridViewDistFrecuencia = new DataGridView();
            buttonGraficar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMuestra).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDistFrecuencia).BeginInit();
            SuspendLayout();
            // 
            // labelDistribucion
            // 
            labelDistribucion.AutoSize = true;
            labelDistribucion.Location = new Point(5, 63);
            labelDistribucion.Name = "labelDistribucion";
            labelDistribucion.Size = new Size(74, 15);
            labelDistribucion.TabIndex = 0;
            labelDistribucion.Text = "Distribucion:";
            // 
            // comboBoxDistribucion
            // 
            comboBoxDistribucion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDistribucion.FormattingEnabled = true;
            comboBoxDistribucion.Location = new Point(88, 61);
            comboBoxDistribucion.Margin = new Padding(3, 2, 3, 2);
            comboBoxDistribucion.Name = "comboBoxDistribucion";
            comboBoxDistribucion.Size = new Size(126, 23);
            comboBoxDistribucion.TabIndex = 1;
            comboBoxDistribucion.SelectedValueChanged += comboBoxDistribucion_SelectedValueChanged;
            // 
            // labelTamañoMuestra
            // 
            labelTamañoMuestra.AutoSize = true;
            labelTamañoMuestra.Location = new Point(5, 29);
            labelTamañoMuestra.Name = "labelTamañoMuestra";
            labelTamañoMuestra.Size = new Size(98, 15);
            labelTamañoMuestra.TabIndex = 2;
            labelTamañoMuestra.Text = "Tamaño Muestra:";
            // 
            // textBoxTamañoMuestra
            // 
            textBoxTamañoMuestra.Location = new Point(116, 29);
            textBoxTamañoMuestra.Margin = new Padding(3, 2, 3, 2);
            textBoxTamañoMuestra.Name = "textBoxTamañoMuestra";
            textBoxTamañoMuestra.Size = new Size(98, 23);
            textBoxTamañoMuestra.TabIndex = 3;
            // 
            // labelParametro1
            // 
            labelParametro1.AutoSize = true;
            labelParametro1.Location = new Point(9, 33);
            labelParametro1.Name = "labelParametro1";
            labelParametro1.Size = new Size(68, 15);
            labelParametro1.TabIndex = 4;
            labelParametro1.Text = "Parametro1";
            // 
            // textBoxParametro1
            // 
            textBoxParametro1.Location = new Point(106, 31);
            textBoxParametro1.Margin = new Padding(3, 2, 3, 2);
            textBoxParametro1.Name = "textBoxParametro1";
            textBoxParametro1.Size = new Size(107, 23);
            textBoxParametro1.TabIndex = 5;
            // 
            // textBoxParametro2
            // 
            textBoxParametro2.Location = new Point(106, 58);
            textBoxParametro2.Margin = new Padding(3, 2, 3, 2);
            textBoxParametro2.Name = "textBoxParametro2";
            textBoxParametro2.Size = new Size(107, 23);
            textBoxParametro2.TabIndex = 6;
            // 
            // labelParametro2
            // 
            labelParametro2.AutoSize = true;
            labelParametro2.Location = new Point(9, 58);
            labelParametro2.Name = "labelParametro2";
            labelParametro2.Size = new Size(68, 15);
            labelParametro2.TabIndex = 7;
            labelParametro2.Text = "Parametro2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 8;
            label1.Text = "TP2 - Grupo 9";
            // 
            // buttonGenerarMuestra
            // 
            buttonGenerarMuestra.Location = new Point(19, 371);
            buttonGenerarMuestra.Margin = new Padding(3, 2, 3, 2);
            buttonGenerarMuestra.Name = "buttonGenerarMuestra";
            buttonGenerarMuestra.Size = new Size(96, 44);
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
            dataGridViewMuestra.Location = new Point(257, 72);
            dataGridViewMuestra.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMuestra.Name = "dataGridViewMuestra";
            dataGridViewMuestra.ReadOnly = true;
            dataGridViewMuestra.RowHeadersWidth = 51;
            dataGridViewMuestra.RowTemplate.Height = 29;
            dataGridViewMuestra.Size = new Size(141, 343);
            dataGridViewMuestra.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelTamañoMuestra);
            groupBox1.Controls.Add(textBoxTamañoMuestra);
            groupBox1.Controls.Add(labelDistribucion);
            groupBox1.Controls.Add(comboBoxDistribucion);
            groupBox1.Location = new Point(10, 72);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(225, 94);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelParametro1);
            groupBox2.Controls.Add(labelParametro2);
            groupBox2.Controls.Add(textBoxParametro1);
            groupBox2.Controls.Add(textBoxParametro2);
            groupBox2.Location = new Point(10, 180);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(225, 94);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parametro/s";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxCantIntervalos);
            groupBox3.Controls.Add(labelCantidadIntervalos);
            groupBox3.Location = new Point(10, 278);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(225, 67);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Intervalos";
            // 
            // comboBoxCantIntervalos
            // 
            comboBoxCantIntervalos.FormattingEnabled = true;
            comboBoxCantIntervalos.Location = new Point(136, 32);
            comboBoxCantIntervalos.Margin = new Padding(3, 2, 3, 2);
            comboBoxCantIntervalos.Name = "comboBoxCantIntervalos";
            comboBoxCantIntervalos.Size = new Size(77, 23);
            comboBoxCantIntervalos.TabIndex = 17;
            // 
            // labelCantidadIntervalos
            // 
            labelCantidadIntervalos.AutoSize = true;
            labelCantidadIntervalos.Location = new Point(9, 32);
            labelCantidadIntervalos.Name = "labelCantidadIntervalos";
            labelCantidadIntervalos.Size = new Size(112, 15);
            labelCantidadIntervalos.TabIndex = 0;
            labelCantidadIntervalos.Text = "Cantidad intervalos:";
            // 
            // dataGridViewDistFrecuencia
            // 
            dataGridViewDistFrecuencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDistFrecuencia.Location = new Point(422, 72);
            dataGridViewDistFrecuencia.Margin = new Padding(3, 2, 3, 2);
            dataGridViewDistFrecuencia.Name = "dataGridViewDistFrecuencia";
            dataGridViewDistFrecuencia.RowHeadersWidth = 51;
            dataGridViewDistFrecuencia.RowTemplate.Height = 29;
            dataGridViewDistFrecuencia.Size = new Size(469, 343);
            dataGridViewDistFrecuencia.TabIndex = 14;
            // 
            // buttonGraficar
            // 
            buttonGraficar.Location = new Point(127, 371);
            buttonGraficar.Margin = new Padding(3, 2, 3, 2);
            buttonGraficar.Name = "buttonGraficar";
            buttonGraficar.Size = new Size(96, 44);
            buttonGraficar.TabIndex = 16;
            buttonGraficar.Text = "Graficar";
            buttonGraficar.UseVisualStyleBackColor = true;
            buttonGraficar.Click += buttonGraficar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 424);
            Controls.Add(buttonGraficar);
            Controls.Add(dataGridViewDistFrecuencia);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewMuestra);
            Controls.Add(buttonGenerarMuestra);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPrincipal";
            Text = "Tp2 - Grupo 9";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMuestra).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDistFrecuencia).EndInit();
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label labelCantidadIntervalos;
        private DataGridView dataGridViewDistFrecuencia;
        private Button buttonGraficar;
        private ComboBox comboBoxCantIntervalos;
    }
}