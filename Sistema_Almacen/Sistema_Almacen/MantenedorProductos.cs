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
    public partial class MantenedorProductos : Form
    {
        public MantenedorProductos()
        {
            InitializeComponent();
            gpDatos.Enabled = false;
            txtCodigo.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gpDatos.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gpDatos.Enabled = true;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            gpDatos.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ( txtDescripcion.Text == "" || txtNombre.Text == "" || cbMarca.Text == "" || cbTipoProducto.Text == "")
            {
                MessageBox.Show("LLene todos los campos");
            }
        }

        private void MantenedorProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
