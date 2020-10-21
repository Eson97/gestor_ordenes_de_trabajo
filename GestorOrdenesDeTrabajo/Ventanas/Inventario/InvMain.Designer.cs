namespace GestorOrdenesDeTrabajo.OrdenWindow.Inventario
{
    partial class InvMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.subPanel = new System.Windows.Forms.Panel();
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.tablaInventario = new System.Windows.Forms.DataGridView();
            this.lblActionTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tlpContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInventario)).BeginInit();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // subPanel
            // 
            this.subPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPanel.Location = new System.Drawing.Point(8, 48);
            this.subPanel.Name = "subPanel";
            this.subPanel.Size = new System.Drawing.Size(532, 499);
            this.subPanel.TabIndex = 4;
            this.subPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.subPanel_ControlAdded);
            this.subPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.subPanel_ControlRemoved);
            // 
            // tlpContenido
            // 
            this.tlpContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tlpContenido.ColumnCount = 5;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.86882F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.138266F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.99292F));
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpContenido.Controls.Add(this.txtBuscarCodigo, 3, 1);
            this.tlpContenido.Controls.Add(this.tablaInventario, 3, 2);
            this.tlpContenido.Controls.Add(this.subPanel, 1, 2);
            this.tlpContenido.Controls.Add(this.lblActionTittle, 1, 1);
            this.tlpContenido.Controls.Add(this.panel1, 1, 0);
            this.tlpContenido.Controls.Add(this.panel2, 2, 0);
            this.tlpContenido.Controls.Add(this.panel3, 3, 0);
            this.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenido.Location = new System.Drawing.Point(0, 50);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 4;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContenido.Size = new System.Drawing.Size(1050, 555);
            this.tlpContenido.TabIndex = 1;
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCodigo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBuscarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCodigo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBuscarCodigo.Location = new System.Drawing.Point(568, 11);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(471, 31);
            this.txtBuscarCodigo.TabIndex = 2;
            this.txtBuscarCodigo.Text = "Ingrese <Codigo> o <Pieza> a buscar...";
            this.txtBuscarCodigo.TextChanged += new System.EventHandler(this.txtBuscarCodigo_TextChanged);
            this.txtBuscarCodigo.Enter += new System.EventHandler(this.txtBuscarCodigo_Enter);
            this.txtBuscarCodigo.Leave += new System.EventHandler(this.txtBuscarCodigo_Leave);
            // 
            // tablaInventario
            // 
            this.tablaInventario.AllowUserToAddRows = false;
            this.tablaInventario.AllowUserToDeleteRows = false;
            this.tablaInventario.AllowUserToOrderColumns = true;
            this.tablaInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tablaInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tablaInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.tablaInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaInventario.EnableHeadersVisualStyles = false;
            this.tablaInventario.Location = new System.Drawing.Point(568, 48);
            this.tablaInventario.Name = "tablaInventario";
            this.tablaInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaInventario.RowHeadersVisible = false;
            this.tablaInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            this.tablaInventario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaInventario.RowTemplate.Height = 35;
            this.tablaInventario.RowTemplate.ReadOnly = true;
            this.tablaInventario.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaInventario.Size = new System.Drawing.Size(471, 499);
            this.tablaInventario.TabIndex = 3;
            this.tablaInventario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaInventario_CellDoubleClick_1);
            // 
            // lblActionTittle
            // 
            this.lblActionTittle.AutoSize = true;
            this.lblActionTittle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblActionTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionTittle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblActionTittle.Location = new System.Drawing.Point(8, 20);
            this.lblActionTittle.Name = "lblActionTittle";
            this.lblActionTittle.Size = new System.Drawing.Size(532, 25);
            this.lblActionTittle.TabIndex = 0;
            this.lblActionTittle.Text = "Tittle";
            this.lblActionTittle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblActionTittle.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(546, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 1);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(568, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 1);
            this.panel3.TabIndex = 7;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnImportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnImportar.Location = new System.Drawing.Point(527, 8);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(167, 39);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Visible = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEliminar.Location = new System.Drawing.Point(354, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(167, 39);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnModificar.Location = new System.Drawing.Point(181, 8);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(167, 39);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnNuevo.Location = new System.Drawing.Point(8, 8);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(167, 39);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tlpButtons
            // 
            this.tlpButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tlpButtons.ColumnCount = 8;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpButtons.Controls.Add(this.btnNuevo, 1, 1);
            this.tlpButtons.Controls.Add(this.btnModificar, 2, 1);
            this.tlpButtons.Controls.Add(this.btnEliminar, 3, 1);
            this.tlpButtons.Controls.Add(this.btnImportar, 4, 1);
            this.tlpButtons.Controls.Add(this.btnExportar, 5, 1);
            this.tlpButtons.Controls.Add(this.btnActualizar, 6, 1);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 2;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(1050, 50);
            this.tlpButtons.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnExportar.Location = new System.Drawing.Point(700, 8);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(167, 39);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Visible = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnActualizar.Location = new System.Drawing.Point(873, 8);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(167, 39);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // InvMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1050, 605);
            this.ControlBox = false;
            this.Controls.Add(this.tlpContenido);
            this.Controls.Add(this.tlpButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1050, 605);
            this.Name = "InvMain";
            this.Text = "Main";
            this.tlpContenido.ResumeLayout(false);
            this.tlpContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInventario)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel subPanel;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.DataGridView tablaInventario;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblActionTittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}