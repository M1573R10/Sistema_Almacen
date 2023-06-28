namespace Sistema_Almacen
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            mantenedoresToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            tipoProductoToolStripMenuItem = new ToolStripMenuItem();
            marcaToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            órdenDeCompraToolStripMenuItem = new ToolStripMenuItem();
            movimientosToolStripMenuItem = new ToolStripMenuItem();
            recepciónDeProductosToolStripMenuItem = new ToolStripMenuItem();
            salidaDeProductosToolStripMenuItem = new ToolStripMenuItem();
            panelFormularios = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, mantenedoresToolStripMenuItem, comprasToolStripMenuItem, movimientosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(968, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // mantenedoresToolStripMenuItem
            // 
            mantenedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productoToolStripMenuItem, proveedoresToolStripMenuItem, tipoProductoToolStripMenuItem, marcaToolStripMenuItem });
            mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
            mantenedoresToolStripMenuItem.Size = new Size(95, 20);
            mantenedoresToolStripMenuItem.Text = "Mantenedores";
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(149, 22);
            productoToolStripMenuItem.Text = "Producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(149, 22);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // tipoProductoToolStripMenuItem
            // 
            tipoProductoToolStripMenuItem.Name = "tipoProductoToolStripMenuItem";
            tipoProductoToolStripMenuItem.Size = new Size(149, 22);
            tipoProductoToolStripMenuItem.Text = "Tipo Producto";
            tipoProductoToolStripMenuItem.Click += tipoProductoToolStripMenuItem_Click;
            // 
            // marcaToolStripMenuItem
            // 
            marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            marcaToolStripMenuItem.Size = new Size(149, 22);
            marcaToolStripMenuItem.Text = "Marca";
            marcaToolStripMenuItem.Click += marcaToolStripMenuItem_Click;
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { órdenDeCompraToolStripMenuItem });
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(67, 20);
            comprasToolStripMenuItem.Text = "Compras";
            // 
            // órdenDeCompraToolStripMenuItem
            // 
            órdenDeCompraToolStripMenuItem.Name = "órdenDeCompraToolStripMenuItem";
            órdenDeCompraToolStripMenuItem.Size = new Size(169, 22);
            órdenDeCompraToolStripMenuItem.Text = "Orden de Compra";
            órdenDeCompraToolStripMenuItem.Click += órdenDeCompraToolStripMenuItem_Click;
            // 
            // movimientosToolStripMenuItem
            // 
            movimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { recepciónDeProductosToolStripMenuItem, salidaDeProductosToolStripMenuItem });
            movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            movimientosToolStripMenuItem.Size = new Size(89, 20);
            movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // recepciónDeProductosToolStripMenuItem
            // 
            recepciónDeProductosToolStripMenuItem.Name = "recepciónDeProductosToolStripMenuItem";
            recepciónDeProductosToolStripMenuItem.Size = new Size(202, 22);
            recepciónDeProductosToolStripMenuItem.Text = "Recepción de Productos";
            recepciónDeProductosToolStripMenuItem.Click += recepciónDeProductosToolStripMenuItem_Click;
            // 
            // salidaDeProductosToolStripMenuItem
            // 
            salidaDeProductosToolStripMenuItem.Name = "salidaDeProductosToolStripMenuItem";
            salidaDeProductosToolStripMenuItem.Size = new Size(202, 22);
            salidaDeProductosToolStripMenuItem.Text = "Salida de Productos";
            salidaDeProductosToolStripMenuItem.Click += salidaDeProductosToolStripMenuItem_Click;
            // 
            // panelFormularios
            // 
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(0, 24);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(968, 500);
            panelFormularios.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 524);
            Controls.Add(panelFormularios);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuPrincipal";
            Text = "Menu_Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenedoresToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem tipoProductoToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem órdenDeCompraToolStripMenuItem;
        private Panel panelFormularios;
        private ToolStripMenuItem marcaToolStripMenuItem;
        private ToolStripMenuItem movimientosToolStripMenuItem;
        private ToolStripMenuItem recepciónDeProductosToolStripMenuItem;
        private ToolStripMenuItem salidaDeProductosToolStripMenuItem;
    }
}
