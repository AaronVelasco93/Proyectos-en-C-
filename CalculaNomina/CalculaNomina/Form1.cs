using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaNomina
{
    public partial class Error1 : Form
    {
        Empleado miEmpleado = new Empleado();
        Nomina miNomina = new Nomina();

        public Error1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //limpiar las cajas de texto para hacer un noevo cambio
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtAsignacionDia.Clear();
            txtTotalDevengado.Clear();
            txtDiasLaborados.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //metodo para cerrar la aplicacion
            Application.Exit();
        }
        
        private void btnAlmacenaRegistro_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "") {
                error_1.SetError(txtNombre, "Ingresa un texto");
                txtNombre.Focus();
                return;                
            }
            error_1.SetError(txtNombre, "");

            //valida para que solo pueda ingresar datos numericos
            decimal AsginacionDia;
            if (!Decimal.TryParse(txtAsignacionDia.Text, out AsginacionDia))
            {
                error_1.SetError(txtAsignacionDia, "Ingresa un numero");
                txtNombre.Focus();
                return;
            }
            error_1.SetError(txtAsignacionDia, "");

            miEmpleado.Nombre = txtNombre.Text;

            miEmpleado.Identificacion = txtIdentificacion.Text;

            miEmpleado.AsignacionDia = ( txtAsignacionDia.Text);

            miNomina.DiasLaborados = Convert.ToInt32(txtDiasLaborados.Text);
            MessageBox.Show("Se guardo correctamente el mensaje");    
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {

            txtTotalDevengado.Text = miNomina.CalcularNomina(Convert.ToInt32( miNomina.DiasLaborados), Convert.ToDecimal( miEmpleado.AsignacionDia)).ToString();

        }

        private void txtTotalDevengado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
