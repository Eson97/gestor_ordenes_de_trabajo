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
        private string _tittle;
        private decimal _info;
        private bool _isMoney = false;

        public infoPanel()
        {
            InitializeComponent();
        }

        public infoPanel(string tittle, decimal info,bool isMoney)
        {
            InitializeComponent();
            updateData(tittle,info);
            _isMoney = isMoney;
        }

        public string Titulo { get => _tittle; set { _tittle = value; lblTittle.Text = _tittle; } }
        public decimal Info { get => _info; set { _info = value; lblInfo.Text = (_isMoney) ? _info.ToString("C2") : _info.ToString(); } }

        internal void updateData(string titulo,decimal info)
        {
            Titulo = titulo;
            Info = info;

            lblInfo.Text = info.ToString("C2");
            lblTittle.Text = _tittle;
        }

    }
}
