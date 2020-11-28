using GestorOrdenesDeTrabajo.Ventanas.Ventanas_Emergentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //CON ESTO YA FUNKA, PEEEERO NO SE QUE TANTO IMPACTE AL RENDIMIENTO EL RESTART, LO PUEDO HACER DISTINTO

            //Application.Run(new LoginDialog());




            //DataLayer.Usuario user;
            //do
            //{

            //    user = LoginDialog.showLogin();
            //    if (user != null) Application.Run(new Main(user));

            //} while (user != null); 

            //LoginDialog login = new LoginDialog();

            if (true)
            {
                Application.Run(new Main(null));
                return;
            }

            //Application.Run(login);
            //var LogedUser = login.CurrentUser;

            //if (LogedUser != null)
            //    Application.Run(new Main(LogedUser));

        }
    }
}
