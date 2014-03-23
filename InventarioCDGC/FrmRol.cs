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
    public partial class FrmRol : Form
    {
        public FrmRol()
        {
            InitializeComponent();
        }

        RolInv rolesClass = new RolInv(); 

        private void guardartoolStripMenuItem1_Click(object sender, EventArgs e)
        {

              if (textBoxNombre.Text != "")
                {
                    rolesClass.rol = textBoxNombre.Text;
                       
                        try
                        {
                            if (rolesClass.Guardar())
                            {
                                MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CleanText();
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error, por favor digite nuevamente el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CleanText();
                        }             
                }
                else
                {
                    MessageBox.Show("Llene el campo nombre del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tbuscarpor.Text != "")
            {
                if (comboBoxBuscar.Text != "")
                {
                    if (textBoxNombre.Text != "")
                    {
                        rolesClass.rol = textBoxNombre.Text;
                       
                            if (rolesClass.Modificar())
                            {
                                MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CleanText();
                            }        
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un rol para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un rol para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero busque un rol para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tbuscarpor.Text != "")
            {
                // se valida que el id de la fila seleccionada sea igual que la del textbox
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (row.Cells[0].Value.ToString() == comboBoxBuscar.Text)
                {
                    if (rolesClass.Borrar())
                    {
                        MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanText();
                    }
                }

                else
                {
                    MessageBox.Show("Seleccion un rol para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero busque un rol para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            comboBoxBuscar.Text = row.Cells[0].Value.ToString();
            //textBoxNombre.Text = row.Cells[1].Value.ToString();
            textBoxNombre.Text = row.Cells[1].Value.ToString();
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text != "")
            {
                if (tbuscarpor.Text != "")
                {
                    if (comboBoxBuscar.Text == "ID del rol")
                    {
                        try
                        {
                            rolesClass.ID = Convert.ToInt32(tbuscarpor.Text);

                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = rolesClass.BuscarxID();

                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este rol no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El ID del rol debe ser numerico!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else if (comboBoxBuscar.Text == "Nombre del rol")
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = rolesClass.BuscarxNombre(tbuscarpor.Text);

                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este rol no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        public void CleanText()
        {
            textBoxNombre.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
