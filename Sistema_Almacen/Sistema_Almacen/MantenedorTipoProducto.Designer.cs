namespace Sistema_Almacen
{
    partial class MantenedorTipoProducto
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
            label2 = new Label();
            label3 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            btnRegistrar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(563, 83);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(563, 156);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(563, 219);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(632, 81);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(110, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(632, 148);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(653, 211);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(276, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(584, 273);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 22);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(584, 312);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(584, 347);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button4
            // 
            button4.Location = new Point(584, 383);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 9;
            button4.Text = "Limpiar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 35);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(445, 424);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(765, 347);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 22);
            button5.TabIndex = 11;
            button5.Text = "Regresar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // MantenedorTipoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 500);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MantenedorTipoProducto";
            Text = "Mantenedor Tipo Producto";
            Load += MantenedorTipoProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button btnRegistrar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button5;
    }
}
