﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.EntityClient;
using System.Transactions;
using System.Data.Objects;

namespace DataInventarioCDGC
{
   public class TransationsVentas
    {
        InventarioCDGCEntities1 dbEntities = new InventarioCDGCEntities1();
        //VentasInv venta = new VentasInv();
        ventaDetalles ventaDetalle = new ventaDetalles();
       
        public static int idventa { get; set; }
        public int idcliente { get; set; }
        public string idproducto { get; set; }
        public int idusuario { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public decimal descuento { get; set; }
        public string observacion { get; set; }
        public DateTime fecha { get; set; }

       InventarioCDGCEntities1 db = new InventarioCDGCEntities1();
       InventarioCDGCEntities1 db1 = new InventarioCDGCEntities1();
       AlmacenIn almacen = new AlmacenIn();

       public TransactionScope transScope ;


        public bool transationsVentas(List<AgregarVentas> listaVenta)
        {
            bool savecommit = false;

            using (transScope = new TransactionScope())
            {

                try
                {
                    //Guardar Venta
                        Venta ventas = new Venta();
                        ventas.ID_Cliente = idcliente;

                        ventas.ID_Usuario = UsuarioInv.IDusuario;
                        ventas.Observacion = observacion;
                        ventas.Fecha = DateTime.Now;
                           
                        db.AddToVentas(ventas);
                        db.SaveChanges(SaveOptions.DetectChangesBeforeSave);

                    var filtro = (from c in listaVenta
                                  select new
                                  {
                                      idProducto = c.Producto.Select(x => x.Key).Single(),
                                      Producto = c.Producto.Select(x => x.Value).Single(),
                                      c.Precio,
                                      c.Cantidad,
                                      c.Descuento,
                                      c.PrecioNeto
                                  }).ToList();

                    //Guardar Venta detalle
                    VentaDetalle ventasDetalle = new VentaDetalle();
                    
                    foreach (var item in filtro)
                    {
                        ventasDetalle.ID_Venta =  ventas.ID_Venta;
                        ventasDetalle.ID_Producto = item.idProducto;
                        ventasDetalle.Precio_Unidad = item.Precio;
                        ventasDetalle.Cantidad = item.Cantidad;
                        ventasDetalle.Descuento = Convert.ToDecimal(item.Descuento);
                        ventasDetalle.Total = item.PrecioNeto;

                        //Sacar productos del almacen
                        Almacen update = (from upd in dbEntities.Almacens
                                          where upd.ID_Producto == item.idProducto
                                          select upd).First();

                        update.Existencia = update.Existencia - item.Cantidad;



                        db1.AddToVentaDetalles(ventasDetalle);
                        db1.SaveChanges(SaveOptions.DetectChangesBeforeSave);
                        dbEntities.SaveChanges();
                    }


                   
                    dbEntities.SaveChanges();

                    idventa = ventas.ID_Venta;
                    
                    transScope.Complete();
                    db.AcceptAllChanges();
                    db1.AcceptAllChanges();
                    dbEntities.AcceptAllChanges();
                    savecommit = true;
                  
                }
                catch (Exception)
                {
                    
                   //rollback
                }
       
            }

            return savecommit;
        }


    }
}

/*using (TransactionScope scope = new TransactionScope())
{
    // Save changes but maintain context1 current state.
    context1.SaveChanges(SaveOptions.DetectChangesBeforeSave);

    // Save changes but maintain context2 current state.
    context2.SaveChanges(SaveOptions.DetectChangesBeforeSave);

    // Commit succeeded since we got here, then completes the transaction.
    scope.Complete();

    // Now it is safe to update context state.
    context1.AcceptAllChanges();
    context2.AcceptAllChanges();
}*/