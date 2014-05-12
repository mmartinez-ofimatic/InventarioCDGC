using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.EntityClient;
using System.Data.Objects;

namespace DataInventarioCDGC
{
    class ventaDetalles
    {
        InventarioCDGCEntities1 dbEntities = new InventarioCDGCEntities1();

        public int idventa { get; set; }
        public string idproducto { get; set; }      
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public decimal descuento { get; set; }
       
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
                VentaDetalle ventasDetalle = new VentaDetalle();
                ventasDetalle.ID_Venta = idventa;
                ventasDetalle.ID_Producto = idproducto;
                ventasDetalle.Precio_Unidad = precio;
                ventasDetalle.Cantidad = cantidad;
                ventasDetalle.Descuento = descuento;

                db.AddToVentaDetalles(ventasDetalle);
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
        /// Lista de todas las ventas.
        /// </summary>
        /// <returns>List select</returns>
        public List<VentaDetalle> BuscarTodos()
        {
            var selec = (from s in dbEntities.VentaDetalles
                         select s).ToList();
            return selec;
        }

        /// <summary>
        /// Busqueda por ID.
        /// </summary>
        /// <returns>List</returns>
        public List<VentaDetalle> BuscarxIDVenta(int id)
        {

            List<VentaDetalle> busc = (from b in dbEntities.VentaDetalles
                                where b.ID_Venta == id
                                select b).ToList();
            if (busc != null)
            {
                if (busc.Count != 0)
                {
                    foreach (var item in busc)
                    {
                        idventa = Convert.ToInt32(item.ID_Venta);

                        idproducto = item.ID_Producto;
                        precio = Convert.ToDecimal(item.Precio_Unidad);
                        cantidad = Convert.ToInt32 (item.Cantidad);
                        descuento = Convert.ToDecimal(item.Descuento);

                    }
                }
            }

            return busc;
        }

        /// <summary>
        /// Buscar por ID del Detalle.
        /// </summary>
        /// <param name="nombre">ID del Detalle.</param>
        /// <returns>List</returns>
        public List<VentaDetalle> BuscarxIDDetalle(int id)
        {
            List<VentaDetalle> busc = (from b in dbEntities.VentaDetalles
                                where b.ID_Detalle == id
                                select b).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    idventa = Convert.ToInt32(item.ID_Venta);
                    idproducto = item.ID_Producto;
                    precio = Convert.ToDecimal(item.Precio_Unidad);
                    cantidad = Convert.ToInt32(item.Cantidad);
                    descuento = Convert.ToDecimal(item.Descuento);
                }
            }
            return busc;
        }
    }
}
