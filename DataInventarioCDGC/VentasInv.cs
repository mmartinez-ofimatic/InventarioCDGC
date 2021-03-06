﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;

namespace DataInventarioCDGC
{
  public class VentasInv
    {
        public int idventa { get; set; }
        public int idcliente { get; set; }
        public int iDproducto { get; set; }
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
                db.SaveChanges(SaveOptions.DetectChangesBeforeSave);
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
       /* public List<Venta> BuscarTodos()
        {
            var selec = (from s in dbEntities.Ventas
                         select s).ToList();
            return selec;
        }*/



        /// <summary>
        /// Lista de las Ultimas Ventas vwVentas.
        /// </summary>
        /// <returns>List</returns>
        public List<vwVenta> BuscarUltimasVentasVista()
        {
            var selec = (from s in dbEntities.vwVentas
                         select s).Take(15).OrderByDescending(x => x.ID_Venta).ToList();
            return selec;
        }

        /// <summary>
        /// Busqueda por ID Vista ventas.
        /// </summary>
        /// <returns>List</returns>
        public List<vwVenta> BuscarxIDVista(int idvent)
        {

            List<vwVenta> busc = (from b in dbEntities.vwVentas
                                    where b.ID_Venta == idvent
                                    select b).ToList();

            return busc;
        }

        /// <summary>
        /// Buscar por nombre Vista.
        /// </summary>
        /// <param name="nombre">nombre del cliente.</param>
        /// <returns>List</returns>
        public List<vwVenta> BuscarxNombreClienteVista(string nombre)
        {

            List<vwVenta> busc = (from b in dbEntities.vwVentas
                                    where b.Cliente.Contains(nombre)
                                    select b).OrderByDescending(x => x.ID_Venta).ToList();

            return busc;


        }




        ///// <summary>
        ///// Lista de Detalles de Ventas.
        ///// </summary>
        ///// <returns>List</returns>
        //public List<VentaDetalle> BuscarDetallesVentas(int id)
        //{
        //    var selec = (from s in dbEntities.VentaDetalles
        //                 where s.ID_Venta == id
        //                 select s).ToList();

        //    return selec;
        //}

        /// <summary>
        /// Lista de Detalles de Ventas.
        /// </summary>
        /// <returns>List</returns>
        public List<vwFactura> BuscarDetallesVentas(int id)
        {
            InventarioCDGCEntities1 dbent = new InventarioCDGCEntities1();

            var selec = (from s in dbent.vwFacturas
                                    where s.ID_Venta == id
                                    select s).ToList();

            return selec;
        }

        /// <summary>
        /// Lista de las Ultimas Ventas.
        /// </summary>
        /// <returns>List</returns>
        public List<vwFactura> BuscarUltimasVentas()
        {
            var selec = (from s in dbEntities.vwFacturas
                         select s).Take(15).OrderByDescending(x=>x.ID_Venta).ToList();
            return selec;
        }

        /// <summary>
        /// Busqueda por ID.
        /// </summary>
        /// <returns>List</returns>
        public List<vwFactura> BuscarxID(int idvent)
        {

            List<vwFactura> busc = (from b in dbEntities.vwFacturas
                                where b.ID_Venta == idvent
                                    select b).ToList();
           
            return busc;
        }

        /// <summary>
        /// Buscar por nombre.
        /// </summary>
        /// <param name="nombre">nombre del cliente.</param>
        /// <returns>List</returns>
        public List<vwFactura> BuscarxNombreCliente(string nombre)
        {

            List<vwFactura> busc = (from b in dbEntities.vwFacturas
                                  where b.Cliente.Contains(nombre)
                                  select b).OrderByDescending(x => x.ID_Venta).ToList();

            return busc;

            
        }

        /// <summary>
        /// Buscar por nombre del producto.
        /// </summary>
        /// <param name="nombre">nombre del producto.</param>
        /// <returns>List</returns>
        public List<vwFactura> BuscarxNombreProducto(string nom)
        {

            List<vwFactura> busc = (from b in dbEntities.vwFacturas
                                    where b.Producto.Contains(nom)
                                    select b).OrderByDescending(x => x.ID_Venta).ToList();

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
      public Dictionary<string, string> Producto { get; set; }
      public decimal Precio { get; set; }
      public int Cantidad { get; set; }
      public double Descuento { get; set; }
      //public double DescuentoNeto { get; set; }
      public decimal PrecioNeto { get; set; }

      List<AgregarVentas> Lista = new List<AgregarVentas>();
      //Dictionary<int, string> Productokey { get; set; }
      
      public List<AgregarVentas> addList(Dictionary<string,string> fproducto, decimal fprecio, int fcantidad, double fdescuento)
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

      public TransationsVentas transVenta = new TransationsVentas();

      public void listaGuardar(List<AgregarVentas> lista)
      {

          var filtro = (from c in lista
                        select new
                        {
                            IDProducto = c.Producto.Select(x => x.Key).Single(),
                            Producto = c.Producto.Select(x => x.Value).Single(),
                            c.Precio,
                            c.Cantidad,
                            c.Descuento,
                            c.PrecioNeto
                        }).ToList();

          foreach (var item in filtro)
          {
              transVenta.idproducto = item.IDProducto.ToString();
              transVenta.precio = item.Precio;
              transVenta.cantidad = item.Cantidad;
              transVenta.descuento = Convert.ToDecimal(item.Descuento);

              //transVenta.transationsVentas();
          }
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

      public List<AgregarVentas> UpdateList(Dictionary<string,string> idproducto, string id, decimal fprecio, int fcantidad, double fdescuento)
      {

          var buscar = from b in Lista
                       where b.Producto.Select(x => x.Key).Single() ==  id //idproducto.Select(y => y.Key).Single()
                       select b;
          //var buscar = from b in Lista
          //             where b.Producto.Select(x => x.Key).Single() == idproducto.Select(y=> y.Key).Single()
          //             select b;

          decimal fprecioBruto = fprecio * fcantidad;
          double fdescuentoNeto = (double)fprecioBruto * (fdescuento / 100.00);

          foreach (var l in buscar)
          {
              //l.Producto = idproducto;
              l.Precio = fprecio;
              l.Cantidad = fcantidad;
              l.Descuento = fdescuento;
              l.PrecioNeto = fprecioBruto - (decimal)fdescuentoNeto;
          }

          return Lista;

      }

      public bool ExistProductList(string idproducto)
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

          if (Producto != null)
          {
              Producto.Clear();
          }
         
      }

  }
}
