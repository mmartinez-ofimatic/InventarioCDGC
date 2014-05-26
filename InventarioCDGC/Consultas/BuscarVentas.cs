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
    public partial class BuscarVentasDetalles : Form
    {
        public BuscarVentasDetalles()
        {
            InitializeComponent();
        }

        VentasInv ventasClass = new VentasInv();

        public static int idVentaDetalles { get; set; }

        private void BuscarVentas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ventasClass.BuscarDetallesVentas(idVentaDetalles);        
        }

        private void xBuscar_Click(object sender, EventArgs e)
        {
            //try{
            //    /*ID de Venta
            //        Nombre del Cliente
            //        Nombre del Producto
            //        Ultimas Ventas*/
            //if (comboBoxBuscar.Text != "")
            //{
            //    if (tbuscarpor.Text != "")
            //    {
            //        if (comboBoxBuscar.Text == "ID de Venta")
            //        {
            //            Validaciones v = new Validaciones();
            //            if (v.ValidateNumeric(tbuscarpor.Text))
            //            {
                           
            //                dataGridView1.AutoGenerateColumns = false;

            //                dataGridView1.DataSource = ventasClass.BuscarxID(Convert.ToInt32 (tbuscarpor.Text));
            //                //dataGridView1.DataSource = ventasClass.BuscarxIDProducto(tbuscarpor.Text);

            //                if (dataGridView1.RowCount == 0)
            //                {
            //                    MessageBox.Show("Esta Venta no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }

            //            }
            //            else
            //            {
            //                MessageBox.Show("El ID de la Venta debe ser numerico!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //            }
            //        }
            //        else if (comboBoxBuscar.Text == "Nombre del Cliente")
            //        {
            //            try
            //            {
            //                //ventasClass.idventa = Convert.ToInt32(tbuscarpor.Text);
            //                dataGridView1.AutoGenerateColumns = false;
            //                dataGridView1.DataSource = ventasClass.BuscarxNombreCliente(tbuscarpor.Text);

            //                if (dataGridView1.RowCount == 0)
            //                {
            //                    MessageBox.Show("Este nombre no existe en las ventas realizadas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }

            //            }
            //            catch (Exception)
            //            {
            //                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //        else if (comboBoxBuscar.Text == "Nombre del Producto")
            //        {
            //            try
            //            {
            //                dataGridView1.AutoGenerateColumns = false;

            //                dataGridView1.DataSource = ventasClass.BuscarxNombreProducto(tbuscarpor.Text);

            //                if (dataGridView1.RowCount == 0)
            //                {
            //                    MessageBox.Show("Este producto no tiene ventas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }

            //            }
            //            catch (Exception)
            //            {
            //                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //            }
            //        }

            //    }
            //    else
            //    {
            //        MessageBox.Show("LLene el campo de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Elija la opcion de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //  }
            //catch (Exception) {
            //    MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxBuscar.Text == "Ultimas Ventas")
            //{
            //    dataGridView1.AutoGenerateColumns = false;
            //    dataGridView1.DataSource = ventasClass.BuscarUltimasVentas();
            //}
        }

    }

}
