namespace GestorOrdenesDeTrabajo.Ventanas.Buscar
{
    partial class SrchPiezasUsadas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbRefacciones = new System.Windows.Forms.GroupBox();
            this.flpListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.infoPanel1 = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.piezaItemList1 = new GestorOrdenesDeTrabajo.CustomComponents.PiezaItemList();
            this.piezaItemList2 = new GestorOrdenesDeTrabajo.CustomComponents.PiezaItemList();
            this.piezaItemList3 = new GestorOrdenesDeTrabajo.CustomComponents.PiezaItemList();
            this.piezaItemList4 = new GestorOrdenesDeTrabajo.CustomComponents.PiezaItemList();
            this.piezaItemList5 = new GestorOrdenesDeTrabajo.CustomComponents.PiezaItemList();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbRefacciones.SuspendLayout();
            this.flpListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTittle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 37);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1007, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(253, 0);
            this.lblTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(200, 37);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "000000";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Refacciones de orden:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1047, 713);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.infoPanel1);
            this.panel2.Controls.Add(this.gbRefacciones);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(31, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 655);
            this.panel2.TabIndex = 0;
            // 
            // gbRefacciones
            // 
            this.gbRefacciones.Controls.Add(this.flpListPanel);
            this.gbRefacciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbRefacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRefacciones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbRefacciones.Location = new System.Drawing.Point(0, 0);
            this.gbRefacciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRefacciones.Name = "gbRefacciones";
            this.gbRefacciones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRefacciones.Size = new System.Drawing.Size(985, 466);
            this.gbRefacciones.TabIndex = 0;
            this.gbRefacciones.TabStop = false;
            this.gbRefacciones.Text = "Refacciones";
            // 
            // flpListPanel
            // 
            this.flpListPanel.AutoScroll = true;
            this.flpListPanel.Controls.Add(this.piezaItemList1);
            this.flpListPanel.Controls.Add(this.piezaItemList2);
            this.flpListPanel.Controls.Add(this.piezaItemList3);
            this.flpListPanel.Controls.Add(this.piezaItemList4);
            this.flpListPanel.Controls.Add(this.piezaItemList5);
            this.flpListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListPanel.Location = new System.Drawing.Point(4, 20);
            this.flpListPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpListPanel.Name = "flpListPanel";
            this.flpListPanel.Size = new System.Drawing.Size(977, 442);
            this.flpListPanel.TabIndex = 0;
            // 
            // infoPanel1
            // 
            this.infoPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.infoPanel1.Info = "";
            this.infoPanel1.Location = new System.Drawing.Point(57, 523);
            this.infoPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.infoPanel1.Name = "infoPanel1";
            this.infoPanel1.Size = new System.Drawing.Size(253, 90);
            this.infoPanel1.TabIndex = 1;
            this.infoPanel1.Tittle = null;
            // 
            // piezaItemList1
            // 
            this.piezaItemList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.piezaItemList1.Location = new System.Drawing.Point(5, 5);
            this.piezaItemList1.Margin = new System.Windows.Forms.Padding(5);
            this.piezaItemList1.Name = "piezaItemList1";
            this.piezaItemList1.Size = new System.Drawing.Size(937, 90);
            this.piezaItemList1.TabIndex = 0;
            // 
            // piezaItemList2
            // 
            this.piezaItemList2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.piezaItemList2.Location = new System.Drawing.Point(5, 105);
            this.piezaItemList2.Margin = new System.Windows.Forms.Padding(5);
            this.piezaItemList2.Name = "piezaItemList2";
            this.piezaItemList2.Size = new System.Drawing.Size(937, 90);
            this.piezaItemList2.TabIndex = 1;
            // 
            // piezaItemList3
            // 
            this.piezaItemList3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.piezaItemList3.Location = new System.Drawing.Point(5, 205);
            this.piezaItemList3.Margin = new System.Windows.Forms.Padding(5);
            this.piezaItemList3.Name = "piezaItemList3";
            this.piezaItemList3.Size = new System.Drawing.Size(937, 90);
            this.piezaItemList3.TabIndex = 2;
            // 
            // piezaItemList4
            // 
            this.piezaItemList4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.piezaItemList4.Location = new System.Drawing.Point(5, 305);
            this.piezaItemList4.Margin = new System.Windows.Forms.Padding(5);
            this.piezaItemList4.Name = "piezaItemList4";
            this.piezaItemList4.Size = new System.Drawing.Size(937, 90);
            this.piezaItemList4.TabIndex = 3;
            // 
            // piezaItemList5
            // 
            this.piezaItemList5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.piezaItemList5.Location = new System.Drawing.Point(5, 405);
            this.piezaItemList5.Margin = new System.Windows.Forms.Padding(5);
            this.piezaItemList5.Name = "piezaItemList5";
            this.piezaItemList5.Size = new System.Drawing.Size(937, 90);
            this.piezaItemList5.TabIndex = 4;
            // 
            // SrchPiezasUsadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1047, 750);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SrchPiezasUsadas";
            this.Text = "SrchPiezasUsadas";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbRefacciones.ResumeLayout(false);
            this.flpListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbRefacciones;
        private System.Windows.Forms.FlowLayoutPanel flpListPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label label1;
        private CustomComponents.PiezaItemList piezaItemList1;
        private CustomComponents.PiezaItemList piezaItemList2;
        private CustomComponents.PiezaItemList piezaItemList3;
        private CustomComponents.PiezaItemList piezaItemList4;
        private CustomComponents.PiezaItemList piezaItemList5;
        private CustomComponents.infoPanel infoPanel1;
    }
}