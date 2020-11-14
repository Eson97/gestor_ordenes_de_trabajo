using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    public partial class infoPanel : UserControl
    {
        string tittle;
        decimal info;

        public infoPanel()
        {
            InitializeComponent();
        }

        public infoPanel(string tittle, decimal info)
        {
            InitializeComponent();
            updateData(tittle,info);
        }

        public string Titulo { get => tittle; private set => tittle = value; }
        public decimal Info { get => info; private set => info = value; }

        internal void updateData(string titulo,decimal info)
        {
            Titulo = titulo;
            Info = info;

            lblInfo.Text = info.ToString("C2");
            lblTittle.Text = tittle;
        }

    }
}
