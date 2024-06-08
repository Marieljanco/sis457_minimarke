namespace CpMinimarke
{
    partial class FrmProducto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            lblTitulo = new Label();
            lblParametro = new Label();
            txtParametro = new TextBox();
            gbxLista = new GroupBox();
            dgvLista = new DataGridView();
            panel1 = new Panel();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            gbxDatos = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            panel1.SuspendLayout();
            gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(360, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(151, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Productos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblParametro
            // 
            lblParametro.AutoSize = true;
            lblParametro.Location = new Point(12, 44);
            lblParametro.Name = "lblParametro";
            lblParametro.Size = new Size(423, 22);
            lblParametro.TabIndex = 1;
            lblParametro.Text = "Buscar por código, descripción o unidad de medida:";
            // 
            // txtParametro
            // 
            txtParametro.Location = new Point(448, 41);
            txtParametro.Name = "txtParametro";
            txtParametro.Size = new Size(350, 28);
            txtParametro.TabIndex = 2;
            // 
            // gbxLista
            // 
            gbxLista.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxLista.BackColor = Color.Transparent;
            gbxLista.Controls.Add(dgvLista);
            gbxLista.Location = new Point(12, 76);
            gbxLista.Name = "gbxLista";
            gbxLista.Size = new Size(820, 181);
            gbxLista.TabIndex = 4;
            gbxLista.TabStop = false;
            gbxLista.Text = "Lista de Productos";
            // 
            // dgvLista
            // 
            dgvLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLista.BackgroundColor = Color.Gainsboro;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(6, 24);
            dgvLista.Name = "dgvLista";
            dgvLista.RowHeadersWidth = 51;
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new Size(800, 148);
            dgvLista.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnNuevo);
            panel1.Location = new Point(12, 256);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 47);
            panel1.TabIndex = 5;
            // 
            // btnNuevo
            // 
            btnNuevo.Image = Properties.Resources._new;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(212, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(110, 40);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(328, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 40);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = Properties.Resources.delete;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(444, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 40);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Image = Properties.Resources.close;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(568, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 40);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // gbxDatos
            // 
            gbxDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxDatos.BackColor = Color.Transparent;
            gbxDatos.Controls.Add(button2);
            gbxDatos.Controls.Add(button1);
            gbxDatos.Controls.Add(numericUpDown1);
            gbxDatos.Controls.Add(comboBox1);
            gbxDatos.Controls.Add(label5);
            gbxDatos.Controls.Add(label4);
            gbxDatos.Controls.Add(textBox3);
            gbxDatos.Controls.Add(textBox2);
            gbxDatos.Controls.Add(textBox1);
            gbxDatos.Controls.Add(label3);
            gbxDatos.Controls.Add(label2);
            gbxDatos.Controls.Add(label1);
            gbxDatos.Location = new Point(12, 309);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(820, 126);
            gbxDatos.TabIndex = 6;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(72, 22);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 58);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 89);
            label3.Name = "label3";
            label3.Size = new Size(109, 22);
            label3.TabIndex = 2;
            label3.Text = "Descripcion:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 28);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 28);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 28);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 24);
            label4.Name = "label4";
            label4.Size = new Size(93, 22);
            label4.TabIndex = 6;
            label4.Text = "Categoria:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 56);
            label5.Name = "label5";
            label5.Size = new Size(118, 22);
            label5.TabIndex = 7;
            label5.Text = "Precio Venta:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(476, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 30);
            comboBox1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(477, 51);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(236, 28);
            numericUpDown1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.cancel1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(693, 81);
            button1.Name = "button1";
            button1.Size = new Size(121, 40);
            button1.TabIndex = 10;
            button1.Text = "Cancel";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.save;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(556, 81);
            button2.Name = "button2";
            button2.Size = new Size(110, 40);
            button2.TabIndex = 11;
            button2.Text = "Guarda";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(844, 447);
            Controls.Add(gbxDatos);
            Controls.Add(panel1);
            Controls.Add(gbxLista);
            Controls.Add(txtParametro);
            Controls.Add(lblParametro);
            Controls.Add(lblTitulo);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "::: Minimarket - Productos :::";
            gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            panel1.ResumeLayout(false);
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblParametro;
        private TextBox txtParametro;
        private GroupBox gbxLista;
        private DataGridView dgvLista;
        private Panel panel1;
        private Button btnNuevo;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnEditar;
        private GroupBox gbxDatos;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
    }
}
