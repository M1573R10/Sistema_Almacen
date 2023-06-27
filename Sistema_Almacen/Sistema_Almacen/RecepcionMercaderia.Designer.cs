namespace Sistema_Almacen
{
    partial class RecepcionMercaderia
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
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            txtFactura = new TextBox();
            label3 = new Label();
            txtRUC = new TextBox();
            label4 = new Label();
            txtRazonSocial = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnRegistrar = new Button();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            button4 = new Button();
            dgvRUC = new DataGridView();
            groupBox2 = new GroupBox();
            btnAgregar = new Button();
            label7 = new Label();
            txtCantidad = new TextBox();
            txtNombreProducto = new TextBox();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            button3 = new Button();
            dgvProducto = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRUC).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 31);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(145, 28);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 68);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Nro Factura:";
            // 
            // txtFactura
            // 
            txtFactura.Location = new Point(145, 61);
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(183, 27);
            txtFactura.TabIndex = 3;
            txtFactura.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 101);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "RUC:";
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(144, 94);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(100, 27);
            txtRUC.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 130);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 6;
            label4.Text = "Razón Social:";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(145, 127);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(219, 27);
            txtRazonSocial.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(371, 555);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(171, 555);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(271, 555);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Agregar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFactura);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRUC);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Location = new Point(27, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 176);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Compra";
            // 
            // button4
            // 
            button4.Location = new Point(499, 66);
            button4.Name = "button4";
            button4.Size = new Size(150, 29);
            button4.TabIndex = 15;
            button4.Text = "Consulta Proveedor";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dgvRUC
            // 
            dgvRUC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRUC.Location = new Point(499, 101);
            dgvRUC.Name = "dgvRUC";
            dgvRUC.RowHeadersWidth = 51;
            dgvRUC.RowTemplate.Height = 29;
            dgvRUC.Size = new Size(497, 150);
            dgvRUC.TabIndex = 16;
            dgvRUC.CellContentClick += dgvRUC_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(txtNombreProducto);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(27, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 116);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(338, 53);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 62);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 3;
            label7.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(143, 59);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 2;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(144, 26);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(125, 27);
            txtNombreProducto.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 29);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 0;
            label6.Text = "Nombre:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad });
            dataGridView2.Location = new Point(27, 361);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(438, 188);
            dataGridView2.TabIndex = 18;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 300;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // button3
            // 
            button3.Location = new Point(499, 257);
            button3.Name = "button3";
            button3.Size = new Size(150, 29);
            button3.TabIndex = 19;
            button3.Text = "Consulta Producto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(499, 292);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.RowTemplate.Height = 29;
            dgvProducto.Size = new Size(497, 150);
            dgvProducto.TabIndex = 20;
            dgvProducto.CellContentClick += dgvProducto_CellContentClick;
            // 
            // RecepcionMercaderia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 598);
            Controls.Add(dgvProducto);
            Controls.Add(button3);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox2);
            Controls.Add(dgvRUC);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnRegistrar);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RecepcionMercaderia";
            Text = "Recepcion de Mercaderia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRUC).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtFactura;
        private Label label3;
        private TextBox txtRUC;
        private Label label4;
        private TextBox txtRazonSocial;
        private Button button1;
        private Button button2;
        private Button btnRegistrar;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private Button button4;
        private DataGridView dgvRUC;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox txtCantidad;
        private TextBox txtNombreProducto;
        private Label label6;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private Button btnAgregar;
        private Button button3;
        private DataGridView dgvProducto;
    }
}
