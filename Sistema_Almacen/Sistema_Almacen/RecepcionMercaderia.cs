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
    public partial class RecepcionMercaderia : Form
    {
        public RecepcionMercaderia()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarProveedores();
        }

        public void MostrarProveedores()
        {
            dgvRUC.DataSource = logProveedores.Instancia.ListarProveedores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        public void MostrarProductos()
        {
            dgvProducto.DataSource = logProducto.Instancia.ListarProducto();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex];
            txtNombreProducto.Text = filaActual.Cells[1].Value.ToString();
        }

        private void dgvRUC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvRUC.Rows[e.RowIndex];
            txtRUC.Text = filaActual.Cells[0].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[1].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView2);
            fila.Cells[0].Value = txtNombreProducto.Text;
            fila.Cells[1].Value = txtCantidad.Text;
            dataGridView2.Rows.Add(fila);
        }
    }
}
