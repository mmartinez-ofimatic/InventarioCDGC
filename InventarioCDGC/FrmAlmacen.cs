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
        bool selectModeRow = false;
        private void FrmAlmacen_Load(object sender, EventArgs e)
        {
            Permisos();
            comboBoxID.DataSource = almacen.BuscarIDProducto();
            dataGridView1.DataSource = almacen.BuscarTodos();
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

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxNombre.Text = almacen.BuscarxIDNombreCbx(comboBoxID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexion por favor verificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
        DataGridViewRow row;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            comboBoxID.Text = row.Cells[0].Value.ToString();
            //textBoxNombre.Text = row.Cells[1].Value.ToString();
            textBoxExistencia.Text = row.Cells[1].Value.ToString();

           dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
           selectModeRow = row.Selected;
        }

        public void CleanText()
        {
           // comboBoxID.SelectedIndex = 0;
            selectModeRow = false;
           // textBoxNombre.Clear();
            textBoxExistencia.Value = 1;
            comboBoxID.DataSource = almacen.BuscarIDProducto();
            dataGridView1.DataSource = almacen.BuscarTodos();
        }

        private void xButtonBuscar_Click(object sender, EventArgs e)
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
        }

        private void xButtonGuardar_Click(object sender, EventArgs e)
        {
            if (selectModeRow == false)
            {
                if (comboBoxID.Text != "")
                {
                    if (textBoxNombre.Text != "")
                    {
                        if (textBoxExistencia.Text != "")
                        {

                            almacen.IDproducto = comboBoxID.Text;
                            almacen.existencia = Convert.ToInt32(textBoxExistencia.Text);

                            try
                            {
                                if (almacen.Guardar())
                                {
                                    MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanText();
                                    comboBoxID.SelectedIndex = 0;
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Este producto existe, solo modifique su existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                CleanText();
                                comboBoxID.SelectedIndex = 0;

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
          
                if (selectModeRow == true)
                {
                    if (comboBoxID.Text != "")
                    {
                        if (textBoxNombre.Text != "")
                        {
                            if (textBoxExistencia.Text != "")
                            {
                                almacen.IDproducto = comboBoxID.Text;
                                almacen.existencia = Convert.ToInt32(textBoxExistencia.Text);

                                if (almacen.Modificar())
                                {
                                    MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanText();
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

        private void xButtonBorrar_Click(object sender, EventArgs e)
        {
            if (selectModeRow == true)
            {
                // se valida que el id de la fila seleccionada sea igual que la del textbox
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (row.Cells[0].Value.ToString() == comboBoxID.Text)
                {
                    if (almacen.Borrar())
                    {
                        MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanText();
                    }
                }

                else
                {
                    MessageBox.Show("Busque un producto y luego seleccionelo para eliminar del almacen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero busque un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void xButtonBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            Consultas.BuscarAlmacen almacen = new Consultas.BuscarAlmacen();
            almacen.ShowDialog(this);
        
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

        private void FrmAlmacen_Click(object sender, EventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            CleanText();
        }
    }
}
