using BussinessLayer.UsesCases;
using DataLayer;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Message
{
    public partial class SrchClienteDialog : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        DataTable datatable; 
        static SrchClienteDialog _Dialog;
        static Cliente _DialogResult = null;
        private Cliente c;

        public SrchClienteDialog()
        {
            InitializeComponent();
            datatable = new DataTable();
            datatable.Columns.Add("ID");
            datatable.Columns.Add("Nombre");
            datatable.Columns.Add("Direccion");
            datatable.Columns.Add("Telefono");
            datatable.Columns[0].ReadOnly = true;
            datatable.Columns[1].ReadOnly = true;
            datatable.Columns[2].ReadOnly = true;
            datatable.Columns[3].ReadOnly = true;
            Actualizar();
        }

        public static Cliente showClientDialog()
        {
            _Dialog = new SrchClienteDialog();
            _Dialog.ShowDialog();
            return _DialogResult;
        }

        public void Actualizar()
        {
            while (tablaClientes.RowCount > 0) tablaClientes.Rows.RemoveAt(0); //LE VOLVI A PONER EL WHILE PORQUE ME TIRABA ERROR CON EL .CLEAR()
            var clientes = ClienteController.I.GetLista();

            foreach (Cliente item in clientes)
                datatable.Rows.Add(new object[] { item.Id, item.Nombre, item.Direccion, item.Telefono });

            tablaClientes.DataSource = datatable;
            tablaClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaClientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaClientes.Columns[0].Resizable = DataGridViewTriState.False;
            tablaClientes.Columns[1].Resizable = DataGridViewTriState.True;
            tablaClientes.Columns[2].Resizable = DataGridViewTriState.True;
            tablaClientes.Columns[3].Resizable = DataGridViewTriState.True;
        }

        private void EditMode(Cliente c)
        {
            if (c == null)
            {
                lblTittle.Text = "Nuevo";
                txtNombre.Clear();//Les dejo esto para asegurarme que no contienen nada al desplegar el panel
                txtDir.Clear();
                txtTel.Clear();
            }
            else
            {
                lblTittle.Text = "Editar";
                txtNombre.Text = c.Nombre;
                txtDir.Text = c.Direccion;
                txtTel.Text = c.Telefono;
            }

            dataPanel.Show();
            lblTittle.Show();
        }

        void enablePanel(){ }

        private void tablaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Se dio doble click :D");
            //TODO añadir validacion para permiso de usuario
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

                Console.WriteLine($"ID:{_DialogResult.Id}\nNombre:{_DialogResult.Nombre}");

                this.Dispose();       
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EditMode(null);
        }
        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "Ingrese el nombre del cliente")
            {
                txtFilter.ForeColor = Color.Black;
                txtFilter.Text = "";
            }
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
                datatable.DefaultView.RowFilter = $"Nombre LIKE '%{txtFilter.Text}%'";
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

            c = new Cliente()
            {
                Id = id,
                Nombre = nombre,
                Direccion = dir,
                Telefono = tel
            };


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblTittle.Hide();
            dataPanel.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //TODO AGREGAR CODIGO PARA AGREGAR/EDTAR

            lblTittle.Hide();
            dataPanel.Hide();
            Actualizar();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMode(c);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
