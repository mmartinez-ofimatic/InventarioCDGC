using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventarioCDGC
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public static int tiporol { get; set; }
        public static string nameUser { get; set; }
        Consultas.ProductosEnAlmacen pa = new Consultas.ProductosEnAlmacen();

        private void FrmMenu_Load(object sender, EventArgs e)
        {       
            Permisos();
            
            pa.Show();
            pa.SetDesktopLocation(this.Location.X + this.Size.Width, this.Location.Y);
            
            
        }



        public void Permisos()
        {   
            if (tiporol == 1)
            {
                toolStripMenuItemUsuario.Visible = true;
                toolStripStatusNombre.Text = nameUser;
            }
            else if (tiporol == 2)
            {
                toolStripMenuItemUsuario.Visible = false;
                toolStripStatusNombre.Text = nameUser;
            }
            else if (tiporol == 3)
            {
                toolStripMenuItemUsuario.Visible = false;
                toolStripStatusNombre.Text = nameUser;
            }
            else if (tiporol == 4)
            {
                toolStripMenuItemUsuario.Visible = false;
                toolStripStatusNombre.Text = nameUser;
            }
            else
            {
                toolStripMenuItemUsuario.Visible = false;
                MessageBox.Show("Usted no tiene permiso para acceder al sistema!", "Usuario sin permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes cliente = new FrmClientes();
            //cliente.MdiParent = this;
            cliente.ShowDialog(this);
        }

        private void registroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas ventas = new FrmVentas();
          //  ventas.MdiParent = this;
            ventas.ShowDialog(this);
        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos productos = new FrmProductos();
           // productos.MdiParent = this;
            productos.ShowDialog(this);
        }

        private void registroDeAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlmacen almacen = new FrmAlmacen();
           // almacen.MdiParent = this;
            almacen.ShowDialog(this);
        }

        private void consultaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.BuscarClienteVentas buscarClientes = new Consultas.BuscarClienteVentas();
           // buscarClientes.MdiParent = this;
            buscarClientes.ShowDialog(this);
        }

        private void consultaDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.BuscadordeVentas ventas = new Consultas.BuscadordeVentas();
            
           // Consultas.BuscarVentasDetalles ventas = new Consultas.BuscarVentasDetalles();
            ventas.ShowDialog(this);
        }

        private void consultaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.BuscarProductosVentas buscarProducts = new Consultas.BuscarProductosVentas();
           // buscarProducts.MdiParent = this;
            buscarProducts.ShowDialog(this);
        }

        private void consultaDeAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.BuscarAlmacen almacen = new Consultas.BuscarAlmacen();
            almacen.ShowDialog(this);
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.ShowDialog(this);
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRol roles = new FrmRol();
            roles.ShowDialog(this);
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Consultas.ProductosEnAlmacen pa = new Consultas.ProductosEnAlmacen();

            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                pa.Hide();
                FrmLogin login = new FrmLogin();
                login.Show();
            }
            
            
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            FrmClientes cliente = new FrmClientes();
            //cliente.MdiParent = this;
            cliente.ShowDialog(this);
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            FrmProductos productos = new FrmProductos();
            // productos.MdiParent = this;
            productos.ShowDialog(this);
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            FrmVentas ventas = new FrmVentas();
            //  ventas.MdiParent = this;
            ventas.ShowDialog(this);
        }

        private void buttonAlmacen_Click(object sender, EventArgs e)
        {
            FrmAlmacen almacen = new FrmAlmacen();
            // almacen.MdiParent = this;
            almacen.ShowDialog(this);
        }



        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.ShowDialog(this);
        }





        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea cerrar la aplicación", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
            
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenu_Move(object sender, EventArgs e)
        {

            //pa.BringToFront();
            pa.SetDesktopLocation(this.Location.X + this.Size.Width, this.Location.Y);
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            //Reportes.ReporteVentas1 reporteventas = new Reportes.ReporteVentas1();
            //reporteventas.Show();
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            Consultas.FrmConsultas consultas = new Consultas.FrmConsultas();
            consultas.ShowDialog(this);
        }

        private void reportesDeClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.ReporteClientes rclientes = new Reportes.ReporteClientes();
            rclientes.ShowDialog(this);
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteProductos rproductos = new Reportes.ReporteProductos();
            rproductos.ShowDialog(this);
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteVentasFecha rventas = new Reportes.ReporteVentasFecha();
            rventas.ShowDialog(this);
        }


    }
}
