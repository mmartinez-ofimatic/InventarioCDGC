using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataInventarioCDGC;

namespace InventarioCDGC
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        ProductosInv product = new ProductosInv();

        private void guardartoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            product.idproducto = Convert.ToInt32(textBoxIDproducto.Text); 
            product.producto = textBoxNombre.Text;
            product.precio = Convert.ToDouble(textBoxPrecio.Text);
            if (product.Guardar())
            {
                MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
