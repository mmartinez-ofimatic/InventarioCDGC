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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        VentasInv ventasClass = new VentasInv();
        DataGridViewRow rowCurrent;
        bool selectModeRow = false;
        int idusuario;

        private void bbuscarcliente_Click(object sender, EventArgs e)
        {
            Consultas.BuscarClienteVentas buscarCliente = new Consultas.BuscarClienteVentas();
            buscarCliente.ShowDialog(this);
            textBoxCliente.Text = buscarCliente.Cliente;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ventasClass.BuscarTodos();
        }

        private void bbuscarproducto_Click(object sender, EventArgs e)
        {
            Consultas.BuscarProductosVentas buscarProducto = new Consultas.BuscarProductosVentas();
            buscarProducto.ShowDialog(this);
            textBoxProducto.Text = buscarProducto.Producto;
        }

        private void guardartoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Clientescdgc clientes = new Clientescdgc();

            if (textBoxCliente.Text != "")
            {
                if (textBoxProducto.Text != "")
                {
                    if (textBoxPrecio.Text != "")
                    {
                        if (textBoxCantidad.Text != "")
                        {
                                ventasClass.idcliente = Convert.ToInt32(textBoxCliente.Text);
                                ventasClass.idproducto = Convert.ToInt32(textBoxProducto.Text);
                                ventasClass.precio = Convert.ToDecimal(textBoxPrecio.Text);
                                ventasClass.cantidad = Convert.ToInt32(textBoxCantidad.Text);
                                ventasClass.descuento = Convert.ToDecimal(textBoxDescuento.Text);
                                ventasClass.observacion = textBoxObservacion.Text;
                                //Falta el id de usuario para saber que usuario hiso la venta
                                //ventasClass.idusuario = el id del usuario loguiado.

                                if (ventasClass.Guardar())
                                {
                                    MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanText();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Llene el campo Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

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

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (selectModeRow == true)
            {
                if (textBoxCliente.Text != "")
                {
                    if (textBoxProducto.Text != "")
                    {
                        if (textBoxPrecio.Text != "")
                        {
                            if (textBoxCantidad.Text != "")
                            {
                                    rowCurrent = dataGridView1.CurrentRow;
                                    ventasClass.idventa = Convert.ToInt32(rowCurrent.Cells[0].Value.ToString());
                                    ventasClass.idcliente = Convert.ToInt32(textBoxCliente.Text);
                                    ventasClass.idproducto = Convert.ToInt32(textBoxProducto.Text);
                                    ventasClass.precio = Convert.ToDecimal(textBoxPrecio.Text);
                                    ventasClass.cantidad = Convert.ToInt32(textBoxCantidad.Text);
                                    ventasClass.descuento = Convert.ToDecimal(textBoxDescuento.Text);
                                    ventasClass.observacion = textBoxObservacion.Text;
                                    //Falta el id de usuario para saber que usuario hiso la venta
                                    //ventasClass.idusuario = el id del usuario loguiado.

                                    if (ventasClass.Modificar())
                                    {
                                        MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        CleanText();
                                    }
                            }
                            else
                            {
                                MessageBox.Show("Llene el campo Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe buscar una venta y luego seleccionarla para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
          //textBoxIDVenta.Text = row.Cells[0].Value.ToString();
            textBoxCliente.Text = row.Cells[1].Value.ToString();
            textBoxProducto.Text = row.Cells[2].Value.ToString();
            //Pasar el id de usuario
            //idusuario = Convert.ToInt32 (row.Cells[3].Value.ToString());
            textBoxPrecio.Text = row.Cells[4].Value.ToString();
            textBoxCantidad.Text = row.Cells[5].Value.ToString();
            textBoxDescuento.Text = row.Cells[6].Value.ToString();
            textBoxObservacion.Text = row.Cells[8].Value.ToString();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            selectModeRow = dataGridView1.Rows[e.RowIndex].Selected;
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                if ( row.Selected == true)
                {          
               
                if (row.Cells[0].Value.ToString() != "" )
                {
                    ventasClass.idventa = Convert.ToInt32(row.Cells[0].Value.ToString());

                    if (ventasClass.Borrar())
                    {
                        MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CleanText();
                    }
                }

                else
                {
                    MessageBox.Show("Seleccion un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero busque un producto y seleccionelo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void CleanText()
        {
            selectModeRow = false;
            textBoxCliente.Clear();
            textBoxProducto.Clear();
            textBoxPrecio.Clear();
            textBoxCantidad.Clear();
            textBoxDescuento.Clear();
            textBoxObservacion.Clear();
        }

    }
}
