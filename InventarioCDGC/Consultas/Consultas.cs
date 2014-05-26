using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventarioCDGC.Consultas
{
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            BuscarClienteVentas clientes = new BuscarClienteVentas();
            clientes.ShowDialog(this);
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            BuscadordeVentas ventas = new BuscadordeVentas();
            ventas.ShowDialog(this);
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            BuscarAlmacen productos = new BuscarAlmacen();
            productos.ShowDialog(this);
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {

        }
    }
}
