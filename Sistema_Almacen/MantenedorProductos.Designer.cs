namespace Sistema_Almacen
{
    partial class MantenedorProductos
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
            dgvProductos = new DataGridView();
            btnDeshabilitar = new Button();
            btnEditar = new Button();
            gpDatos = new GroupBox();
            label6 = new Label();
            cbMarca = new ComboBox();
            cbTipoProducto = new ComboBox();
            label5 = new Label();
            btnAceptar = new Button();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            button6 = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            gpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(11, 41);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(603, 168);
            dgvProductos.TabIndex = 0;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(672, 111);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(94, 29);
            btnDeshabilitar.TabIndex = 1;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(672, 76);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // gpDatos
            // 
            gpDatos.Controls.Add(label6);
            gpDatos.Controls.Add(cbMarca);
            gpDatos.Controls.Add(cbTipoProducto);
            gpDatos.Controls.Add(label5);
            gpDatos.Controls.Add(btnAceptar);
            gpDatos.Controls.Add(txtDescripcion);
            gpDatos.Controls.Add(label3);
            gpDatos.Controls.Add(txtNombre);
            gpDatos.Controls.Add(label2);
            gpDatos.Controls.Add(txtCodigo);
            gpDatos.Controls.Add(label1);
            gpDatos.Location = new Point(11, 229);
            gpDatos.Name = "gpDatos";
            gpDatos.Size = new Size(754, 227);
            gpDatos.TabIndex = 4;
            gpDatos.TabStop = false;
            gpDatos.Text = "Registro de los Productos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 139);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 16;
            label6.Text = "Marca:";
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(165, 136);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(210, 28);
            cbMarca.TabIndex = 15;
            // 
            // cbTipoProducto
            // 
            cbTipoProducto.FormattingEnabled = true;
            cbTipoProducto.Location = new Point(165, 102);
            cbTipoProducto.Name = "cbTipoProducto";
            cbTipoProducto.Size = new Size(210, 28);
            cbTipoProducto.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 105);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 13;
            label5.Text = "Tipo de Producto:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(614, 96);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(125, 69);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(358, 27);
            txtDescripcion.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 72);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 8;
            label3.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(306, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 39);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(87, 36);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(79, 27);
            txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 39);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // button6
            // 
            button6.Location = new Point(672, 180);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 12;
            button6.Text = "Cancelar";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(672, 41);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // MantenedorProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(gpDatos);
            Controls.Add(btnEditar);
            Controls.Add(btnDeshabilitar);
            Controls.Add(button6);
            Controls.Add(dgvProductos);
            Controls.Add(btnNuevo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenedorProductos";
            Text = "Mantenedor de Productos";
            Load += MantenedorProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            gpDatos.ResumeLayout(false);
            gpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox txtCodigo;
        private TextBox textBox1;
        private Label label1;
        private Button button4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private TextBox txtNombre;
        private Button button6;
        private Button btnAceptar;
        private Button btnNuevo;
        private TextBox txtDescripcion;
        private Button button5;
        private Label label6;
        private ComboBox cbMarca;
        private ComboBox comboBox2;
        private ComboBox cbTipoProducto;
        private Label label5;
        private DataGridView dgvProductos;
        private Button btnDeshabilitar;
        private Button btnEditar;
        private GroupBox gpDatos;
    }
}
