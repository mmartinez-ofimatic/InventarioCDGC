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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            InventarioCDGC.Office2010Green office2010Green1 = new InventarioCDGC.Office2010Green();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxObservacion1 = new System.Windows.Forms.TextBox();
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDescuento = new System.Windows.Forms.NumericUpDown();
            this.textBoxCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.xbuscarproducto = new InventarioCDGC.XButton();
            this.xButtonModificarProductos = new InventarioCDGC.XButton();
            this.xButtonBorrarProductos = new InventarioCDGC.XButton();
            this.xButtonAgregar = new InventarioCDGC.XButton();
            this.xButtonNuevaVenta = new InventarioCDGC.XButton();
            this.xButtonGuardar = new InventarioCDGC.XButton();
            this.xbuscarcliente = new InventarioCDGC.XButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(145, 43);
            this.textBoxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(132, 24);
            this.textBoxCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.Location = new System.Drawing.Point(11, -230);
            this.textBoxObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxObservacion.Multiline = true;
            this.textBoxObservacion.Name = "textBoxObservacion";
            this.textBoxObservacion.Size = new System.Drawing.Size(288, 70);
            this.textBoxObservacion.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Observación";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.xbuscarcliente);
            this.groupBox1.Controls.Add(this.textBoxObservacion1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxObservacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(475, 187);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // textBoxObservacion1
            // 
            this.textBoxObservacion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservacion1.Location = new System.Drawing.Point(145, 91);
            this.textBoxObservacion1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxObservacion1.Multiline = true;
            this.textBoxObservacion1.Name = "textBoxObservacion1";
            this.textBoxObservacion1.ReadOnly = true;
            this.textBoxObservacion1.Size = new System.Drawing.Size(288, 68);
            this.textBoxObservacion1.TabIndex = 2;
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.AllowUserToAddRows = false;
            this.dataGridViewVentas.AllowUserToDeleteRows = false;
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnProduct});
            this.dataGridViewVentas.Location = new System.Drawing.Point(-3, 599);
            this.dataGridViewVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVentas.Size = new System.Drawing.Size(649, 144);
            this.dataGridViewVentas.TabIndex = 45;
            this.dataGridViewVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVentas_CellClick);
            this.dataGridViewVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVentas_CellContentClick);
            this.dataGridViewVentas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVentas_CellContentDoubleClick);
            this.dataGridViewVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVentas_CellDoubleClick);
            this.dataGridViewVentas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewVentas_RowHeaderMouseClick);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.xbuscarproducto);
            this.groupBox2.Controls.Add(this.textBoxDescuento);
            this.groupBox2.Controls.Add(this.xButtonModificarProductos);
            this.groupBox2.Controls.Add(this.textBoxCantidad);
            this.groupBox2.Controls.Add(this.xButtonBorrarProductos);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.xButtonAgregar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxPrecio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxProducto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 241);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(609, 338);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Productos a la Venta";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // textBoxDescuento
            // 
            this.textBoxDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescuento.Location = new System.Drawing.Point(155, 203);
            this.textBoxDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescuento.Name = "textBoxDescuento";
            this.textBoxDescuento.ReadOnly = true;
            this.textBoxDescuento.Size = new System.Drawing.Size(133, 24);
            this.textBoxDescuento.TabIndex = 6;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(155, 150);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCantidad.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.ReadOnly = true;
            this.textBoxCantidad.Size = new System.Drawing.Size(133, 24);
            this.textBoxCantidad.TabIndex = 5;
            this.textBoxCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Precio RD$:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(155, 100);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(132, 24);
            this.textBoxPrecio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "Producto";
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Enabled = false;
            this.textBoxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProducto.Location = new System.Drawing.Point(155, 47);
            this.textBoxProducto.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.ReadOnly = true;
            this.textBoxProducto.Size = new System.Drawing.Size(132, 24);
            this.textBoxProducto.TabIndex = 3;
            // 
            // xbuscarproducto
            // 
            this.xbuscarproducto.ColorTable = office2010Green1;
            this.xbuscarproducto.Enabled = false;
            this.xbuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xbuscarproducto.Location = new System.Drawing.Point(311, 45);
            this.xbuscarproducto.Name = "xbuscarproducto";
            this.xbuscarproducto.Size = new System.Drawing.Size(100, 23);
            this.xbuscarproducto.TabIndex = 3;
            this.xbuscarproducto.Text = "Buscar";
            this.xbuscarproducto.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xbuscarproducto.UseVisualStyleBackColor = true;
            this.xbuscarproducto.Click += new System.EventHandler(this.xbuscarproducto_Click);
            // 
            // xButtonModificarProductos
            // 
            this.xButtonModificarProductos.ColorTable = office2010Green1;
            this.xButtonModificarProductos.Enabled = false;
            this.xButtonModificarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButtonModificarProductos.Location = new System.Drawing.Point(233, 282);
            this.xButtonModificarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.xButtonModificarProductos.Name = "xButtonModificarProductos";
            this.xButtonModificarProductos.Size = new System.Drawing.Size(143, 48);
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
            this.xButtonBorrarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButtonBorrarProductos.Location = new System.Drawing.Point(452, 282);
            this.xButtonBorrarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.xButtonBorrarProductos.Name = "xButtonBorrarProductos";
            this.xButtonBorrarProductos.Size = new System.Drawing.Size(136, 48);
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
            this.xButtonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButtonAgregar.Location = new System.Drawing.Point(8, 282);
            this.xButtonAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.xButtonAgregar.Name = "xButtonAgregar";
            this.xButtonAgregar.Size = new System.Drawing.Size(141, 48);
            this.xButtonAgregar.TabIndex = 7;
            this.xButtonAgregar.Text = "Agregar Producto +";
            this.xButtonAgregar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonAgregar.UseVisualStyleBackColor = true;
            this.xButtonAgregar.Click += new System.EventHandler(this.xButtonAgregar_Click);
            // 
            // xButtonNuevaVenta
            // 
            this.xButtonNuevaVenta.ColorTable = office2010Green1;
            this.xButtonNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButtonNuevaVenta.Location = new System.Drawing.Point(519, 51);
            this.xButtonNuevaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.xButtonNuevaVenta.Name = "xButtonNuevaVenta";
            this.xButtonNuevaVenta.Size = new System.Drawing.Size(116, 46);
            this.xButtonNuevaVenta.TabIndex = 49;
            this.xButtonNuevaVenta.Text = "Nueva Venta";
            this.xButtonNuevaVenta.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonNuevaVenta.UseVisualStyleBackColor = true;
            this.xButtonNuevaVenta.Click += new System.EventHandler(this.xButtonNuevaVenta_Click);
            // 
            // xButtonGuardar
            // 
            this.xButtonGuardar.ColorTable = office2010Green1;
            this.xButtonGuardar.Enabled = false;
            this.xButtonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xButtonGuardar.Location = new System.Drawing.Point(519, 149);
            this.xButtonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.xButtonGuardar.Name = "xButtonGuardar";
            this.xButtonGuardar.Size = new System.Drawing.Size(116, 44);
            this.xButtonGuardar.TabIndex = 41;
            this.xButtonGuardar.Text = "Realizar Venta";
            this.xButtonGuardar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonGuardar.UseVisualStyleBackColor = true;
            this.xButtonGuardar.Click += new System.EventHandler(this.xButtonGuardar_Click);
            // 
            // xbuscarcliente
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
            this.xbuscarcliente.ColorTable = office2010Green1;
            this.xbuscarcliente.Enabled = false;
            this.xbuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xbuscarcliente.Location = new System.Drawing.Point(311, 42);
            this.xbuscarcliente.Name = "xbuscarcliente";
            this.xbuscarcliente.Size = new System.Drawing.Size(122, 23);
            this.xbuscarcliente.TabIndex = 1;
            this.xbuscarcliente.Text = "Buscar Cliente";
            this.xbuscarcliente.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xbuscarcliente.UseVisualStyleBackColor = true;
            this.xbuscarcliente.Click += new System.EventHandler(this.xbuscarcliente_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventarioCDGC.Properties.Resources.prueba2;
            this.ClientSize = new System.Drawing.Size(648, 746);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.xButtonNuevaVenta);
            this.Controls.Add(this.dataGridViewVentas);
            this.Controls.Add(this.xButtonGuardar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.Click += new System.EventHandler(this.FrmVentas_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XButton xButtonGuardar;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxObservacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxObservacion1;
        private XButton xButtonAgregar;
        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private XButton xButtonBorrarProductos;
        private XButton xButtonModificarProductos;
        private XButton xButtonNuevaVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown textBoxDescuento;
        private System.Windows.Forms.NumericUpDown textBoxCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct;
        private XButton xbuscarproducto;
        private XButton xbuscarcliente;
    }
}