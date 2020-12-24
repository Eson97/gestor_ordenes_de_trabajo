namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    partial class OrdenesEnProceso
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fbtnAdd = new GestorOrdenesDeTrabajo.CustomComponents.FloatButton();
            this.flpOrdenList = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 821F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ContainerPanel, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1400, 745);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFiltro);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(31, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 687);
            this.panel1.TabIndex = 0;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(584, 0);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(229, 26);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fbtnAdd);
            this.groupBox1.Controls.Add(this.flpOrdenList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(813, 660);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // fbtnAdd
            // 
            this.fbtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.fbtnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.fbtnAdd.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.fbtnAdd.FlatAppearance.BorderSize = 0;
            this.fbtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fbtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fbtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnAdd.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnAdd.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.fbtnAdd.Location = new System.Drawing.Point(719, 570);
            this.fbtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnAdd.Name = "fbtnAdd";
            this.fbtnAdd.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.fbtnAdd.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.fbtnAdd.OnHoverTextColor = System.Drawing.SystemColors.ControlDark;
            this.fbtnAdd.OnMouseDownBorderColor = System.Drawing.Color.Transparent;
            this.fbtnAdd.OnMouseDownButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.fbtnAdd.Size = new System.Drawing.Size(87, 80);
            this.fbtnAdd.TabIndex = 7;
            this.fbtnAdd.Text = "+";
            this.fbtnAdd.TextColor = System.Drawing.SystemColors.ControlDark;
            this.fbtnAdd.textShadow = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fbtnAdd.UseVisualStyleBackColor = false;
            this.fbtnAdd.Visible = false;
            this.fbtnAdd.Click += new System.EventHandler(this.fbtnAdd_Click);
            // 
            // flpOrdenList
            // 
            this.flpOrdenList.AutoScroll = true;
            this.flpOrdenList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOrdenList.Location = new System.Drawing.Point(4, 19);
            this.flpOrdenList.Margin = new System.Windows.Forms.Padding(4);
            this.flpOrdenList.Name = "flpOrdenList";
            this.flpOrdenList.Size = new System.Drawing.Size(805, 637);
            this.flpOrdenList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDENES DE TRABAJO:";
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(879, 29);
            this.ContainerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(490, 687);
            this.ContainerPanel.TabIndex = 1;
            this.ContainerPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.ContainerPanel_ControlRemoved);
            // 
            // OrdenesEnProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1400, 745);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1400, 745);
            this.Name = "OrdenesEnProceso";
            this.Text = "OrdenesEnProceso";
            this.Load += new System.EventHandler(this.OrdenesEnProceso_Load);
            this.Resize += new System.EventHandler(this.OrdenesEnProceso_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpOrdenList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private CustomComponents.FloatButton fbtnAdd;
    }
}