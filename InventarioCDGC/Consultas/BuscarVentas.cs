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
    public partial class BuscarVentas : Form
    {
        public BuscarVentas()
        {
            InitializeComponent();
        }

        VentasInv ventasClass = new VentasInv();

        private void bbuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text != "")
            {
                if (tbuscarpor.Text != "")
                {
                    if (comboBoxBuscar.Text == "ID del producto")
                    {
                        try
                        {
                            //ventasClass.idproducto = Convert.ToInt32(tbuscarpor.Text);

                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = ventasClass.BuscarxIDProducto(Convert.ToInt32(tbuscarpor.Text));

                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este Producto no tiene venta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El ID del producto debe ser numerico!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else if (comboBoxBuscar.Text == "ID de Venta")
                    {
                        try
                        {
                            ventasClass.idventa = Convert.ToInt32(tbuscarpor.Text);
                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = ventasClass.BuscarxID();

                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Esta venta no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El ID de la venta debe ser numerico!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else if (comboBoxBuscar.Text == "ID del Cliente")
                    {
                        try
                        {
                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = ventasClass.BuscarxIDCliente(Convert.ToInt32(tbuscarpor.Text));

                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este cliente no tiene venta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El ID del cliente debe ser numerico!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void BuscarVentas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ventasClass.BuscarTodos();
        }
    }
}
