using BussinessLayer.UsesCases;
using DataLayer;
using GestorOrdenesDeTrabajo.Utilerias.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Ventanas_Emergentes
{
    public partial class LoginDialog : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private Usuario currentUser;

        public LoginDialog()
        {
            InitializeComponent();
        }

        private void topPAnel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool isValid = Helper.Llenos(txtUser, txtPass);

            if (!isValid)
            { MessageBox.Show("Introduce tu nombre de usuario y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            var user = UsuarioController.I.GetUser(txtUser.Text, txtPass.Text);
            if (user == null)
            { MessageBox.Show("No se encuentra el usuario", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            currentUser = user;

        }
    }
}
