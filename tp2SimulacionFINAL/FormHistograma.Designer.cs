namespace tp2SimulacionFINAL
{
    partial class FormHistograma
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartHistograma).BeginInit();
            SuspendLayout();
            // 
            // chartHistograma
            // 
            chartArea1.Name = "ChartArea1";
            chartHistograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartHistograma.Legends.Add(legend1);
            chartHistograma.Location = new Point(1, 1);
            chartHistograma.Margin = new Padding(3, 2, 3, 2);
            chartHistograma.Name = "chartHistograma";
            chartHistograma.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartHistograma.Series.Add(series1);
            chartHistograma.Size = new Size(798, 450);
            chartHistograma.TabIndex = 16;
            chartHistograma.Text = "chart1";
            // 
            // FormHistograma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartHistograma);
            Name = "FormHistograma";
            ShowIcon = false;
            Text = "FormHistograma";
            Load += FormHistograma_Load;
            ((System.ComponentModel.ISupportInitialize)chartHistograma).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistograma;
    }
}