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
    public partial class Usuarios : Form
    {
        /**
         * @todo terminar parte logica de form usuarios
         * @body agregar todo el funcionamiento del form
         */

        Usuario user;

        public Usuarios()
        {
            InitializeComponent();
            fillUsers();
        }

        void fillUsers()
        {
            //TODO Cambiar por consulta en la BD
            for (int i = 0; i < 5; i++)
            {
                UserCard uc = new UserCard(new Usuario()
                {
                    Id = new Random().Next(0, 50),
                    Usuario1 = "a",
                    Password = new Random().Next(0,100).ToString()
                });
                uc.lblID.Click += (s, e) => { user = uc.User; openSubPanel(new UsuariosNuevo_Mod(user)); };
                uc.lblUsuario.Click += (s, e) => { user = uc.User; openSubPanel(new UsuariosNuevo_Mod(user)); };
                uc.pbImg.Click += (s, e) => { user = uc.User; openSubPanel(new UsuariosNuevo_Mod(user)); };
                userContainerPanel.Controls.Add(uc);
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
                //DESPLEGAR CRUD PERMISOS
            }
        }
        

    }
}
