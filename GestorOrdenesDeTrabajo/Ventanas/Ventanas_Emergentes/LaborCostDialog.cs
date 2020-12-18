using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Ventanas_Emergentes
{
    public partial class LaborCostDialog : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private static LaborCostDialog _lcd;
        private static decimal _Costo = default(decimal);
        private static bool _Result = false;

        public LaborCostDialog()
        {
            InitializeComponent();
            txtCosto.Text = _Costo.ToString();
        }

        public static (bool Result, decimal Costo) ShowLaborCostDialog()
        {
            _Result = false;

            _lcd = new LaborCostDialog();
            _lcd.ShowDialog();

            return (_Result, _Costo);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCosto.Text, out _Costo))
            {
                MessageBox.Show("Error al intentar convertir el valor a decimal", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Costo = decimal.Parse(txtCosto.Text);
            _Result = true;

            this.Dispose();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCosto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
