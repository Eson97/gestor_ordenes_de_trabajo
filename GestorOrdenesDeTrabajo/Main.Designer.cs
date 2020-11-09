namespace GestorOrdenesDeTrabajo
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnMinWindow = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.lblWindowTit = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dynamicPanel = new System.Windows.Forms.Panel();
            this.btnEnGarantia = new System.Windows.Forms.Button();
            this.btnPorEntregar = new System.Windows.Forms.Button();
            this.btnEnProceso = new System.Windows.Forms.Button();
            this.btnEnEspera = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.btnClosePanel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.TimeGetter = new System.Windows.Forms.Timer(this.components);
            this.bottomPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.dynamicPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bottomPanel.Controls.Add(this.lblDate);
            this.bottomPanel.Controls.Add(this.lblHour);
            this.bottomPanel.Controls.Add(this.lblUser);
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 690);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1280, 30);
            this.bottomPanel.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDate.Location = new System.Drawing.Point(747, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(401, 30);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "00/00/00";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHour
            // 
            this.lblHour.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHour.Location = new System.Drawing.Point(1148, 0);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(132, 30);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "00:00:00";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUser.Location = new System.Drawing.Point(98, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(247, 30);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "XXXXXXXXXXXXXXX";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Maroon;
            this.topPanel.Controls.Add(this.btnMinWindow);
            this.topPanel.Controls.Add(this.btnMax);
            this.topPanel.Controls.Add(this.btnCloseWindow);
            this.topPanel.Controls.Add(this.lblWindowTit);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1280, 35);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // btnMinWindow
            // 
            this.btnMinWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinWindow.FlatAppearance.BorderSize = 0;
            this.btnMinWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnMinWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinWindow.Location = new System.Drawing.Point(1175, 0);
            this.btnMinWindow.Name = "btnMinWindow";
            this.btnMinWindow.Size = new System.Drawing.Size(35, 35);
            this.btnMinWindow.TabIndex = 4;
            this.btnMinWindow.Text = "_";
            this.btnMinWindow.UseVisualStyleBackColor = true;
            this.btnMinWindow.Click += new System.EventHandler(this.btnMinWindow_Click);
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(1210, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(35, 35);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "■";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseWindow.Location = new System.Drawing.Point(1245, 0);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(35, 35);
            this.btnCloseWindow.TabIndex = 1;
            this.btnCloseWindow.Text = "X";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // lblWindowTit
            // 
            this.lblWindowTit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblWindowTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindowTit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWindowTit.Location = new System.Drawing.Point(0, 0);
            this.lblWindowTit.Name = "lblWindowTit";
            this.lblWindowTit.Size = new System.Drawing.Size(262, 35);
            this.lblWindowTit.TabIndex = 0;
            this.lblWindowTit.Text = "Gestor de Ordenes de Trabajo";
            this.lblWindowTit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sidePanel.Controls.Add(this.btnUsuarios);
            this.sidePanel.Controls.Add(this.btnStats);
            this.sidePanel.Controls.Add(this.btnBuscar);
            this.sidePanel.Controls.Add(this.dynamicPanel);
            this.sidePanel.Controls.Add(this.btnLogOut);
            this.sidePanel.Controls.Add(this.btnOrdenes);
            this.sidePanel.Controls.Add(this.btnInventario);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Controls.Add(this.btnMenu);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 35);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(230, 655);
            this.sidePanel.TabIndex = 2;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 473);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(230, 50);
            this.btnUsuarios.TabIndex = 12;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnStats
            // 
            this.btnStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnStats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnStats.Image = ((System.Drawing.Image)(resources.GetObject("btnStats.Image")));
            this.btnStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStats.Location = new System.Drawing.Point(0, 423);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(230, 50);
            this.btnStats.TabIndex = 11;
            this.btnStats.Text = "Estadisticas";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(0, 373);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(230, 50);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dynamicPanel
            // 
            this.dynamicPanel.AutoSize = true;
            this.dynamicPanel.Controls.Add(this.btnEnGarantia);
            this.dynamicPanel.Controls.Add(this.btnPorEntregar);
            this.dynamicPanel.Controls.Add(this.btnEnProceso);
            this.dynamicPanel.Controls.Add(this.btnEnEspera);
            this.dynamicPanel.Controls.Add(this.btnNueva);
            this.dynamicPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dynamicPanel.Location = new System.Drawing.Point(0, 173);
            this.dynamicPanel.Name = "dynamicPanel";
            this.dynamicPanel.Size = new System.Drawing.Size(230, 200);
            this.dynamicPanel.TabIndex = 9;
            // 
            // btnEnGarantia
            // 
            this.btnEnGarantia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnGarantia.FlatAppearance.BorderSize = 0;
            this.btnEnGarantia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnEnGarantia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnEnGarantia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnGarantia.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEnGarantia.Location = new System.Drawing.Point(0, 160);
            this.btnEnGarantia.Name = "btnEnGarantia";
            this.btnEnGarantia.Size = new System.Drawing.Size(230, 40);
            this.btnEnGarantia.TabIndex = 14;
            this.btnEnGarantia.Text = "En Garantia";
            this.btnEnGarantia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnGarantia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnGarantia.UseVisualStyleBackColor = true;
            this.btnEnGarantia.Click += new System.EventHandler(this.btnEnGarantia_Click);
            // 
            // btnPorEntregar
            // 
            this.btnPorEntregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPorEntregar.FlatAppearance.BorderSize = 0;
            this.btnPorEntregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnPorEntregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnPorEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorEntregar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnPorEntregar.Location = new System.Drawing.Point(0, 120);
            this.btnPorEntregar.Name = "btnPorEntregar";
            this.btnPorEntregar.Size = new System.Drawing.Size(230, 40);
            this.btnPorEntregar.TabIndex = 13;
            this.btnPorEntregar.Text = "Por Entregar";
            this.btnPorEntregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPorEntregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPorEntregar.UseVisualStyleBackColor = true;
            this.btnPorEntregar.Click += new System.EventHandler(this.btnPorEntregar_Click);
            // 
            // btnEnProceso
            // 
            this.btnEnProceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnProceso.FlatAppearance.BorderSize = 0;
            this.btnEnProceso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnEnProceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnEnProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnProceso.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEnProceso.Location = new System.Drawing.Point(0, 80);
            this.btnEnProceso.Name = "btnEnProceso";
            this.btnEnProceso.Size = new System.Drawing.Size(230, 40);
            this.btnEnProceso.TabIndex = 12;
            this.btnEnProceso.Text = "En Proceso";
            this.btnEnProceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnProceso.UseVisualStyleBackColor = true;
            this.btnEnProceso.Click += new System.EventHandler(this.btnEnProceso_Click);
            // 
            // btnEnEspera
            // 
            this.btnEnEspera.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnEspera.FlatAppearance.BorderSize = 0;
            this.btnEnEspera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnEnEspera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnEnEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnEspera.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEnEspera.Location = new System.Drawing.Point(0, 40);
            this.btnEnEspera.Name = "btnEnEspera";
            this.btnEnEspera.Size = new System.Drawing.Size(230, 40);
            this.btnEnEspera.TabIndex = 11;
            this.btnEnEspera.Text = "En Espera";
            this.btnEnEspera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnEspera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnEspera.UseVisualStyleBackColor = true;
            this.btnEnEspera.Click += new System.EventHandler(this.btnEnEspera_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNueva.FlatAppearance.BorderSize = 0;
            this.btnNueva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnNueva.Location = new System.Drawing.Point(0, 0);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(230, 40);
            this.btnNueva.TabIndex = 10;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(0, 605);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(230, 50);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenes.FlatAppearance.BorderSize = 0;
            this.btnOrdenes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnOrdenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnOrdenes.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenes.Image")));
            this.btnOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenes.Location = new System.Drawing.Point(0, 123);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(230, 50);
            this.btnOrdenes.TabIndex = 3;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 73);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(230, 50);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventaro";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 50);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(230, 23);
            this.logoPanel.TabIndex = 1;
            this.logoPanel.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(230, 50);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.btnClosePanel);
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(230, 35);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1050, 50);
            this.titlePanel.TabIndex = 3;
            // 
            // btnClosePanel
            // 
            this.btnClosePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClosePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClosePanel.FlatAppearance.BorderSize = 0;
            this.btnClosePanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnClosePanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePanel.Location = new System.Drawing.Point(1000, 0);
            this.btnClosePanel.Name = "btnClosePanel";
            this.btnClosePanel.Size = new System.Drawing.Size(50, 50);
            this.btnClosePanel.TabIndex = 1;
            this.btnClosePanel.Text = "X";
            this.btnClosePanel.UseVisualStyleBackColor = false;
            this.btnClosePanel.Click += new System.EventHandler(this.btnClosePanel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1050, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inicio";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(230, 85);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1050, 605);
            this.containerPanel.TabIndex = 4;
            this.containerPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.containerPanel_ControlRemoved);
            // 
            // TimeGetter
            // 
            this.TimeGetter.Interval = 10;
            this.TimeGetter.Tick += new System.EventHandler(this.DateTimeGetter_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Main";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.main_Load);
            this.bottomPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.dynamicPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel titlePanel;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Label lblWindowTit;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel dynamicPanel;
        private System.Windows.Forms.Button btnEnGarantia;
        private System.Windows.Forms.Button btnPorEntregar;
        private System.Windows.Forms.Button btnEnProceso;
        private System.Windows.Forms.Button btnEnEspera;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnClosePanel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Timer TimeGetter;
        private System.Windows.Forms.Button btnMinWindow;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnUsuarios;
    }
}

