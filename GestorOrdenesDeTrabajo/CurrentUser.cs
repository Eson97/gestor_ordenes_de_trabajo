using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.UsesCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorOrdenesDeTrabajo
{

    public static class CurrentUser
    {
        private static Usuario _usuario = null;
        private static IList<Permiso> permisos;

        public static Usuario User {
            get => _usuario;
            set {
                _usuario = value;
                permisos = UsuarioPermisoController.I.GetListaPermisoByUsuario(_usuario.Id);
            }
        }
        public static IList<Permiso> Permisos
        {
            get => permisos;
        }
    }
}
