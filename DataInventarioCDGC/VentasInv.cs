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

        InventarioCDGCEntities1 dbEntities = new InventarioCDGCEntities1();

        /// <summary>
        /// Guarda una venta.
        /// </summary>
       /// <returns>bool isComplete</returns>
        public bool Guardar()
        {
            bool isComplete = false;
            try
            {
                InventarioCDGCEntities1 db = new InventarioCDGCEntities1();
                Venta ventas = new Venta();
                ventas.ID_Cliente = idcliente;
                //falata el id de usuario
                ventas.ID_Usuario = null;
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
                Venta update = (from upd in dbEntities.Ventas
                                      where upd.ID_Venta == idventa
                                      select upd).First();

                update.ID_Cliente = idcliente;
                //Poner el di de usuario loguiado.
                update.ID_Usuario = null;
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
                Venta borrar = (from bor in dbEntities.Ventas
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
        public List<Venta> BuscarTodos()
        {
            var selec = (from s in dbEntities.Ventas
                         select s).ToList();
            return selec;
        }

        /// <summary>
        /// Busqueda por ID.
        /// </summary>
        /// <returns>List</returns>
        public List<Venta> BuscarxID()
        {

            List<Venta> busc = (from b in dbEntities.Ventas
                                      where b.ID_Venta == idventa
                                      select b).ToList();
            if (busc != null)
            {
                if (busc.Count != 0)
                {
                    foreach (var item in busc)
                    {
                        idcliente = Convert.ToInt32(item.ID_Cliente);

                        idusuario = Convert.ToInt32(item.ID_Usuario);
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
       /* public List<Venta> BuscarxIDProducto(int id)
        {

            List<Venta> busc = (from b in dbEntities.Ventas
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
        }*/

        /// <summary>
        /// Buscar por ID del Cliente.
        /// </summary>
        /// <param name="nombre">ID del cliente.</param>
        /// <returns>List</returns>
        public List<Venta> BuscarxIDCliente(int id)
        {
            List<Venta> busc = (from b in dbEntities.Ventas
                                      where b.ID_Cliente == id
                                      select b).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    idcliente = Convert.ToInt32(item.ID_Cliente);
                    idusuario = Convert.ToInt32(item.ID_Usuario);
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

           // agregarVentasList.Add(new AgregarVentas{ Producto = productos, Precio = precio, Cantidad = cantidad, Descuento = desc });

            // selec.
            return agregarVentasList;
        }

    }

  public class AgregarVentas
  {
      public Dictionary<int, string> Producto { get; set; }
      public decimal Precio { get; set; }
      public int Cantidad { get; set; }
      public double Descuento { get; set; }
      public decimal PrecioNeto { get; set; }

      List<AgregarVentas> Lista = new List<AgregarVentas>();
      //Dictionary<int, string> Productokey { get; set; }
      
      public List<AgregarVentas> addList(Dictionary<int,string> fproducto, decimal fprecio, int fcantidad, double fdescuento)
      {       
              decimal fprecioBruto = fprecio * fcantidad;
              double fdescuentoNeto = (double)fprecioBruto * (fdescuento / 100.00);

              Lista.Add(new AgregarVentas
              {
                  Producto = fproducto,
                  Precio = fprecio,
                  Cantidad = fcantidad,
                  Descuento = fdescuento,
                  PrecioNeto = fprecioBruto - (decimal)fdescuentoNeto
              });

          return Lista;
      }


      public List<AgregarVentas> RemoveList(int index)
      {
          try
          {
              Lista.RemoveAt(index);
          }
          catch (Exception)
          {              
              throw;
          }

          return Lista;
      }

      public List<AgregarVentas> UpdateList(Dictionary<int,string> idproducto, decimal fprecio, int fcantidad, double fdescuento)
      {

          var buscar = from b in Lista
                       where b.Producto.Select(x=> x.Value) == idproducto.Select(y => y.Value)
                       select b;
          //var buscar = from b in Lista
          //             where b.Producto.Select(x => x.Key).Single() == idproducto.Select(y=> y.Key).Single()
          //             select b;

          decimal fprecioBruto = fprecio * fcantidad;
          double fdescuentoNeto = (double)fprecioBruto * (fdescuento / 100.00);

          foreach (var l in buscar)
          {
              l.Producto = idproducto;
              l.Precio = fprecio;
              l.Cantidad = fcantidad;
              l.Descuento = fdescuento;
              l.PrecioNeto = fprecioBruto - (decimal)fdescuentoNeto;
          }

          return Lista;

      }

      public bool ExistProductList(int idproducto)
      {
          //bool exist = false;
          //foreach (var item in idproducto)
          //{
          //   exist = Lista.Exists(x => x.Producto.Where(y => y.Key.Equals(1));
          //}
          //return exist;
          return Lista.Exists(x => x.Producto.Select(y=>y.Key).Single() == idproducto);
      }

      public void EraserList()
      {
          Lista.Clear();
      }

  }
}
