using BussinessLayer.UsesCases;
using DataLayer;
using GestorOrdenesDeTrabajo.CustomComponents;
using GestorOrdenesDeTrabajo.Utilerias.Controles;
using GestorOrdenesDeTrabajo.Utilerias.Eventos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Usuarios
{
    public partial class UsuariosNuevo_Mod : Form
    {
        Usuario currentUser;
        public UsuariosNuevo_Mod(Usuario user)
        {
            InitializeComponent();
            this.currentUser = user;
            fillData();
        }
        public UsuariosNuevo_Mod()
        {
            InitializeComponent();
        }

        void fillData()
        {
            if (currentUser == null)
                return;
            txtUsuario.Text = currentUser.Usuario1;
            txtPassword.Text = currentUser.Password;
        }
        void FillPermisos()
        {
            if (currentUser == null)
                return;
            permisosContainerPanel.Controls.Clear();
            var asigned = UsuarioPermisoController.I.GetListaPermisoByUsuario(currentUser.Id).Select(el => new PermisoItemList(el, currentUser.Id, true));
            var notAsigned = UsuarioPermisoController.I.GetListaExcludePermisoByUsuario(currentUser.Id).Select(el => new PermisoItemList(el, currentUser.Id, false));
            var permisos = asigned.Concat(notAsigned);

            foreach (var item in permisos)
                permisosContainerPanel.Controls.Add(item);
        }

        private void UsuariosNuevo_Mod_Load(object sender, EventArgs e)
        {
            FillPermisos();
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            //TODO min length password?
            bool isValid = Helper.Llenos(txtUsuario, txtPassword);
            if (!isValid)
            { MessageBox.Show("Introduzca un usuario y una contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (currentUser == null)
            {
                currentUser = UsuarioController.I.Add(new Usuario()
                {
                    Usuario1 = txtUsuario.Text,
                    Password = txtPassword.Text
                });
            }
            else
            {
                currentUser.Usuario1 = txtUsuario.Text;
                currentUser.Password = txtPassword.Text;
                currentUser = UsuarioController.I.Edit(currentUser);
            }

            if (currentUser == null)
                MessageBox.Show("No se pudo agregar o editar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            currentUser = null;
            Helper.VaciarTexto(txtUsuario, txtPassword);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.Alfanumerico(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Filtro.Alfanumerico(e);
            Char c = e.KeyChar;
            if (c == (char)Keys.Enter) btnAcept_Click(sender, e);
        }
    }
}
