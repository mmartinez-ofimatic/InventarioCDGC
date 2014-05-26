namespace InventarioCDGC
{
    partial class FrmAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlmacen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bbuscarproducto = new System.Windows.Forms.Button();
            this.textBoxIDProducto = new System.Windows.Forms.TextBox();
            this.textBoxExistencia = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xButtonAgregarExitAlmacen = new InventarioCDGC.XButton();
            this.xButtonModificar = new InventarioCDGC.XButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bbuscarproducto);
            this.groupBox1.Controls.Add(this.textBoxIDProducto);
            this.groupBox1.Controls.Add(this.textBoxExistencia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 172);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Almacen";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // bbuscarproducto
            // 
            this.bbuscarproducto.BackColor = System.Drawing.Color.Gainsboro;
            this.bbuscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bbuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscarproducto.Location = new System.Drawing.Point(273, 28);
            this.bbuscarproducto.Name = "bbuscarproducto";
            this.bbuscarproducto.Size = new System.Drawing.Size(93, 20);
            this.bbuscarproducto.TabIndex = 49;
            this.bbuscarproducto.Text = "Buscar producto";
            this.bbuscarproducto.UseVisualStyleBackColor = false;
            this.bbuscarproducto.Click += new System.EventHandler(this.bbuscarproducto_Click);
            // 
            // textBoxIDProducto
            // 
            this.textBoxIDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDProducto.Location = new System.Drawing.Point(123, 29);
            this.textBoxIDProducto.Name = "textBoxIDProducto";
            this.textBoxIDProducto.ReadOnly = true;
            this.textBoxIDProducto.Size = new System.Drawing.Size(121, 20);
            this.textBoxIDProducto.TabIndex = 42;
            this.textBoxIDProducto.TextChanged += new System.EventHandler(this.textBoxIDProducto_TextChanged);
            // 
            // textBoxExistencia
            // 
            this.textBoxExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExistencia.Location = new System.Drawing.Point(122, 124);
            this.textBoxExistencia.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.textBoxExistencia.Name = "textBoxExistencia";
            this.textBoxExistencia.Size = new System.Drawing.Size(120, 20);
            this.textBoxExistencia.TabIndex = 41;
            this.textBoxExistencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existencia:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(122, 78);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombre.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID del Producto:";
            // 
            // xButtonAgregarExitAlmacen
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
            this.xButtonAgregarExitAlmacen.ColorTable = office2010Green1;
            this.xButtonAgregarExitAlmacen.Location = new System.Drawing.Point(22, 249);
            this.xButtonAgregarExitAlmacen.Name = "xButtonAgregarExitAlmacen";
            this.xButtonAgregarExitAlmacen.Size = new System.Drawing.Size(163, 37);
            this.xButtonAgregarExitAlmacen.TabIndex = 48;
            this.xButtonAgregarExitAlmacen.Text = "Agregar Existencia al Almacen";
            this.xButtonAgregarExitAlmacen.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonAgregarExitAlmacen.UseVisualStyleBackColor = true;
            this.xButtonAgregarExitAlmacen.Click += new System.EventHandler(this.xButtonAgregarExitAlmacen_Click);
            // 
            // xButtonModificar
            // 
            this.xButtonModificar.ColorTable = office2010Green1;
            this.xButtonModificar.Location = new System.Drawing.Point(225, 248);
            this.xButtonModificar.Name = "xButtonModificar";
            this.xButtonModificar.Size = new System.Drawing.Size(165, 37);
            this.xButtonModificar.TabIndex = 47;
            this.xButtonModificar.Text = "Sacar Existencia del Almacen";
            this.xButtonModificar.Theme = InventarioCDGC.Theme.MSOffice2010_Green;
            this.xButtonModificar.UseVisualStyleBackColor = true;
            this.xButtonModificar.Click += new System.EventHandler(this.xButtonModificar_Click);
            // 
            // FrmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventarioCDGC.Properties.Resources.prueba2;
            this.ClientSize = new System.Drawing.Size(444, 320);
            this.Controls.Add(this.xButtonAgregarExitAlmacen);
            this.Controls.Add(this.xButtonModificar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacén";
            this.Load += new System.EventHandler(this.FrmAlmacen_Load);
            this.Click += new System.EventHandler(this.FrmAlmacen_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown textBoxExistencia;
        private XButton xButtonAgregarExitAlmacen;
        private System.Windows.Forms.TextBox textBoxIDProducto;
        private System.Windows.Forms.Button bbuscarproducto;
        private XButton xButtonModificar;
    }
}