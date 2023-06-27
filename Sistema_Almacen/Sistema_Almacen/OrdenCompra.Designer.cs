namespace Sistema_Almacen
{
    partial class OrdenCompra
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            txtRUC = new TextBox();
            label3 = new Label();
            txtRazonSocial = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            txtDireccion = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            btnConsultaRUC = new Button();
            dgvRUC = new DataGridView();
            groupBox1 = new GroupBox();
            btnLimpiar = new Button();
            btnConsultaProductos = new Button();
            dgvProducto = new DataGridView();
            groupBox2 = new GroupBox();
            btnAgregar = new Button();
            label10 = new Label();
            txtCostoTotal = new TextBox();
            label9 = new Label();
            txtPrecioUnitario = new TextBox();
            label8 = new Label();
            txtCantidad = new TextBox();
            label7 = new Label();
            txtNombreProducto = new TextBox();
            btnRegistrar = new Button();
            txtCodProducto = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRUC).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(42, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(269, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 48);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(123, 45);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 48);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "RUC:";
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(312, 45);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(125, 27);
            txtRUC.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 81);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 5;
            label3.Text = "Razón Social:";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(123, 78);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(314, 27);
            txtRazonSocial.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(308, 501);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 10;
            label5.Text = "Total a Pagar:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(412, 498);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(743, 498);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(643, 498);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(123, 111);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(314, 27);
            txtDireccion.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 114);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 16;
            label4.Text = "Dirección:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(560, 48);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 24);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Enviado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(482, 49);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 19;
            label6.Text = "Estado:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item, Producto, Cantidad });
            dataGridView1.Location = new Point(42, 331);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(795, 161);
            dataGridView1.TabIndex = 20;
            // 
            // Item
            // 
            Item.HeaderText = "Producto";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.Width = 500;
            // 
            // Producto
            // 
            Producto.HeaderText = "Cantidad";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Precio";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // btnConsultaRUC
            // 
            btnConsultaRUC.Location = new Point(897, 45);
            btnConsultaRUC.Name = "btnConsultaRUC";
            btnConsultaRUC.Size = new Size(125, 29);
            btnConsultaRUC.TabIndex = 21;
            btnConsultaRUC.Text = "Consulta RUC";
            btnConsultaRUC.UseVisualStyleBackColor = true;
            btnConsultaRUC.Click += btnConsultaRUC_Click;
            // 
            // dgvRUC
            // 
            dgvRUC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRUC.Location = new Point(897, 80);
            dgvRUC.Name = "dgvRUC";
            dgvRUC.RowHeadersWidth = 51;
            dgvRUC.RowTemplate.Height = 29;
            dgvRUC.Size = new Size(497, 150);
            dgvRUC.TabIndex = 22;
            dgvRUC.CellContentClick += dgvRUC_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(txtRUC);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Location = new Point(42, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 171);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Proveedor";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(670, 84);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnConsultaProductos
            // 
            btnConsultaProductos.Location = new Point(897, 236);
            btnConsultaProductos.Name = "btnConsultaProductos";
            btnConsultaProductos.Size = new Size(147, 29);
            btnConsultaProductos.TabIndex = 24;
            btnConsultaProductos.Text = "Consulta Productos";
            btnConsultaProductos.UseVisualStyleBackColor = true;
            btnConsultaProductos.Click += btnConsultaProductos_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(897, 271);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.RowTemplate.Height = 29;
            dgvProducto.Size = new Size(497, 150);
            dgvProducto.TabIndex = 25;
            dgvProducto.CellContentClick += dgvProducto_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtCodProducto);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtCostoTotal);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtPrecioUnitario);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtNombreProducto);
            groupBox2.Location = new Point(42, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(795, 103);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de la Compra";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(670, 68);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(546, 26);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 7;
            label10.Text = "Costo Total:";
            // 
            // txtCostoTotal
            // 
            txtCostoTotal.Location = new Point(639, 26);
            txtCostoTotal.Name = "txtCostoTotal";
            txtCostoTotal.Size = new Size(125, 27);
            txtCostoTotal.TabIndex = 6;
            txtCostoTotal.TextChanged += txtCostoTotal_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(300, 62);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 5;
            label9.Text = "Precio unitario:";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(414, 59);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(125, 27);
            txtPrecioUnitario.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(333, 29);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 3;
            label8.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(414, 26);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 62);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 1;
            label7.Text = "Producto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(123, 59);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(125, 27);
            txtNombreProducto.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(543, 498);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 27;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCodProducto
            // 
            txtCodProducto.Location = new Point(123, 26);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(125, 27);
            txtCodProducto.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(56, 29);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 10;
            label11.Text = "Codigo:";
            // 
            // OrdenCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 538);
            Controls.Add(btnRegistrar);
            Controls.Add(groupBox2);
            Controls.Add(dgvProducto);
            Controls.Add(btnConsultaProductos);
            Controls.Add(groupBox1);
            Controls.Add(dgvRUC);
            Controls.Add(btnConsultaRUC);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrdenCompra";
            Text = "Orden de Compra";
            Load += OrdenCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRUC).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtRUC;
        private Label label3;
        private TextBox txtRazonSocial;
        private Label label5;
        private TextBox textBox5;
        private Button button2;
        private Button button3;
        private TextBox txtDireccion;
        private Label label4;
        private CheckBox checkBox1;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private Button btnConsultaRUC;
        private DataGridView dgvRUC;
        private GroupBox groupBox1;
        private Button btnLimpiar;
        private Button btnConsultaProductos;
        private DataGridView dgvProducto;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox txtNombreProducto;
        private Button btnAgregar;
        private Label label10;
        private TextBox txtCostoTotal;
        private Label label9;
        private TextBox txtPrecioUnitario;
        private Label label8;
        private TextBox txtCantidad;
        private Button btnRegistrar;
        private Label label11;
        private TextBox txtCodProducto;
    }
}
