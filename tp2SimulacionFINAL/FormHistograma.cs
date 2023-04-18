using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2SimulacionFINAL
{
    public partial class FormHistograma : Form
    {
        private DataGridView dataGridViewDistFrecuencia;

        public FormHistograma(DataGridView dataGridView)
        {
            dataGridViewDistFrecuencia = dataGridView;
            InitializeComponent();
        }

        private void FormHistograma_Load(object sender, EventArgs e)
        {
            chartHistograma.Visible = true;

            GeneradorHistogramaHelper.GenerarHistograma(dataGridViewDistFrecuencia, chartHistograma);

        }
    }
}
