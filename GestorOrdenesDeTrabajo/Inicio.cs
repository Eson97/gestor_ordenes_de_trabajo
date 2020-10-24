using System;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            tlpCont.DoubleBuffered(true);
            tlpMargen.DoubleBuffered(true);
            lblDate.DoubleBuffered(true);
            lblHour.DoubleBuffered(true);
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            lblDate.Text = "  " + DateTime.Now.Date.ToString("D");
            lblHour.Text = DateTime.Now.ToString("T");
            DateTimeGetterInicio.Start();
        }

        private void DateTimeGetterInicio_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.ToString("T");
        }
    }

}
