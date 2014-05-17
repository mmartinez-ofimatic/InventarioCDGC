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
        public string IDproducto { get; set; }
        public int existencia { get; set; }
        public string nombreProducto { get; set; }
        public decimal precio_venta { get; set; }
       /* public decimal precio { get; set; }
        public string producto { get; set; }*/

        InventarioCDGCEntities1 dbEntities = new InventarioCDGCEntities1();

        /// <summary>
        /// Guarda en almacen un producto.
        /// </summary>
        /// <returns>bool</returns>
        public bool Guardar()
        {
            bool isComplete = false;

            try
            {
                InventarioCDGCEntities1 dbEntities2 = new InventarioCDGCEntities1();
                Almacen almacen = new Almacen();
                almacen.ID_Producto = IDproducto;
                almacen.Existencia = 0;
                almacen.Producto_1 = nombreProducto;
                almacen.Precio_Venta = precio_venta;
              

                dbEntities2.AddToAlmacens(almacen);
                dbEntities2.SaveChanges();
                isComplete = true;
            }
            catch (Exception)
            {

                //IDproducto = 0;
                //existencia = 0;
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
                Almacen update = (from upd in dbEntities.Almacens
                                    where upd.ID_Producto == IDproducto
                                    select upd).First();

                update.ID_Producto = IDproducto;
                //update.Existencia = existencia;
                update.Precio_Venta = precio_venta;
                update.Producto_1 = nombreProducto;
                
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
        /// Modifica un producto en el almacen.
        /// </summary>
        public bool AgregarExistenciadeProducto(string idproducto)
        {
            bool isComplete = false;
            try
            {
                Almacen update = (from upd in dbEntities.Almacens
                                  where upd.ID_Producto == idproducto
                                  select upd).First();
         
                update.Existencia = update.Existencia + existencia;
               
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
        /// Modifica un producto en el almacen.
        /// </summary>
        public bool SacarExistenciadeProducto(string idproducto)
        {
            bool isComplete = false;
            try
            {
                Almacen update = (from upd in dbEntities.Almacens
                                  where upd.ID_Producto == idproducto
                                  select upd).First();

                update.Existencia = update.Existencia - existencia;

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
                Almacen borrar = (from bor in dbEntities.Almacens
                                    where bor.ID_Producto == IDproducto
                                    select bor).FirstOrDefault();

                dbEntities.Almacens.DeleteObject(borrar);
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
        public List<Almacen> BuscarTodos()
        {
            var selec = (from s in dbEntities.Almacens
                         select s).ToList();

            return selec;
        }

        /// <summary>
        /// Busqueda por ID con producto.
        /// </summary>
        /// <returns>List</returns>
        public List<Almacen> BuscarxIDconProducto()
        {

            List<Almacen> busc = (from b in dbEntities.Almacens
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
        /// Busqueda por ID.
        /// </summary>
        /// <returns>List</returns>
        public List<Almacen> BuscarxID()
        {

            List<Almacen> busc = (from b in dbEntities.Almacens
                                   where b.ID_Producto == IDproducto
                                   select b).ToList();
            if (busc != null)
            {
                if (busc.Count != 0)
                {
                    foreach (var item in busc)
                    {
                        IDproducto = item.ID_Producto;
                        nombreProducto = item.Producto_1;
                        precio_venta = Convert.ToDecimal(item.Precio_Venta);
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
        public List<Almacen> BuscarxNombreconProducto(string nomproducto)
        {
            List<Almacen> busc = (from a in dbEntities.Almacens
                                     join p in dbEntities.Productos
                                     on a.ID_Producto equals p.ID_Producto
                                  where p.Producto1 == nomproducto
                                     select a).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    IDproducto = item.ID_Producto;
                    existencia = Convert.ToInt32(item.Existencia);
                    nombreProducto = (from p in dbEntities.Productos
                                        where p.ID_Producto == IDproducto
                                        select p.Producto1).ToString();
                }
            }
            


            return busc;
        }

        /// <summary>
        /// Lista de todos los productos en el almacen.
        /// </summary>
        /// <returns>List select</returns>
        public List<string> BuscarIDProducto()
        {
            var selec = (from s in dbEntities.Productos
                         select s.ID_Producto).ToList();

            return selec;
        }



        /// <summary>
        /// Buscar por nombre.
        /// </summary>
        /// <param name="nombre">nombre del producto.</param>
        /// <returns>List</returns>
        public List<Almacen> BuscarxNombre(string nomproducto)
        {
            List<Almacen> busc = (from b in dbEntities.Almacens
                                   where b.Producto_1 == nomproducto
                                   select b).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    IDproducto = item.ID_Producto;
                    nombreProducto = item.Producto_1;
                    precio_venta = Convert.ToDecimal(item.Precio_Venta);
                }
            }
            return busc;
        }


        /// <summary>
        /// Lista de todos los productos en el almacen.
        /// </summary>
        /// <returns>List select</returns>
        public string BuscarxIDNombreCbx(string ID)
        {
            string selec = (from s in dbEntities.Productos
                            where s.ID_Producto == ID
                            select s.Producto1).First();

            return selec;
        }



        /// <summary>
        /// Lista de todos los productos en el almacen.
        /// </summary>
        /// <returns>List select</returns>
        public List<ProductosEnAlmacen> BuscarTodosConProductos()
        {
           // Tipo anonimo 

            var selec = (from s in dbEntities.Almacens
                         select new ProductosEnAlmacen () {producto = s.Producto_1, existencia = s.Existencia.Value,
                                                            precio = s.Precio_Venta.Value}).ToList();


           // selec.
            return selec ;
        }

        //var selec = (from s in dbEntities.Almacens
        //             join p in dbEntities.Productos
        //             on s.ID_Producto equals p.ID_Producto
        //             select new ProductosEnAlmacen()
        //             {
        //                 producto = p.Producto1,
        //                 existencia = s.Existencia.Value,
        //                 precio = p.Precio_Venta.Value
        //             }).ToList();



    }

   public class ProductosEnAlmacen 
   {
       public string producto { get; set; }
       public int existencia { get; set; }
       public decimal precio { get; set; }       
   }
}
