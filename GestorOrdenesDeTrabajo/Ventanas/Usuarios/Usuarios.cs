using BussinessLayer.UsesCases;
using DataLayer;
using GestorOrdenesDeTrabajo.CustomComponents;
using GestorOrdenesDeTrabajo.Ventanas.Message;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Usuarios
{
    public partial class Usuarios : Form
    {
        Usuario currentUser;

        public Usuarios()
        {
            InitializeComponent();
            fillUsers();
        }

        //TODO refresh Users after operation
        async void fillUsers()
        {
            var usuarios = await Task.Run(() => UsuarioController.I.GetLista().Select(el => new UserCard(el)));
            while (userContainerPanel.Controls.Count > 0) userContainerPanel.Controls[0].Dispose();

            foreach (UserCard userCard in usuarios)
            {
                userCard.lblID.Click += (s, e) => { currentUser = userCard.User; openSubPanel(new UsuariosNuevo_Mod(currentUser)); };
                userCard.lblUsuario.Click += (s, e) => { currentUser = userCard.User; openSubPanel(new UsuariosNuevo_Mod(currentUser)); };
                userCard.pbImg.Click += (s, e) => { currentUser = userCard.User; openSubPanel(new UsuariosNuevo_Mod(currentUser)); };
                userContainerPanel.Controls.Add(userCard);
            }
        }

        void openSubPanel(Form f)
        {
            //Abre nueva ventana en el panel contenedor
            if (this.ContainerPanel.Controls.Count > 0)
                this.ContainerPanel.Controls.RemoveAt(0);
            Form newPanel = f as Form;
            newPanel.TopLevel = false;
            newPanel.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(newPanel);
            this.ContainerPanel.Tag = newPanel;
            newPanel.Show();
        }

        private void permisosContainerPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                ModuloDialog diag = new ModuloDialog();
                diag.ShowDialog(this);
            }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            currentUser = null;
            openSubPanel(new UsuariosNuevo_Mod(currentUser));
            fillUsers();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            openSubPanel(new UsuariosNuevo_Mod(currentUser));
            currentUser = null;
            fillUsers();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            { MessageBox.Show("Seleccione un usuario", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            var deleted = UsuarioController.I.Delete(currentUser.Id);
            if (!deleted)
                MessageBox.Show("Error al eliminar el usuario, vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            fillUsers();
        }

        private void btnCrudPermisos_Click(object sender, EventArgs e)
        {
            ModuloDialog.showDialog();
        }
    }
}
