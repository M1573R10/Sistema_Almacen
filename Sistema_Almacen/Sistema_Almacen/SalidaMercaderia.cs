using CapaDatos;
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
    public partial class SalidaMercaderia : Form
    {
        public SalidaMercaderia()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }
        public void MostrarProductos()
        {
            dgvProducto.DataSource = logProducto.Instancia.ListarProducto();
        }
    }
}
