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


        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFormularios.Controls.Clear();
            MantenedorMarca marca = new MantenedorMarca();
            marca.TopLevel = false;
            panelFormularios.Controls.Add(marca);
            marca.Show();

        }

        private void recepciónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFormularios.Controls.Clear();
            RecepcionMercaderia recepcion = new RecepcionMercaderia();
            recepcion.TopLevel = false;
            panelFormularios.Controls.Add(recepcion);
            recepcion.Show();
        }

        private void salidaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFormularios.Controls.Clear();
            SalidaMercaderia salida = new SalidaMercaderia();
            salida.TopLevel = false;
            panelFormularios.Controls.Add(salida);
            salida.Show();
        }
    }
}
