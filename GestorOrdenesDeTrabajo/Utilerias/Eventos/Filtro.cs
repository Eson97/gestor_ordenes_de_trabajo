using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Utilerias.Eventos
{
    public static class Filtro
    {
        public static void Direccion(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == (char)Keys.Space) return;
            if (c == (char)Keys.Back) return;
            if (char.IsLetterOrDigit(c)) return;
            if (c.Equals("#")) return;

            e.Handled = true;
        }

        public static void SoloLetras(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c)) return;
            if (c == (char)Keys.Back) return;
            if (c == ' ') return;
            e.Handled = true;
        }


        public static void SoloNumeros(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == (char)Keys.Back) return;
            if (char.IsNumber(c)) return;
            e.Handled = true;
        }

        public static void Telefono(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == (char)Keys.Back) return;
            if (char.IsNumber(c)) return;
            if (c == '(' || c == ')' || c == '-') return;

            e.Handled = true;
        }

        public static void Alfanumerico(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            // if (char.IsControl(c)) return;
            if (c == (char)Keys.Back) return;
            if (char.IsLetterOrDigit(c)) return;

            e.Handled = true;
        }

        public static void AlfanumericoSpace(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == (char)Keys.Space) return;
            if (c == (char)Keys.Back) return;
            if (char.IsLetterOrDigit(c)) return;

            e.Handled = true;
        }

        public static void AlfanumericoSpaceComa(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == (char)Keys.Space) return;
            if (c == (char)Keys.Back) return;
            if (c == (char)',') return;
            if (c == (char)'.') return;
            if (char.IsLetterOrDigit(c)) return;
            e.Handled = true;
        }
        public static void AlfanumericoSpaceComaPunto(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == (char)Keys.Space) return;
            if (c == (char)Keys.Back) return;
            if (c == (char)',') return;
            if (c == (char)'.') return;
            if (char.IsLetterOrDigit(c)) return;
            e.Handled = true;
        }

    }
}
