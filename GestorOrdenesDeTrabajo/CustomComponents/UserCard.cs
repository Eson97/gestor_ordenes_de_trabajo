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
        }
        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                this.usuario = value as Usuario;
                this.lblUsuario.Text = this.usuario.Usuario1;
            }
        }
    }
}
