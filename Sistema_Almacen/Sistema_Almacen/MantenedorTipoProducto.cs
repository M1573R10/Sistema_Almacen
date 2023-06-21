﻿using CapaEntidad;
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
    public partial class MantenedorTipoProducto : Form
    {
        public MantenedorTipoProducto()
        {
            InitializeComponent();
            txtCodigo.Enabled=false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoProducto Registrar = new entTipoProducto();
                Registrar.Nombre = txtNombre.Text.Trim();
                Registrar.Descripcion = txtDescripcion.Text.Trim();
                logTipoProducto.Instancia.RegistrarTipoProducto(Registrar);
                MessageBox.Show("Registrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
        }
    }
}

