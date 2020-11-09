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
            StatusPanel.DoubleBuffered(true);
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
            StatusPanel.DoubleBuffered(true);
            resaltarItem(isOn);
        }

        public bool Status { get => isOn; }

        void resaltarItem(bool b)
        {
            if (b)
                this.StatusPanel.BackColor = Color.Green;
            else
                this.StatusPanel.BackColor = Color.Firebrick;
        }

        private void PermisoItemList_Click(object sender, EventArgs e)
        {
            isOn = !isOn; //se cambia el estado
            resaltarItem(isOn);
        }
    }
}
