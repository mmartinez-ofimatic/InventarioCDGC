namespace InventarioCDGC
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datosInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosInventarioToolStripMenuItem,
            this.consultasDeInventarioToolStripMenuItem,
            this.reportesDeInventarioToolStripMenuItem,
            this.toolStripMenuItemUsuario,
            this.AyudatoolStripMenuItem,
            this.cerrarSeccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datosInventarioToolStripMenuItem
            // 
            this.datosInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeClientesToolStripMenuItem,
            this.registroDeVentasToolStripMenuItem,
            this.registroDeProductosToolStripMenuItem,
            this.registroDeAlmacenToolStripMenuItem});
            this.datosInventarioToolStripMenuItem.Name = "datosInventarioToolStripMenuItem";
            this.datosInventarioToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.datosInventarioToolStripMenuItem.Text = "Datos del Inventario";
            // 
            // registroDeClientesToolStripMenuItem
            // 
            this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
            this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeClientesToolStripMenuItem.Text = "Registro de Clientes";
            this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.registroDeClientesToolStripMenuItem_Click);
            // 
            // registroDeVentasToolStripMenuItem
            // 
            this.registroDeVentasToolStripMenuItem.Name = "registroDeVentasToolStripMenuItem";
            this.registroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeVentasToolStripMenuItem.Text = "Registro de Ventas";
            this.registroDeVentasToolStripMenuItem.Click += new System.EventHandler(this.registroDeVentasToolStripMenuItem_Click);
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeProductosToolStripMenuItem.Text = "Registro de Productos";
            this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registroDeProductosToolStripMenuItem_Click);
            // 
            // registroDeAlmacenToolStripMenuItem
            // 
            this.registroDeAlmacenToolStripMenuItem.Name = "registroDeAlmacenToolStripMenuItem";
            this.registroDeAlmacenToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeAlmacenToolStripMenuItem.Text = "Registro de Almacen";
            this.registroDeAlmacenToolStripMenuItem.Click += new System.EventHandler(this.registroDeAlmacenToolStripMenuItem_Click);
            // 
            // consultasDeInventarioToolStripMenuItem
            // 
            this.consultasDeInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaClientesToolStripMenuItem,
            this.consultaDeVentasToolStripMenuItem,
            this.consultaDeProductosToolStripMenuItem,
            this.consultaDeAlmacenToolStripMenuItem});
            this.consultasDeInventarioToolStripMenuItem.Name = "consultasDeInventarioToolStripMenuItem";
            this.consultasDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.consultasDeInventarioToolStripMenuItem.Text = "Consultas del Inventario";
            // 
            // consultaClientesToolStripMenuItem
            // 
            this.consultaClientesToolStripMenuItem.Name = "consultaClientesToolStripMenuItem";
            this.consultaClientesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.consultaClientesToolStripMenuItem.Text = "Consulta de Clientes";
            this.consultaClientesToolStripMenuItem.Click += new System.EventHandler(this.consultaClientesToolStripMenuItem_Click);
            // 
            // consultaDeVentasToolStripMenuItem
            // 
            this.consultaDeVentasToolStripMenuItem.Name = "consultaDeVentasToolStripMenuItem";
            this.consultaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.consultaDeVentasToolStripMenuItem.Text = "Consulta de Ventas";
            this.consultaDeVentasToolStripMenuItem.Click += new System.EventHandler(this.consultaDeVentasToolStripMenuItem_Click);
            // 
            // consultaDeProductosToolStripMenuItem
            // 
            this.consultaDeProductosToolStripMenuItem.Name = "consultaDeProductosToolStripMenuItem";
            this.consultaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.consultaDeProductosToolStripMenuItem.Text = "Consulta de Productos";
            this.consultaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeProductosToolStripMenuItem_Click);
            // 
            // consultaDeAlmacenToolStripMenuItem
            // 
            this.consultaDeAlmacenToolStripMenuItem.Name = "consultaDeAlmacenToolStripMenuItem";
            this.consultaDeAlmacenToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.consultaDeAlmacenToolStripMenuItem.Text = "Consulta de Almacen";
            this.consultaDeAlmacenToolStripMenuItem.Click += new System.EventHandler(this.consultaDeAlmacenToolStripMenuItem_Click);
            // 
            // reportesDeInventarioToolStripMenuItem
            // 
            this.reportesDeInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeClientesToolStripMenuItem1,
            this.reporteDeVentasToolStripMenuItem,
            this.reporteDeProductosToolStripMenuItem});
            this.reportesDeInventarioToolStripMenuItem.Name = "reportesDeInventarioToolStripMenuItem";
            this.reportesDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesDeInventarioToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDeClientesToolStripMenuItem1
            // 
            this.reportesDeClientesToolStripMenuItem1.Name = "reportesDeClientesToolStripMenuItem1";
            this.reportesDeClientesToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.reportesDeClientesToolStripMenuItem1.Text = "Reportes de Clientes";
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas";
            // 
            // reporteDeProductosToolStripMenuItem
            // 
            this.reporteDeProductosToolStripMenuItem.Name = "reporteDeProductosToolStripMenuItem";
            this.reporteDeProductosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeProductosToolStripMenuItem.Text = "Reporte de Productos";
            // 
            // toolStripMenuItemUsuario
            // 
            this.toolStripMenuItemUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.rolesToolStripMenuItem});
            this.toolStripMenuItemUsuario.Name = "toolStripMenuItemUsuario";
            this.toolStripMenuItemUsuario.Size = new System.Drawing.Size(127, 20);
            this.toolStripMenuItemUsuario.Text = "Usuarios del Sistema";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // AyudatoolStripMenuItem
            // 
            this.AyudatoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.AyudatoolStripMenuItem.Name = "AyudatoolStripMenuItem";
            this.AyudatoolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.AyudatoolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // cerrarSeccionToolStripMenuItem
            // 
            this.cerrarSeccionToolStripMenuItem.Name = "cerrarSeccionToolStripMenuItem";
            this.cerrarSeccionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.cerrarSeccionToolStripMenuItem.Text = "Cerrar Seccion";
            this.cerrarSeccionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSeccionToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusNombre});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(668, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusNombre
            // 
            this.toolStripStatusNombre.Name = "toolStripStatusNombre";
            this.toolStripStatusNombre.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusNombre.Text = "Nombre";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 394);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUsuario;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AyudatoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSeccionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusNombre;

    }
}