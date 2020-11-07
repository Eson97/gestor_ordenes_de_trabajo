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
    public partial class MecanicoDialog : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        DataTable datatable;
        static MecanicoDialog _Dialog;
        static Mecanico _DialogResult = null;
        private Mecanico mecanico;

        public MecanicoDialog()
        {
            InitializeComponent();
            datatable = new DataTable();
            datatable.Columns.Add("ID");
            datatable.Columns.Add("Nombre");
            datatable.Columns[0].ReadOnly = true;
            datatable.Columns[1].ReadOnly = true;
            Actualizar();
        }

        public static Mecanico showClientDialog()
        {
            _Dialog = new MecanicoDialog();
            _Dialog.ShowDialog();
            return _DialogResult;
        }

        private void ShowAddEditMecanico()
        {
            Helper.VaciarTexto(txtNombre);

            if (mecanico == null)
            { lblTittle.Text = "Nuevo"; }
            else
            {
                lblTittle.Text = "Editar";
                txtNombre.Text = mecanico.Nombre;
            }

            dataPanel.Show();
            lblTittle.Show();
        }

        public void Actualizar()
        {
            while (tablaMecanicos.RowCount > 0) tablaMecanicos.Rows.RemoveAt(0);
            var mecanicos = MecanicoController.I.GetLista();

            foreach (Mecanico item in mecanicos)
                datatable.Rows.Add(new object[] { item.Id, item.Nombre });

            tablaMecanicos.DataSource = datatable;
            tablaMecanicos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaMecanicos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaMecanicos.Columns[0].Resizable = DataGridViewTriState.False;
            tablaMecanicos.Columns[1].Resizable = DataGridViewTriState.True;
            tablaMecanicos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            mecanico = null;
            ShowAddEditMecanico();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (mecanico == null)
                MessageBox.Show("Seleccione un Mecanico de la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowAddEditMecanico();
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

            if (mecanico == null)
            {
                mecanico = MecanicoController.I.Add(new Mecanico
                {
                    Nombre = txtNombre.Text
                });
            }
            else
            {
                mecanico.Nombre = txtNombre.Text;
                mecanico = MecanicoController.I.Edit(mecanico);
            }

            if (mecanico == null)
                MessageBox.Show("No se pudo agregar o editar el cliente, intente de nuevo", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Actualizar();

            Helper.VaciarTexto(txtNombre);
            mecanico = null;

            lblTittle.Hide();
            dataPanel.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mecanico = null;

            lblTittle.Hide();
            dataPanel.Hide();
        }

        private void tablaMecanicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Se dio doble click :D");
            //TODO añadir validacion para permiso de usuario
            if (e.RowIndex <= -1)
                return;

            DataGridViewRow row = tablaMecanicos.CurrentRow;
            int id = int.Parse(row.Cells[0].Value as string);
            string nombre = row.Cells[1].Value as string;

            _DialogResult = new Mecanico()
            {
                Id = id,
                Nombre = nombre
            };

            Console.WriteLine($"ID:{_DialogResult.Id}\nNombre:{_DialogResult.Nombre}");

            this.Dispose();
        }

        private void tablaMecanicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            DataGridViewRow row = tablaMecanicos.CurrentRow;
            int id = int.Parse(row.Cells[0].Value as string);
            string nombre = row.Cells[1].Value as string;

            mecanico = new Mecanico()
            {
                Id = id,
                Nombre = nombre
            };

            Console.WriteLine(
                $"*****************************" +
                $"\nID: {mecanico.Id}" +
                $"\nNombre: {mecanico.Nombre}" +
                $"\n*****************************");
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "Ingrese el nombre del mecanico")
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

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
