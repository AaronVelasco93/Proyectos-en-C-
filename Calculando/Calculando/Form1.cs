using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculando
{
    public partial class Form1 : Form
    {
        //se instancian los objetos
        Empleado miEmpleado = new Empleado();
        Nomina miNomina = new Nomina();
        
        public Form1()
        {
            InitializeComponent();
        }

        //evento para que se alamcenen las variables del formulario
        private void btnGuardaRegistro_Click(object sender, EventArgs e)
        {
            miEmpleado.Nombre = txtNombre.Text;
            miEmpleado.NoTrabajador = txtNumeroTrabajador.Text;
            miEmpleado.DiasLaborados = Convert.ToInt32( txtDiasLaborales.Text);
            miNomina.PagoPorDia = Convert.ToDecimal(txtPagoDia.Text);

            MessageBox.Show("Se ingreso correctamente");

        }
        //salir de la aplicacion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //limpiar los campos de texto
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDiasLaborales.Clear();
            txtNombre.Clear();
            txtNumeroTrabajador.Clear();
            txtPagoDia.Clear();
            txtTotalDePago.Clear();
        }
        //evento para realizar la operacion
        private void btnCalculaSalario_Click(object sender, EventArgs e)
        {
            txtTotalDePago.Text = miNomina.PagoNomina( Convert.ToInt32( miEmpleado.DiasLaborados),Convert.ToDecimal (miNomina.PagoPorDia)).ToString();
        }
    }
}
