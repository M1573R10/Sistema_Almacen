using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Almacen
{
    public partial class MantenedorProveedores : Form
    {
        public MantenedorProveedores()
        {
            InitializeComponent();
            LimpiarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedores Registrar = new entProveedores();
                Registrar.RUC = txtRUC.Text.Trim();
                Registrar.RazonSocial = txtRazonSocial.Text.Trim();
                Registrar.Direccion = txtDireccion.Text.Trim();
                Registrar.Telefono = txtTelefono.Text.Trim();
                Registrar.Contacto = txtContacto.Text.Trim();
                Registrar.Correo = txtCorreo.Text.Trim();
                Registrar.FechaInicio = dateTimePicker1.Value;
                Registrar.Estado = checkBox1.Checked;
                logProveedores.Instancia.RegistrarProveedores(Registrar);
                MessageBox.Show("Registrado correctamente");
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }
        private void LimpiarDatos()
        {
            txtContacto.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtRazonSocial.Clear();
            txtRUC.Clear();
            txtTelefono.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
}
