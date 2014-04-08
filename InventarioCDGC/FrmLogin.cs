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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

       
        UsuarioInv login = new UsuarioInv();
        
        private void BLOGIN_Click(object sender, EventArgs e)
        {
            bool validate;
            validate = login.ValidateUsers(tusuario.Text, tpass.Text);

            if (validate == true)
            {
                FrmMenu menu = new FrmMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Password Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tusuario.Clear();
                tpass.Clear();
            }
        }
    }
}
