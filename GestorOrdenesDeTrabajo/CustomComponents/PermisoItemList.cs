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
using BussinessLayer.UsesCases;

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    public partial class PermisoItemList : UserControl
    {
        bool isOn = false;
        private Modulo modulo;
        private readonly int idUser;

        public PermisoItemList(Modulo m, int IdUser, bool isOn)
        {
            InitializeComponent();
            StatusPanel.DoubleBuffered(true);
            this.modulo = m;
            idUser = IdUser;
            this.isOn = isOn;
            resaltarItem(isOn);
            lblDesc.Text = modulo.Descripcion;
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
            var permiso = new UsuarioModulo()
            {
                IdUsuario = idUser,
                IdModulo = modulo.Id,
                IsEnabled = isOn
            };
            if (isOn)
                UsuarioPermisoController.I.Add(permiso);
            else
                UsuarioPermisoController.I.DeleteByPermiso(permiso);
        }
    }
}
