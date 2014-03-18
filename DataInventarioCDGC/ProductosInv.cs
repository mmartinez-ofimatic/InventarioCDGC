using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.EntityClient;

namespace DataInventarioCDGC
{
   public class ProductosInv
    {

    InventarioCDGCEntities dbEntities = new InventarioCDGCEntities();
    public int idproducto { get; set; }
    public string producto { get; set; }
    public double precio { get; set; }

    /// <summary>
    /// Guarda un producto.
    /// </summary>
    /// <returns>bool</returns>
    public bool Guardar()
    {
        bool isComplete = false;

        try
        {
            Productos product = new Productos();
            product.ID_Producto = idproducto;
            product.Producto = producto;
            product.Precio_Venta = Convert.ToDecimal(precio);

            dbEntities.AddToProductos(product);
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
    /// Modifica un producto.
    /// </summary>
    public bool Modificar()
    {
        bool isComplete = false;
        try
        {
            Productos update = (from upd in dbEntities.Productos
                                  where upd.ID_Producto == idproducto
                                  select upd).First();

            update.ID_Producto = idproducto;
            update.Producto = producto;
            update.Precio_Venta = Convert.ToDecimal(precio);
            
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
    /// Borra un producto.
    /// </summary>
    /// <returns>bool isComplete</returns>
    public bool Borrar()
    {
        bool isComplete = false;

        try
        {
            Productos borrar = (from bor in dbEntities.Productos
                                  where bor.ID_Producto == idproducto
                                  select bor).FirstOrDefault();

            dbEntities.Productos.DeleteObject(borrar);
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
    /// Lista de todos los productos.
    /// </summary>
    /// <returns>List select</returns>
    public List<Productos> BuscarTodos()
    {
        var selec = (from s in dbEntities.Productos
                     select s).ToList();

        return selec;
    }

    }
}
