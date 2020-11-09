namespace GestorOrdenesDeTrabajo.CustomComponents
{
    partial class UserCard
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 3);
            this.panel1.TabIndex = 0;
            // 
            // pbImg
            // 
            this.pbImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbImg.Image = ((System.Drawing.Image)(resources.GetObject("pbImg.Image")));
            this.pbImg.Location = new System.Drawing.Point(0, 0);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(43, 59);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImg.TabIndex = 2;
            this.pbImg.TabStop = false;
            this.pbImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserCard_MouseDown);
            this.pbImg.MouseEnter += new System.EventHandler(this.UserCard_MouseEnter);
            this.pbImg.MouseLeave += new System.EventHandler(this.UserCard_MouseLeave);
            this.pbImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserCard_MouseUp);
            // 
            // lblID
            // 
            this.lblID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblID.Location = new System.Drawing.Point(43, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(102, 19);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID: 00000";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserCard_MouseDown);
            this.lblID.MouseEnter += new System.EventHandler(this.UserCard_MouseEnter);
            this.lblID.MouseLeave += new System.EventHandler(this.UserCard_MouseLeave);
            this.lblID.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserCard_MouseUp);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUsuario.Location = new System.Drawing.Point(43, 19);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(102, 40);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserCard_MouseDown);
            this.lblUsuario.MouseEnter += new System.EventHandler(this.UserCard_MouseEnter);
            this.lblUsuario.MouseLeave += new System.EventHandler(this.UserCard_MouseLeave);
            this.lblUsuario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserCard_MouseUp);
            // 
            // UserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(145, 62);
            this.Name = "UserCard";
            this.Size = new System.Drawing.Size(145, 62);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.PictureBox pbImg;
        internal System.Windows.Forms.Label lblID;
        internal System.Windows.Forms.Label lblUsuario;
    }
}
