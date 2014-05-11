using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;

namespace DataInventarioCDGC
{
  public class RolInv
    {

        InventarioCDGCEntities1 db = new InventarioCDGCEntities1();

        public  int ID { get; set; }
        public  string rol { get; set; }
        public int permisos { get; set;}


    /// <summary>
    /// Guarda un rol en la base de datos.
    /// </summary>
    public bool Guardar ()
    {
        bool isComplete = false;

        Role roles = new Role();

        try
        {
            roles.Rol = rol;
            roles.Permisos = permisos;
            db.AddToRoles(roles);
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
    /// Modifica un rol.
    /// </summary>
    public bool Modificar()
    {
        bool isComplete = false;

        try
        {
            Role update = (from upd in db.Roles
                                  where upd.ID_Rol == ID
                                  select upd).First();

            update.Rol = rol;
            update.Permisos = permisos;
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
    /// Borra un rol.
    /// </summary>
    /// <returns>bool isComplete</returns>
    public bool Borrar()
    {
        bool isComplete = false;
       
        try
        {
            Role borrar = (from bor in db.Roles
                                  where bor.ID_Rol == ID
                                  select bor).FirstOrDefault();

            db.Roles.DeleteObject(borrar);
            db.SaveChanges();

            isComplete = true;
        }
        catch (Exception)
        {
            throw;
        }

        return isComplete;
    }


      
    public int GetPermisos(int ID)
    {
        try
        {
            int selectquery = Convert.ToInt32((from p in db.Roles
                                 where p.ID_Rol == ID
                                 select p.Permisos).First());

            return selectquery;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public string GetNombreRol(int ID)
    {
        try
        {
            string selectquery = (from p in db.Roles
                                    where p.ID_Rol == ID
                                    select p.Rol).First();

            return selectquery;
        }
        catch (Exception)
        {
            throw;
        }
    }


    /// <summary>
    /// Lista de todos los roles.
    /// </summary>
    /// <returns>List select</returns>
    public List<Role> BuscarTodos()
    {
        var selec = (from s in db.Roles
                     select s).ToList();
        return selec;
    }

    /// <summary>
    /// Busqueda por ID.
    /// </summary>
    /// <returns>List</returns>
    public List<Role> BuscarxID()
    {
        List<Role> busc = (from b in db.Roles
                                  where b.ID_Rol == ID
                                  select b).ToList();
        if (busc != null)
        {
            if (busc.Count != 0)
            {
                foreach (var item in busc)
                {
                    rol = item.Rol;
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
    public List<Role> BuscarxNombre(string nombre)
    {

        List<Role> busc = (from b in db.Roles
                                  where b.Rol == nombre
                                  select b).ToList();
        if (busc != null)
        {
            foreach (var item in busc)
            {
                nombre = item.Rol;     
            }
        }
        return busc;
    }


    }
}
