using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;

namespace DataInventarioCDGC
{
  public class UsuarioInv
    {
        public int IDusuario { get; set; }
        public int IDrol { get; set; }
        public string nomusuario { get; set; }
        public string contrasena { get; set; }


        InventarioCDGCEntities1 db = new InventarioCDGCEntities1();


        public bool ValidateUsers(string nombre, string pass)
        {
            bool valido = false;

            Usuario usuario = db.Usuarios.FirstOrDefault(x => x.Nombre == nombre && x.Contrasena == pass);

            if (usuario != null)
            {
                IDrol = Get_Rol(nombre, pass);
                nomusuario = nombre;
                valido = true;
            }

            return valido;
        }

        public static int Get_Rol(string nom, string pass)
        {
         
            InventarioCDGCEntities1 db = new InventarioCDGCEntities1();

            var selec = (from s in db.Usuarios
                         where s.Nombre == nom && s.Contrasena == pass
                         select s.ID_Rol).First();

            return Convert.ToInt32(selec);
        }



        /// <summary>
        /// Guarda un usuario en la base de datos.
        /// </summary>
        public bool Guardar()
        {
            bool isComplete = false;

            Usuario usuario = new Usuario();

            try
            {
                usuario.ID_Rol = IDrol;
                usuario.Nombre = nomusuario;
                usuario.Contrasena = contrasena;
                db.AddToUsuarios(usuario);
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
        /// Modifica un usuario.
        /// </summary>
        public bool Modificar()
        {
            bool isComplete = false;

            try
            {
                Usuario update = (from upd in db.Usuarios
                                where upd.ID_Usuario == IDusuario
                                select upd).First();

                update.ID_Rol = IDrol;
                update.Nombre = nomusuario;
                update.Contrasena = contrasena;
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
        /// Borra un usuario.
        /// </summary>
        /// <returns>bool isComplete</returns>
        public bool Borrar()
        {
            bool isComplete = false;

            try
            {
                Usuario borrar = (from bor in db.Usuarios
                                where bor.ID_Usuario == IDusuario
                                select bor).FirstOrDefault();

                db.Usuarios.DeleteObject(borrar);
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
        /// Lista de todos los usuarios.
        /// </summary>
        /// <returns>List select</returns>
        public List<Usuario> BuscarTodos()
        {
            var selec = (from s in db.Usuarios
                         select s).ToList();
            return selec;
        }

        /// <summary>
        /// Busqueda por ID.
        /// </summary>
        /// <returns>List</returns>
        public List<Usuario> BuscarxID()
        {
            List<Usuario> busc = (from b in db.Usuarios
                                where b.ID_Usuario == IDusuario
                                select b).ToList();
            if (busc != null)
            {
                if (busc.Count != 0)
                {
                    foreach (var item in busc)
                    {
                        IDrol = Convert.ToInt32(item.ID_Rol);
                        nomusuario = item.Nombre;
                        contrasena = item.Contrasena;
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
        public List<Usuario> BuscarxNombre(string nombre)
        {

            List<Usuario> busc = (from b in db.Usuarios
                                where b.Nombre == nombre
                                select b).ToList();
            if (busc != null)
            {
                foreach (var item in busc)
                {
                    IDrol = Convert.ToInt32(item.ID_Rol);
                    nomusuario = item.Nombre;
                    contrasena = item.Contrasena;
                }
            }
            return busc;
        }

    

    }
}
