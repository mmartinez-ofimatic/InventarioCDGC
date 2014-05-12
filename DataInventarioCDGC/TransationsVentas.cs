using System;
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
        VentasInv venta = new VentasInv();
        ventaDetalles ventaDetalle = new ventaDetalles();


        public int idventa { get; set; }
        public int idcliente { get; set; }
        public string idproducto { get; set; }
        public int idusuario { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public decimal descuento { get; set; }
        public string observacion { get; set; }
        public DateTime fecha { get; set; }

        public bool estadoGuardado = false;
        public bool savecommit = false;

       public InventarioCDGCEntities1 db = new InventarioCDGCEntities1();
       public InventarioCDGCEntities1 db1 = new InventarioCDGCEntities1();
       public TransactionScope transScope;

        public bool transationsVentas()
        {
            //bool savecommit = false;

            using (transScope = new TransactionScope())
            {
                try
                {
                    if (!estadoGuardado)
                    {
                        Venta ventas = new Venta();
                        ventas.ID_Cliente = idcliente;
                        //falata el id de usuario
                        ventas.ID_Usuario = null;
                        ventas.Observacion = observacion;
                        ventas.Fecha = DateTime.Now;

                        db.AddToVentas(ventas);
                        db.SaveChanges(SaveOptions.DetectChangesBeforeSave);
                        estadoGuardado = true;
                    }
                
                    VentaDetalle ventasDetalle = new VentaDetalle();
                    ventasDetalle.ID_Venta = 5;
                    ventasDetalle.ID_Producto = idproducto;
                    ventasDetalle.Precio_Unidad = precio;
                    ventasDetalle.Cantidad = cantidad;
                    ventasDetalle.Descuento = descuento;

                    db1.AddToVentaDetalles(ventasDetalle);
                    db1.SaveChanges(SaveOptions.DetectChangesBeforeSave);


                    //venta.Guardar();
                    //ventaDetalle.Guardar();

                    //transScope.Complete();
                    //db.AcceptAllChanges();
                    //db1.AcceptAllChanges();
                    savecommit = true;
                  
                }
                catch (Exception)
                {
                    
                   //rollback
                }
       
            }

            return savecommit;
        }


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