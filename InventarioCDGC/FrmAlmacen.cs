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
      
        AlmacenIn almacen = new AlmacenIn();
        bool selectModeRow = false;
        private void FrmAlmacen_Load(object sender, EventArgs e)
        {
            comboBoxID.DataSource = almacen.BuscarIDProducto();         
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNombre.Text = almacen.BuscarxIDNombreCbx(Convert.ToInt32(comboBoxID.Text));
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
                        almacen.IDproducto = Convert.ToInt32(tbuscarpor.Text);
                       
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

        private void guardartoolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (comboBoxID.Text != "")
            {
                if (textBoxNombre.Text != "")
                {
                    if (textBoxExistencia.Text != "")
                    {

                        almacen.IDproducto = Convert.ToInt32(comboBoxID.Text);
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

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tbuscarpor.Text != "")
            {
                if (selectModeRow == true)
                {
                    if (comboBoxID.Text != "")
                    {
                        if (textBoxNombre.Text != "")
                        {
                            if (textBoxExistencia.Text != "")
                            {
                                almacen.IDproducto = Convert.ToInt32(comboBoxID.Text);
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
                    MessageBox.Show("Debe seleccionar un producto para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero busque un producto para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            comboBoxID.Text = row.Cells[0].Value.ToString();
            //textBoxNombre.Text = row.Cells[1].Value.ToString();
            textBoxExistencia.Text = row.Cells[1].Value.ToString();

           dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
           selectModeRow = dataGridView1.Rows[e.RowIndex].Selected;
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tbuscarpor.Text != "")
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
                    MessageBox.Show("Seleccion un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero busque un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        public void CleanText()
        {
            comboBoxID.Text.FirstOrDefault();
            selectModeRow = false;
            textBoxNombre.Clear();
            textBoxExistencia.Value = 1;
        }

    

        private void busquedaAvanzadaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.BuscarAlmacen almacen = new Consultas.BuscarAlmacen();
            almacen.ShowDialog(this);
        }

       
    }
}
