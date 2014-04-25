﻿namespace InventarioCDGC
{
    partial class FrmVentas
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
            InventarioCDGC.Office2010Green office2010Green1 = new InventarioCDGC.Office2010Green();
            this.tbuscarpor = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnIDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bbuscar = new System.Windows.Forms.Button();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bbuscarcliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxObservacion1 = new System.Windows.Forms.TextBox();
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDescuento = new System.Windows.Forms.NumericUpDown();
            this.bbuscarproducto = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.xButtonModificarProductos = new InventarioCDGC.XButton();
            this.xButtonBorrarProductos = new InventarioCDGC.XButton();
            this.xButtonAgregar = new InventarioCDGC.XButton();
            this.xButtonNuevaVenta = new InventarioCDGC.XButton();
            this.xButtonBusquedaAvanzada = new InventarioCDGC.XButton();
            this.xButtonBorrar = new InventarioCDGC.XButton();
            this.xButtonModificar = new InventarioCDGC.XButton();
            this.xButtonGuardar = new InventarioCDGC.XButton();
            this.xButton1 = new InventarioCDGC.XButton();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tbuscarpor
            // 
            this.tbuscarpor.Location = new System.Drawing.Point(923, 18);
            this.tbuscarpor.Name = "tbuscarpor";
            this.tbuscarpor.Size = new System.Drawing.Size(80, 20);
            this.tbuscarpor.TabIndex = 38;
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "ID de Venta",
            "ID del Cliente",
            "ID del Producto"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(805, 17);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(112, 21);
            this.comboBoxBuscar.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(741, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Buscar por";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDVenta,
            this.ColumnNombre,
            this.ColumnIDProducto,
            this.ColumnIDusuario,
            this.ColumnPrecio,
            this.ColumnCantidad,
            this.ColumnDescuento,
            this.ColumnFecha,
            this.ColumnObservacion});
            this.dataGridView1.Location = new System.Drawing.Point(749, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(327, 173);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ColumnIDVenta
            // 
            this.ColumnIDVenta.DataPropertyName = "ID_Venta";
            this.ColumnIDVenta.HeaderText = "ID de Venta";
            this.ColumnIDVenta.Name = "ColumnIDVenta";
            this.ColumnIDVenta.ReadOnly = true;
            this.ColumnIDVenta.Width = 108;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.DataPropertyName = "ID_Cliente";
            this.ColumnNombre.HeaderText = "ID de Cliente";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 130;
            // 
            // ColumnIDProducto
            // 
            this.ColumnIDProducto.DataPropertyName = "ID_Producto";
            this.ColumnIDProducto.HeaderText = "ID del Producto";
            this.ColumnIDProducto.Name = "ColumnIDProducto";
            this.ColumnIDProducto.ReadOnly = true;
            this.ColumnIDProducto.Width = 110;
            // 
            // ColumnIDusuario
            // 
            this.ColumnIDusuario.DataPropertyName = "ID_Usuario";
            this.ColumnIDusuario.HeaderText = "ID de Usuario";
            this.ColumnIDusuario.Name = "ColumnIDusuario";
            this.ColumnIDusuario.ReadOnly = true;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.DataPropertyName = "Precio_Unidad";
            this.ColumnPrecio.HeaderText = "Precio de Venta";
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.DataPropertyName = "Cantidad";
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.ReadOnly = true;
            // 
            // ColumnDescuento
            // 
            this.ColumnDescuento.DataPropertyName = "Descuento";
            this.ColumnDescuento.HeaderText = "Descuento";
            this.ColumnDescuento.Name = "ColumnDescuento";
            this.ColumnDescuento.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.DataPropertyName = "Fecha";
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // ColumnObservacion
            // 
            this.ColumnObservacion.DataPropertyName = "Observacion";
            this.ColumnObservacion.HeaderText = "Observacion";
            this.ColumnObservacion.Name = "ColumnObservacion";
            this.ColumnObservacion.ReadOnly = true;
            // 
            // bbuscar
            // 
            this.bbuscar.Location = new System.Drawing.Point(1009, 13);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Size = new System.Drawing.Size(75, 28);
            this.bbuscar.TabIndex = 36;
            this.bbuscar.Text = "Buscar";
            this.bbuscar.UseVisualStyleBackColor = true;
            this.bbuscar.Click += new System.EventHandler(this.bbuscar_Click);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(109, 35);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.Location = new System.Drawing.Point(8, -187);
            this.textBoxObservacion.Multiline = true;
            this.textBoxObservacion.Name = "textBoxObservacion";
            this.textBoxObservacion.Size = new System.Drawing.Size(217, 58);
            this.textBoxObservacion.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Observación";
            // 
            // bbuscarcliente
            // 
            this.bbuscarcliente.BackColor = System.Drawing.Color.Gainsboro;
            this.bbuscarcliente.Enabled = false;
            this.bbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bbuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscarcliente.Location = new System.Drawing.Point(237, 35);
            this.bbuscarcliente.Name = "bbuscarcliente";
            this.bbuscarcliente.Size = new System.Drawing.Size(93, 21);
            this.bbuscarcliente.TabIndex = 33;
            this.bbuscarcliente.Text = "Buscar cliente";
            this.bbuscarcliente.UseVisualStyleBackColor = false;
            this.bbuscarcliente.Click += new System.EventHandler(this.bbuscarcliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxObservacion1);
            this.groupBox1.Controls.Add(this.bbuscarcliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxObservacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 152);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // textBoxObservacion1
            // 
            this.textBoxObservacion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservacion1.Location = new System.Drawing.Point(109, 74);
            this.textBoxObservacion1.Multiline = true;
            this.textBoxObservacion1.Name = "textBoxObservacion1";
            this.textBoxObservacion1.ReadOnly = true;
            this.textBoxObservacion1.Size = new System.Drawing.Size(217, 56);
            this.textBoxObservacion1.TabIndex = 42;
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.AllowUserToAddRows = false;
            this.dataGridViewVentas.AllowUserToDeleteRows = false;
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnProduct});
            this.dataGridViewVentas.Location = new System.Drawing.Point(-2, 487);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.ReadOnly = true;
            this.dataGridViewVentas.Size = new System.Drawing.Size(487, 117);
            this.dataGridViewVentas.TabIndex = 45;
            this.dataGridViewVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVentas_CellClick);
            this.dataGridViewVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVentas_CellContentClick);
            this.dataGridViewVentas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVentas_CellContentDoubleClick);
            this.dataGridViewVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVentas_CellDoubleClick);
            this.dataGridViewVentas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewVentas_RowHeaderMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBoxDescuento);
            this.groupBox2.Controls.Add(this.xButtonModificarProductos);
            this.groupBox2.Controls.Add(this.bbuscarproducto);
            this.groupBox2.Controls.Add(this.textBoxCantidad);
            this.groupBox2.Controls.Add(this.xButtonBorrarProductos);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.xButtonAgregar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxPrecio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxProducto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 275);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Productos a la Venta";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // textBoxDescuento
            // 
            this.textBoxDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescuento.Location = new System.Drawing.Point(116, 165);
            this.textBoxDescuento.Name = "textBoxDescuento";
            this.textBoxDescuento.ReadOnly = true;
            this.textBoxDescuento.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescuento.TabIndex = 50;
            // 
            // bbuscarproducto
            // 
            this.bbuscarproducto.BackColor = System.Drawing.Color.Gainsboro;
            this.bbuscarproducto.Enabled = false;
            this.bbuscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bbuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscarproducto.Location = new System.Drawing.Point(244, 38);
            this.bbuscarproducto.Name = "bbuscarproducto";
            this.bbuscarproducto.Size = new System.Drawing.Size(93, 20);
            this.bbuscarproducto.TabIndex = 48;
            this.bbuscarproducto.Text = "Buscar producto";
            this.bbuscarproducto.UseVisualStyleBackColor = false;
            this.bbuscarproducto.Click += new System.EventHandler(this.bbuscarproducto_Click_1);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(116, 122);
            this.textBoxCantidad.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.ReadOnly = true;
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidad.TabIndex = 49;
            this.textBoxCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Precio de unidad";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(116, 81);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Producto";
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Enabled = false;
            this.textBoxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProducto.Location = new System.Drawing.Point(116, 38);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.ReadOnly = true;
            this.textBoxProducto.Size = new System.Drawing.Size(100, 20);
            this.textBoxProducto.TabIndex = 42;
            // 
            // xButtonModificarProductos
            // 
            office2010Green1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Green1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Green1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Green1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Green1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Green1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Green1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(43)))));
            office2010Green1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            office2010Green1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(43)))));
            office2010Green1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            office2010Green1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Green1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Green1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Green1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Green1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Green1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Green1.TextColor = System.Drawing.Color.White;
            this.xButtonModificarProductos.ColorTable = office2010Green1;
            this.xButtonModificarProductos.Enabled = false;
            this.xButtonModificarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButtonModificarProductos.Location = new System.Drawing.Point(175, 229);
            this.xButtonModificarProductos.Name = "xButtonModificarProductos";
            this.xButtonModificarProductos.Size = new System.Drawing.Size(107, 23);
            this.xButtonModificarProductos.TabIndex = 48;
            this.xButtonModificarProductos.Text = "Modificar Producto";
            this.xButtonModificarProductos.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonModificarProductos.UseVisualStyleBackColor = true;
            this.xButtonModificarProductos.Click += new System.EventHandler(this.xButtonModificarProductos_Click);
            // 
            // xButtonBorrarProductos
            // 
            this.xButtonBorrarProductos.ColorTable = office2010Green1;
            this.xButtonBorrarProductos.Enabled = false;
            this.xButtonBorrarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButtonBorrarProductos.Location = new System.Drawing.Point(339, 229);
            this.xButtonBorrarProductos.Name = "xButtonBorrarProductos";
            this.xButtonBorrarProductos.Size = new System.Drawing.Size(102, 23);
            this.xButtonBorrarProductos.TabIndex = 47;
            this.xButtonBorrarProductos.Text = "Borrar Producto -";
            this.xButtonBorrarProductos.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonBorrarProductos.UseVisualStyleBackColor = true;
            this.xButtonBorrarProductos.Click += new System.EventHandler(this.xButtonBorrarProductos_Click);
            // 
            // xButtonAgregar
            // 
            this.xButtonAgregar.ColorTable = office2010Green1;
            this.xButtonAgregar.Enabled = false;
            this.xButtonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButtonAgregar.Location = new System.Drawing.Point(6, 229);
            this.xButtonAgregar.Name = "xButtonAgregar";
            this.xButtonAgregar.Size = new System.Drawing.Size(106, 23);
            this.xButtonAgregar.TabIndex = 46;
            this.xButtonAgregar.Text = "Agregar Producto +";
            this.xButtonAgregar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonAgregar.UseVisualStyleBackColor = true;
            this.xButtonAgregar.Click += new System.EventHandler(this.xButtonAgregar_Click);
            // 
            // xButtonNuevaVenta
            // 
            this.xButtonNuevaVenta.ColorTable = office2010Green1;
            this.xButtonNuevaVenta.Location = new System.Drawing.Point(389, 48);
            this.xButtonNuevaVenta.Name = "xButtonNuevaVenta";
            this.xButtonNuevaVenta.Size = new System.Drawing.Size(87, 31);
            this.xButtonNuevaVenta.TabIndex = 49;
            this.xButtonNuevaVenta.Text = "Nueva Venta";
            this.xButtonNuevaVenta.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonNuevaVenta.UseVisualStyleBackColor = true;
            this.xButtonNuevaVenta.Click += new System.EventHandler(this.xButtonNuevaVenta_Click);
            // 
            // xButtonBusquedaAvanzada
            // 
            this.xButtonBusquedaAvanzada.ColorTable = office2010Green1;
            this.xButtonBusquedaAvanzada.Location = new System.Drawing.Point(1085, 219);
            this.xButtonBusquedaAvanzada.Name = "xButtonBusquedaAvanzada";
            this.xButtonBusquedaAvanzada.Size = new System.Drawing.Size(75, 41);
            this.xButtonBusquedaAvanzada.TabIndex = 44;
            this.xButtonBusquedaAvanzada.Text = "Busqueda Avanzada";
            this.xButtonBusquedaAvanzada.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.xButtonBusquedaAvanzada.Click += new System.EventHandler(this.xButtonBusquedaAvanzada_Click);
            // 
            // xButtonBorrar
            // 
            this.xButtonBorrar.ColorTable = office2010Green1;
            this.xButtonBorrar.Location = new System.Drawing.Point(1085, 157);
            this.xButtonBorrar.Name = "xButtonBorrar";
            this.xButtonBorrar.Size = new System.Drawing.Size(75, 23);
            this.xButtonBorrar.TabIndex = 43;
            this.xButtonBorrar.Text = "Borrar";
            this.xButtonBorrar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonBorrar.UseVisualStyleBackColor = true;
            this.xButtonBorrar.Click += new System.EventHandler(this.xButtonBorrar_Click);
            // 
            // xButtonModificar
            // 
            this.xButtonModificar.ColorTable = office2010Green1;
            this.xButtonModificar.Location = new System.Drawing.Point(1085, 92);
            this.xButtonModificar.Name = "xButtonModificar";
            this.xButtonModificar.Size = new System.Drawing.Size(75, 23);
            this.xButtonModificar.TabIndex = 42;
            this.xButtonModificar.Text = "Modificar";
            this.xButtonModificar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonModificar.UseVisualStyleBackColor = true;
            this.xButtonModificar.Click += new System.EventHandler(this.xButtonModificar_Click);
            // 
            // xButtonGuardar
            // 
            this.xButtonGuardar.ColorTable = office2010Green1;
            this.xButtonGuardar.Enabled = false;
            this.xButtonGuardar.Location = new System.Drawing.Point(389, 121);
            this.xButtonGuardar.Name = "xButtonGuardar";
            this.xButtonGuardar.Size = new System.Drawing.Size(87, 36);
            this.xButtonGuardar.TabIndex = 41;
            this.xButtonGuardar.Text = "Realizar Venta";
            this.xButtonGuardar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonGuardar.UseVisualStyleBackColor = true;
            this.xButtonGuardar.Click += new System.EventHandler(this.xButtonGuardar_Click);
            // 
            // xButton1
            // 
            this.xButton1.ColorTable = office2010Green1;
            this.xButton1.Location = new System.Drawing.Point(1085, 40);
            this.xButton1.Name = "xButton1";
            this.xButton1.Size = new System.Drawing.Size(75, 23);
            this.xButton1.TabIndex = 40;
            this.xButton1.Text = " Buscar";
            this.xButton1.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButton1.UseVisualStyleBackColor = true;
            this.xButton1.Click += new System.EventHandler(this.xButton1_Click);
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "idProducto";
            this.ColumnID.HeaderText = "ID Producto";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnProduct
            // 
            this.ColumnProduct.DataPropertyName = "Producto";
            this.ColumnProduct.HeaderText = "Productos";
            this.ColumnProduct.Name = "ColumnProduct";
            this.ColumnProduct.ReadOnly = true;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventarioCDGC.Properties.Resources.prueba2;
            this.ClientSize = new System.Drawing.Size(486, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.xButtonNuevaVenta);
            this.Controls.Add(this.dataGridViewVentas);
            this.Controls.Add(this.xButtonBusquedaAvanzada);
            this.Controls.Add(this.xButtonBorrar);
            this.Controls.Add(this.xButtonModificar);
            this.Controls.Add(this.xButtonGuardar);
            this.Controls.Add(this.xButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbuscarpor);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.bbuscar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.Click += new System.EventHandler(this.FrmVentas_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbuscarpor;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObservacion;
        private XButton xButtonBusquedaAvanzada;
        private XButton xButtonBorrar;
        private XButton xButtonModificar;
        private XButton xButtonGuardar;
        private XButton xButton1;
        private System.Windows.Forms.Button bbuscar;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxObservacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bbuscarcliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxObservacion1;
        private XButton xButtonAgregar;
        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private XButton xButtonBorrarProductos;
        private XButton xButtonModificarProductos;
        private XButton xButtonNuevaVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown textBoxDescuento;
        private System.Windows.Forms.Button bbuscarproducto;
        private System.Windows.Forms.NumericUpDown textBoxCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct;
    }
}