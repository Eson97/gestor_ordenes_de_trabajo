using BussinessLayer.UsesCases;
using DataLayer;
using GestorOrdenesDeTrabajo.Utilerias.Controles;
using GestorOrdenesDeTrabajo.Utilerias.Eventos;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Message
{
    public partial class ModuloDialog : Form
    {
        private DataTable datatable;
        private Modulo modulo;
        private static ModuloDialog _Dialog;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public ModuloDialog()
        {
            InitializeComponent();
            datatable = new DataTable();
            datatable.Columns.Add("ID");
            datatable.Columns.Add("Descripcion");
            datatable.Columns[0].ReadOnly = true;
            datatable.Columns[1].ReadOnly = true;
            Actualizar();
        }

        private void ShowAddEditModulo()
        {
            Helper.VaciarTexto(txtNombre);

            if (modulo == null)
            { lblTittle.Text = "Nuevo"; }
            else
            {
                lblTittle.Text = "Editar";
                txtNombre.Text = modulo.Descripcion;
            }

            dataPanel.Show();
            lblTittle.Show();
        }

        public void Actualizar()
        {
            while (tablaModulos.RowCount > 0) tablaModulos.Rows.RemoveAt(0);
            var modulos = ModuloController.I.GetLista();

            foreach (Modulo item in modulos)
                datatable.Rows.Add(new object[] { item.Id, item.Descripcion });

            tablaModulos.DataSource = datatable;
            tablaModulos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaModulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaModulos.Columns[0].Resizable = DataGridViewTriState.False;
            tablaModulos.Columns[1].Resizable = DataGridViewTriState.True;
            tablaModulos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modulo = null;
            ShowAddEditModulo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (modulo == null)
                MessageBox.Show("Seleccione un Modulo de la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowAddEditModulo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            bool isValid = Helper.Llenos(txtNombre);
            if (!isValid)
                return;

            if (modulo == null)
            {
                modulo = ModuloController.I.Add(new Modulo
                {
                    Descripcion = txtNombre.Text
                });
            }
            else
            {
                modulo.Descripcion = txtNombre.Text;
                modulo = ModuloController.I.Edit(modulo);
            }

            if (modulo == null)
                MessageBox.Show("No se pudo agregar o editar el cliente, intente de nuevo", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Actualizar();

            Helper.VaciarTexto(txtNombre);
            modulo = null;

            lblTittle.Hide();
            dataPanel.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modulo = null;

            lblTittle.Hide();
            dataPanel.Hide();
        }

        private void tablaModulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Se dio doble click :D");
            //TODO añadir validacion para permiso de usuario
            if (e.RowIndex <= -1)
                return;

            DataGridViewRow row = tablaModulos.CurrentRow;
            int id = int.Parse(row.Cells[0].Value as string);
            string descripcion = row.Cells[1].Value as string;
        }

        private void tablaModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            DataGridViewRow row = tablaModulos.CurrentRow;
            int id = int.Parse(row.Cells[0].Value as string);
            string descripcion = row.Cells[1].Value as string;

            modulo = new Modulo()
            {
                Id = id,
                Descripcion = descripcion
            };

            Console.WriteLine(
                $"*****************************" +
                $"\nID: {modulo.Id}" +
                $"\nNombre: {modulo.Descripcion}" +
                $"\n*****************************");
        }

        public static void showClientDialog()
        {
            _Dialog = new ModuloDialog();
            _Dialog.ShowDialog();
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "Ingrese el nombre del modulo")
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
                txtFilter.Text = "Ingrese el nombre del modulo";
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.AlfanumericoSpace(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);

        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
