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

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    public partial class UserCard : UserControl
    {
        private Usuario usuario;

        public UserCard()
        {
            InitializeComponent();
        }
        public UserCard(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            this.lblUsuario.Text = this.usuario.Usuario1;
            this.lblID.Text = $"ID: {usuario.Id}";
        }
        public Usuario User
        {
            get { return usuario; }
        }

        private void UserCard_MouseEnter(object sender, EventArgs e)
        {
           this.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void UserCard_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void UserCard_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(55,55,55);
        }

        private void UserCard_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(45, 45, 45);
        }
    }
}
