using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

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

            if (!validarInputs()) return;

            dataGridViewDistFrecuencia.Visible = true;

            var cantIntervalos = comboBoxCantIntervalos.Text == null | comboBoxCantIntervalos.Text == "" ? Convert.ToInt32(Math.Ceiling(Math.Sqrt(Convert.ToInt32(textBoxTamañoMuestra.Text)))) : Convert.ToInt32(comboBoxCantIntervalos.SelectedValue);

            var parametro1 = Math.Round(Convert.ToDouble(textBoxParametro1.Text),4);

            var parametro2 = Math.Round(Convert.ToDouble(textBoxParametro2.Text),4);

            switch (comboBoxDistribucion.SelectedValue.ToString())
            {
                case "1":
                    double[] muestraUniforme = GeneradorHelper.GenerarDistUniforme(Convert.ToInt32(textBoxTamañoMuestra.Text), parametro1, parametro2);
                    dataGridViewMuestra.Columns.Clear();
                    dataGridViewMuestra.DataSource = muestraUniforme.Select(valor => new { Muestra = valor }).ToList(); // Asignar los datos generados como fuente de datos del DataGridView

                    GeneradorTablaFrecuenciasHelper.GenerarTablaFrecuencias(Convert.ToDouble(textBoxParametro1.Text), Convert.ToDouble(textBoxParametro2.Text), comboBoxDistribucion, dataGridViewDistFrecuencia, muestraUniforme, cantIntervalos);
                    break;


                case "2":
                    if (!validarExponencial()) break;
                    double[] muestraExpNegativa = GeneradorHelper.GenerarDistExpNegativa(Convert.ToInt32(textBoxTamañoMuestra.Text), parametro1);
                    dataGridViewMuestra.Columns.Clear();
                    dataGridViewMuestra.DataSource = muestraExpNegativa.Select(valor => new { Muestra = valor }).ToList(); // Asignar los datos generados como fuente de datos del DataGridView
                    parametro2 = 0.0;
                    GeneradorTablaFrecuenciasHelper.GenerarTablaFrecuencias(parametro1, parametro2, comboBoxDistribucion, dataGridViewDistFrecuencia, muestraExpNegativa, cantIntervalos); ;
                    break;
                case "3":
                    if (!validarNormal()) break;
                    double[] muestraNormal = GeneradorHelper.GenerarDistNormal(Convert.ToInt32(textBoxTamañoMuestra.Text), parametro1, parametro2);
                    dataGridViewMuestra.Columns.Clear();
                    dataGridViewMuestra.DataSource = muestraNormal.Select(valor => new { Muestra = valor }).ToList(); // Asignar los datos generados como fuente de datos del DataGridView

                    GeneradorTablaFrecuenciasHelper.GenerarTablaFrecuencias(parametro1, parametro2, comboBoxDistribucion, dataGridViewDistFrecuencia, muestraNormal, cantIntervalos);
                    break;
            }


        }

        private void buttonGraficar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDistFrecuencia.Rows.Count == 0) {
                MessageBox.Show("No se genero ninguna muestra.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormHistograma formHistograma = new FormHistograma(dataGridViewDistFrecuencia);
            formHistograma.Show();
        }
        private bool validarNormal() 
        {
            // Obtener los valores de los TextBox
            double media, desviacion;
            if (double.TryParse(textBoxParametro1.Text, out media) && double.TryParse(textBoxParametro2.Text, out desviacion))
            {
                if (desviacion < 0)
                {
                    MessageBox.Show("La desviacion estandar debe ser mayor o igual a 0.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            else
            {
                // Mostrar mensajes de error si los valores no son números double válidos
                MessageBox.Show("Por favor ingrese números válidos", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private bool validarExponencial()
        {
            // Obtener los valores de los TextBox
            double media;
            if (double.TryParse(textBoxParametro1.Text, out media) )
            {
                if (media < 0)
                {
                    MessageBox.Show("La desviacion estandar debe ser mayor o igual a 0.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            else
            {
                // Mostrar mensajes de error si los valores no son números double válidos
                MessageBox.Show("Por favor ingrese números válidos", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private bool validarUniforme()
        {
            // Obtener los valores de los TextBox
            double media, desviacion;
            if (double.TryParse(textBoxParametro1.Text, out media) && double.TryParse(textBoxParametro2.Text, out desviacion))
            {
                if (desviacion < 0)
                {
                    MessageBox.Show("La desviacion estandar debe ser mayor o igual a 0.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            else
            {
                // Mostrar mensajes de error si los valores no son números double válidos
                MessageBox.Show("Por favor ingrese números válidos", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private bool validarInputs()
        {
            // Obtener los valores de los TextBox
            int tamañoMuestra;
            double parametro1, parametro2;
            if (double.TryParse(textBoxParametro1.Text, out parametro1) && double.TryParse(textBoxParametro2.Text, out parametro2) && int.TryParse(textBoxTamañoMuestra.Text, out tamañoMuestra))
            {
                return true;
            }
            else
            {
                // Mostrar mensajes de error si los valores no son números double válidos
                MessageBox.Show("Por favor ingrese números válidos", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
