using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Usuarios
{
    public partial class Usuarios : Form
    {
        /**
         * @todo terminar parte logica de form usuarios
         * @body agregar todo el funcionamiento del form
         */



        public Usuarios()
        {
            InitializeComponent();
        }

        private void permisosContainerPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                //DESPLEGAR CRUD PERMISOS
            }
        }
    }
}
