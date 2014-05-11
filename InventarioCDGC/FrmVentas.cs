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

        public static int tiporol { get; set; }
        VentasInv ventasClass = new VentasInv();
        DataGridViewRow rowCurrent;
        bool selectModeRow = false;
        int idusuario;

        Consultas.BuscarProductosVentas buscarProducto = new Consultas.BuscarProductosVentas();
        AgregarVentas productVentasList = new AgregarVentas();
        List<AgregarVentas> lista = new List<AgregarVentas>();
        AgregarVentas v = new AgregarVentas();
        Dictionary<int, string> clienteKeyValue;
        Dictionary<int, string> productoKeyValue;

        private void bbuscarcliente_Click(object sender, EventArgs e)
        {
            Consultas.BuscarClienteVentas buscarCliente = new Consultas.BuscarClienteVentas();
            buscarCliente.ShowDialog(this);
            //textBoxCliente.Text = buscarCliente.idCliente.ToString();
            clienteKeyValue = new Dictionary<int, string>();
            clienteKeyValue.Add(buscarCliente.idCliente, buscarCliente.Cliente);
            textBoxCliente.Text = clienteKeyValue[buscarCliente.idCliente];
            //textBoxCliente.Text = keyvalue.Keys.ToString();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            Permisos();
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ventasClass.BuscarTodos();
        }

        public void Permisos()
        {
            if (tiporol == 1)
            {
                xButtonBorrar.Enabled = true;
                xButtonModificar.Enabled = true;
            }
            else if (tiporol == 2)
            {
                xButtonBorrar.Enabled = false;
                xButtonModificar.Enabled = true;
            }
            else if (tiporol == 3)
            {
                xButtonBorrar.Enabled = false;
                xButtonModificar.Enabled = false;
            }
            else if (tiporol == 4)
            {
                xButtonBorrar.Enabled = false;
                xButtonModificar.Enabled = false;
                xButtonGuardar.Enabled = false;
            }
            else
            {
                xButtonBorrar.Enabled = false;
                xButtonModificar.Enabled = false;
                xButtonGuardar.Enabled = false;
            }

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
                            try
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

                                else
                                {
                                    MessageBox.Show("Llene el campo Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }


                            }
                            catch (Exception)
                            {

                                textBoxPrecio.Clear();
                                MessageBox.Show("El campo precio debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                            //dataGridView1.DataSource = ventasClass.BuscarxIDProducto(Convert.ToInt32(tbuscarpor.Text));

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
        DataGridViewRow row;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            //textBoxIDVenta.Text = row.Cells[0].Value.ToString();
            textBoxCliente.Text = row.Cells[1].Value.ToString();
            textBoxProducto.Text = row.Cells[2].Value.ToString();
            //Pasar el id de usuario
            //idusuario = Convert.ToInt32 (row.Cells[3].Value.ToString());
            textBoxPrecio.Text = row.Cells[4].Value.ToString();
            textBoxCantidad.Text = row.Cells[5].Value.ToString();
            textBoxDescuento.Text = row.Cells[6].Value.ToString();
            textBoxObservacion1.Text = row.Cells[8].Value.ToString();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            selectModeRow = row.Selected;
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                if (row.Selected == true)
                {

                    if (row.Cells[0].Value.ToString() != "")
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
            textBoxCantidad.Value = 1;
            textBoxDescuento.Value = 0;
            textBoxObservacion1.Clear();
        }

        private void busquedaAvanzadaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.BuscarVentas ventas = new Consultas.BuscarVentas();
            ventas.ShowDialog(this);
        }

        private void xButtonGuardar_Click(object sender, EventArgs e)
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
                            try
                            {

                                ventasClass.idcliente = Convert.ToInt32(clienteKeyValue.Keys.ToString());//textBoxCliente.Text);
                                ventasClass.idproducto = Convert.ToInt32(textBoxProducto.Text);
                                ventasClass.precio = Convert.ToDecimal(textBoxPrecio.Text);
                                ventasClass.cantidad = Convert.ToInt32(textBoxCantidad.Text);
                                ventasClass.descuento = Convert.ToDecimal(textBoxDescuento.Text);
                                ventasClass.observacion = textBoxObservacion1.Text;
                                //Falta el id de usuario para saber que usuario hiso la venta
                                //ventasClass.idusuario = el id del usuario loguiado.

                                if (ventasClass.Guardar())
                                {
                                    MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanText();
                                    ActualizarGrid();
                                }

                                else
                                {
                                    MessageBox.Show("Llene el campo Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }


                            }
                            catch (Exception)
                            {

                                textBoxPrecio.Clear();
                                MessageBox.Show("El campo precio debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void xButtonModificar_Click(object sender, EventArgs e)
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
                                ventasClass.observacion = textBoxObservacion1.Text;
                                //Falta el id de usuario para saber que usuario hiso la venta
                                //ventasClass.idusuario = el id del usuario loguiado.

                                if (ventasClass.Modificar())
                                {
                                    MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanText();
                                    ActualizarGrid();
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

        private void xButtonBorrar_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                if (row.Selected == true)
                {

                    if (row.Cells[0].Value.ToString() != "")
                    {
                        ventasClass.idventa = Convert.ToInt32(row.Cells[0].Value.ToString());

                        if (ventasClass.Borrar())
                        {
                            MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CleanText();
                            ActualizarGrid();
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

        private void xButtonBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            Consultas.BuscarVentas ventas = new Consultas.BuscarVentas();
            ventas.ShowDialog(this);
        }

        private void xButton1_Click(object sender, EventArgs e)
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

                          //  dataGridView1.DataSource = ventasClass.BuscarxIDProducto(Convert.ToInt32(tbuscarpor.Text));

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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = true;
            dataGridView1_RowHeaderMouseClick(sender, null);
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            CustomGroupBoxProperties.DrawGroupBox(box, e.Graphics, System.Drawing.ColorTranslator.FromHtml("#25BB04"));
        }

        private void FrmVentas_Click(object sender, EventArgs e)
        {
        }


        private void xButtonAgregar_Click(object sender, EventArgs e)
        {

            if (textBoxProducto.Text != "")
            {
                if (textBoxPrecio.Text != "")
                {
                    if (textBoxCantidad.Value.ToString() != "")
                    {
                        if (textBoxDescuento.Value.ToString() != "")
                        {
                            
                            ////if (!productVentasList.ExistProductList(productoKeyValue/*.Select(x=>x.Key).Single()*/))
                            ////{
                                dataGridViewVentas.DataSource = null;

                                var listaNueva = productVentasList.addList(productoKeyValue, decimal.Parse(textBoxPrecio.Text),
                                                  int.Parse(textBoxCantidad.Value.ToString()), double.Parse(textBoxDescuento.Value.ToString()));

                                var filtro = (from c in listaNueva
                                              select new
                                              {
                                                  idProducto = c.Producto.Select(x => x.Key).Single(),
                                                  Producto = c.Producto.Select(x => x.Value).Single(),
                                                  c.Precio,
                                                  c.Cantidad,
                                                  c.Descuento,
                                                  c.PrecioNeto
                                              }).ToList();

                                dataGridViewVentas.DataSource = filtro;

                                CleanProductos();
                            }
                            else
                            {
                                MessageBox.Show("Este producto ya esta agregado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //}
            //else
            //{
            //    MessageBox.Show("Elija el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dataGridViewVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowProducto = dataGridViewVentas.CurrentRow;
            rowProducto.Selected = false;

            xButtonAgregar.Enabled = true;
            xButtonBorrar.Enabled = false;
            xButtonModificar.Enabled = false;
            CleanProductos();
        }
        DataGridViewRow rowProducto;
        int index;
        // bool SelectModeProduct = false;
        private void xButtonBorrarProductos_Click(object sender, EventArgs e)
        {
            if (rowProducto.Selected == true)
            {
                // lista.RemoveAt(index);

                dataGridViewVentas.DataSource = null;
                dataGridViewVentas.DataSource = productVentasList.RemoveList(index);
                //SelectModeProduct = false;
                rowProducto.Selected = false;

                xButtonAgregar.Enabled = true;
                xButtonBorrarProductos.Enabled = false;
                xButtonModificarProductos.Enabled = false;
                CleanProductos();
            }
        }

        private void dataGridViewVentas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowProducto = dataGridViewVentas.CurrentRow;
            index = rowProducto.Index;
            xButtonAgregar.Enabled = false;
            xButtonBorrarProductos.Enabled = true;
            xButtonModificarProductos.Enabled = true;
            //SelectModeProduct = rowProducto.Selected;
            
            textBoxProducto.Text = rowProducto.Cells[0].Value.ToString();
            textBoxPrecio.Text = rowProducto.Cells[1].Value.ToString();
            textBoxCantidad.Text = rowProducto.Cells[2].Value.ToString();
            textBoxDescuento.Text = rowProducto.Cells[3].Value.ToString();

        }

        public void CleanProductos()
        {
            //textBoxCliente.Clear();
            textBoxProducto.Clear();
            textBoxPrecio.Clear();
            textBoxCantidad.Value = 1;
            textBoxDescuento.Value = 0;
            //textBoxObservacion.Clear();
        }

        private void xButtonModificarProductos_Click(object sender, EventArgs e)
        {
            if (textBoxProducto.Text != "")
            {
                if (textBoxPrecio.Text != "")
                {
                    if (textBoxCantidad.Value.ToString() != "")
                    {
                        if (textBoxDescuento.Value.ToString() != "")
                        {
                            dataGridViewVentas.DataSource = null;
                            var listaUpdate = productVentasList.UpdateList(/*int.Parse(textBoxProducto.Text)*/productoKeyValue, decimal.Parse(textBoxPrecio.Text),
                                                              int.Parse(textBoxCantidad.Value.ToString()), double.Parse(textBoxDescuento.Value.ToString()));

                            var filtro = (from c in listaUpdate
                                          select new
                                          {
                                              Producto = c.Producto.Select(x => x.Value).Single(),
                                              c.Precio,
                                              c.Cantidad,
                                              c.Descuento,
                                              c.PrecioNeto
                                          }).ToList();

                            dataGridViewVentas.DataSource = filtro;

                            CleanProductos();



                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Elija el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            CleanText();
        }

        private void xButtonNuevaVenta_Click(object sender, EventArgs e)
        {
            textBoxPrecio.ReadOnly = false;
            textBoxCantidad.ReadOnly = false;
            textBoxDescuento.ReadOnly = false;
            textBoxObservacion1.ReadOnly = false;
            bbuscarcliente.Enabled = true;
            bbuscarproducto.Enabled = true;
            xButtonAgregar.Enabled = true;
            xButtonGuardar.Enabled = true;
            dataGridViewVentas.DataSource = null;
            // productoKeyValue.Clear();
            //productVentasList.EraserList();
            lista.Clear();
            CleanProductos();
            CleanText();

        }

        private void bbuscarproducto_Click_1(object sender, EventArgs e)
        {

            buscarProducto.ShowDialog(this);
            productoKeyValue = new Dictionary<int, string>();
            productoKeyValue.Add(buscarProducto.idProducto, buscarProducto.Productoo);
            textBoxProducto.Text = productoKeyValue[buscarProducto.idProducto];
            //textBoxProducto.Text = buscarProducto.Producto;
        }

        private void dataGridViewVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            CustomGroupBoxProperties.DrawGroupBox(box, e.Graphics, System.Drawing.ColorTranslator.FromHtml("#25BB04"));

        }

        private void dataGridViewVentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowProducto = dataGridViewVentas.CurrentRow;
            rowProducto.Selected = false;

            xButtonAgregar.Enabled = true;
            xButtonBorrar.Enabled = false;
            xButtonModificar.Enabled = false;
            CleanProductos();
        }

        private void dataGridViewVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowProducto = dataGridViewVentas.CurrentRow;
            rowProducto.Selected = false;

            xButtonAgregar.Enabled = true;
            xButtonBorrar.Enabled = false;
            xButtonModificar.Enabled = false;
            CleanProductos();
        }


    }
}
