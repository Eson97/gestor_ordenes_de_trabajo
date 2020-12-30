using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.Utilerias.Controles;
using GestorOrdenesDeTrabajo.Utilerias.Eventos;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Validation;
using System.Collections.Generic;

namespace GestorOrdenesDeTrabajo.Ventanas.Message
{
    public partial class MecanicoDialog : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        DataTable DataTable;
        static MecanicoDialog _Dialog;
        static Mecanico _DialogResult = null;
        private Mecanico CurrentMecanico;
        private readonly Orden CurrentOrden;
        private MecanicoValidator MecanicoValidator;

        public MecanicoDialog(Orden orden)
        {
            InitializeComponent();
            InitPermisos();
            CurrentOrden = orden;
            MecanicoValidator = new MecanicoValidator();
            DataTable = new DataTable();
            DataTable.Columns.Add("ID");
            DataTable.Columns.Add("Nombre");
            DataTable.Columns[0].ReadOnly = true;
            DataTable.Columns[1].ReadOnly = true;
            Actualizar();
        }

        private void InitPermisos()
        {
            if (CurrentUser.User == null)
                return;
            //permisos = await Task.Run(() => UsuarioPermisoController.I.GetListaPermisoByUsuario(currentUser.Id));
            Permission(CurrentUser.Permisos);
        }

        private void DeniedPermission(params Control[] control)
        {
            foreach (Control c in control)
            {
                c.Enabled = false;
            }
        }

        private void Permission(IList<Permiso> permisos)
        {
            Button[] buttons = { btnNew, btnEdit };

            DeniedPermission(buttons);

            if (permisos != null)
            {
                int a = (int)Permisos.INVENTARIO;
                Console.WriteLine(a.ToString());
                foreach (Permiso item in permisos)
                {
                    if (item.Id == (int)Permisos.MOD_MECANICOS)
                    {
                        btnNew.Enabled = true;
                        btnEdit.Enabled = true;
                    }

                }
            }
        }

        public static Mecanico showClientDialog(Orden orden)
        {
            _Dialog = new MecanicoDialog(orden);
            _Dialog.ShowDialog();
            return _DialogResult;
        }

        private void ShowAddEditMecanico()
        {
            Helper.VaciarTexto(txtNombre);

            if (CurrentMecanico == null)
            { lblTittle.Text = "Nuevo"; }
            else
            {
                lblTittle.Text = "Editar";
                txtNombre.Text = CurrentMecanico.Nombre;
            }

            dataPanel.Show();
            lblTittle.Show();
        }

        public void Actualizar()
        {
            while (tablaMecanicos.RowCount > 0) tablaMecanicos.Rows.RemoveAt(0);
            var mecanicos = MecanicoController.I.GetLista();

            foreach (Mecanico item in mecanicos)
                DataTable.Rows.Add(new object[] { item.Id, item.Nombre });

            tablaMecanicos.DataSource = DataTable;
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
            CurrentMecanico = null;
            ShowAddEditMecanico();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CurrentMecanico == null)
                MessageBox.Show("Seleccione un Mecanico de la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowAddEditMecanico();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool isValid = Helper.Llenos(txtNombre) && txtNombre.TextLength < 25;
            if (!isValid)
            { MessageBox.Show("El nombre no puede pasar de 25 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (CurrentMecanico == null)
            {
                var newMec = new Mecanico
                {
                    Nombre = txtNombre.Text
                };

                var res = MecanicoValidator.Validate(newMec);

                if (ShowErrorValidation.Valid(res))
                    CurrentMecanico = MecanicoController.I.Add(newMec);
            }
            else
            {
                CurrentMecanico.Nombre = txtNombre.Text;

                var res = MecanicoValidator.Validate(CurrentMecanico);

                if (ShowErrorValidation.Valid(res))
                    CurrentMecanico = MecanicoController.I.Edit(CurrentMecanico);
            }

            if (CurrentMecanico == null)
                MessageBox.Show("No se pudo agregar o editar el mecanico, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Actualizar();

            Helper.VaciarTexto(txtNombre);
            CurrentMecanico = null;

            lblTittle.Hide();
            dataPanel.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CurrentMecanico = null;

            lblTittle.Hide();
            dataPanel.Hide();
        }

        private void tablaMecanicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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

            if (MessageDialog.ShowMessageDialog("Asignar mecanico", $"¿Desea asignarle a {nombre} la orden de trabajo {CurrentOrden.Folio}?", false) == (int)MessageDialogResult.Yes)
                this.Dispose();
            else _DialogResult = null; //por si se cierra la ventana regrese null y no se asigne un mecanico por error
        }

        private void tablaMecanicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            DataGridViewRow row = tablaMecanicos.CurrentRow;
            int id = int.Parse(row.Cells[0].Value as string);
            string nombre = row.Cells[1].Value as string;

            CurrentMecanico = new Mecanico()
            {
                Id = id,
                Nombre = nombre
            };

            Console.WriteLine(
                $"*****************************" +
                $"\nID: {CurrentMecanico.Id}" +
                $"\nNombre: {CurrentMecanico.Nombre}" +
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
                txtFilter.Text = "Ingrese el nombre del mecanico";
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            if (txtFilter.Text != "Ingrese el nombre del mecanico")
                DataTable.DefaultView.RowFilter = $"Nombre LIKE '%{txtFilter.Text}%'";
        }
    }
}
