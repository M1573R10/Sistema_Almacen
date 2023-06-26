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
            btnInhabilitar = new Button();
            btnRegresar = new Button();
            gpDatos = new GroupBox();
            btnActualizar = new Button();
            label4 = new Label();
            cmbMarca = new ComboBox();
            btnCancelar = new Button();
            cmbTipoProducto = new ComboBox();
            label5 = new Label();
            btnAgregar = new Button();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            btnLimpiar = new Button();
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
            dgvProductos.Size = new Size(564, 168);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.Location = new Point(627, 150);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(94, 29);
            btnInhabilitar.TabIndex = 1;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = true;
            btnInhabilitar.Click += btnDeshabilitar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(627, 115);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnEditar_Click;
            // 
            // gpDatos
            // 
            gpDatos.Controls.Add(btnActualizar);
            gpDatos.Controls.Add(label4);
            gpDatos.Controls.Add(cmbMarca);
            gpDatos.Controls.Add(btnCancelar);
            gpDatos.Controls.Add(cmbTipoProducto);
            gpDatos.Controls.Add(label5);
            gpDatos.Controls.Add(btnAgregar);
            gpDatos.Controls.Add(txtDescripcion);
            gpDatos.Controls.Add(label3);
            gpDatos.Controls.Add(txtNombre);
            gpDatos.Controls.Add(label2);
            gpDatos.Controls.Add(txtCodigo);
            gpDatos.Controls.Add(label1);
            gpDatos.Location = new Point(11, 229);
            gpDatos.Name = "gpDatos";
            gpDatos.Size = new Size(754, 186);
            gpDatos.TabIndex = 4;
            gpDatos.TabStop = false;
            gpDatos.Text = "Registro de los Productos";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(616, 61);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Modificar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 139);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 17;
            label4.Text = "Marca:";
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(165, 136);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(210, 28);
            cmbMarca.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(616, 96);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbTipoProducto
            // 
            cmbTipoProducto.FormattingEnabled = true;
            cmbTipoProducto.Location = new Point(165, 102);
            cmbTipoProducto.Name = "cmbTipoProducto";
            cmbTipoProducto.Size = new Size(210, 28);
            cmbTipoProducto.TabIndex = 14;
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
            // btnAgregar
            // 
            btnAgregar.Location = new Point(616, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
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
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(627, 80);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Nuevo";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnNuevo_Click;
            // 
            // MantenedorProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 427);
            Controls.Add(gpDatos);
            Controls.Add(btnRegresar);
            Controls.Add(btnInhabilitar);
            Controls.Add(dgvProductos);
            Controls.Add(btnLimpiar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenedorProductos";
            Text = "Mantenedor de Productos";
            Load += MantenedorProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            gpDatos.ResumeLayout(false);
            gpDatos.PerformLayout();
            ResumeLayout(false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCancelar;
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
        private Button btnAgregar;
        private Button btnLimpiar;
        private TextBox txtDescripcion;
        private Button button5;
        private ComboBox comboBox2;
        private ComboBox cmbTipoProducto;
        private Label label5;
        private DataGridView dgvProductos;
        private Button btnInhabilitar;
        private Button btnRegresar;
        private GroupBox gpDatos;
        private Label label4;
        private ComboBox cmbMarca;
        private Button btnActualizar;
    }
}
