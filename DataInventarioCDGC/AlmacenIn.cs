using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.EntityClient;

namespace DataInventarioCDGC
{
   public class AlmacenIn
    {
        public int IDproducto { get; set; }
        public int existencia { get; set; }
        public string nombreProducto { get; set; }

        InventarioCDGCEntities dbEntities = new InventarioCDGCEntities();

        /// <summary>
        /// Guarda en almacen un producto.
        /// </summary>
        /// <returns>bool</returns>
        public bool Guardar()
        {
            bool isComplete = false;

            try
            {
                InventarioCDGCEntities dbEntities2 = new InventarioCDGCEntities();
                AlmacenInv almacen = new AlmacenInv();
                almacen.ID_Producto = IDproducto;
                almacen.Existencia = existencia;


                dbEntities2.AddToAlmacen(almacen);
                dbEntities2.SaveChanges();
                isComplete = true;
            }
            catch (Exception)
            {

                IDproducto = 0;
                existencia = 0;
                throw;
            }

            return isComplete;
        }

        /// <summary>
        /// Modifica un producto en el almacen.
        /// </summary>
        public bool Modificar()
        {
            bool isComplete = false;
            try
            {
                AlmacenInv update = (from upd in dbEntities.Almacen
                                    where upd.ID_Producto == IDproducto
                                    select upd).First();

                update.ID_Producto = IDproducto;
                update.Existencia = existencia;
                
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
        /// Borra un producto del almacen.
        /// </summary>
        /// <returns>bool isComplete</returns>
        public bool Borrar()
        {
            bool isComplete = false;

            try
            {
                AlmacenInv borrar = (from bor in dbEntities.Almacen
                                    where bor.ID_Producto == IDproducto
                                    select bor).FirstOrDefault();

                dbEntities.Almacen.DeleteObject(borrar);
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
        /// Lista de todos los productos en el almacen.
        /// </summary>
        /// <returns>List select</returns>
        public List<AlmacenInv> BuscarTodos()
        {
            var selec = (from s in dbEntities.Almacen
                         select s).ToList();

            return selec;
        }

        /// <summary>
        /// Busqueda por ID.
        /// </summary>
        /// <returns>List</returns>
        public List<AlmacenInv> BuscarxID()
        {

            List<AlmacenInv> busc = (from b in dbEntities.Almacen
                                     join a in dbEntities.Productos
                                     on b.ID_Producto equals a.ID_Producto
                                     where b.ID_Producto == IDproducto
                                     select b).ToList();
            if (busc != null)
            {
                if (busc.Count != 0)
                {
                    foreach (var item in busc)
                    {
                        IDproducto = item.ID_Producto;
                        existencia = Convert.ToInt32(item.Existencia);                    
                    }

                }
            }

            return busc;
        }

        /// <summary>
        /// Buscar por nombre.
        /// </summary>
        /// <param name="nombre">nombre del producto.</param>
        /// <returns>List</returns>
        public List<AlmacenInv> BuscarxNombre(string nomproducto)
        {
            List<AlmacenInv> busc = (from a in dbEntities.Almacen
                                     join p in dbEntities.Productos
                                     on a.ID_Producto equals p.ID_Producto
                                     where p.Producto == nomproducto
                                     select a).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    IDproducto = item.ID_Producto;
                    existencia = Convert.ToInt32(item.Existencia);
                    nombreProducto = (from p in dbEntities.Productos
                                        where p.ID_Producto == IDproducto
                                        select p.Producto).ToString();
                }
            }
            


            return busc;
        }

        /// <summary>
        /// Lista de todos los productos en el almacen.
        /// </summary>
        /// <returns>List select</returns>
        public List<int> BuscarIDProducto()
        {
            var selec = (from s in dbEntities.Productos
                         select s.ID_Producto).ToList();

            return selec;
        }


        /// <summary>
        /// Lista de todos los productos en el almacen.
        /// </summary>
        /// <returns>List select</returns>
        public string BuscarxIDNombreCbx(int ID)
        {
            string selec = (from s in dbEntities.Productos
                            where s.ID_Producto == ID
                            select s.Producto).First();

            return selec;
        }

    }
}
