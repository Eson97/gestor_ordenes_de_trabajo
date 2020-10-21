using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Buscar
{
    public partial class SrchDetailInfo : Form
    {
        public SrchDetailInfo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SrchDetailInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnPiezas_Click(object sender, EventArgs e)
        {
            //ABRIR NUEVA VENTANA DONDE SE OBSERVARAN LAS PIEZAS ADJUNTAS A LA ORDEN DE TRABAJO
        }
    }
}
