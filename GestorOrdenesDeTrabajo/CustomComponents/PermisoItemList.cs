using System;
using System.Drawing;
using System.Windows.Forms;
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.UsesCases;

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    public partial class PermisoItemList : UserControl
    {
        bool isOn = false;
        private Permiso modulo;
        private readonly int idUser;

        public PermisoItemList(Permiso m, int IdUser, bool isOn)
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
            var permiso = new UsuarioPermiso()
            {
                IdUsuario = idUser,
                IdPermiso = modulo.Id,
            };
            if (isOn)
                UsuarioPermisoController.I.Add(permiso);
            else
                UsuarioPermisoController.I.DeleteByPermiso(permiso);
        }
    }
}
