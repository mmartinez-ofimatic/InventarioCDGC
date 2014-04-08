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

            if (textBoxIDproducto.Text != "")
            {
                if (textBoxNombre.Text != "")
                {
                    if (textBoxPrecio.Text != "")
                    {

                        product.idproducto = Convert.ToInt32(textBoxIDproducto.Text);
                        product.producto = textBoxNombre.Text;
                        product.precio = Convert.ToDecimal(textBoxPrecio.Text);
                        if (product.Guardar())
                        {
                            MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tbuscarpor.Text != "")
            {
                if (textBoxIDproducto.Text!="")
                {
                    if (textBoxNombre.Text!="")
                    {
                        if (textBoxPrecio.Text!="")
                        {
                            //dataGridView1.SelectionMode.GetType();
                          
                            product.idproducto = Convert.ToInt32(textBoxIDproducto.Text);
                            product.producto = textBoxNombre.Text;
                            product.precio = Convert.ToDecimal(textBoxPrecio.Text);

                            if (product.Modificar())
                            {
                                MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tbuscarpor.Text != "")
            {
                // se valida que el id de la fila seleccionada sea igual que la del texbox
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (row.Cells[0].Value.ToString() == textBoxIDproducto.Text)
                {
                    if (product.Borrar())
                    {
                        MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        product.idproducto = Convert.ToInt32(tbuscarpor.Text);
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow row = dataGridView1.CurrentRow;
            textBoxIDproducto.Text = row.Cells[0].Value.ToString();
            textBoxNombre.Text = row.Cells[1].Value.ToString();
            textBoxPrecio.Text = row.Cells[2].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void busquedaAvanzadaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.BuscarProductosVentas bProductos = new Consultas.BuscarProductosVentas();
            bProductos.ShowDialog(this);
        }


    }
}
