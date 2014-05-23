using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataInventarioCDGC;
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
        Validaciones validar = new Validaciones();
        bool selectModeRow = false;

        public static int tiporol { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            Permisos();
            actualizarDatagrid();
        }

        public void Permisos()
        {
            if (tiporol == 1)
            {
               // xButtonBorrar.Enabled = true;
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

        public void actualizarDatagrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = clientesclass.BuscarUltimosClientes();
            //dataGridView1.DataSource = clientesclass.BuscarTodos();
        }

        public void CleanText()
        {
            textBoxNombre.Clear();
            textBoxCedula.Clear();
            textBoxCelular.Clear();
            textBoxDireccion.Clear();
            textBoxTelefono.Clear();
            selectModeRow = false;
            actualizarDatagrid();
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text!="")
            {
                if (tbuscarpor.Text != "")
                {
                    if (comboBoxBuscar.Text == "ID del Cliente")
                    {
                        try
                        {
                        clientesclass.idcliente = Convert.ToInt32(tbuscarpor.Text);
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = clientesclass.BuscarxID();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El ID del cliente debe ser numerico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Cliente no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (comboBoxBuscar.Text == "Nombre")
                    {
                        dataGridView1.AutoGenerateColumns = false;

                        dataGridView1.DataSource = clientesclass.BuscarxNombre(tbuscarpor.Text);
                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Cliente no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (comboBoxBuscar.Text == "Cedula")
                    {
                        //Validaciones v = new Validaciones();
                       // v.ValidateCedula(tbuscarpor.Text);

                        //if (v.ValidateCedula(tbuscarpor.Text) == false)

                        //    MessageBox.Show("Cedula Invalida. Por favor verifique.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //else
                        //{

                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = clientesclass.BuscarxCedula(tbuscarpor.Text);
                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Cliente no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //}
                    }




                    else if (comboBoxBuscar.Text == "Ultimos Clientes")
                    {   
                            dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.DataSource = clientesclass.BuscarUltimosClientes();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView1.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            xButtonGuardar.Enabled = true;
            CleanText();
        }
         DataGridViewRow row; 
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

//int index = e.RowIndex;

             row = dataGridView1.CurrentRow;        
            textBoxNombre.Text = row.Cells[1].Value.ToString();
            textBoxCedula.Text = row.Cells[2].Value.ToString();
            textBoxTelefono.Text = row.Cells[3].Value.ToString();
            textBoxCelular.Text = row.Cells[4].Value.ToString();
            textBoxDireccion.Text = row.Cells[5].Value.ToString();

            //textBoxNombre.ReadOnly = true;
            xButtonGuardar.Enabled = false;
            clientesclass.idcliente = Convert.ToInt32(row.Cells[0].Value.ToString());
            selectModeRow = row.Selected;

        }

        private void xButtonGuardar_Click(object sender, EventArgs e)
        {
           Clientescdgc clientes = new Clientescdgc();

           try
           {

               if (selectModeRow == false)
               {
                   if (textBoxNombre.Text != "")
                   {
                       if (validar.ValidateCedula(textBoxCedula.Text) || textBoxCedula.Text == "")
                       {
                           if (validar.ValidateNumeric(textBoxTelefono.Text) || textBoxTelefono.Text == "")
                           {
                               if (validar.ValidateNumeric(textBoxCelular.Text) || textBoxCelular.Text == "")
                               {
                                   clientes.nombre = textBoxNombre.Text;

                                   clientes.cedula = textBoxCedula.Text;
                                   clientes.telefono = textBoxTelefono.Text;
                                   clientes.celular = textBoxCelular.Text;
                                   clientes.direccion = textBoxDireccion.Text;
                                   DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                   if (dialogResult == DialogResult.Yes)
                                   {
                                       if (clientes.Guardar())
                                       {
                                           CleanText();
                                           MessageBox.Show("Guardado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                       }
                                   }

                               }


                               else
                               {
                                   MessageBox.Show("El campo Celular debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                               }
                           }



                           else
                           {
                               MessageBox.Show("El campo Telefono debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           }
                       }



                       else
                       {
                           MessageBox.Show("La cedula debe ser numerica y debe tener 11 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }
                   }


                   else
                   {
                       MessageBox.Show("Llene el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               }
               else
               {
                   MessageBox.Show("Hay un cliente seleccionado, Deseleccionelo para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
           }
           catch (Exception)
           {
               MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
           }
            
        }

        private void xButtonModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (selectModeRow == true)
                {
                    if (textBoxNombre.Text != "")
                    {

                        if (validar.ValidateCedula(textBoxCedula.Text) || textBoxCedula.Text == "")
                        {

                            if (validar.ValidateNumeric(textBoxTelefono.Text) || textBoxTelefono.Text == "")
                            {

                                if (validar.ValidateNumeric(textBoxCelular.Text) || textBoxCelular.Text == "")
                                {

                                    clientesclass.nombre = textBoxNombre.Text;
                                    clientesclass.cedula = textBoxCedula.Text;
                                    clientesclass.telefono = textBoxTelefono.Text;
                                    clientesclass.celular = textBoxCelular.Text;
                                    clientesclass.direccion = textBoxDireccion.Text;
                                    DialogResult dialogResult = MessageBox.Show("¿Estas seguro que desea modificar este cliente?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        if (clientesclass.Modificar())
                                        {
                                            CleanText();
                                            MessageBox.Show("Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        }
                                    }



                                }
                                else
                                {
                                    MessageBox.Show("El campo Celular debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }


                            }
                            else
                            {
                                MessageBox.Show("El campo Telefono debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                        else
                        {
                            MessageBox.Show("La Cedula debe ser numerica y debe tener 11 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                    else
                    {
                        MessageBox.Show("Primero busque un cliente y seleccionelo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, intente de nuevo. Si el problema persiste contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void xButtonBorrar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (selectModeRow == true)
        //    {
        //           // clientesclass.idcliente = Convert.ToInt32(row.Cells[0].Value.ToString());
        //            if (clientesclass.Borrar())
        //            {
        //                CleanText();
        //                MessageBox.Show("Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
                
        //    }
        //      else
        //        {
        //            MessageBox.Show("Primero busque un cliente y luego seleccionelo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Error, trate de eliminar nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void xButtonBusquedaAvanzada_Click(object sender, EventArgs e)
        //{
        //    Consultas.BuscarClienteVentas bclientes = new Consultas.BuscarClienteVentas();
        //    bclientes.ShowDialog(this);
        //}

        //private void bbuscar_Click_1(object sender, EventArgs e)
        //{
        //    if (comboBoxBuscar.Text != "")
        //    {
        //        if (tbuscarpor.Text != "")
        //        {
        //            if (comboBoxBuscar.Text == "ID del Cliente")
        //            {
        //                try
        //                {
        //                    clientesclass.idcliente = Convert.ToInt32(tbuscarpor.Text);
        //                    dataGridView1.AutoGenerateColumns = false;
        //                    dataGridView1.DataSource = clientesclass.BuscarxID();
        //                }
        //                catch (Exception)
        //                {
        //                    MessageBox.Show("El ID del cliente debe ser numerico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //                if (dataGridView1.RowCount == 0)
        //                {
        //                    MessageBox.Show("Este Cliente no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //            }
        //            else if (comboBoxBuscar.Text == "Nombre")
        //            {
        //                dataGridView1.AutoGenerateColumns = false;

        //                dataGridView1.DataSource = clientesclass.BuscarxNombre(tbuscarpor.Text);
        //                if (dataGridView1.RowCount == 0)
        //                {
        //                    MessageBox.Show("Este Cliente no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //            }
        //            else if (comboBoxBuscar.Text == "Cedula")
        //            {
        //                Validaciones v = new Validaciones();
        //                // v.ValidateCedula(tbuscarpor.Text);

        //                if (v.ValidateCedula(tbuscarpor.Text) == false)

        //                    MessageBox.Show("La Cedula debe ser numerica y debe tener 11 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                else
        //                {

        //                    dataGridView1.AutoGenerateColumns = false;

        //                    dataGridView1.DataSource = clientesclass.BuscarxCedula(tbuscarpor.Text);
        //                    if (dataGridView1.RowCount == 0)
        //                    {
        //                        MessageBox.Show("Este Cliente no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("LLene el campo de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Elija la opcion de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

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
        
        //}

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            row = dataGridView1.CurrentRow;
            row.Selected = false;
            selectModeRow = false;
            xButtonGuardar.Enabled = true;
            CleanText();
           // DataGridViewCellMouseEventArgs a =
           /* row = dataGridView1.CurrentRow; 
            row.Selected = true;
            dataGridView1_RowHeaderMouseClick(sender, null); */
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            CustomGroupBoxProperties.DrawGroupBox(box, e.Graphics, System.Drawing.ColorTranslator.FromHtml("#25BB04"));  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         //    row = dataGridView1.CurrentRow;
        //    row.Selected = false;
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text == "Ultimos Clientes")
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = clientesclass.BuscarUltimosClientes();
            }
        }


    }
}
