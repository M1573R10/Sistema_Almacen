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
            panelFormularios.Controls.Clear(); //limpiamos el panel
            MantenedorProveedores mantenedorProveedores = new MantenedorProveedores();
            mantenedorProveedores.TopLevel = false;
            panelFormularios.Controls.Add(mantenedorProveedores);
            mantenedorProveedores.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFormularios.Controls.Clear(); //limpiamos el panel
            MantenedorTipoProducto mantenedorTipoProducto = new MantenedorTipoProducto();
            mantenedorTipoProducto.TopLevel = false;
            panelFormularios.Controls.Add(mantenedorTipoProducto);
            mantenedorTipoProducto.Show();
        }

        private void órdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFormularios.Controls.Clear(); //limpiamos el panel
            OrdenCompra ordenCompra = new OrdenCompra();
            ordenCompra.TopLevel = false;
            panelFormularios.Controls.Add(ordenCompra);
            ordenCompra.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFormularios.Controls.Clear();
            MantenedorMarca marca = new MantenedorMarca();
            marca.TopLevel = false;
            panelFormularios.Controls.Add(marca);
            marca.Show();

        }
    }
}
