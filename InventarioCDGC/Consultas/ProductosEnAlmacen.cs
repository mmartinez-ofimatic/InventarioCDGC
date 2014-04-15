using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataInventarioCDGC;

namespace InventarioCDGC.Consultas
{
    public partial class ProductosEnAlmacen : Form
    {
        public ProductosEnAlmacen()
        {
            InitializeComponent();
        }

        AlmacenIn almacen = new AlmacenIn();

        private void ProductosEnAlmacen_Load(object sender, EventArgs e)
        {
          //dataGridView1.DataSource = almacen.BuscarTodosConProductos();
        }
    }
}
