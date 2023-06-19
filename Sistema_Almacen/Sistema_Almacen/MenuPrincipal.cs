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
           panelFormularios.Controls.Clear(); //limpiamos el panel
            MantenedorProductos productos = new MantenedorProductos();
            productos.TopLevel = false;
            panelFormularios.Controls.Add(productos);
            productos.Show();
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

        private void órdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenCompra ordenCompra = new OrdenCompra();
            ordenCompra.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
