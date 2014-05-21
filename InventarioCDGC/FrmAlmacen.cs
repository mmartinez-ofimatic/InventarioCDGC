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
    public partial class FrmAlmacen : Form
    {
        public FrmAlmacen()
        {
            InitializeComponent();
        }

        public static int tiporol { get; set; }
        AlmacenIn almacen = new AlmacenIn();
       // Dictionary<int, string> productoKeyValue;

        Consultas.BuscarProductosVentas buscarProducto = new Consultas.BuscarProductosVentas();
   
        bool selectModeRow = false;
        private void FrmAlmacen_Load(object sender, EventArgs e)
        {
            Permisos();
            //comboBoxID.DataSource = almacen.BuscarIDProducto();
           // dataGridView1.DataSource = almacen.BuscarTodos();
        }


        public void Permisos()
        {
            if (tiporol == 1)
            {
               // xButtonBorrar.Enabled = true;
                xButtonAgregarExitAlmacen.Enabled = true;
            }
            else if (tiporol == 2)
            {
              //  xButtonBorrar.Enabled = false;
                xButtonAgregarExitAlmacen.Enabled = true;
            }
            else if (tiporol == 3)
            {
                //xButtonBorrar.Enabled = false;
                xButtonAgregarExitAlmacen.Enabled = true;
            }
            else if (tiporol == 4)
            {
                //xButtonBorrar.Enabled = false;
                xButtonAgregarExitAlmacen.Enabled = false;
                xButtonAgregarExitAlmacen.Enabled = false;
            }
            else
            {
                //xButtonBorrar.Enabled = false;
                xButtonAgregarExitAlmacen.Enabled = false;
                xButtonAgregarExitAlmacen.Enabled = false;
            }

        }


        /*private void bbuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text != "")
            {
                if (tbuscarpor.Text != "")
                {

                    if (comboBoxBuscar.Text == "ID del producto")
                    {
                        try
                        {                
                        almacen.IDproducto =tbuscarpor.Text;
                       
                        dataGridView1.AutoGenerateColumns = false;

                        dataGridView1.DataSource = almacen.BuscarxID();

                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Producto no existe en el almacen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El ID del producto debe ser numerico!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           
                        }
                    }
                    else if (comboBoxBuscar.Text == "Nombre del producto")
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = almacen.BuscarxNombre(tbuscarpor.Text);

                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Producto no existe en el almacen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
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
        }*/
        /*DataGridViewRow row;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            textBoxIDProducto.Text = row.Cells[0].Value.ToString();
            //textBoxNombre.Text = row.Cells[1].Value.ToString();
            textBoxExistencia.Text = row.Cells[1].Value.ToString();
            textBoxNombre.Text = row.Cells[2].Value.ToString();

           dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
           selectModeRow = row.Selected;
           xButtonAgregarExitAlmacen.Enabled = false;
        }
        */
        public void CleanText()
        {
           // comboBoxID.SelectedIndex = 0;
            selectModeRow = false;
            textBoxNombre.Clear();
            textBoxIDProducto.Clear();
            textBoxExistencia.Value = 1;
           // comboBoxID.DataSource = almacen.BuscarIDProducto();
          //  dataGridView1.DataSource = almacen.BuscarTodos();
        }

      /*  private void xButtonBuscar_Click(object sender, EventArgs e)
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
                                MessageBox.Show("Este Producto no existe en el almacen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El ID del producto debe ser numerico!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else if (comboBoxBuscar.Text == "Nombre del producto")
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = almacen.BuscarxNombre(tbuscarpor.Text);

                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Producto no existe en el almacen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        }*/

        private void xButtonGuardar_Click(object sender, EventArgs e)
        {
            if (selectModeRow == false)
            {
                if (textBoxIDProducto.Text != "")
                {
                    if (textBoxNombre.Text != "")
                    {
                        if (textBoxExistencia.Text != "")
                        {

                            almacen.IDproducto = textBoxIDProducto.Text;
                            almacen.existencia = Convert.ToInt32(textBoxExistencia.Text);

                            try
                            {
                                DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    if (almacen.Guardar())
                                    {
                                        MessageBox.Show("Se agrego "+ textBoxExistencia.Text + " productos con exito en su existencia!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        CleanText();
                                        //textBoxIDProducto.SelectedIndex = 0;
                                    }
                                }
                                
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Este producto existe, solo modifique su existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                CleanText();
                                //comboBoxID.SelectedIndex = 0;

                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Elija un ID de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Elija un ID de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay un producto seleccionado, Deseleccionelo para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void xButtonModificar_Click(object sender, EventArgs e)
        {
            //if (selectModeRow == true)
            //{
            try
            {
                if (textBoxIDProducto.Text != "")
                {
                    if (textBoxNombre.Text != "")
                    {
                        if (textBoxExistencia.Text != "")
                        {
                            almacen.IDproducto = textBoxIDProducto.Text;
                            almacen.existencia = Convert.ToInt32(textBoxExistencia.Text);
                            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea sacar: " + textBoxExistencia.Text + " productos de la existencia?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                if (almacen.SacarExistenciadeProducto(textBoxIDProducto.Text))
                                {
                                    MessageBox.Show("Existencia eliminada!", "Existencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanText();
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Debe llenar el campo existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un producto para modificar su existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un producto para modificar su existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception) {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                //}
                //else
                //{
                //    MessageBox.Show("Primero busque un producto y seleccionelo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
           
        
        }

        //private void xButtonBorrar_Click(object sender, EventArgs e)
        //{
        //    if (selectModeRow == true)
        //    {
        //        // se valida que el id de la fila seleccionada sea igual que la del textbox
        //        DataGridViewRow row = dataGridView1.CurrentRow;
        //        if (row.Cells[0].Value.ToString() == comboBoxID.Text)
        //        {
        //            if (almacen.Borrar())
        //            {
        //                MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                CleanText();
        //            }
        //        }

        //        else
        //        {
        //            MessageBox.Show("Busque un producto y luego seleccionelo para eliminar del almacen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Primero busque un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //private void xButtonBusquedaAvanzada_Click(object sender, EventArgs e)
        //{
        //    Consultas.BuscarAlmacen almacen = new Consultas.BuscarAlmacen();
        //    almacen.ShowDialog(this);
        
        //}

       /* private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            xButtonAgregarExitAlmacen.Enabled = true;
            CleanText();
            //row = dataGridView1.CurrentRow;
            //row.Selected = true;
            //dataGridView1_RowHeaderMouseClick(sender, null);
        }*/

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            CustomGroupBoxProperties.DrawGroupBox(box, e.Graphics, System.Drawing.ColorTranslator.FromHtml("#25BB04"));            
        }

        private void FrmAlmacen_Click(object sender, EventArgs e)
        {
            //row = dataGridView1.CurrentRow;
           // row.Selected = false;
           // selectModeRow = false;
            CleanText();
        }

        private void bbuscarproducto_Click(object sender, EventArgs e)
        {
            buscarProducto.idProducto = null;
            buscarProducto.Productoo = null;
            buscarProducto.ShowDialog(this);
           // productoKeyValue = new Dictionary<string, string>();
           // productoKeyValue.Add(buscarProducto.idProducto, buscarProducto.Productoo);
            textBoxIDProducto.Text = buscarProducto.idProducto;
            textBoxNombre.Text = buscarProducto.Productoo;
        }

        private void xButtonAgregarExitAlmacen_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxNombre.Text != "")
                {
                    if (textBoxExistencia.Text != "")
                    {
                        //almacen.IDproducto = comboBoxID.Text;
                        //almacen.existencia = Convert.ToInt32(textBoxExistencia.Text);

                        almacen.IDproducto = textBoxIDProducto.Text;
                        almacen.existencia = Convert.ToInt32(textBoxExistencia.Text);


                        try
                        {
                            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea agregar " + textBoxExistencia.Text + " existencia mas a este producto?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                if (almacen.AgregarExistenciadeProducto(textBoxIDProducto.Text))
                                {
                                    MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanText();
                                    //comboBoxID.SelectedIndex = 0;
                                }
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ocurrio un error, Intentelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CleanText();
                            // comboBoxID.SelectedIndex = 0;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene el campo Existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Elija un ID de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception) {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxIDProducto_TextChanged(object sender, EventArgs e)
        {

        }

      /*  private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            xButtonAgregarExitAlmacen.Enabled = true;
            CleanText();
        }
   */ 
    }
}
