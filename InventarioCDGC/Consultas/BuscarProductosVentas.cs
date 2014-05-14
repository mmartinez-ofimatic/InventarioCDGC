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
    public partial class BuscarProductosVentas : Form
    {
        public BuscarProductosVentas()
        {
            InitializeComponent();
        }

        ProductosInv productosClass = new ProductosInv();
        public int idProducto { get; set; }
        public string Productoo { get; set; }
        public decimal precio { get; set; }

        private void BuscarProductosVentas_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
           dataGridView1.DataSource = productosClass.BuscarTodos();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            this.idProducto = Convert.ToInt32(row.Cells[0].Value.ToString());
            Productoo = row.Cells[1].Value.ToString();
            precio = Convert.ToDecimal(row.Cells[2].Value.ToString());
            this.Close(); 
        }


        private void xBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text != "")
            {
                if (tbuscarpor.Text != "")
                {

                    if (comboBoxBuscar.Text == "ID del producto")
                    {
                        try
                        {
                            productosClass.idproducto = tbuscarpor.Text;
                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = productosClass.BuscarxID();

                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este Producto no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El ID debe ser numerico!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBoxBuscar.Text == "Nombre del producto")
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = productosClass.BuscarxNombre(tbuscarpor.Text);

                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Producto no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("LLene el campo de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Elija la opcion de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
