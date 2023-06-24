namespace Sistema_Almacen
{
    partial class MantenedorProveedores
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            btnCancelar = new Button();
            btnModificar = new Button();
            btnRegistrar = new Button();
            checkBox1 = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            txtCorreo = new TextBox();
            label6 = new Label();
            txtContacto = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtRazonSocial = new TextBox();
            label2 = new Label();
            txtRUC = new TextBox();
            label1 = new Label();
            btnLimpiar = new Button();
            btnRegresar = new Button();
            btnInhabilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(606, 188);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtContacto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtRUC);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 253);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 237);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Proveedor";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(31, 188);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(295, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(676, 140);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(676, 89);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(676, 39);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Agregar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(498, 164);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Habilitado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(435, 165);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 14;
            label8.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 165);
            label7.Name = "label7";
            label7.Size = new Size(180, 20);
            label7.TabIndex = 12;
            label7.Text = "Fecha Inición de Relación:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(332, 121);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(268, 27);
            txtCorreo.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 121);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 10;
            label6.Text = "Correo:";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(96, 118);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(139, 27);
            txtContacto.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 125);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 8;
            label5.Text = "Contacto:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(447, 77);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(153, 27);
            txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 80);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(96, 77);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(240, 27);
            txtDireccion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 80);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Dirección:";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(357, 36);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(243, 27);
            txtRazonSocial.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 39);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Razón Social:";
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(90, 36);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(125, 27);
            txtRUC.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 39);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "RUC:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(688, 97);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button4_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(688, 132);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.Location = new Point(688, 167);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(94, 29);
            btnInhabilitar.TabIndex = 5;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = true;
            // 
            // MantenedorProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(btnInhabilitar);
            Controls.Add(btnRegresar);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenedorProveedores";
            Text = "Mantenedor de Proveedores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnModificar;
        private Button btnRegistrar;
        private CheckBox checkBox1;
        private Label label8;
        private Label label7;
        private TextBox txtCorreo;
        private Label label6;
        private TextBox txtContacto;
        private Label label5;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtRazonSocial;
        private Label label2;
        private TextBox txtRUC;
        private Label label1;
        private Button btnLimpiar;
        private Button btnRegresar;
        private Button btnInhabilitar;
        private DateTimePicker dateTimePicker1;
    }
}
