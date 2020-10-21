namespace GestorOrdenesDeTrabajo
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            this.tlpMargen = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCont = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.DateTimeGetterInicio = new System.Windows.Forms.Timer(this.components);
            this.tlpMargen.SuspendLayout();
            this.tlpCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMargen
            // 
            this.tlpMargen.BackColor = System.Drawing.Color.Transparent;
            this.tlpMargen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpMargen.ColumnCount = 3;
            this.tlpMargen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMargen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMargen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMargen.Controls.Add(this.tlpCont, 1, 1);
            this.tlpMargen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMargen.Location = new System.Drawing.Point(0, 0);
            this.tlpMargen.Name = "tlpMargen";
            this.tlpMargen.RowCount = 3;
            this.tlpMargen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMargen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMargen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMargen.Size = new System.Drawing.Size(1050, 605);
            this.tlpMargen.TabIndex = 0;
            // 
            // tlpCont
            // 
            this.tlpCont.ColumnCount = 1;
            this.tlpCont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCont.Controls.Add(this.lblDate, 0, 2);
            this.tlpCont.Controls.Add(this.lblHour, 0, 1);
            this.tlpCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCont.Location = new System.Drawing.Point(53, 53);
            this.tlpCont.Name = "tlpCont";
            this.tlpCont.RowCount = 3;
            this.tlpCont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpCont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpCont.Size = new System.Drawing.Size(944, 499);
            this.tlpCont.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDate.Location = new System.Drawing.Point(3, 389);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(938, 110);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "  XXXXXXXXX";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblHour.Location = new System.Drawing.Point(3, 279);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(938, 110);
            this.lblHour.TabIndex = 1;
            this.lblHour.Text = "00:00:00";
            // 
            // DateTimeGetterInicio
            // 
            this.DateTimeGetterInicio.Interval = 500;
            this.DateTimeGetterInicio.Tick += new System.EventHandler(this.DateTimeGetterInicio_Tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1050, 605);
            this.Controls.Add(this.tlpMargen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1050, 605);
            this.Name = "Inicio";
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.tlpMargen.ResumeLayout(false);
            this.tlpCont.ResumeLayout(false);
            this.tlpCont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMargen;
        private System.Windows.Forms.Timer DateTimeGetterInicio;
        private System.Windows.Forms.TableLayoutPanel tlpCont;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHour;
    }
}