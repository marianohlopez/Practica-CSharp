using System.Data;

namespace PrimerEjercicio
{
    public partial class PrimerEjercicio : Form
    {
        public PrimerEjercicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculo_Click(object sender, EventArgs e)
        {
            string Numero1 = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el primer Numero", "Datos");
            string Numero2 = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el segundo Numero", "Datos");
            int.TryParse(Numero1, out int Num1);
            int.TryParse(Numero2, out int Num2);
            if (Num1 > Num2)
            {
                MessageBox.Show($"El numero mas alto es {Num1}", "Calculo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"El numero mas alto es {Num2}", "Calculo", MessageBoxButtons.OK);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int renglon = dtgvDatos.Rows.Add();
            Postulante persona = new Postulante(txtNombre.Text, txtApellido.Text, comboBox1.Text, txtDocumento.Text);
            dtgvDatos.Rows[renglon].Cells[0].Value = persona.Nombre;
            dtgvDatos.Rows[renglon].Cells[1].Value = persona.Apellido;
            dtgvDatos.Rows[renglon].Cells[2].Value = persona.Documento;
            dtgvDatos.Rows[renglon].Cells[3].Value = persona.Tipo;

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            comboBox1.Text = "";

            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            comboBox1.Text = "";
        }

        private void dtgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nro = e.RowIndex;
            int nroColumn = e.ColumnIndex;
            if(nro != -1)
            {
                MessageBox.Show((string)dtgvDatos.Rows[nro].Cells[nroColumn].Value);
            }
            else
            {
                MessageBox.Show("Selecciono el encabezado");
            }
        }
    }
}
