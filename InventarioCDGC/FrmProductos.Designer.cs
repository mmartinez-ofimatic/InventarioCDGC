namespace InventarioCDGC
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.guardartoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaAvanzadaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.tbuscarpor = new System.Windows.Forms.TextBox();
            this.bbuscar = new InventarioCDGC.XButton();
            this.xButtonGuardar = new InventarioCDGC.XButton();
            this.xButtonModificar = new InventarioCDGC.XButton();
            this.xButtonBorrar = new InventarioCDGC.XButton();
            this.xButtonBusquedaAvanzada = new InventarioCDGC.XButton();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardartoolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.borrarToolStripMenuItem1,
            this.busquedaAvanzadaToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(391, 24);
            this.menuStrip.TabIndex = 23;
            this.menuStrip.Text = "menuStrip";
            // 
            // guardartoolStripMenuItem1
            // 
            this.guardartoolStripMenuItem1.Name = "guardartoolStripMenuItem1";
            this.guardartoolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.guardartoolStripMenuItem1.Text = "Guardar";
            this.guardartoolStripMenuItem1.Click += new System.EventHandler(this.guardartoolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.borrarToolStripMenuItem1_Click);
            // 
            // busquedaAvanzadaToolStripMenuItem1
            // 
            this.busquedaAvanzadaToolStripMenuItem1.Name = "busquedaAvanzadaToolStripMenuItem1";
            this.busquedaAvanzadaToolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.busquedaAvanzadaToolStripMenuItem1.Text = "Busqueda Avanzada";
            this.busquedaAvanzadaToolStripMenuItem1.Click += new System.EventHandler(this.busquedaAvanzadaToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPrecio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxIDproducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 172);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Productos";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(117, 128);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio de Venta:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(117, 78);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Producto:";
            // 
            // textBoxIDproducto
            // 
            this.textBoxIDproducto.Location = new System.Drawing.Point(117, 32);
            this.textBoxIDproducto.Name = "textBoxIDproducto";
            this.textBoxIDproducto.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDproducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID del Producto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDProducto,
            this.ColumnNombre,
            this.ColumnPrecio});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(391, 101);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // ColumnIDProducto
            // 
            this.ColumnIDProducto.DataPropertyName = "ID_Producto";
            this.ColumnIDProducto.HeaderText = "ID del Producto";
            this.ColumnIDProducto.Name = "ColumnIDProducto";
            this.ColumnIDProducto.ReadOnly = true;
            this.ColumnIDProducto.Width = 108;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.DataPropertyName = "Producto";
            this.ColumnNombre.HeaderText = "Nombre del Producto";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 130;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.DataPropertyName = "Precio_Venta";
            this.ColumnPrecio.HeaderText = "Precio de Venta";
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            this.ColumnPrecio.Width = 110;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 298);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Buscar por";
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "ID del producto",
            "Nombre del producto"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(76, 294);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(112, 21);
            this.comboBoxBuscar.TabIndex = 33;
            // 
            // tbuscarpor
            // 
            this.tbuscarpor.Location = new System.Drawing.Point(194, 295);
            this.tbuscarpor.Name = "tbuscarpor";
            this.tbuscarpor.Size = new System.Drawing.Size(80, 20);
            this.tbuscarpor.TabIndex = 34;
            // 
            // bbuscar
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
            this.bbuscar.ColorTable = office2010Green1;
            this.bbuscar.Location = new System.Drawing.Point(280, 292);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Size = new System.Drawing.Size(75, 23);
            this.bbuscar.TabIndex = 35;
            this.bbuscar.Text = "Buscar";
            this.bbuscar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.bbuscar.UseVisualStyleBackColor = true;
            // 
            // xButtonGuardar
            // 
            this.xButtonGuardar.ColorTable = office2010Green1;
            this.xButtonGuardar.Location = new System.Drawing.Point(295, 71);
            this.xButtonGuardar.Name = "xButtonGuardar";
            this.xButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.xButtonGuardar.TabIndex = 36;
            this.xButtonGuardar.Text = "Guardar";
            this.xButtonGuardar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonGuardar.UseVisualStyleBackColor = true;
            this.xButtonGuardar.Click += new System.EventHandler(this.xButtonGuardar_Click);
            // 
            // xButtonModificar
            // 
            this.xButtonModificar.ColorTable = office2010Green1;
            this.xButtonModificar.Location = new System.Drawing.Point(295, 113);
            this.xButtonModificar.Name = "xButtonModificar";
            this.xButtonModificar.Size = new System.Drawing.Size(75, 23);
            this.xButtonModificar.TabIndex = 37;
            this.xButtonModificar.Text = "Modificar";
            this.xButtonModificar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonModificar.UseVisualStyleBackColor = true;
            // 
            // xButtonBorrar
            // 
            this.xButtonBorrar.ColorTable = office2010Green1;
            this.xButtonBorrar.Location = new System.Drawing.Point(295, 160);
            this.xButtonBorrar.Name = "xButtonBorrar";
            this.xButtonBorrar.Size = new System.Drawing.Size(75, 23);
            this.xButtonBorrar.TabIndex = 38;
            this.xButtonBorrar.Text = "Borrar";
            this.xButtonBorrar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonBorrar.UseVisualStyleBackColor = true;
            // 
            // xButtonBusquedaAvanzada
            // 
            this.xButtonBusquedaAvanzada.ColorTable = office2010Green1;
            this.xButtonBusquedaAvanzada.Location = new System.Drawing.Point(295, 206);
            this.xButtonBusquedaAvanzada.Name = "xButtonBusquedaAvanzada";
            this.xButtonBusquedaAvanzada.Size = new System.Drawing.Size(75, 41);
            this.xButtonBusquedaAvanzada.TabIndex = 39;
            this.xButtonBusquedaAvanzada.Text = "Busqueda Avanzada";
            this.xButtonBusquedaAvanzada.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonBusquedaAvanzada.UseVisualStyleBackColor = true;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventarioCDGC.Properties.Resources.prueba2;
            this.ClientSize = new System.Drawing.Size(391, 444);
            this.Controls.Add(this.xButtonBusquedaAvanzada);
            this.Controls.Add(this.xButtonBorrar);
            this.Controls.Add(this.xButtonModificar);
            this.Controls.Add(this.xButtonGuardar);
            this.Controls.Add(this.bbuscar);
            this.Controls.Add(this.tbuscarpor);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem guardartoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem busquedaAvanzadaToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.TextBox tbuscarpor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private XButton bbuscar;
        private XButton xButtonGuardar;
        private XButton xButtonModificar;
        private XButton xButtonBorrar;
        private XButton xButtonBusquedaAvanzada;
    }
}