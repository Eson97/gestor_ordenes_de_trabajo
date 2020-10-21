using GestorOrdenesDeTrabajo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Message
{
    public partial class MessageDialog : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        static MessageDialog MD;
        static int DR = (int)MessageDialogResult.No;

        public MessageDialog()
        {
            InitializeComponent();
        }

        public static int ShowMessageDialog(string tittle, string message, bool showOKButton)
        {
            MD = new MessageDialog();
            MD.lblTittle.Text = tittle;
            MD.lblMessage.Text = message;
            if (showOKButton)
            {
                MD.btnSi.Enabled=false;
                MD.btnSi.Text = "";
                MD.btnSi.BackColor = Color.FromArgb(25,25,25);
                MD.btnNo.Text = "OK";
            }
            MD.ShowDialog();
            return DR;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            DR = (int)MessageDialogResult.Yes;
            MD.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DR = (int)MessageDialogResult.No;
            MD.Dispose();
        }

        private void lblTittle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
