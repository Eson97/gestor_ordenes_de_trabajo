namespace GestorOrdenesDeTrabajo.Ventanas.Buscar
{
    partial class SrchMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tablaOrdenes = new System.Windows.Forms.DataGridView();
            this.txtBuscarCodigo_Cliente = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSrchFolio = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBuscarFolio = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.customDateTimePicker2 = new GestorOrdenesDeTrabajo.Clases.CustomDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.customDateTimePicker1 = new GestorOrdenesDeTrabajo.Clases.CustomDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaOrdenes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 605);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 1);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel2.Controls.Add(this.containerPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1034, 544);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(3, 3);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(531, 538);
            this.containerPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tablaOrdenes);
            this.panel3.Controls.Add(this.txtBuscarCodigo_Cliente);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(540, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 538);
            this.panel3.TabIndex = 1;
            // 
            // tablaOrdenes
            // 
            this.tablaOrdenes.AllowUserToAddRows = false;
            this.tablaOrdenes.AllowUserToDeleteRows = false;
            this.tablaOrdenes.AllowUserToOrderColumns = true;
            this.tablaOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaOrdenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tablaOrdenes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tablaOrdenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaOrdenes.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaOrdenes.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaOrdenes.EnableHeadersVisualStyles = false;
            this.tablaOrdenes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.tablaOrdenes.Location = new System.Drawing.Point(0, 37);
            this.tablaOrdenes.Name = "tablaOrdenes";
            this.tablaOrdenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaOrdenes.RowHeadersVisible = false;
            this.tablaOrdenes.RowHeadersWidth = 51;
            this.tablaOrdenes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tablaOrdenes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaOrdenes.RowTemplate.Height = 35;
            this.tablaOrdenes.RowTemplate.ReadOnly = true;
            this.tablaOrdenes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaOrdenes.Size = new System.Drawing.Size(491, 501);
            this.tablaOrdenes.TabIndex = 4;
            this.tablaOrdenes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tablaOrdenes_CellFormatting);
            // 
            // txtBuscarCodigo_Cliente
            // 
            this.txtBuscarCodigo_Cliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscarCodigo_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCodigo_Cliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBuscarCodigo_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCodigo_Cliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBuscarCodigo_Cliente.Location = new System.Drawing.Point(0, 0);
            this.txtBuscarCodigo_Cliente.Name = "txtBuscarCodigo_Cliente";
            this.txtBuscarCodigo_Cliente.Size = new System.Drawing.Size(491, 37);
            this.txtBuscarCodigo_Cliente.TabIndex = 3;
            this.txtBuscarCodigo_Cliente.Text = "Ingrese <Folio> o <Cliente> a buscar...";
            this.txtBuscarCodigo_Cliente.TextChanged += new System.EventHandler(this.txtBuscarCodigo_Cliente_TextChanged);
            this.txtBuscarCodigo_Cliente.Enter += new System.EventHandler(this.txtBuscarCodigo_Cliente_Enter);
            this.txtBuscarCodigo_Cliente.Leave += new System.EventHandler(this.txtBuscarCodigo_Cliente_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSrchFolio);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnBuscarFolio);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnMostrar);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.customDateTimePicker2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.customDateTimePicker1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 34);
            this.panel2.TabIndex = 2;
            // 
            // txtSrchFolio
            // 
            this.txtSrchFolio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtSrchFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSrchFolio.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSrchFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrchFolio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSrchFolio.Location = new System.Drawing.Point(700, 0);
            this.txtSrchFolio.Name = "txtSrchFolio";
            this.txtSrchFolio.Size = new System.Drawing.Size(178, 37);
            this.txtSrchFolio.TabIndex = 14;
            this.txtSrchFolio.Text = "Numero de Orden";
            this.txtSrchFolio.Enter += new System.EventHandler(this.txtSrchFolio_Enter);
            this.txtSrchFolio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSrchFolio_KeyDown);
            this.txtSrchFolio.Leave += new System.EventHandler(this.txtSrchFolio_Leave);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(878, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(28, 34);
            this.panel6.TabIndex = 13;
            // 
            // btnBuscarFolio
            // 
            this.btnBuscarFolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBuscarFolio.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscarFolio.Enabled = false;
            this.btnBuscarFolio.FlatAppearance.BorderSize = 0;
            this.btnBuscarFolio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBuscarFolio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnBuscarFolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFolio.Location = new System.Drawing.Point(906, 0);
            this.btnBuscarFolio.Name = "btnBuscarFolio";
            this.btnBuscarFolio.Size = new System.Drawing.Size(100, 34);
            this.btnBuscarFolio.TabIndex = 12;
            this.btnBuscarFolio.Text = "Buscar";
            this.btnBuscarFolio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarFolio.UseVisualStyleBackColor = false;
            this.btnBuscarFolio.Click += new System.EventHandler(this.btnBuscarFolio_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1006, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(28, 34);
            this.panel5.TabIndex = 11;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMostrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(439, 0);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(146, 34);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(411, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 34);
            this.panel4.TabIndex = 9;
            // 
            // customDateTimePicker2
            // 
            this.customDateTimePicker2.Dock = System.Windows.Forms.DockStyle.Left;
            this.customDateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.customDateTimePicker2.Location = new System.Drawing.Point(272, 0);
            this.customDateTimePicker2.Name = "customDateTimePicker2";
            this.customDateTimePicker2.Size = new System.Drawing.Size(139, 37);
            this.customDateTimePicker2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customDateTimePicker1
            // 
            this.customDateTimePicker1.Dock = System.Windows.Forms.DockStyle.Left;
            this.customDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.customDateTimePicker1.Location = new System.Drawing.Point(58, 0);
            this.customDateTimePicker1.Name = "customDateTimePicker1";
            this.customDateTimePicker1.Size = new System.Drawing.Size(139, 37);
            this.customDateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "De:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SrchMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1050, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1050, 605);
            this.Name = "SrchMain";
            this.Text = "SrchMain";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaOrdenes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBuscarCodigo_Cliente;
        private System.Windows.Forms.DataGridView tablaOrdenes;
        private Clases.CustomDateTimePicker customDateTimePicker2;
        private System.Windows.Forms.Label label2;
        private Clases.CustomDateTimePicker customDateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBuscarFolio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSrchFolio;
        private System.Windows.Forms.Panel panel6;
    }
}