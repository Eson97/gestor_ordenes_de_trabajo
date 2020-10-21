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
        string tittle, info;

        public infoPanel()
        {
            InitializeComponent();
        }

        public infoPanel(string tittle, string info)
        {
            InitializeComponent();
            this.Tittle = tittle;
            this.Info = info;
            updateData();
        }

        public string Tittle { get => tittle; set => tittle = value; }
        public string Info { get => info; set => info = value; }

        void updateData()
        {
            lblInfo.Text = info;
            lblTittle.Text = tittle;
        }

    }
}
