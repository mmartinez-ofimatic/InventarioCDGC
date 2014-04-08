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
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void registroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas ventas = new FrmVentas();
            ventas.MdiParent = this;
            ventas.Show();
        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos productos = new FrmProductos();
            productos.MdiParent = this;
            productos.Show();
        }

        private void registroDeAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlmacen almacen = new FrmAlmacen();
            almacen.MdiParent = this;
            almacen.Show();
        }

        private void consultaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.BuscarClienteVentas buscarClientes = new Consultas.BuscarClienteVentas();
            buscarClientes.MdiParent = this;
            buscarClientes.Show();
        }

        private void consultaDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void consultaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.BuscarProductosVentas buscarProducts = new Consultas.BuscarProductosVentas();
            buscarProducts.MdiParent = this;
            buscarProducts.Show();
        }


    }
}
