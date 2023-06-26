using CapaEntidad;
using CapaLogica;
using Microsoft.Win32;
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
            MostrarProveedores();
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

        private void MantenedorProveedores_Load(object sender, EventArgs e)
        {

        }
        public void MostrarProveedores()
        {
            dataGridView1.DataSource = logProveedores.Instancia.ListarProveedores();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedores Modificar = new entProveedores();
                //Modificar.RUC = txtRUC.Text.Trim();
                //Modificar.RazonSocial = txtRazonSocial.Text.Trim();
                Modificar.Direccion = txtDireccion.Text.Trim();
                Modificar.Telefono = txtTelefono.Text.Trim();
                Modificar.Contacto = txtContacto.Text.Trim();
                Modificar.Correo = txtCorreo.Text.Trim();
                Modificar.FechaInicio = dateTimePicker1.Value;
                Modificar.Estado = checkBox1.Checked;
                MessageBox.Show("Actualizado correctamente");
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {

            try
            {
                entProveedores Eliminar = new entProveedores();
                Eliminar.RUC = txtRUC.Text.Trim();
                checkBox1.Checked = false;
                Eliminar.Estado = checkBox1.Checked;
                logProveedores.Instancia.DeshabilitaProveedores(Eliminar);
                MessageBox.Show("Se eliminó la información");
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dataGridView1.Rows[e.RowIndex];
            txtRUC.Text = filaActual.Cells[0].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[1].Value.ToString();
            txtDireccion.Text = filaActual.Cells[2].Value.ToString();
            txtTelefono.Text = filaActual.Cells[3].Value.ToString();
            txtContacto.Text = filaActual.Cells[4].Value.ToString();
            txtCorreo.Text = filaActual.Cells[5].Value.ToString();
            dateTimePicker1.Text = filaActual.Cells[6].Value.ToString();
        }
    }
}


