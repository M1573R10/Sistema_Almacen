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
    public partial class OrdenCompra : Form
    {
        public OrdenCompra()
        {
            InitializeComponent();
            dgvRUC.Visible = false;
            dgvProducto.Visible = false;
        }
        public void CostoProducto()
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(txtPrecioUnitario.Text))
            {
                return; // Salir de la función
            }

            // Convertir los valores a números
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || !decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario))
            {
                return; // Salir de la función
            }

            // Calcular el costo total
            decimal costoTotal = cantidad * precioUnitario;

            // Mostrar el costo total en el TextBox o en otro lugar deseado
            txtCostoTotal.Text = costoTotal.ToString();
        }


        private void OrdenCompra_Load(object sender, EventArgs e)
        {
            //dgvRUC.Enabled = false;
        }

        private void btnConsultaRUC_Click(object sender, EventArgs e)
        {
            MostrarProveedores();
            dgvRUC.Visible = true;
        }
        public void MostrarProveedores()
        {
            dgvRUC.DataSource = logProveedores.Instancia.ListarProveedores();
        }

        private void dgvRUC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvRUC.Rows[e.RowIndex];
            txtRUC.Text = filaActual.Cells[0].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[1].Value.ToString();
            txtDireccion.Text = filaActual.Cells[2].Value.ToString();
        }

        private void btnConsultaProductos_Click(object sender, EventArgs e)
        {
            dgvProducto.Visible = true;
            MostrarProductos();
        }
        public void MostrarProductos()
        {
            dgvProducto.DataSource = logProducto.Instancia.ListarProducto();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex];
            txtCodProducto.Text = filaActual.Cells[0].Value.ToString();
            txtNombreProducto.Text = filaActual.Cells[1].Value.ToString();
        }

        private void txtCostoTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcularTotalOrdenCompra()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells["Cantidad"].Value != null)
                {
                    decimal precio = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                    total += precio;
                }
            }

            textBox5.Text = total.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CostoProducto();

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = txtCodProducto.Text;  // Ajusta el índice de la columna según tus necesidades
            fila.Cells[1].Value = txtCantidad.Text;
            fila.Cells[2].Value = txtCostoTotal.Text;
            dataGridView1.Rows.Add(fila);

            CalcularTotalOrdenCompra();

            txtCodProducto.Clear();
            txtNombreProducto.Clear();
            txtCantidad.Clear();
            txtCostoTotal.Clear();
            txtPrecioUnitario.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           // try
            //{
                // Obtener datos del formulario
                string ruc = txtRUC.Text;
                DateTime fecha = dateTimePicker1.Value;

                // Obtener productos del DataGridView
                StringBuilder productosBuilder = new StringBuilder();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                int codPro = Convert.ToInt32(row.Cells["Item"].Value);
                int cantidad = Convert.ToInt32(row.Cells["Producto"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                    string producto = $"{codPro},{cantidad},{precio}";
                    productosBuilder.Append(producto);
                    productosBuilder.Append("|");
                }
                string productos = productosBuilder.ToString().TrimEnd('|');

                // Guardar la orden de compra
                logOrdenCompra1 negocio = new logOrdenCompra1();
                negocio.GuardarOrdenCompra(ruc, fecha, productos);
                MessageBox.Show("Orden de Compra registrada correctamente");
            //}
            //catch (Exception ex)
            //{
              //  MessageBox.Show("Error al guardar la orden de compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }



        }
    }
}
