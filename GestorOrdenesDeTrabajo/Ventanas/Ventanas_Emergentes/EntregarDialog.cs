
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.Ventanas.Message;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Ventanas_Emergentes
{
    public partial class EntregarDialog : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        static EntregarDialog _Dialog;
        private static TipoPago _MetodoPago;
        private static DateTime _FechaEntrega;
        private static string _Referencia;
        private static bool _Result = false;

        Orden orden;

        public EntregarDialog(Orden orden)
        {
            InitializeComponent();
            this.orden = orden;
            this.lblTittle.Text = $"Orden: {orden.Folio}";
        }

        public static (bool Result,string Referencia, DateTime FechaEntrega,TipoPago MetodoPago) ShowEntregarOrden(Orden o)
        {
            _Result = false;

            _Dialog = new EntregarDialog(o);
            _Dialog.ShowDialog();

            return (_Result, _Referencia, _FechaEntrega, _MetodoPago);
        }

        private void loadComboBox()
        {
            cbFormaDePago.Items.Clear();
            cbFormaDePago.DataSource = Enum.GetValues(typeof(TipoPago));
        }

        private void EntregarDialog_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageDialog.ShowMessageDialog("", "¿Toda la infotmacion ingresada es correcta?", false) == (int)MessageDialogResult.No) return;

            _MetodoPago = (TipoPago)Enum.Parse(typeof(TipoPago), cbFormaDePago.SelectedValue.ToString());
            _FechaEntrega = cdtpFechaEntrega.Value;
            _Referencia = txtRef.Text;
            _Result = true;

            this.Dispose();
        }

        private void lblTittle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
