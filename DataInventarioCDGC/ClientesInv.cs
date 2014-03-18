using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.EntityClient;
using System.Data.Objects;


namespace DataInventarioCDGC
{
    public class Clientescdgc
    {
        public int idcliente { get; set; }
        public string nombre { get; set; }
        public string cedula { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string direccion { get; set; }

        InventarioCDGCEntities dbEntities = new InventarioCDGCEntities();
        
        /// <summary>
        /// Guarda un cliente en la base de datos.
        /// </summary>
        public bool Guardar()
        {
            bool isComplete = false;
            try
            {
            InventarioCDGCEntities db = new InventarioCDGCEntities();
            ClientesInv clientes = new ClientesInv();   
            clientes.Nombre = nombre;
            clientes.Cedula = cedula;
            clientes.Telefono = telefono;
            clientes.Celular = celular;
            clientes.Direccion = direccion;
                //Cambio...
                //Cambio Santiago.

            db.Clientes.AddObject(clientes);
            db.SaveChanges();
            isComplete = true;
            }
            catch (Exception)
            {

                throw;
            }

            return isComplete;
        }

        /// <summary>
        /// Modifica un cliente.
        /// </summary>
        public bool Modificar()
        {
           bool isComplete = false;
            try
            {
                ClientesInv update = (from upd in dbEntities.Clientes
                                      where upd.ID_Cliente == idcliente
                                      select upd).First();

                update.Nombre = nombre;
                update.Cedula = cedula;
                update.Telefono = telefono;
                update.Celular = celular;
                update.Direccion = direccion;

                dbEntities.SaveChanges();
               
                isComplete = true;
            }
            catch (Exception)
            {       
                throw;
            }

            return isComplete;
        }

        /// <summary>
        /// Borra un cliente.
        /// </summary>
        /// <returns>bool isComplete</returns>
        public bool Borrar()
        {
            bool isComplete = false;
            
            try
            {
                ClientesInv borrar = (from bor in dbEntities.Clientes
                                      where bor.ID_Cliente == idcliente
                                      select bor).FirstOrDefault();

                dbEntities.Clientes.DeleteObject(borrar);
                dbEntities.SaveChanges();

                isComplete = true;
            }
            catch (Exception)
            {              
                throw;
            }

            return isComplete;
        }

        /// <summary>
        /// Lista de todos los clientes.
        /// </summary>
        /// <returns>List select</returns>
        public List<ClientesInv> BuscarTodos()
        {
           var selec = (from s in dbEntities.Clientes
                         select s).ToList();
            return selec;
        }

        /// <summary>
        /// Busqueda por ID.
        /// </summary>
        /// <returns>List</returns>
        public List<ClientesInv> BuscarxID()
        {

            List<ClientesInv> busc = (from b in dbEntities.Clientes
                                           where b.ID_Cliente == idcliente
                                           select b).ToList();
            if (busc != null)
            {
                if (busc.Count != 0)
                {
                    foreach (var item in busc)
                    {
                        nombre = item.Nombre;
                       
                        cedula = item.Cedula;
                        telefono = item.Telefono;
                        celular = item.Celular;                
                        direccion = item.Direccion;                       
                    }

                }
            }

            return busc;
        }

        /// <summary>
        /// Buscar por nombre.
        /// </summary>
        /// <param name="nombre">nombre del cliente.</param>
        /// <returns>List</returns>
        public List<ClientesInv> BuscarxNombre(string nombre)
        {

            List<ClientesInv> busc = (from b in dbEntities.Clientes
                                           where b.Nombre == nombre
                                           select b).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    nombre = item.Nombre;            
                    cedula = item.Cedula;
                    telefono = item.Telefono;
                    celular = item.Celular;
                    direccion = item.Direccion;
                }
            }
            return busc;
        }

        /// <summary>
        /// Buscar por cedula.
        /// </summary>
        /// <param name="nombre">cedula del cliente.</param>
        /// <returns>List</returns>
        public List<ClientesInv> BuscarxCedula(string cedula)
        {
            List<ClientesInv> busc = (from b in dbEntities.Clientes
                                      where b.Cedula == cedula
                                      select b).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    nombre = item.Nombre;
                    cedula = item.Cedula;
                    telefono = item.Telefono;
                    celular = item.Celular;
                    direccion = item.Direccion;
                }
            }
            return busc;
        }



    }
}
