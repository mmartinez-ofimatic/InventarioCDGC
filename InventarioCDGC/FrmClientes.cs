using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataInventarioCDGC;
using System.Data;
using System.Data.Entity;

namespace InventarioCDGC
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        Clientescdgc clientesclass = new Clientescdgc();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clientescdgc clientes = new Clientescdgc();

            if (textBoxNombre.Text != "")
            {
                if (textBoxCedula.Text != "")
                {
                   if (textBoxTelefono.Text != "")
                    {
                        if (textBoxCelular.Text != "")
                        {
                            if (textBoxDireccion.Text != "")
                            {
                                clientes.nombre = textBoxNombre.Text;
                               
                                clientes.cedula = textBoxCedula.Text;
                                clientes.telefono = textBoxTelefono.Text;
                                clientes.celular = textBoxCelular.Text;
                                clientes.direccion = textBoxDireccion.Text;
                                if (clientes.Guardar())
                                {
                                    MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                } 
                            }
                            else
                            {
                                MessageBox.Show("Llene el campo Direccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Llene el campo Celular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene el campo Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Llene el campo Cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show("Llene el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tbuscarpor.Text != "")
            {
                if (clientesclass.idcliente == Convert.ToInt32(tbuscarpor.Text))
                {
                    clientesclass.nombre = textBoxNombre.Text;
                    clientesclass.cedula = textBoxCedula.Text;
                    clientesclass.telefono = textBoxTelefono.Text;
                    clientesclass.celular = textBoxCelular.Text;
                    clientesclass.direccion = textBoxDireccion.Text;
                    if (clientesclass.Modificar())
                    {
                        MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Primero busque por ID para modificar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero busque por ID para modificar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text!="")
            {
                if (tbuscarpor.Text != "")
                {

                    if (comboBoxBuscar.Text == "ID del Cliente")
                    {                     
                        clientesclass.idcliente = Convert.ToInt32(tbuscarpor.Text);
                        dataGridView1.AutoGenerateColumns = false;

                        dataGridView1.DataSource = clientesclass.BuscarxID();
                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Cliente no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBoxBuscar.Text == "Nombre")
                    {
                        dataGridView1.AutoGenerateColumns = false;

                        dataGridView1.DataSource = clientesclass.BuscarxNombre(tbuscarpor.Text);
                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Cliente no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBoxBuscar.Text == "Cedula")
                    {
                        dataGridView1.AutoGenerateColumns = false;

                        dataGridView1.DataSource = clientesclass.BuscarxCedula(tbuscarpor.Text);
                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Cliente no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            //if (tbuscarpor.Text != "")
            //{
            //    clientesclass.idcliente = Convert.ToInt32(tbuscarpor.Text);
            //    dataGridView1.AutoGenerateColumns = false;
               
            //    dataGridView1.DataSource = clientesclass.BuscarTodos();

            //   /* textBoxNombre.Text = clientesclass.nombre;
            //    textBoxCedula.Text = clientesclass.cedula;
            //    textBoxTelefono.Text = clientesclass.telefono;
            //    textBoxCelular.Text = clientesclass.celular;
            //    textBoxDireccion.Text = clientesclass.direccion;*/
            //}
            //else
            //{
            //    MessageBox.Show("LLene el campo de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tbuscarpor.Text != "")
            {
                if (clientesclass.idcliente == Convert.ToInt32(tbuscarpor.Text))
                {
                    if (clientesclass.Borrar())
                    {
                        MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Primero busque por ID para eliminar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero busque por ID para eliminar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow row = dataGridView1.CurrentRow;        
            textBoxNombre.Text = row.Cells[1].Value.ToString();
            textBoxCedula.Text = row.Cells[2].Value.ToString();
            textBoxTelefono.Text = row.Cells[3].Value.ToString();
            textBoxCelular.Text = row.Cells[4].Value.ToString();
            textBoxDireccion.Text = row.Cells[5].Value.ToString();
        }



    }
}
