using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.CustomComponents;
using GestorOrdenesDeTrabajo.Utilerias.Controles;
using GestorOrdenesDeTrabajo.Utilerias.Eventos;
using System;
using System.Linq;
using System.Windows.Forms;
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Validation;

namespace GestorOrdenesDeTrabajo.Ventanas.Usuarios
{
    public partial class UsuariosNuevo_Mod : Form
    {
        Usuario cUser;
        private bool ShowPass = true;
        private UsuarioValidator UsuarioValidator;
        public UsuariosNuevo_Mod(Usuario user)
        {
            UsuarioValidator = new UsuarioValidator();
            InitializeComponent();
            this.cUser = user;
            txtPassword.UseSystemPasswordChar = ShowPass;
            fillData();
        }
        public UsuariosNuevo_Mod()
        {
            UsuarioValidator = new UsuarioValidator();
            InitializeComponent();
        }

        void fillData()
        {
            if (cUser == null)
                return;
            txtUsuario.Text = cUser.Usuario1;
            txtPassword.Text = cUser.Password;
        }
        void FillPermisos()
        {
            Console.WriteLine("holi");
            if (cUser == null)
                return;
            permisosContainerPanel.Controls.Clear();
            var asigned = UsuarioPermisoController.I.GetListaPermisoByUsuario(cUser.Id).Select(el => new PermisoItemList(el, cUser.Id, true));
            var notAsigned = UsuarioPermisoController.I.GetListaExcludePermisoByUsuario(cUser.Id).Select(el => new PermisoItemList(el, cUser.Id, false));
            var permisos = asigned.Concat(notAsigned);

            foreach (var item in permisos)
                permisosContainerPanel.Controls.Add(item as PermisoItemList);
        }

        private void UsuariosNuevo_Mod_Load(object sender, EventArgs e)
        {
            FillPermisos();
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            bool isValid = Helper.Llenos(txtUsuario, txtPassword) && txtPassword.TextLength >= 8;
            if (!isValid)
            { MessageBox.Show("Introduzca un usuario y una contraseña validos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (cUser == null)
            {
                var newUser = new Usuario()
                {
                    Usuario1 = txtUsuario.Text,
                    Password = txtPassword.Text
                };
                var res = UsuarioValidator.Validate(newUser);
                if (ShowErrorValidation.Valid(res))
                    cUser = UsuarioController.I.Add(newUser);
            }
            else
            {
                cUser.Usuario1 = txtUsuario.Text;
                cUser.Password = txtPassword.Text;
                var res = UsuarioValidator.Validate(cUser);
                if (ShowErrorValidation.Valid(res))
                    cUser = UsuarioController.I.Edit(cUser);
            }

            if (cUser == null)
                MessageBox.Show("No se pudo agregar o editar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            cUser = null;
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

        private void btnShowHidePass_Click(object sender, EventArgs e)
        {
            ShowPass = !ShowPass;

            txtPassword.UseSystemPasswordChar = ShowPass;
            if (ShowPass)
                btnShowHidePass.Text = "Ver";
            else
                btnShowHidePass.Text = "Ocultar";
        }
    }
}
