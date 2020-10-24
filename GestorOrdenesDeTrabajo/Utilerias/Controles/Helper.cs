using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Utilerias.Controles
{
    //TODO hacer static?
    public class Helper
    {
        /// <summary>
        /// Reviza si tiene algo el Control
        /// </summary>
        /// <param name="f">Recibe un textBox</param>
        /// <returns>true si esta vacio</returns>
        public static bool Vacio(Control f)
        {
            if (f.Text == null) return true;
            if (f.Text.Trim().Length == 0) return true;
            return false;
        }

        /// <summary>
        /// Elimina texto de todos los controles
        /// </summary>
        /// <param name="control">Recibe lista de Controles</param>
        public static void VaciarTexto(params Control[] control)
        {
            foreach (Control c in control)
            {
                c.Text = string.Empty;
            }
        }

        /// <summary>
        /// Reviza si los controles contienen texto
        /// </summary>
        /// <param name="control">Lista de controles</param>
        /// <returns>true todos tienen texto</returns>
        public static bool Llenos(params Control[] control)
        {
            // return control.Where(c => Vacio(c)).ToList().Count == 0;
            foreach (Control c in control)
            {
                if (Vacio(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
