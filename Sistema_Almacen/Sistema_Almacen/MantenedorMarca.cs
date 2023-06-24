using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Almacen
{
    public partial class MantenedorMarca : Form
    {
        public MantenedorMarca()
        {
            InitializeComponent();
            LimpiarDatos();
            txtCodigo.Enabled = false;
            MostrarMarca();
        }

        private void MantenedorMarcacs_Load(object sender, EventArgs e)
        {

        }

        private void MostrarMarca()
        {
            dataGridView1.DataSource = logMarca.Instancia.ListarMarca();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca Registrar = new entMarca();
                Registrar.Nombre = txtNombre.Text.Trim();
                Registrar.Descripcion = txtDescripcion.Text.Trim();
                logMarca.Instancia.RegistrarMarca(Registrar);
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
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca Modificar = new entMarca();
                Modificar.CodMarca = int.Parse(txtCodigo.Text.Trim());
                Modificar.Nombre = txtNombre.Text.Trim();
                Modificar.Descripcion = txtDescripcion.Text.Trim();
                logMarca.Instancia.ModificarMarca(Modificar);
                MessageBox.Show("Actualizado correctamente");
                LimpiarDatos();
            }catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }
    }
}
