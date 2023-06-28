namespace Sistema_Almacen
{
    partial class SalidaMercaderia
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
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            button4 = new Button();
            dgvProducto = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Factura:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(32, 20);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 29);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "DNI Cliente:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 54);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 81);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 23);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 83);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombre:";
            // 
            // button1
            // 
            button1.Location = new Point(349, 413);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 9;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(262, 413);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 10;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(32, 44);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(399, 121);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(32, 170);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(399, 94);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de Producto:";
            // 
            // button3
            // 
            button3.Location = new Point(264, 55);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(88, 24);
            button3.TabIndex = 4;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 59);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 3;
            label5.Text = "Cantidad:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(127, 54);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 23);
            textBox5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 32);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 1;
            label4.Text = "Nombre:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 29);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 23);
            textBox4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad });
            dataGridView1.Location = new Point(32, 268);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(399, 141);
            dataGridView1.TabIndex = 13;
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
            // button4
            // 
            button4.Location = new Point(494, 44);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(133, 22);
            button4.TabIndex = 14;
            button4.Text = "Consultar Producto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(494, 76);
            dgvProducto.Margin = new Padding(3, 2, 3, 2);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.RowTemplate.Height = 29;
            dgvProducto.Size = new Size(435, 345);
            dgvProducto.TabIndex = 15;
            // 
            // SalidaMercaderia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 500);
            Controls.Add(dgvProducto);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SalidaMercaderia";
            Text = "Salida Mercaderia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox textBox4;
        private Button button3;
        private Label label5;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private Button button4;
        private DataGridView dgvProducto;
    }
}
