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

        private void FrmMenu_Load(object sender, EventArgs e)
        {

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
            Consultas.BuscarVentas ventas = new Consultas.BuscarVentas();
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

            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }


    }
}
