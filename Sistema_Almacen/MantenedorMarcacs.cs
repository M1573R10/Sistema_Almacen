using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace Sistema_Almacen
{
    public partial class MantenedorMarcacs : Form
    {
        public MantenedorMarcacs()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Recopilar datos del formulario
            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            // Crear instancia de entidad Marca con los datos recopilados
            entMarca marca = new entMarca()
            {
                Codigo = codigo,
                Nombre = nombre,
                Descripcion = descripcion
            };

            try
            {
                // Utilizar el método de registro de la capa lógica
                bool resultado = logMarca.Instancia.RegistrarMarca(marca);

                if (resultado)
                {
                    MessageBox.Show("Marca registrada exitosamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar la marca.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Recopilar datos del formulario
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            // Crear instancia de entidad Marca con los datos recopilados
            entMarca marca = new entMarca()
            {
                Codigo = codigo,
                Nombre = nombre,
                Descripcion = descripcion
            };

            try
            {
                // Utilizar el método de modificación de la capa lógica
                bool resultado = logMarca.Instancia.ModificarMarca(marca);

                if (resultado)
                {
                    MessageBox.Show("Marca modificada exitosamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar la marca.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Recopilar datos del formulario
            string codigo = txtCodigo.Text;

            // Crear instancia de entidad Marca con el código recopilado
            entMarca marca = new entMarca()
            {
                Codigo = codigo
            };

            try
            {
                // Utilizar el método de eliminación de la capa lógica
                bool resultado = logMarca.Instancia.EliminarMarca(marca);

                if (resultado)
                {
                    MessageBox.Show("Marca eliminada exitosamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la marca.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
