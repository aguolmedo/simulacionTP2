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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            labelCantidadIntervalos = new Label();
            dataGridViewDistFrecuencia = new DataGridView();
            chartHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonGraficar = new Button();
            comboBoxCantIntervalos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMuestra).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDistFrecuencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartHistograma).BeginInit();
            SuspendLayout();
            // 
            // labelDistribucion
            // 
            labelDistribucion.AutoSize = true;
            labelDistribucion.Location = new Point(6, 84);
            labelDistribucion.Name = "labelDistribucion";
            labelDistribucion.Size = new Size(92, 20);
            labelDistribucion.TabIndex = 0;
            labelDistribucion.Text = "Distribucion:";
            // 
            // comboBoxDistribucion
            // 
            comboBoxDistribucion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDistribucion.FormattingEnabled = true;
            comboBoxDistribucion.Location = new Point(101, 81);
            comboBoxDistribucion.Name = "comboBoxDistribucion";
            comboBoxDistribucion.Size = new Size(143, 28);
            comboBoxDistribucion.TabIndex = 1;
            comboBoxDistribucion.SelectedValueChanged += comboBoxDistribucion_SelectedValueChanged;
            // 
            // labelTamañoMuestra
            // 
            labelTamañoMuestra.AutoSize = true;
            labelTamañoMuestra.Location = new Point(6, 39);
            labelTamañoMuestra.Name = "labelTamañoMuestra";
            labelTamañoMuestra.Size = new Size(121, 20);
            labelTamañoMuestra.TabIndex = 2;
            labelTamañoMuestra.Text = "Tamaño Muestra:";
            // 
            // textBoxTamañoMuestra
            // 
            textBoxTamañoMuestra.Location = new Point(133, 39);
            textBoxTamañoMuestra.Name = "textBoxTamañoMuestra";
            textBoxTamañoMuestra.Size = new Size(111, 27);
            textBoxTamañoMuestra.TabIndex = 3;
            // 
            // labelParametro1
            // 
            labelParametro1.AutoSize = true;
            labelParametro1.Location = new Point(10, 44);
            labelParametro1.Name = "labelParametro1";
            labelParametro1.Size = new Size(85, 20);
            labelParametro1.TabIndex = 4;
            labelParametro1.Text = "Parametro1";
            // 
            // textBoxParametro1
            // 
            textBoxParametro1.Location = new Point(121, 41);
            textBoxParametro1.Name = "textBoxParametro1";
            textBoxParametro1.Size = new Size(122, 27);
            textBoxParametro1.TabIndex = 5;
            // 
            // textBoxParametro2
            // 
            textBoxParametro2.Location = new Point(121, 77);
            textBoxParametro2.Name = "textBoxParametro2";
            textBoxParametro2.Size = new Size(122, 27);
            textBoxParametro2.TabIndex = 6;
            // 
            // labelParametro2
            // 
            labelParametro2.AutoSize = true;
            labelParametro2.Location = new Point(10, 77);
            labelParametro2.Name = "labelParametro2";
            labelParametro2.Size = new Size(85, 20);
            labelParametro2.TabIndex = 7;
            labelParametro2.Text = "Parametro2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(203, 41);
            label1.TabIndex = 8;
            label1.Text = "TP2 - Grupo 9";
            // 
            // buttonGenerarMuestra
            // 
            buttonGenerarMuestra.Location = new Point(22, 495);
            buttonGenerarMuestra.Name = "buttonGenerarMuestra";
            buttonGenerarMuestra.Size = new Size(110, 58);
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
            dataGridViewMuestra.Location = new Point(294, 96);
            dataGridViewMuestra.Name = "dataGridViewMuestra";
            dataGridViewMuestra.ReadOnly = true;
            dataGridViewMuestra.RowHeadersWidth = 51;
            dataGridViewMuestra.RowTemplate.Height = 29;
            dataGridViewMuestra.Size = new Size(161, 457);
            dataGridViewMuestra.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelTamañoMuestra);
            groupBox1.Controls.Add(textBoxTamañoMuestra);
            groupBox1.Controls.Add(labelDistribucion);
            groupBox1.Controls.Add(comboBoxDistribucion);
            groupBox1.Location = new Point(12, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 125);
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
            groupBox2.Location = new Point(12, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 125);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parametro/s";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxCantIntervalos);
            groupBox3.Controls.Add(labelCantidadIntervalos);
            groupBox3.Location = new Point(12, 371);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(257, 89);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Intervalos";
            // 
            // labelCantidadIntervalos
            // 
            labelCantidadIntervalos.AutoSize = true;
            labelCantidadIntervalos.Location = new Point(10, 42);
            labelCantidadIntervalos.Name = "labelCantidadIntervalos";
            labelCantidadIntervalos.Size = new Size(140, 20);
            labelCantidadIntervalos.TabIndex = 0;
            labelCantidadIntervalos.Text = "Cantidad intervalos:";
            // 
            // dataGridViewDistFrecuencia
            // 
            dataGridViewDistFrecuencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDistFrecuencia.Location = new Point(482, 96);
            dataGridViewDistFrecuencia.Name = "dataGridViewDistFrecuencia";
            dataGridViewDistFrecuencia.RowHeadersWidth = 51;
            dataGridViewDistFrecuencia.RowTemplate.Height = 29;
            dataGridViewDistFrecuencia.Size = new Size(536, 457);
            dataGridViewDistFrecuencia.TabIndex = 14;
            // 
            // chartHistograma
            // 
            chartArea1.Name = "ChartArea1";
            chartHistograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartHistograma.Legends.Add(legend1);
            chartHistograma.Location = new Point(482, 96);
            chartHistograma.Name = "chartHistograma";
            chartHistograma.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartHistograma.Series.Add(series1);
            chartHistograma.Size = new Size(534, 457);
            chartHistograma.TabIndex = 15;
            chartHistograma.Text = "chart1";
            // 
            // buttonGraficar
            // 
            buttonGraficar.Location = new Point(145, 495);
            buttonGraficar.Name = "buttonGraficar";
            buttonGraficar.Size = new Size(110, 58);
            buttonGraficar.TabIndex = 16;
            buttonGraficar.Text = "Graficar";
            buttonGraficar.UseVisualStyleBackColor = true;
            buttonGraficar.Click += buttonGraficar_Click;
            // 
            // comboBoxCantIntervalos
            // 
            comboBoxCantIntervalos.FormattingEnabled = true;
            comboBoxCantIntervalos.Location = new Point(156, 42);
            comboBoxCantIntervalos.Name = "comboBoxCantIntervalos";
            comboBoxCantIntervalos.Size = new Size(87, 28);
            comboBoxCantIntervalos.TabIndex = 17;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 565);
            Controls.Add(buttonGraficar);
            Controls.Add(chartHistograma);
            Controls.Add(dataGridViewDistFrecuencia);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewMuestra);
            Controls.Add(buttonGenerarMuestra);
            Controls.Add(label1);
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
            ((System.ComponentModel.ISupportInitialize)chartHistograma).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistograma;
        private Button buttonGraficar;
        private ComboBox comboBoxCantIntervalos;
    }
}