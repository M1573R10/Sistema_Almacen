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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorProductos productos = new MantenedorProductos();
            productos.Show(this);
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorProveedores mantenedorProveedores = new MantenedorProveedores();
            mantenedorProveedores.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorTipoProducto mantenedorTipoProducto = new MantenedorTipoProducto();
            mantenedorTipoProducto.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorMarca mantenedorMarca = new MantenedorMarca();
            mantenedorMarca.Show();
        }
    }
}
