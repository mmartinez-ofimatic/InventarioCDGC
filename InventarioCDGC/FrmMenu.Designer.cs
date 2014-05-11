﻿namespace InventarioCDGC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
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
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.buttonConsultas = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonAlmacen = new System.Windows.Forms.Button();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonVentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosInventarioToolStripMenuItem,
            this.consultasDeInventarioToolStripMenuItem,
            this.reportesDeInventarioToolStripMenuItem,
            this.toolStripMenuItemUsuario,
            this.AyudatoolStripMenuItem,
            this.cerrarSeccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1184, 28);
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
            this.datosInventarioToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.datosInventarioToolStripMenuItem.Text = "Datos del Inventario";
            // 
            // registroDeClientesToolStripMenuItem
            // 
            this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
            this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.registroDeClientesToolStripMenuItem.Text = "Registro de Clientes";
            this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.registroDeClientesToolStripMenuItem_Click);
            // 
            // registroDeVentasToolStripMenuItem
            // 
            this.registroDeVentasToolStripMenuItem.Name = "registroDeVentasToolStripMenuItem";
            this.registroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.registroDeVentasToolStripMenuItem.Text = "Registro de Ventas";
            this.registroDeVentasToolStripMenuItem.Click += new System.EventHandler(this.registroDeVentasToolStripMenuItem_Click);
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.registroDeProductosToolStripMenuItem.Text = "Registro de Productos";
            this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registroDeProductosToolStripMenuItem_Click);
            // 
            // registroDeAlmacenToolStripMenuItem
            // 
            this.registroDeAlmacenToolStripMenuItem.Name = "registroDeAlmacenToolStripMenuItem";
            this.registroDeAlmacenToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
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
            this.consultasDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.consultasDeInventarioToolStripMenuItem.Text = "Consultas del Inventario";
            // 
            // consultaClientesToolStripMenuItem
            // 
            this.consultaClientesToolStripMenuItem.Name = "consultaClientesToolStripMenuItem";
            this.consultaClientesToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.consultaClientesToolStripMenuItem.Text = "Consulta de Clientes";
            this.consultaClientesToolStripMenuItem.Click += new System.EventHandler(this.consultaClientesToolStripMenuItem_Click);
            // 
            // consultaDeVentasToolStripMenuItem
            // 
            this.consultaDeVentasToolStripMenuItem.Name = "consultaDeVentasToolStripMenuItem";
            this.consultaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.consultaDeVentasToolStripMenuItem.Text = "Consulta de Ventas";
            this.consultaDeVentasToolStripMenuItem.Click += new System.EventHandler(this.consultaDeVentasToolStripMenuItem_Click);
            // 
            // consultaDeProductosToolStripMenuItem
            // 
            this.consultaDeProductosToolStripMenuItem.Name = "consultaDeProductosToolStripMenuItem";
            this.consultaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.consultaDeProductosToolStripMenuItem.Text = "Consulta de Productos";
            this.consultaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeProductosToolStripMenuItem_Click);
            // 
            // consultaDeAlmacenToolStripMenuItem
            // 
            this.consultaDeAlmacenToolStripMenuItem.Name = "consultaDeAlmacenToolStripMenuItem";
            this.consultaDeAlmacenToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
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
            this.reportesDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesDeInventarioToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDeClientesToolStripMenuItem1
            // 
            this.reportesDeClientesToolStripMenuItem1.Name = "reportesDeClientesToolStripMenuItem1";
            this.reportesDeClientesToolStripMenuItem1.Size = new System.Drawing.Size(222, 24);
            this.reportesDeClientesToolStripMenuItem1.Text = "Reportes de Clientes";
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas";
            // 
            // reporteDeProductosToolStripMenuItem
            // 
            this.reporteDeProductosToolStripMenuItem.Name = "reporteDeProductosToolStripMenuItem";
            this.reporteDeProductosToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.reporteDeProductosToolStripMenuItem.Text = "Reporte de Productos";
            // 
            // toolStripMenuItemUsuario
            // 
            this.toolStripMenuItemUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItemUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.rolesToolStripMenuItem});
            this.toolStripMenuItemUsuario.Name = "toolStripMenuItemUsuario";
            this.toolStripMenuItemUsuario.Size = new System.Drawing.Size(158, 24);
            this.toolStripMenuItemUsuario.Text = "Usuarios del Sistema";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // AyudatoolStripMenuItem
            // 
            this.AyudatoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.AyudatoolStripMenuItem.Name = "AyudatoolStripMenuItem";
            this.AyudatoolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.AyudatoolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // cerrarSeccionToolStripMenuItem
            // 
            this.cerrarSeccionToolStripMenuItem.Name = "cerrarSeccionToolStripMenuItem";
            this.cerrarSeccionToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cerrarSeccionToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSeccionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSeccionToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusNombre});
            this.statusStrip1.Location = new System.Drawing.Point(0, 726);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1184, 25);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusNombre
            // 
            this.toolStripStatusNombre.Name = "toolStripStatusNombre";
            this.toolStripStatusNombre.Size = new System.Drawing.Size(64, 20);
            this.toolStripStatusNombre.Text = "Nombre";
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.BackgroundImage = global::InventarioCDGC.Properties.Resources.usuarios2;
            this.buttonUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.Location = new System.Drawing.Point(109, 523);
            this.buttonUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(208, 140);
            this.buttonUsuarios.TabIndex = 36;
            this.buttonUsuarios.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonUsuarios.UseVisualStyleBackColor = true;
            this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // buttonConsultas
            // 
            this.buttonConsultas.BackgroundImage = global::InventarioCDGC.Properties.Resources.Consultas;
            this.buttonConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultas.Location = new System.Drawing.Point(484, 295);
            this.buttonConsultas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConsultas.Name = "buttonConsultas";
            this.buttonConsultas.Size = new System.Drawing.Size(208, 140);
            this.buttonConsultas.TabIndex = 35;
            this.buttonConsultas.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonConsultas.UseVisualStyleBackColor = true;
            this.buttonConsultas.Click += new System.EventHandler(this.buttonConsultas_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.BackgroundImage = global::InventarioCDGC.Properties.Resources.Reportes;
            this.buttonReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportes.Location = new System.Drawing.Point(863, 295);
            this.buttonReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(208, 140);
            this.buttonReportes.TabIndex = 34;
            this.buttonReportes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonReportes.UseVisualStyleBackColor = true;
            // 
            // buttonAlmacen
            // 
            this.buttonAlmacen.BackgroundImage = global::InventarioCDGC.Properties.Resources.Almacen;
            this.buttonAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlmacen.Location = new System.Drawing.Point(109, 295);
            this.buttonAlmacen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAlmacen.Name = "buttonAlmacen";
            this.buttonAlmacen.Size = new System.Drawing.Size(208, 140);
            this.buttonAlmacen.TabIndex = 33;
            this.buttonAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonAlmacen.UseVisualStyleBackColor = true;
            this.buttonAlmacen.Click += new System.EventHandler(this.buttonAlmacen_Click);
            // 
            // buttonProductos
            // 
            this.buttonProductos.BackgroundImage = global::InventarioCDGC.Properties.Resources.Producto;
            this.buttonProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductos.Location = new System.Drawing.Point(484, 84);
            this.buttonProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(208, 140);
            this.buttonProductos.TabIndex = 32;
            this.buttonProductos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonProductos.UseVisualStyleBackColor = true;
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.BackgroundImage = global::InventarioCDGC.Properties.Resources.Client;
            this.buttonClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.Location = new System.Drawing.Point(109, 84);
            this.buttonClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(208, 140);
            this.buttonClientes.TabIndex = 31;
            this.buttonClientes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonVentas
            // 
            this.buttonVentas.BackgroundImage = global::InventarioCDGC.Properties.Resources.Ventas;
            this.buttonVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentas.Location = new System.Drawing.Point(863, 84);
            this.buttonVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(208, 140);
            this.buttonVentas.TabIndex = 30;
            this.buttonVentas.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonVentas.UseVisualStyleBackColor = true;
            this.buttonVentas.Click += new System.EventHandler(this.buttonVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Almacén";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Consultas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Productos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(919, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ventas";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(909, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 29);
            this.label7.TabIndex = 43;
            this.label7.Text = "Reportes";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(153, 667);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 29);
            this.label8.TabIndex = 44;
            this.label8.Text = "Usuarios";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventarioCDGC.Properties.Resources.prueba2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 751);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUsuarios);
            this.Controls.Add(this.buttonConsultas);
            this.Controls.Add(this.buttonReportes);
            this.Controls.Add(this.buttonAlmacen);
            this.Controls.Add(this.buttonProductos);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonVentas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
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
        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.Button buttonAlmacen;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonConsultas;
        private System.Windows.Forms.Button buttonUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

    }
}