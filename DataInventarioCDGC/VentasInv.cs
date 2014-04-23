using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataInventarioCDGC
{
  public class VentasInv
    {
        public int idventa { get; set; }
        public int idcliente { get; set; }
        public int idproducto { get; set; }
        public int idusuario { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public decimal descuento { get; set; }
        public string observacion { get; set; }
        public DateTime fecha { get; set; }

        InventarioCDGCEntities dbEntities = new InventarioCDGCEntities();

        /// <summary>
        /// Guarda una venta.
        /// </summary>
       /// <returns>bool isComplete</returns>
        public bool Guardar()
        {
            bool isComplete = false;
            try
            {
                InventarioCDGCEntities db = new InventarioCDGCEntities();
                Ventas ventas = new Ventas();
                ventas.ID_Cliente = idcliente;
                ventas.ID_Producto = idproducto;
                //falata el id de usuario
                ventas.ID_Usuario = null;
                ventas.Precio_Unidad = precio;
                ventas.Cantidad = cantidad;
                ventas.Descuento = descuento;
                ventas.Observacion = observacion;
                ventas.Fecha = DateTime.Now;

                db.AddToVentas(ventas);
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
        /// Modifica una venta.
        /// </summary>
        /// <returns>bool isComplete</returns>
        public bool Modificar()
        {
            bool isComplete = false;
            try
            {
                Ventas update = (from upd in dbEntities.Ventas
                                      where upd.ID_Venta == idventa
                                      select upd).First();

                update.ID_Cliente = idcliente;
                update.ID_Producto = idproducto;
                //Poner el di de usuario loguiado.
                update.ID_Usuario = null;
                update.Precio_Unidad = precio;
                update.Cantidad = cantidad;
                update.Descuento = descuento;
                update.Fecha = DateTime.Now;
                update.Observacion = observacion;
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
        /// Borra una venta.
        /// </summary>
        /// <returns>bool isComplete</returns>
        public bool Borrar()
        {
            bool isComplete = false;

            try
            {
                Ventas borrar = (from bor in dbEntities.Ventas
                                      where bor.ID_Venta == idventa
                                      select bor).FirstOrDefault();

                dbEntities.Ventas.DeleteObject(borrar);
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
        /// Lista de todas las ventas.
        /// </summary>
        /// <returns>List select</returns>
        public List<Ventas> BuscarTodos()
        {
            var selec = (from s in dbEntities.Ventas
                         select s).ToList();
            return selec;
        }

        /// <summary>
        /// Busqueda por ID.
        /// </summary>
        /// <returns>List</returns>
        public List<Ventas> BuscarxID()
        {

            List<Ventas> busc = (from b in dbEntities.Ventas
                                      where b.ID_Venta == idventa
                                      select b).ToList();
            if (busc != null)
            {
                if (busc.Count != 0)
                {
                    foreach (var item in busc)
                    {
                        idcliente = Convert.ToInt32(item.ID_Cliente);

                        idproducto = Convert.ToInt32(item.ID_Producto);
                        idusuario = Convert.ToInt32(item.ID_Usuario);
                        precio = Convert.ToDecimal(item.Precio_Unidad);
                        cantidad = Convert.ToInt32(item.Cantidad);
                        descuento = Convert.ToDecimal(item.Descuento);
                        fecha = Convert.ToDateTime(item.Fecha);
                        observacion = item.Observacion;
                    }
                }
            }

            return busc;
        }

        /// <summary>
        /// Buscar por ID del producto.
        /// </summary>
        /// <param name="nombre">ID del producto.</param>
        /// <returns>List</returns>
        public List<Ventas> BuscarxIDProducto(int id)
        {

            List<Ventas> busc = (from b in dbEntities.Ventas
                                      where b.ID_Producto == id
                                      select b).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    idcliente = Convert.ToInt32(item.ID_Cliente);
                    idproducto = Convert.ToInt32(item.ID_Producto);
                    idusuario = Convert.ToInt32(item.ID_Usuario);
                    precio = Convert.ToDecimal(item.Precio_Unidad);
                    cantidad = Convert.ToInt32(item.Cantidad);
                    descuento = Convert.ToDecimal(item.Descuento);
                    fecha = Convert.ToDateTime(item.Fecha);
                    observacion = item.Observacion;
                }
            }
            return busc;
        }

        /// <summary>
        /// Buscar por ID del Cliente.
        /// </summary>
        /// <param name="nombre">ID del cliente.</param>
        /// <returns>List</returns>
        public List<Ventas> BuscarxIDCliente(int id)
        {
            List<Ventas> busc = (from b in dbEntities.Ventas
                                      where b.ID_Cliente == id
                                      select b).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    idcliente = Convert.ToInt32(item.ID_Cliente);
                    idproducto = Convert.ToInt32(item.ID_Producto);
                    idusuario = Convert.ToInt32(item.ID_Usuario);
                    precio = Convert.ToDecimal(item.Precio_Unidad);
                    cantidad = Convert.ToInt32(item.Cantidad);
                    descuento = Convert.ToDecimal(item.Descuento);
                    fecha = Convert.ToDateTime(item.Fecha);
                    observacion = item.Observacion;
                }
            }
            return busc;
        }

        List<AgregarVentas> agregarVentasList = new List<AgregarVentas>();
        /// <summary>
        /// Agregar Productos a la venta.
        /// </summary>
        /// <returns>List select</returns>
        public List<AgregarVentas> AgregarProductos(int clientes, int productos, decimal precio, int cantidad, int desc, string obs)
        {
            // Tipo anonimo 

            agregarVentasList.Add(new AgregarVentas{ Producto = productos, Precio = precio, Cantidad = cantidad, Descuento = desc });

            // selec.
            return agregarVentasList;
        }

    }

  public class AgregarVentas
  {     
      public int Producto { get; set; }
      public decimal Precio { get; set; }
      public int Cantidad { get; set; }
      public double Descuento { get; set; }
      public decimal PrecioNeto { get; set; }     
  }
}
