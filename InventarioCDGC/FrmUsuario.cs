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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        UsuarioInv usuarioClass = new UsuarioInv();
        bool selectModeRow = false;
        int id;
      
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            RolInv roles = new RolInv();
            comboBoxRol.DataSource = roles.BuscarTodos();
            comboBoxRol.DisplayMember = "Rol";
            comboBoxRol.ValueMember = "ID_Rol";
            ActualizarGrid();
            
        }

        public void ActualizarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = usuarioClass.BuscarTodos();
         }

        private void guardartoolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
            if (textBoxNombre.Text != "")
            {
                if (textBoxContrasena.Text!="")
                {
                    if (textBoxRcontrasena.Text!="")
                    {
                        if (textBoxContrasena.Text == textBoxRcontrasena.Text)
                        {
                            if (comboBoxRol.Text!="")
                            {
                                usuarioClass.nomusuario = textBoxNombre.Text;
                                usuarioClass.contrasena = textBoxContrasena.Text;
                                usuarioClass.IDrol = Convert.ToInt32(comboBoxRol.SelectedValue);
                                try
                                {
                                    if (usuarioClass.Guardar())
                                    {
                                        MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        CleanText();
                                        ActualizarGrid();
                                    }
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Error, por favor digite nuevamente el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    CleanText();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Elija un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La contraseña deben ser igual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Repita la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Llene el campo contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                if (textBoxContrasena.Text != "")
                                {
                                    if (textBoxRcontrasena.Text != "")
                                    {
                                        if (textBoxContrasena.Text == textBoxRcontrasena.Text)
                                        {
                                            if (comboBoxRol.Text != "")
                                            {
                                                if (id > 0)
                                                {
                                                    UsuarioInv.IDusuario = id;
                                                    usuarioClass.nomusuario = textBoxNombre.Text;
                                                    usuarioClass.contrasena = textBoxContrasena.Text;
                                                    usuarioClass.IDrol = Convert.ToInt32(comboBoxRol.SelectedValue);

                                                    if (usuarioClass.Modificar())
                                                    {
                                                        MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        CleanText();
                                                        ActualizarGrid();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Debe seleccionar un usuario para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Elija un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("La contraseña deben ser igual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Repita la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Llene el campo contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Llene el campo nombre del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }                     
      
            }
            else
            {
                MessageBox.Show("Debe buscar un usuario y despues seleccionarlo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            }
        }
                

        public void CleanText()
        {
            textBoxNombre.Clear();
            textBoxContrasena.Clear();
            textBoxRcontrasena.Clear();
            comboBoxRol.SelectedIndex = 0;
            tbuscarpor.Clear();
            dataGridView1.ClearSelection();
            id = 0;
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text != "")
            {
                if (tbuscarpor.Text != "")
                {
                    if (comboBoxBuscar.Text == "ID de usuario")
                    {
                        try
                        {
                            UsuarioInv.IDusuario = Convert.ToInt32(tbuscarpor.Text);

                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = usuarioClass.BuscarxID();

                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este usuario no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El ID del rol debe ser numerico!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else if (comboBoxBuscar.Text == "Nombre de usuario")
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = usuarioClass.BuscarxNombre(tbuscarpor.Text);

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

        DataGridViewRow row;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            id = Convert.ToInt32(row.Cells[0].Value.ToString());
           
            comboBoxRol.SelectedValue = Convert.ToInt32(row.Cells[1].Value.ToString());
            textBoxNombre.Text = row.Cells[2].Value.ToString();
            textBoxContrasena.Text = row.Cells[3].Value.ToString();
            textBoxRcontrasena.Text = row.Cells[3].Value.ToString();
        
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tbuscarpor.Text != "")
            {
                // se valida que el id de la fila seleccionada sea igual que la del textbox
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (Convert.ToInt32(row.Cells[0].Value.ToString()) == id)
                {
                    UsuarioInv.IDusuario = id;
                    if (usuarioClass.Borrar())
                    {
                        MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanText();
                    }
                }

                else
                {
                    MessageBox.Show("Seleccione un usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero busque un usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = true;
            dataGridView1_RowHeaderMouseClick(sender, null);
        }

        private void xButtonGuardar_Click(object sender, EventArgs e)
        {
            try{
            if (selectModeRow == false)
           {
            if (textBoxNombre.Text != "")
            {
                if (textBoxContrasena.Text != "")
                {
                    if (textBoxRcontrasena.Text != "")
                    {
                        if (textBoxContrasena.Text == textBoxRcontrasena.Text)
                        {
                            if (comboBoxRol.Text != "")
                            {
                                usuarioClass.nomusuario = textBoxNombre.Text;
                                usuarioClass.contrasena = textBoxContrasena.Text;
                                usuarioClass.IDrol = Convert.ToInt32(comboBoxRol.SelectedValue);
                              
                                    DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        if (usuarioClass.Guardar())
                                        {
                                            MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            CleanText();
                                        }
                                    }
                                    
                            }
                            else
                            {
                                MessageBox.Show("Elija un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La contraseña deben ser igual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Repita la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Llene el campo contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Llene el campo nombre del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           }
            else
            {
                MessageBox.Show("Hay un usuario seleccionado, Deseleccionelo para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CleanText();
            }
        }

        private void xButtonModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            try{

            if (row.Selected == true)
            {
                if (textBoxNombre.Text != "")
                {
                    if (textBoxContrasena.Text != "")
                    {
                        if (textBoxRcontrasena.Text != "")
                        {
                            if (textBoxContrasena.Text == textBoxRcontrasena.Text)
                            {
                                if (comboBoxRol.Text != "")
                                {
                                    if (id > 0)
                                    {
                                        UsuarioInv.IDusuario = id;
                                        usuarioClass.nomusuario = textBoxNombre.Text;
                                        usuarioClass.contrasena = textBoxContrasena.Text;
                                        usuarioClass.IDrol = Convert.ToInt32(comboBoxRol.SelectedValue);

                                        DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea modificar este usuario?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            if (usuarioClass.Modificar())
                                            {
                                                MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                CleanText();
                                            }
                                        }
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe seleccionar un usuario para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Elija un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("La contraseña deben ser igual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Repita la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene el campo contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Llene el campo nombre del rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe buscar un usuario y despues seleccionarlo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void xButtonBorrar_Click(object sender, EventArgs e)
        //{
        //    if (tbuscarpor.Text != "")
        //    {
        //        // se valida que el id de la fila seleccionada sea igual que la del textbox
        //        DataGridViewRow row = dataGridView1.CurrentRow;
        //        if (Convert.ToInt32(row.Cells[0].Value.ToString()) == id)
        //        {
        //            usuarioClass.IDusuario = id;
        //            if (usuarioClass.Borrar())
        //            {
        //                MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                CleanText();
        //                ActualizarGrid();
        //            }
        //        }

        //        else
        //        {
        //            MessageBox.Show("Seleccione un usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Primero busque un usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        
        //}

        //private void xButtonBusquedaAvanzada_Click(object sender, EventArgs e)
        //{

        //}

        private void xButton1_Click(object sender, EventArgs e)
        {
            
            try{
            if (comboBoxBuscar.Text != "")
            {
                if (tbuscarpor.Text != "")
                {
                    if (comboBoxBuscar.Text == "ID de usuario")
                    {
                       
                            UsuarioInv.IDusuario = Convert.ToInt32(tbuscarpor.Text);

                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = usuarioClass.BuscarxID();

                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este usuario no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                    }
                    else if (comboBoxBuscar.Text == "Nombre de usuario")
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = usuarioClass.BuscarxNombre(tbuscarpor.Text);

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
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            CustomGroupBoxProperties.DrawGroupBox(box, e.Graphics, System.Drawing.ColorTranslator.FromHtml("#25BB04"));  
        }


        private void FrmUsuario_Click(object sender, EventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            CleanText();
        }

    }
}
