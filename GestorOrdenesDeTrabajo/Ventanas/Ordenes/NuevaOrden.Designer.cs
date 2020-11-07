namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    partial class NuevaOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaOrden));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.clientDataContainer = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSrchCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.gbMaquina = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cdtpFechaRecepcion = new GestorOrdenesDeTrabajo.Clases.CustomDateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.clientDataContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbMaquina.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 605);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnAceptar, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.gbCliente, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gbMaquina, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(53, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(944, 499);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAceptar.Location = new System.Drawing.Point(3, 452);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(463, 44);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.Location = new System.Drawing.Point(477, 452);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(464, 44);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.clientDataContainer);
            this.gbCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gbCliente.Location = new System.Drawing.Point(3, 53);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(463, 393);
            this.gbCliente.TabIndex = 25;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "DATOS DEL CLIENTE";
            // 
            // clientDataContainer
            // 
            this.clientDataContainer.ColumnCount = 3;
            this.clientDataContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.clientDataContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clientDataContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.clientDataContainer.Controls.Add(this.label2, 1, 1);
            this.clientDataContainer.Controls.Add(this.label4, 1, 3);
            this.clientDataContainer.Controls.Add(this.label3, 1, 5);
            this.clientDataContainer.Controls.Add(this.txtDireccion, 1, 4);
            this.clientDataContainer.Controls.Add(this.txtTelefono, 1, 6);
            this.clientDataContainer.Controls.Add(this.panel3, 1, 2);
            this.clientDataContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientDataContainer.Location = new System.Drawing.Point(3, 18);
            this.clientDataContainer.Name = "clientDataContainer";
            this.clientDataContainer.RowCount = 8;
            this.clientDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.clientDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clientDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clientDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clientDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clientDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clientDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clientDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clientDataContainer.Size = new System.Drawing.Size(457, 372);
            this.clientDataContainer.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cliente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 40);
            this.label4.TabIndex = 19;
            this.label4.Text = "Direccion:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefono:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(23, 143);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(411, 29);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.changeFocus_KeyUp);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(23, 223);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(411, 29);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.KeyUp += new System.Windows.Forms.KeyEventHandler(this.changeFocus_KeyUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSrchCliente);
            this.panel3.Controls.Add(this.txtCliente);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(23, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 34);
            this.panel3.TabIndex = 21;
            // 
            // btnSrchCliente
            // 
            this.btnSrchCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSrchCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSrchCliente.FlatAppearance.BorderSize = 0;
            this.btnSrchCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSrchCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnSrchCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrchCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrchCliente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnSrchCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnSrchCliente.Image")));
            this.btnSrchCliente.Location = new System.Drawing.Point(346, 0);
            this.btnSrchCliente.MaximumSize = new System.Drawing.Size(65, 29);
            this.btnSrchCliente.Name = "btnSrchCliente";
            this.btnSrchCliente.Size = new System.Drawing.Size(65, 29);
            this.btnSrchCliente.TabIndex = 3;
            this.btnSrchCliente.UseVisualStyleBackColor = false;
            this.btnSrchCliente.Click += new System.EventHandler(this.btnSrchCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(0, 0);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(346, 29);
            this.txtCliente.TabIndex = 2;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // gbMaquina
            // 
            this.gbMaquina.Controls.Add(this.tableLayoutPanel4);
            this.gbMaquina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMaquina.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gbMaquina.Location = new System.Drawing.Point(477, 53);
            this.gbMaquina.Name = "gbMaquina";
            this.gbMaquina.Size = new System.Drawing.Size(464, 393);
            this.gbMaquina.TabIndex = 26;
            this.gbMaquina.TabStop = false;
            this.gbMaquina.Text = "DATOS DE LA MAQUINA";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtEquipo, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtObservaciones, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(458, 372);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 40);
            this.label5.TabIndex = 21;
            this.label5.Text = "Equipo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(412, 40);
            this.label6.TabIndex = 22;
            this.label6.Text = "Observaciones:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtEquipo
            // 
            this.txtEquipo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEquipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipo.Location = new System.Drawing.Point(23, 63);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(412, 29);
            this.txtEquipo.TabIndex = 4;
            this.txtEquipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEquipo_KeyPress);
            this.txtEquipo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.changeFocus_KeyUp);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(23, 143);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(412, 206);
            this.txtObservaciones.TabIndex = 5;
            this.txtObservaciones.Text = "";
            this.txtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservaciones_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cdtpFechaRecepcion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFolio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(477, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 44);
            this.panel1.TabIndex = 13;
            // 
            // cdtpFechaRecepcion
            // 
            this.cdtpFechaRecepcion.Dock = System.Windows.Forms.DockStyle.Right;
            this.cdtpFechaRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdtpFechaRecepcion.Location = new System.Drawing.Point(68, 0);
            this.cdtpFechaRecepcion.Name = "cdtpFechaRecepcion";
            this.cdtpFechaRecepcion.Size = new System.Drawing.Size(150, 31);
            this.cdtpFechaRecepcion.TabIndex = 12;
            this.cdtpFechaRecepcion.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(218, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 44);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(243, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Folio:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFolio
            // 
            this.txtFolio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolio.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.Location = new System.Drawing.Point(314, 0);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(150, 31);
            this.txtFolio.TabIndex = 0;
            this.txtFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            this.txtFolio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.changeFocus_KeyUp);
            // 
            // NuevaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1050, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1050, 605);
            this.Name = "NuevaOrden";
            this.Text = "NuevaOrden";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.clientDataContainer.ResumeLayout(false);
            this.clientDataContainer.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbMaquina.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.GroupBox gbMaquina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolio;
        private Clases.CustomDateTimePicker cdtpFechaRecepcion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel clientDataContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnSrchCliente;
    }
}