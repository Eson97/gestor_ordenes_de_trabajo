using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    public partial class PermisoItemList : UserControl
    {
        /**
         * @todo Funcionamiento de PermisoItemList
         */

        bool isOn = false;
        Modulo modulo;
        public PermisoItemList(Modulo m)
        {
            InitializeComponent();
            this.modulo = m;

            /**
             * @todo agregar validacion de estado
             * @body hacer que en caso de estar activo se muestre resaltado ( agregar directamente en el constructor? )
             */

            resaltarItem(isOn);

        }
        public PermisoItemList()
        {
            InitializeComponent();
        }

        void resaltarItem(bool b)
        {
            if (b)
                this.BackColor = Color.FromArgb(55, 55, 55);
            else
                this.BackColor = Color.FromArgb(45, 45, 45);
        }

        private void lblDesc_Click(object sender, EventArgs e)
        {
            isOn = !isOn; //se cambia el estado
            resaltarItem(isOn);
        }
    }
}
