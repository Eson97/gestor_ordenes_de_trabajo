using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GestorOrdenesDeTrabajo.OrdenWindow.Inventario;
using System.Reflection;
using GestorOrdenesDeTrabajo.Ventanas.Ordenes;
using GestorOrdenesDeTrabajo.Ventanas.Buscar;
using GestorOrdenesDeTrabajo.Ventanas.Usuarios;
using System.Collections.Generic;
using System.Threading.Tasks;
using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.Ventanas.Estadisticas;

namespace GestorOrdenesDeTrabajo
{
    public partial class Main : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        bool isSidePanelContracted;
        bool isDynamicPanelContracted;
        //private Usuario currentUser;
        //IList<Permiso> permisos;
        public Main()
        {
            InitializeComponent();
            lblUser.Text = (CurrentUser.User == null) ? "Sin usuario" : CurrentUser.User.Usuario1;
            containerPanel.DoubleBuffered(true);
            sidePanel.DoubleBuffered(true);
            titlePanel.DoubleBuffered(true);
            btnClosePanel.DoubleBuffered(true);
            lblTitle.DoubleBuffered(true);
            btnClosePanel.DoubleBuffered(true);
            InitPermisos();
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
                c.Visible = false;
            }
        }

        private void Permission(IList<Permiso> permisos)
        {
            Button[] buttons = { btnBuscar, btnInventario, btnStats, btnUsuarios, btnOrdenes };

            DeniedPermission(buttons);

            if (permisos != null)
            {
                foreach (Permiso item in permisos)
                {
                    _ = (item.Id switch
                    {
                        (int)Permisos.INVENTARIO => btnBuscar.Visible = true,
                        (int)Permisos.ORDENES => btnOrdenes.Visible = true,
                        (int)Permisos.BUSCAR => btnBuscar.Visible = true,
                        (int)Permisos.ESTADISTICAS => btnStats.Visible = true,
                        (int)Permisos.USUARIOS => btnUsuarios.Visible = true,
                        _ => throw new NotImplementedException()
                    });

                }
            }
        }

        void openPanel(Form Panel, string Tittle, object sender)
        {
            //Muestra/Oculta el boton para cerrar ventana
            if ((Button)sender == this.btnClosePanel || (Button)sender == null)
            {
                btnClosePanel.Visible = false;
                lblDate.Visible = false;
                lblHour.Visible = false;
                TimeGetter.Stop();
            }
            else
            {
                btnClosePanel.Visible = true;
                lblDate.Visible = true;
                lblHour.Visible = true;
                TimeGetter.Start();
            }
            this.lblTitle.Text = Tittle;

            //Abre nueva ventana en el panel contenedor
            if (this.containerPanel.Controls.Count > 0)
                this.containerPanel.Controls.RemoveAt(0);
            Form newPanel = Panel as Form;
            newPanel.TopLevel = false;
            newPanel.Dock = DockStyle.Fill;
            this.containerPanel.Controls.Add(newPanel);
            this.containerPanel.Tag = newPanel;
            newPanel.Show();


        }
        void collapseSidePanel(bool collapse)
        {
            if (collapse)
            {
                if (!isDynamicPanelContracted)
                    collapseDynamicPanel(true);
                btnInventario.Text = "";
                btnOrdenes.Text = "";
                btnBuscar.Text = "";
                btnStats.Text = "";
                btnUsuarios.Text = "";
                this.sidePanel.Width = 50;
                isSidePanelContracted = collapse;
            }
            else
            {
                btnInventario.Text = "Inventario";
                btnOrdenes.Text = "Ordenes";
                btnBuscar.Text = "Buscar";
                btnStats.Text = "Estadisticas";
                btnUsuarios.Text = "Usuarios";
                this.sidePanel.Width = 230;
                isSidePanelContracted = collapse;
            }
        }

        void collapseDynamicPanel(bool collapse)
        {
            if (isSidePanelContracted)
                collapseSidePanel(false);

            dynamicPanel.Visible = !collapse;
            isDynamicPanelContracted = collapse;
        }

        private void main_Load(object sender, EventArgs e)
        {
            collapseDynamicPanel(true);
            collapseSidePanel(true);
            btnClosePanel.Visible = false;
            openPanel(new Inicio(), "Inicio", null);
            lblDate.Text = DateTime.Now.Date.ToString("D");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            collapseSidePanel(!isSidePanelContracted);
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            collapseDynamicPanel(!isDynamicPanelContracted);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            collapseSidePanel(true);
            openPanel(new InvMain(), "Inventario", sender); ;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            collapseSidePanel(true);
            openPanel(new SrchMain(), "Buscar", sender);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            collapseSidePanel(true);
            openPanel(new Estadisticas(), "Estadisticas", sender);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            collapseSidePanel(true);
            openPanel(new NuevaOrden(), "Nueva Orden de Trabajo", sender);
        }

        private void btnEnEspera_Click(object sender, EventArgs e)
        {
            collapseSidePanel(true);
            openPanel(new OrdenesEnEspera(OrdenStatus.ESPERA), "Ordenes en Espera", sender);
        }

        private void btnEnProceso_Click(object sender, EventArgs e)
        {
            collapseSidePanel(true);
            openPanel(new OrdenesEnProceso(OrdenStatus.PROCESO), "Ordenes en Proceso", sender);
        }

        private void btnPorEntregar_Click(object sender, EventArgs e)
        {
            collapseSidePanel(true);
            openPanel(new OrdenesEnEspera(OrdenStatus.POR_ENTREGAR), "Ordenes por Entregar", sender);
        }

        private void btnEnGarantia_Click(object sender, EventArgs e)
        {
            collapseSidePanel(true);
            openPanel(new OrdenesEnProceso(OrdenStatus.GARANTIA), "Ordenes en Garantia", sender);
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            openPanel(new Inicio(), "Inicio", sender);
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void DateTimeGetter_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.ToString("T");
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void containerPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (containerPanel.Controls.Equals(new NuevaOrden()))
                openPanel(new Inicio(), "Inicio", null);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            collapseSidePanel(true);
            openPanel(new Usuarios(), "Usuarios", sender);
        }

        private void btnGarantiaEntregar_Click(object sender, EventArgs e)
        {
            collapseSidePanel(true);
            openPanel(new OrdenesEnEspera(OrdenStatus.GARANTIA_POR_ENTREGAR), "Ordenes En Garantia Por Entregar", sender);
        }
    }

    public static class Extensions
    {
        public static void DoubleBuffered(this Control control, bool enabled)
        {
            var prop = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            prop.SetValue(control, enabled, null);
        }
    }
}
