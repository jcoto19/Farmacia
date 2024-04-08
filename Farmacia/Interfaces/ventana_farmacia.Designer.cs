namespace Farmacia
{
    partial class ventana_farmacia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_farmacia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Carrito = new System.Windows.Forms.DataGridView();
            this.dt_fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.RichTextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_carrito = new System.Windows.Forms.Button();
            this.bt_eliminarCarrito = new System.Windows.Forms.Button();
            this.bt_borrarCarrito = new System.Windows.Forms.Button();
            this.bt_venta = new System.Windows.Forms.Button();
            this.bt_agregarNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_medicamentos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_EliminarProducto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_agregarCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_medicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dgv_Carrito);
            this.panel1.Controls.Add(this.dt_fechaIngreso);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_precio);
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.txt_Nombre);
            this.panel1.Controls.Add(this.txt_cantidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 332);
            this.panel1.TabIndex = 0;
            // 
            // dgv_Carrito
            // 
            this.dgv_Carrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Carrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Carrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Carrito.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Carrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.dgv_Carrito.Location = new System.Drawing.Point(453, 32);
            this.dgv_Carrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Carrito.Name = "dgv_Carrito";
            this.dgv_Carrito.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Carrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Carrito.RowHeadersWidth = 51;
            this.dgv_Carrito.Size = new System.Drawing.Size(674, 290);
            this.dgv_Carrito.TabIndex = 30;
            // 
            // dt_fechaIngreso
            // 
            this.dt_fechaIngreso.Location = new System.Drawing.Point(168, 302);
            this.dt_fechaIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_fechaIngreso.Name = "dt_fechaIngreso";
            this.dt_fechaIngreso.Size = new System.Drawing.Size(268, 22);
            this.dt_fechaIngreso.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(7, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha:";
            // 
            // txt_precio
            // 
            this.txt_precio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_precio.Location = new System.Drawing.Point(171, 164);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(128, 22);
            this.txt_precio.TabIndex = 4;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcion.Location = new System.Drawing.Point(168, 202);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(271, 79);
            this.txt_descripcion.TabIndex = 5;
            this.txt_descripcion.Text = "";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nombre.Location = new System.Drawing.Point(171, 74);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(268, 22);
            this.txt_Nombre.TabIndex = 2;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantidad.Location = new System.Drawing.Point(168, 118);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(131, 22);
            this.txt_cantidad.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(7, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Precio unitario:";
            // 
            // txt_id
            // 
            this.txt_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_id.Location = new System.Drawing.Point(168, 37);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(271, 22);
            this.txt_id.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(7, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(4, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Identificador";
            // 
            // btn_carrito
            // 
            this.btn_carrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_carrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.btn_carrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btn_carrito.Image = global::Farmacia.Properties.Resources.carro;
            this.btn_carrito.Location = new System.Drawing.Point(1072, 437);
            this.btn_carrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_carrito.Name = "btn_carrito";
            this.btn_carrito.Size = new System.Drawing.Size(119, 73);
            this.btn_carrito.TabIndex = 8;
            this.btn_carrito.Text = "Agregar al carrito";
            this.btn_carrito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_carrito.UseVisualStyleBackColor = false;
            this.btn_carrito.Click += new System.EventHandler(this.btn_carrito_Click);
            // 
            // bt_eliminarCarrito
            // 
            this.bt_eliminarCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_eliminarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.bt_eliminarCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.bt_eliminarCarrito.Image = global::Farmacia.Properties.Resources.trash;
            this.bt_eliminarCarrito.Location = new System.Drawing.Point(1072, 604);
            this.bt_eliminarCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_eliminarCarrito.Name = "bt_eliminarCarrito";
            this.bt_eliminarCarrito.Size = new System.Drawing.Size(119, 73);
            this.bt_eliminarCarrito.TabIndex = 10;
            this.bt_eliminarCarrito.Text = "Eliminar del carrito";
            this.bt_eliminarCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_eliminarCarrito.UseVisualStyleBackColor = false;
            this.bt_eliminarCarrito.Click += new System.EventHandler(this.bt_eliminarCarrito_Click);
            // 
            // bt_borrarCarrito
            // 
            this.bt_borrarCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_borrarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.bt_borrarCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.bt_borrarCarrito.Image = global::Farmacia.Properties.Resources.clear;
            this.bt_borrarCarrito.Location = new System.Drawing.Point(1072, 523);
            this.bt_borrarCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_borrarCarrito.Name = "bt_borrarCarrito";
            this.bt_borrarCarrito.Size = new System.Drawing.Size(119, 73);
            this.bt_borrarCarrito.TabIndex = 11;
            this.bt_borrarCarrito.Text = "Vaciar carrito";
            this.bt_borrarCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_borrarCarrito.UseVisualStyleBackColor = false;
            this.bt_borrarCarrito.Click += new System.EventHandler(this.bt_borrarCarrito_Click);
            // 
            // bt_venta
            // 
            this.bt_venta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.bt_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.bt_venta.Image = global::Farmacia.Properties.Resources.cuenta_bancaria;
            this.bt_venta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_venta.Location = new System.Drawing.Point(824, 4);
            this.bt_venta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_venta.Name = "bt_venta";
            this.bt_venta.Size = new System.Drawing.Size(172, 47);
            this.bt_venta.TabIndex = 9;
            this.bt_venta.Text = "Vender";
            this.bt_venta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_venta.UseVisualStyleBackColor = false;
            this.bt_venta.Click += new System.EventHandler(this.bt_venta_Click);
            // 
            // bt_agregarNuevo
            // 
            this.bt_agregarNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_agregarNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.bt_agregarNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.bt_agregarNuevo.Image = global::Farmacia.Properties.Resources.save2;
            this.bt_agregarNuevo.Location = new System.Drawing.Point(644, 2);
            this.bt_agregarNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_agregarNuevo.Name = "bt_agregarNuevo";
            this.bt_agregarNuevo.Size = new System.Drawing.Size(172, 49);
            this.bt_agregarNuevo.TabIndex = 7;
            this.bt_agregarNuevo.Text = "Agregar nuevo medicamento";
            this.bt_agregarNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_agregarNuevo.UseVisualStyleBackColor = false;
            this.bt_agregarNuevo.Click += new System.EventHandler(this.bt_agregarNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Administración de medicamentos";
            // 
            // tb_medicamentos
            // 
            this.tb_medicamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_medicamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tb_medicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tb_medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tb_medicamentos.DefaultCellStyle = dataGridViewCellStyle5;
            this.tb_medicamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.tb_medicamentos.Location = new System.Drawing.Point(23, 444);
            this.tb_medicamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_medicamentos.Name = "tb_medicamentos";
            this.tb_medicamentos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tb_medicamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tb_medicamentos.RowHeadersWidth = 51;
            this.tb_medicamentos.ShowCellToolTips = false;
            this.tb_medicamentos.Size = new System.Drawing.Size(1041, 233);
            this.tb_medicamentos.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnSalir.Location = new System.Drawing.Point(1004, 4);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(172, 47);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(836, 402);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Buscar:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Buscar.Location = new System.Drawing.Point(929, 405);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(231, 22);
            this.txt_Buscar.TabIndex = 26;
            this.txt_Buscar.Tag = "";
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // btn_EliminarProducto
            // 
            this.btn_EliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.btn_EliminarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btn_EliminarProducto.Image = global::Farmacia.Properties.Resources.trash;
            this.btn_EliminarProducto.Location = new System.Drawing.Point(603, 396);
            this.btn_EliminarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EliminarProducto.Name = "btn_EliminarProducto";
            this.btn_EliminarProducto.Size = new System.Drawing.Size(213, 43);
            this.btn_EliminarProducto.TabIndex = 31;
            this.btn_EliminarProducto.Text = "Eliminar Medicamento";
            this.btn_EliminarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_EliminarProducto.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(35, 405);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "INVENTARIO";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(448, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "PRESELECCION";
            // 
            // bt_agregarCliente
            // 
            this.bt_agregarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_agregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(172)))), ((int)(((byte)(80)))));
            this.bt_agregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.bt_agregarCliente.Image = global::Farmacia.Properties.Resources.cuenta_bancaria;
            this.bt_agregarCliente.Location = new System.Drawing.Point(484, 5);
            this.bt_agregarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.bt_agregarCliente.Name = "bt_agregarCliente";
            this.bt_agregarCliente.Size = new System.Drawing.Size(152, 46);
            this.bt_agregarCliente.TabIndex = 34;
            this.bt_agregarCliente.Text = "Agregar Cliente";
            this.bt_agregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_agregarCliente.UseVisualStyleBackColor = false;
            this.bt_agregarCliente.Click += new System.EventHandler(this.bt_agregarCliente_Click);
            // 
            // ventana_farmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1204, 690);
            this.Controls.Add(this.bt_agregarCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_EliminarProducto);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.bt_eliminarCarrito);
            this.Controls.Add(this.btn_carrito);
            this.Controls.Add(this.bt_venta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bt_borrarCarrito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_medicamentos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_agregarNuevo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ventana_farmacia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de Farmacia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_medicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_venta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tb_medicamentos;
        private System.Windows.Forms.Button bt_agregarNuevo;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_borrarCarrito;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_eliminarCarrito;
        private System.Windows.Forms.Button btn_carrito;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dt_fechaIngreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.DataGridView dgv_Carrito;
        private System.Windows.Forms.Button btn_EliminarProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_agregarCliente;
    }
}