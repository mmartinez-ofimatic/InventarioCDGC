namespace InventarioCDGC
{
    partial class FrmUsuario
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
            this.ColumnIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRcontrasena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xButtonBusquedaAvanzada = new InventarioCDGC.XButton();
            this.xButtonBorrar = new InventarioCDGC.XButton();
            this.xButtonModificar = new InventarioCDGC.XButton();
            this.xButtonGuardar = new InventarioCDGC.XButton();
            this.xButton1 = new InventarioCDGC.XButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbuscarpor
            // 
            this.tbuscarpor.Location = new System.Drawing.Point(198, 279);
            this.tbuscarpor.Name = "tbuscarpor";
            this.tbuscarpor.Size = new System.Drawing.Size(80, 20);
            this.tbuscarpor.TabIndex = 48;
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "ID de usuario",
            "Nombre de usuario"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(80, 278);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(112, 21);
            this.comboBoxBuscar.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(16, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Buscar por";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDProducto,
            this.ColumnExistencia,
            this.ColumnNombre,
            this.ColumnContrasena});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(417, 108);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ColumnIDProducto
            // 
            this.ColumnIDProducto.DataPropertyName = "ID_Usuario";
            this.ColumnIDProducto.HeaderText = "ID de usuario";
            this.ColumnIDProducto.Name = "ColumnIDProducto";
            this.ColumnIDProducto.ReadOnly = true;
            this.ColumnIDProducto.Width = 108;
            // 
            // ColumnExistencia
            // 
            this.ColumnExistencia.DataPropertyName = "ID_Rol";
            this.ColumnExistencia.HeaderText = "ID_Rol";
            this.ColumnExistencia.Name = "ColumnExistencia";
            this.ColumnExistencia.ReadOnly = true;
            this.ColumnExistencia.Width = 110;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.DataPropertyName = "Nombre";
            this.ColumnNombre.HeaderText = "Nombre de usuario";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 155;
            // 
            // ColumnContrasena
            // 
            this.ColumnContrasena.DataPropertyName = "Contrasena";
            this.ColumnContrasena.HeaderText = "Contraseña";
            this.ColumnContrasena.Name = "ColumnContrasena";
            this.ColumnContrasena.ReadOnly = true;
            this.ColumnContrasena.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxRcontrasena);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxContrasena);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxRol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 193);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // textBoxRcontrasena
            // 
            this.textBoxRcontrasena.Location = new System.Drawing.Point(120, 114);
            this.textBoxRcontrasena.Name = "textBoxRcontrasena";
            this.textBoxRcontrasena.PasswordChar = '*';
            this.textBoxRcontrasena.Size = new System.Drawing.Size(121, 20);
            this.textBoxRcontrasena.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Repetir Contraseña";
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Location = new System.Drawing.Point(120, 71);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = '*';
            this.textBoxContrasena.Size = new System.Drawing.Size(121, 20);
            this.textBoxContrasena.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Contraseña";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(120, 154);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRol.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Rol";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(120, 30);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombre.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de usuario";
            // 
            // xButtonBusquedaAvanzada
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
            this.xButtonBusquedaAvanzada.ColorTable = office2010Green1;
            this.xButtonBusquedaAvanzada.Location = new System.Drawing.Point(318, 197);
            this.xButtonBusquedaAvanzada.Name = "xButtonBusquedaAvanzada";
            this.xButtonBusquedaAvanzada.Size = new System.Drawing.Size(75, 41);
            this.xButtonBusquedaAvanzada.TabIndex = 59;
            this.xButtonBusquedaAvanzada.Text = "Busqueda Avanzada";
            this.xButtonBusquedaAvanzada.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.xButtonBusquedaAvanzada.Click += new System.EventHandler(this.xButtonBusquedaAvanzada_Click);
            // 
            // xButtonBorrar
            // 
            this.xButtonBorrar.ColorTable = office2010Green1;
            this.xButtonBorrar.Location = new System.Drawing.Point(318, 146);
            this.xButtonBorrar.Name = "xButtonBorrar";
            this.xButtonBorrar.Size = new System.Drawing.Size(75, 23);
            this.xButtonBorrar.TabIndex = 58;
            this.xButtonBorrar.Text = "Borrar";
            this.xButtonBorrar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonBorrar.UseVisualStyleBackColor = true;
            this.xButtonBorrar.Click += new System.EventHandler(this.xButtonBorrar_Click);
            // 
            // xButtonModificar
            // 
            this.xButtonModificar.ColorTable = office2010Green1;
            this.xButtonModificar.Location = new System.Drawing.Point(318, 93);
            this.xButtonModificar.Name = "xButtonModificar";
            this.xButtonModificar.Size = new System.Drawing.Size(75, 23);
            this.xButtonModificar.TabIndex = 57;
            this.xButtonModificar.Text = "Modificar";
            this.xButtonModificar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonModificar.UseVisualStyleBackColor = true;
            this.xButtonModificar.Click += new System.EventHandler(this.xButtonModificar_Click);
            // 
            // xButtonGuardar
            // 
            this.xButtonGuardar.ColorTable = office2010Green1;
            this.xButtonGuardar.Location = new System.Drawing.Point(318, 40);
            this.xButtonGuardar.Name = "xButtonGuardar";
            this.xButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.xButtonGuardar.TabIndex = 56;
            this.xButtonGuardar.Text = "Guardar";
            this.xButtonGuardar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonGuardar.UseVisualStyleBackColor = true;
            this.xButtonGuardar.Click += new System.EventHandler(this.xButtonGuardar_Click);
            // 
            // xButton1
            // 
            this.xButton1.ColorTable = office2010Green1;
            this.xButton1.Location = new System.Drawing.Point(295, 276);
            this.xButton1.Name = "xButton1";
            this.xButton1.Size = new System.Drawing.Size(75, 23);
            this.xButton1.TabIndex = 55;
            this.xButton1.Text = " Buscar";
            this.xButton1.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButton1.UseVisualStyleBackColor = true;
            this.xButton1.Click += new System.EventHandler(this.xButton1_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventarioCDGC.Properties.Resources.prueba2;
            this.ClientSize = new System.Drawing.Size(417, 435);
            this.Controls.Add(this.xButtonBusquedaAvanzada);
            this.Controls.Add(this.xButtonBorrar);
            this.Controls.Add(this.xButtonModificar);
            this.Controls.Add(this.xButtonGuardar);
            this.Controls.Add(this.xButton1);
            this.Controls.Add(this.tbuscarpor);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios del Sistema";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbuscarpor;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRcontrasena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContrasena;
        private XButton xButtonBusquedaAvanzada;
        private XButton xButtonBorrar;
        private XButton xButtonModificar;
        private XButton xButtonGuardar;
        private XButton xButton1;
    }
}