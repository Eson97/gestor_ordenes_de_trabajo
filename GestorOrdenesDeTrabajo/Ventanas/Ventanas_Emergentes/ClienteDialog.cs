using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.Utilerias.Controles;
using GestorOrdenesDeTrabajo.Validation;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Message
{
    public partial class ClienteDialog : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        DataTable DataTable;
        static ClienteDialog _Dialog;
        static Cliente _DialogResult = null;
        private Cliente CurrentCliente;
        private ClienteValidator ClienteValidator;
        public ClienteDialog()
        {
            InitializeComponent();
            DataTable = new DataTable();
            ClienteValidator = new ClienteValidator();
            DataTable.Columns.Add("ID");
            DataTable.Columns.Add("Nombre");
            DataTable.Columns.Add("Direccion");
            DataTable.Columns.Add("Telefono");
            DataTable.Columns[0].ReadOnly = true;
            DataTable.Columns[1].ReadOnly = true;
            DataTable.Columns[2].ReadOnly = true;
            DataTable.Columns[3].ReadOnly = true;
            Actualizar();
        }

        public static Cliente showClientDialog()
        {
            _Dialog = new ClienteDialog();
            _Dialog.ShowDialog();
            return _DialogResult;
        }

        public void Actualizar()
        {
            while (tablaClientes.RowCount > 0) tablaClientes.Rows.RemoveAt(0);
            var clientes = ClienteController.I.GetLista();

            foreach (Cliente item in clientes)
                DataTable.Rows.Add(new object[] { item.Id, item.Nombre, item.Direccion, item.Telefono });

            tablaClientes.DataSource = DataTable;
            tablaClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaClientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaClientes.Columns[0].Resizable = DataGridViewTriState.False;
            tablaClientes.Columns[1].Resizable = DataGridViewTriState.True;
            tablaClientes.Columns[2].Resizable = DataGridViewTriState.True;
            tablaClientes.Columns[3].Resizable = DataGridViewTriState.True;
            tablaClientes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void tablaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            DataGridViewRow row = tablaClientes.CurrentRow;
            int id = int.Parse(row.Cells[0].Value as string);
            string nombre = row.Cells[1].Value as string;
            string dir = row.Cells[2].Value as string;
            string tel = row.Cells[3].Value as string;

            _DialogResult = new Cliente()
            {
                Id = id,
                Nombre = nombre,
                Direccion = dir,
                Telefono = tel
            };
            this.Dispose();
        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            DataGridViewRow row = tablaClientes.CurrentRow;
            int id = int.Parse(row.Cells[0].Value as string);
            string nombre = row.Cells[1].Value as string;
            string dir = row.Cells[2].Value as string;
            string tel = row.Cells[3].Value as string;

            CurrentCliente = new Cliente()
            {
                Id = id,
                Nombre = nombre,
                Direccion = dir,
                Telefono = tel
            };
            Console.WriteLine($"ID:{CurrentCliente.Id}\nNombre:{CurrentCliente.Nombre}");
        }

        private void ShowAddEditCliente()
        {
            Helper.VaciarTexto(txtNombre, txtDir, txtTel);

            if (CurrentCliente == null)
            { lblTittle.Text = "Nuevo"; }
            else
            {
                lblTittle.Text = "Editar";
                txtNombre.Text = CurrentCliente.Nombre;
                txtDir.Text = CurrentCliente.Direccion;
                txtTel.Text = CurrentCliente.Telefono;
            }

            dataPanel.Show();
            lblTittle.Show();
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "Ingrese el nombre del cliente")
            {
                txtFilter.ForeColor = Color.Black;
                txtFilter.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CurrentCliente = null;

            lblTittle.Hide();
            dataPanel.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool isValid = Helper.Llenos(txtNombre, txtDir, txtTel);
            if (!isValid)
                return;

            if (CurrentCliente == null)
            {
                var newCliente = ClienteController.I.Add(new Cliente
                {
                    Direccion = txtDir.Text,
                    Nombre = txtNombre.Text,
                    Telefono = txtTel.Text
                });
                var res = ClienteValidator.Validate(newCliente);

                if (ShowErrorValidation.Valid(res))
                    CurrentCliente = newCliente;
            }
            else
            {
                CurrentCliente.Direccion = txtDir.Text;
                CurrentCliente.Nombre = txtNombre.Text;
                CurrentCliente.Telefono = txtTel.Text;

                var res = ClienteValidator.Validate(CurrentCliente);
                if (ShowErrorValidation.Valid(res))
                    CurrentCliente = ClienteController.I.Edit(CurrentCliente);
            }

            if (CurrentCliente == null)
                MessageBox.Show("No se pudo agregar o editar el cliente, intente de nuevo", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Actualizar();

            Helper.VaciarTexto(txtNombre, txtDir, txtTel);
            CurrentCliente = null;

            lblTittle.Hide();
            dataPanel.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CurrentCliente = null;
            ShowAddEditCliente();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CurrentCliente == null)
                MessageBox.Show("Seleccione un Cliente de la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowAddEditCliente();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            if (txtFilter.TextLength == 0)
            {
                txtFilter.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                txtFilter.Text = "Ingrese el nombre del cliente";
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text != "Ingrese el nombre del cliente")
                DataTable.DefaultView.RowFilter = $"Nombre LIKE '%{txtFilter.Text}%'";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
