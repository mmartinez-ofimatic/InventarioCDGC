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
                if (radioButtonAdmin.Checked != false || radioButtonLSyE.Checked != false || radioButtonLyS.Checked != false || radioButtonLectura.Checked != false)
                {
                    if ((MessageBox.Show("Desea guardar el nuevo registro?", "¿Guardar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                    {
                        int permisos;
                        if (radioButtonAdmin.Checked == true)
                        {
                            permisos = 1;
                        }
                        else if (radioButtonLSyE.Checked == true)
                        {
                            permisos = 2;
                        }
                        else if (radioButtonLyS.Checked == true)
                        {
                            permisos = 3;
                        }
                        else if (radioButtonLectura.Checked == true)
                        {
                            permisos = 4;
                        }
                        else
                        {
                            permisos = 0;
                        }


                        rolesClass.rol = textBoxNombre.Text;
                        rolesClass.permisos = permisos;
                        try
                        {
                            if (rolesClass.Guardar())
                            {

                                dataGridView1.DataSource = rolesClass.BuscarTodos();
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
                    }
                    else
                    {
                        MessageBox.Show("Debe especificar por lo menos un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Llene el campo nombre del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            if (row.Selected == true)
            {  
                    if (textBoxNombre.Text != "")
                    {
                        if (radioButtonAdmin.Checked != false || radioButtonLSyE.Checked != false || radioButtonLyS.Checked != false || radioButtonLectura.Checked != false)
                        {
                            if ((MessageBox.Show("Desea modificar este registro?", "¿Guardar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                            {
                                int permisos;
                                if (radioButtonAdmin.Checked == true)
                                {
                                    permisos = 1;
                                }
                                else if (radioButtonLSyE.Checked == true)
                                {
                                    permisos = 2;
                                }
                                else if (radioButtonLyS.Checked == true)
                                {
                                    permisos = 3;
                                }
                                else if (radioButtonLectura.Checked == true)
                                {
                                    permisos = 4;
                                }
                                else
                                {
                                    permisos = 0;
                                }

                                rolesClass.ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                                rolesClass.rol = textBoxNombre.Text;
                                rolesClass.permisos = permisos;

                                try
                                {
                                
                                if (rolesClass.Modificar())
                                {
                                    MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanText();
                                }
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Error al modificar, por favor digite nuevamente el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    CleanText();
                                }
                            }
                        }
                        else
                        {
                           MessageBox.Show("Debe especificar por lo menos un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                  
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene el campo nombre del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            else
            {
                MessageBox.Show("Primero busque un rol y seleccionelo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

                if ( row.Selected == true)
                {          
                // se valida que el id de la fila seleccionada sea igual que la del textbox

                if (row.Cells[0].Value.ToString()!= "")
                {
                    rolesClass.ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    if (rolesClass.Borrar())
                    {
                        MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanText();
                    }
                }

                else
                {
                    MessageBox.Show("Seleccione un rol para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero busque un rol y seleccionelo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataGridViewRow row;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            comboBoxBuscar.Text = row.Cells[0].Value.ToString();
            textBoxNombre.Text = row.Cells[1].Value.ToString();
            int permisos = Convert.ToInt32(row.Cells[2].Value.ToString()) ;
            
            if (permisos == 1 )
            {
                radioButtonAdmin.Checked = true;            
            }
            else if (permisos == 2)
            {
                radioButtonLSyE.Checked = true;
            }
            else if (permisos == 3)
            {
                radioButtonLyS.Checked = true;
                
            }
            else if (permisos == 4)
            {
                radioButtonLectura.Checked = true;
            }
            else
            {
                permisos = 0;
            }

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
            radioButtonAdmin.Checked = false;
            radioButtonLSyE.Checked = false;
            radioButtonLyS.Checked = false;
            radioButtonLectura.Checked = false;
            dataGridView1.DataSource = rolesClass.BuscarTodos();
        }


        private void FrmRol_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = rolesClass.BuscarTodos();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = true;
            dataGridView1_RowHeaderMouseClick(sender, null);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void xButton1_Click(object sender, EventArgs e)
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

        private void xButtonGuardar_Click(object sender, EventArgs e)
        {

            if (textBoxNombre.Text != "")
            {
                if (radioButtonAdmin.Checked != false || radioButtonLSyE.Checked != false || radioButtonLyS.Checked != false || radioButtonLectura.Checked != false)
                {
                    if ((MessageBox.Show("Desea guardar el nuevo registro?", "¿Guardar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                    {
                        int permisos;
                        if (radioButtonAdmin.Checked == true)
                        {
                            permisos = 1;
                        }
                        else if (radioButtonLSyE.Checked == true)
                        {
                            permisos = 2;
                        }
                        else if (radioButtonLyS.Checked == true)
                        {
                            permisos = 3;
                        }
                        else if (radioButtonLectura.Checked == true)
                        {
                            permisos = 4;
                        }
                        else
                        {
                            permisos = 0;
                        }


                        rolesClass.rol = textBoxNombre.Text;
                        rolesClass.permisos = permisos;
                        try
                        {
                            
                                if (rolesClass.Guardar())
                                {

                                    dataGridView1.DataSource = rolesClass.BuscarTodos();
                                    MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanText();
                                    ActualizarGrid();
                                }
                            
                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error, por favor digite nuevamente el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CleanText();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe especificar por lo menos un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Llene el campo nombre del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void xButtonModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            if (row.Selected == true)
            {
                if (textBoxNombre.Text != "")
                {
                    if (radioButtonAdmin.Checked != false || radioButtonLSyE.Checked != false || radioButtonLyS.Checked != false || radioButtonLectura.Checked != false)
                    {
                        if ((MessageBox.Show("Desea modificar este registro?", "¿Guardar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                        {
                            int permisos;
                            if (radioButtonAdmin.Checked == true)
                            {
                                permisos = 1;
                            }
                            else if (radioButtonLSyE.Checked == true)
                            {
                                permisos = 2;
                            }
                            else if (radioButtonLyS.Checked == true)
                            {
                                permisos = 3;
                            }
                            else if (radioButtonLectura.Checked == true)
                            {
                                permisos = 4;
                            }
                            else
                            {
                                permisos = 0;
                            }

                            rolesClass.ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                            rolesClass.rol = textBoxNombre.Text;
                            rolesClass.permisos = permisos;

                            try
                            {

                                if (rolesClass.Modificar())
                                {
                                    MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanText();
                                    ActualizarGrid();
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Error al modificar, por favor digite nuevamente el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                CleanText();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe especificar por lo menos un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Llene el campo nombre del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Primero busque un rol y seleccionelo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void xButtonBorrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            if (row.Selected == true)
            {
                // se valida que el id de la fila seleccionada sea igual que la del textbox

                if (row.Cells[0].Value.ToString() != "")
                {
                    rolesClass.ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea eliminar este Rol?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (rolesClass.Borrar())
                        {
                            MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CleanText();
                            ActualizarGrid();
                        }
                    }
                    
                }

                else
                {
                    MessageBox.Show("Seleccione un rol para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero busque un rol y seleccionelo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void busquedaAvanzadaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            CustomGroupBoxProperties.DrawGroupBox(box, e.Graphics, System.Drawing.ColorTranslator.FromHtml("#25BB04"));  
        }

        private void FrmRol_Click(object sender, EventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = false;
            //selectModeRow = false;
            CleanText();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

    }
}
