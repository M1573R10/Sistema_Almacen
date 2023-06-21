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
using System.Data.SqlClient;

namespace Sistema_Almacen
{
    public partial class MantenedorTipoProducto : Form
    {
        public MantenedorTipoProducto()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            LimpiarDatos();
            MostrarTipoProducto();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoProducto Registrar = new entTipoProducto();
                Registrar.Nombre = txtNombre.Text.Trim();
                Registrar.Descripcion = txtDescripcion.Text.Trim();
                logTipoProducto.Instancia.RegistrarTipoProducto(Registrar);
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
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoProducto Modificar = new entTipoProducto();
                Modificar.CodTipPro = int.Parse(txtCodigo.Text.Trim());
                Modificar.Nombre = txtNombre.Text.Trim();
                Modificar.Descripcion = txtDescripcion.Text.Trim();
                logTipoProducto.Instancia.ModificarTipoProducto(Modificar);
                MessageBox.Show("La información se actualizó correctamente");
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

        }

        private void MantenedorTipoProducto_Load(object sender, EventArgs e)
        {

        }

        public void MostrarTipoProducto()
        {
            dataGridView1.DataSource = logTipoProducto.Instancia.ListarTipoProducto();
        }
    }
}

