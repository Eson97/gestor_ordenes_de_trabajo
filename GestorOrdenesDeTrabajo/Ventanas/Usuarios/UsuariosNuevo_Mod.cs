using DataLayer;
using GestorOrdenesDeTrabajo.CustomComponents;
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
    public partial class UsuariosNuevo_Mod : Form
    {
        Usuario user;
        public UsuariosNuevo_Mod(object user)
        {
            InitializeComponent();
            user = user as Usuario;
        }

        void FillPermisos()
        {
            for (int i = 0; i < 5; i++)
            {
                permisosContainerPanel.Controls.Add(new PermisoItemList());
            }
        }

        private void UsuariosNuevo_Mod_Load(object sender, EventArgs e)
        {
            FillPermisos();
        }
    }
}
