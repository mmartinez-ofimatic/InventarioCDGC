using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;

namespace ClassLibrary1
{
    public class Class1
    {
        InventarioCDGCEntities db = new InventarioCDGCEntities();
        public string nombre { get; set; } 

        public void guardar()
        {

            Clientes clientes = new Clientes();
            clientes.Nombre= nombre;         

        }
    }
}
