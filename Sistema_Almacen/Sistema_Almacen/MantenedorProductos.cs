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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Sistema_Almacen
{
    public partial class MantenedorProductos : Form
    {

        public MantenedorProductos()


        {
            InitializeComponent();
            gpDatos.Enabled = false;
            txtCodigo.Enabled = false;
            MostrarProducto();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            gpDatos.Enabled = true;
            LlenarDatosComboBoxTipoProducto();
            LlenarDatosComboboxMarca();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto Eliminar = new entProducto();
                Eliminar.CodPro = Convert.ToInt32(txtCodigo.Text.Trim());
                logProducto.Instancia.DeshabilitaProducto(Eliminar);
                MessageBox.Show("Se eliminó la información");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        public void LimpiarDatos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
        }
        private void LlenarDatosComboBoxTipoProducto()
        {
            cmbTipoProducto.DataSource = logTipoProducto.Instancia.ListarTipoProducto();
            cmbTipoProducto.DisplayMember = "Nombre";
            cmbTipoProducto.ValueMember = "CodtipPro";
        }

        private void LlenarDatosComboboxMarca()
        {
            cmbMarca.DataSource = logMarca.Instancia.ListarMarca();
            cmbMarca.DisplayMember = "Nombre";
            cmbMarca.ValueMember = "CodMarca";
        }
        private void MantenedorProductos_Load(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto Registrar = new entProducto();
                Registrar.Nombre = txtNombre.Text.Trim();
                Registrar.Descripcion = txtDescripcion.Text.Trim();
                Registrar.CodTipPro = Convert.ToInt32(cmbTipoProducto.SelectedValue);
                Registrar.CodMarca = Convert.ToInt32(cmbMarca.SelectedValue);
                logProducto.Instancia.RegistrarProducto(Registrar);
                MessageBox.Show("Registrado correctamente");
                //LimpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto Modificar = new entProducto();
                Modificar.Descripcion = txtDescripcion.Text.Trim();
                Modificar.CodTipPro = Convert.ToInt32(cmbTipoProducto.SelectedValue);
                Modificar.CodMarca = Convert.ToInt32(cmbMarca.SelectedValue);
                MessageBox.Show("Actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProductos.Rows[e.RowIndex];
            txtCodigo.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
            cmbTipoProducto.Text = filaActual.Cells[3].Value.ToString();
            cmbMarca.Text = filaActual.Cells[4].Value.ToString();
        }

        private void MostrarProducto()
        {
            dgvProductos.DataSource = logProducto.Instancia.ListarProducto();
        }
        
    }
}
