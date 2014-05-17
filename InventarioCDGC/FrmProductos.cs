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
        AlmacenIn almacen = new AlmacenIn();
        public static int tiporol { get; set; }
        bool selectModeRow = false;

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
                        product.idproducto = tbuscarpor.Text;
                        dataGridView1.AutoGenerateColumns = false;

                        dataGridView1.DataSource = product.BuscarxID();
                        
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
                        dataGridView1.DataSource = product.BuscarxNombre(tbuscarpor.Text);
                        
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
        DataGridViewRow row;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            row = dataGridView1.CurrentRow;
            textBoxIDproducto.Text = row.Cells[0].Value.ToString();
            textBoxNombre.Text = row.Cells[1].Value.ToString();
            textBoxPrecio.Text = row.Cells[2].Value.ToString();
            selectModeRow = row.Selected;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Permisos();
            actualizadDatagrid();
        }

        public void Permisos()
        {
            if (tiporol == 1)
            {
                //xButtonBorrar.Enabled = true;
                xButtonModificar.Enabled = true;
            }
            else if (tiporol == 2)
            {
                //xButtonBorrar.Enabled = false;
                xButtonModificar.Enabled = true;
            }
            else if (tiporol == 3)
            {
                //xButtonBorrar.Enabled = false;
                xButtonModificar.Enabled = false;
            }
            else if (tiporol == 4)
            {
                //xButtonBorrar.Enabled = false;
                xButtonModificar.Enabled = false;
                xButtonGuardar.Enabled = false;
            }
            else
            {
                //xButtonBorrar.Enabled = false;
                xButtonModificar.Enabled = false;
                xButtonGuardar.Enabled = false;
            }

        }

        public void CleanText()
        {
            textBoxIDproducto.Clear();
            textBoxNombre.Clear();
            textBoxPrecio.Clear();
             selectModeRow = false;
            actualizadDatagrid();
        }

        public void actualizadDatagrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = almacen.BuscarTodos();
        }

        private void xButtonGuardar_Click(object sender, EventArgs e)
        {
            if (selectModeRow == false)
            {
                if (textBoxIDproducto.Text != "")
                {
                    if (textBoxNombre.Text != "")
                    {
                        if (textBoxPrecio.Text != "")
                        {
                            try
                            {
                                almacen.IDproducto = textBoxIDproducto.Text;
                                almacen.nombreProducto = textBoxNombre.Text;
                                almacen.precio_venta = Convert.ToDecimal(textBoxPrecio.Text);
                                //product.idproducto = 
                               // product.producto = textBoxNombre.Text;
                                //product.precio = Convert.ToDecimal(textBoxPrecio.Text);

                                DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    if (almacen.Guardar())
                                    {
                                        CleanText();
                                        MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ocurrio un error, recuerde el id del producto debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene el campo nombre del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Llene el campo ID del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay un producto seleccionado, Deseleccionelo para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void xButtonModificar_Click(object sender, EventArgs e)
        {
            if (selectModeRow == true)
            {
                if (textBoxIDproducto.Text != "")
                {
                    if (textBoxNombre.Text != "")
                    {
                        if (textBoxPrecio.Text != "")
                        {
                            //dataGridView1.SelectionMode.GetType();
                            try
                            {

                                almacen.IDproducto = textBoxIDproducto.Text;
                                almacen.nombreProducto = textBoxNombre.Text;
                                almacen.precio_venta = Convert.ToDecimal(textBoxPrecio.Text);
                           
                                DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea modificar este producto?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                if (almacen.Modificar())
                                {
                                    CleanText();
                                    MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            

                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ocurrio un error, modifique nuevamente, recuerde el campo precio debe ser numerico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                  
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar un producto para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un producto para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un producto para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero busque un producto y seleccionelo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void xButtonBorrar_Click(object sender, EventArgs e)
        //{
        //    if (selectModeRow == true)
        //    {
        //        // se valida que el id de la fila seleccionada sea igual que la del texbox
        //        DataGridViewRow row = dataGridView1.CurrentRow;
        //        if (row.Cells[0].Value.ToString() == textBoxIDproducto.Text)
        //        {
        //            if (product.Borrar())
        //            {
        //                CleanText();
        //                MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }

        //        else
        //        {
        //            MessageBox.Show("No es posible borrar este producto el id debe ser igual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Primero busque un producto y seleccionelo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //private void xButtonBusquedaAvanzada_Click(object sender, EventArgs e)
        //{
        //    Consultas.BuscarProductosVentas bProductos = new Consultas.BuscarProductosVentas();
        //    bProductos.ShowDialog(this);
        //}

        private void bbuscar_Click_1(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text != "")
            {
                if (tbuscarpor.Text != "")
                {

                    if (comboBoxBuscar.Text == "ID del producto")
                    {
                        try
                        {
                            almacen.IDproducto = tbuscarpor.Text;
                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = almacen.BuscarxID();

                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este Producto no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error, por favor verifique la informacion y intente otra vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBoxBuscar.Text == "Nombre del producto")
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = almacen.BuscarxNombre(tbuscarpor.Text);

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

        private void FrmProductos_Click(object sender, EventArgs e)
        {
            //row = dataGridView1.CurrentRow;
            //row.Selected = false;
            //selectModeRow = false;
            //CleanText();
        }


    }
}
