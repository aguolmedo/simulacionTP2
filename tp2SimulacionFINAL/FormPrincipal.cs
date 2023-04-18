using System.ComponentModel;

namespace tp2SimulacionFINAL
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }



        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            labelParametro1.Visible = false;
            labelParametro2.Visible = false;
            textBoxParametro1.Visible = false;
            textBoxParametro2.Visible = false;

            List<OpcionDistribucion> distribuciones = new List<OpcionDistribucion>
            {
                new OpcionDistribucion { Id = 1, Nombre = "Uniforme" },
                new OpcionDistribucion { Id = 2, Nombre = "Exponencial Negativa" },
                new OpcionDistribucion { Id = 3, Nombre = "Normal" },
            };

            comboBoxDistribucion.DataSource = distribuciones;
            comboBoxDistribucion.DisplayMember = "Nombre";
            comboBoxDistribucion.ValueMember = "Id";

            List<int> intervalos = new List<int> { 10, 15, 20, 25 };
            comboBoxCantIntervalos.DataSource = intervalos;



        }


        public class OpcionDistribucion
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }

        private void comboBoxDistribucion_SelectedValueChanged(object sender, EventArgs e)
        {
            string opcionSeleccionada = comboBoxDistribucion.SelectedValue.ToString();

            switch (opcionSeleccionada)
            {
                case "1":
                    labelParametro1.Text = "A";
                    labelParametro2.Text = "B";

                    labelParametro1.Visible = true;
                    labelParametro2.Visible = true;
                    textBoxParametro1.Visible = true;
                    textBoxParametro2.Visible = true;

                    dataGridViewMuestra.Columns.Clear();


                    break;

                case "2":
                    labelParametro1.Text = "Media";
                    labelParametro1.Visible = true;
                    textBoxParametro1.Visible = true;
                    labelParametro2.Visible = false;
                    textBoxParametro2.Visible = false;

                    dataGridViewMuestra.Columns.Clear();



                    break;
                case "3":
                    labelParametro1.Text = "Media";
                    labelParametro2.Text = "Desviacion";

                    labelParametro2.Visible = true;
                    labelParametro1.Visible = true;
                    textBoxParametro1.Visible = true;
                    textBoxParametro2.Visible = true;

                    dataGridViewMuestra.Columns.Clear();


                    break;
            }

        }

        private void buttonGenerarMuestra_Click(object sender, EventArgs e)
        {

            dataGridViewDistFrecuencia.Visible = true;

            var cantIntervalos = comboBoxCantIntervalos.Text == null | comboBoxCantIntervalos.Text == "" ? Convert.ToInt32(Math.Ceiling(Math.Sqrt(Convert.ToInt32(textBoxTamañoMuestra.Text)))) : Convert.ToInt32(comboBoxCantIntervalos.SelectedValue);


            switch (comboBoxDistribucion.SelectedValue.ToString())
            {
                case "1":
                    double[] muestraUniforme = GeneradorHelper.GenerarDistUniforme(Convert.ToInt32(textBoxTamañoMuestra.Text), Convert.ToInt32(textBoxParametro1.Text), Convert.ToInt32(textBoxParametro2.Text));
                    dataGridViewMuestra.Columns.Clear();
                    dataGridViewMuestra.DataSource = muestraUniforme.Select(valor => new { Muestra = valor }).ToList(); // Asignar los datos generados como fuente de datos del DataGridView

                    GeneradorTablaFrecuenciasHelper.GenerarTablaFrecuencias(Convert.ToDouble(textBoxParametro1.Text), Convert.ToDouble(textBoxParametro2.Text), comboBoxDistribucion, dataGridViewDistFrecuencia, muestraUniforme, cantIntervalos);
                    break;


                case "2":
                    double[] muestraExpNegativa = GeneradorHelper.GenerarDistExpNegativa(Convert.ToInt32(textBoxTamañoMuestra.Text), Convert.ToInt32(textBoxParametro1.Text));
                    dataGridViewMuestra.Columns.Clear();
                    dataGridViewMuestra.DataSource = muestraExpNegativa.Select(valor => new { Muestra = valor }).ToList(); // Asignar los datos generados como fuente de datos del DataGridView
                    double parametro2 = 0.0;
                    GeneradorTablaFrecuenciasHelper.GenerarTablaFrecuencias(Convert.ToDouble(textBoxParametro1.Text), parametro2, comboBoxDistribucion, dataGridViewDistFrecuencia, muestraExpNegativa, cantIntervalos); ;
                    break;
                case "3":
                    double[] muestraNormal = GeneradorHelper.GenerarDistNormal(Convert.ToInt32(textBoxTamañoMuestra.Text), Convert.ToInt32(textBoxParametro1.Text), Convert.ToInt32(textBoxParametro2.Text));
                    dataGridViewMuestra.Columns.Clear();
                    dataGridViewMuestra.DataSource = muestraNormal.Select(valor => new { Muestra = valor }).ToList(); // Asignar los datos generados como fuente de datos del DataGridView

                    GeneradorTablaFrecuenciasHelper.GenerarTablaFrecuencias(Convert.ToDouble(textBoxParametro1.Text), Convert.ToDouble(textBoxParametro2.Text), comboBoxDistribucion, dataGridViewDistFrecuencia, muestraNormal, cantIntervalos);
                    break;
            }


        }

        private void buttonGraficar_Click(object sender, EventArgs e)
        {
            FormHistograma formHistograma = new FormHistograma(dataGridViewDistFrecuencia);
            formHistograma.Show();
        }
    }
}
