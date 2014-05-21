using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataInventarioCDGC;

namespace InventarioCDGC.Consultas
{
    public partial class BuscarClienteVentas : Form
    {
        public BuscarClienteVentas()
        {
            InitializeComponent();
        }

        Clientescdgc clientesClass = new Clientescdgc();
        public int idCliente { get; set; }
        public string Cliente { get; set; }

        private void BuscarClienteVentas_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = clientesClass.BuscarTodos();        
        }
  

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;                
            this.idCliente = Convert.ToInt32(row.Cells[0].Value.ToString());
            Cliente = row.Cells[1].Value.ToString();
            this.Close();  
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1_RowHeaderMouseClick_1(sender, null); 
        }

        

        private void xBuscar_Click(object sender, EventArgs e)
        {
            
            try{
            if (comboBoxBuscar.Text != "")
            {
                if (tbuscarpor.Text != "")
                {

                    if (comboBoxBuscar.Text == "ID del Cliente")
                    {
                        try
                        {
                            clientesClass.idcliente = Convert.ToInt32(tbuscarpor.Text);
                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = clientesClass.BuscarxID();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El ID debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Cliente no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (comboBoxBuscar.Text == "Nombre")
                    {
                        dataGridView1.AutoGenerateColumns = false;

                        dataGridView1.DataSource = clientesClass.BuscarxNombre(tbuscarpor.Text);
                        if (dataGridView1.RowCount == 0)
                        {
                            MessageBox.Show("Este Cliente no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (comboBoxBuscar.Text == "Cedula")
                    {
                        Validaciones v = new Validaciones();
                        // v.ValidateCedula(tbuscarpor.Text);

                        if (v.ValidateCedula(tbuscarpor.Text) == false)

                            MessageBox.Show("Cedula Invalida. Por favor verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {

                            dataGridView1.AutoGenerateColumns = false;

                            dataGridView1.DataSource = clientesClass.BuscarxCedula(tbuscarpor.Text);
                            if (dataGridView1.RowCount == 0)
                            {
                                MessageBox.Show("Este Cliente no existe!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
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
    }
       
}
