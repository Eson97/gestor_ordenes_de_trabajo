
namespace GestorOrdenesDeTrabajo.Ventanas.Estadisticas
{
    partial class Estadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDetalleRefaccion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDetalleServicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ipTotal = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.ipNeto = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.ipCredito = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.ipTransfe = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.ipCheque = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.ipTerminal = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.ipEfectivo = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.ipRefTotal = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.ipCostoRef = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.ipRefGarantia = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.ipRefUsadas = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.infoPanel2 = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.ipTotalServicio = new GestorOrdenesDeTrabajo.CustomComponents.infoPanel();
            this.cdtpFin = new GestorOrdenesDeTrabajo.Clases.CustomDateTimePicker();
            this.cdtpInit = new GestorOrdenesDeTrabajo.Clases.CustomDateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.btnReporte, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1400, 745);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnReporte.Location = new System.Drawing.Point(31, 29);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(661, 48);
            this.btnReporte.TabIndex = 9;
            this.btnReporte.Text = "Reporte ➤";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ipTotal);
            this.groupBox1.Controls.Add(this.ipNeto);
            this.groupBox1.Controls.Add(this.ipCredito);
            this.groupBox1.Controls.Add(this.ipTransfe);
            this.groupBox1.Controls.Add(this.ipCheque);
            this.groupBox1.Controls.Add(this.ipTerminal);
            this.groupBox1.Controls.Add(this.ipEfectivo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(707, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(661, 305);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.chart1.BorderlineColor = System.Drawing.SystemColors.ControlLight;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            legend1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            legend1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            legend1.ForeColor = System.Drawing.SystemColors.ControlLight;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(31, 91);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(661, 305);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Ordenes";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.SystemColors.ControlDark;
            title1.Name = "Title1";
            title1.Text = "Ordenes de trabajo";
            this.chart1.Titles.Add(title1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDetalleRefaccion);
            this.groupBox2.Controls.Add(this.ipRefTotal);
            this.groupBox2.Controls.Add(this.ipCostoRef);
            this.groupBox2.Controls.Add(this.ipRefGarantia);
            this.groupBox2.Controls.Add(this.ipRefUsadas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(31, 410);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(661, 305);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Refacciones";
            // 
            // btnDetalleRefaccion
            // 
            this.btnDetalleRefaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDetalleRefaccion.FlatAppearance.BorderSize = 0;
            this.btnDetalleRefaccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnDetalleRefaccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDetalleRefaccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleRefaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleRefaccion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnDetalleRefaccion.Location = new System.Drawing.Point(457, 249);
            this.btnDetalleRefaccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetalleRefaccion.Name = "btnDetalleRefaccion";
            this.btnDetalleRefaccion.Size = new System.Drawing.Size(193, 48);
            this.btnDetalleRefaccion.TabIndex = 7;
            this.btnDetalleRefaccion.Text = "Detalles ➤";
            this.btnDetalleRefaccion.UseVisualStyleBackColor = false;
            this.btnDetalleRefaccion.Click += new System.EventHandler(this.btnDetalleRefaccion_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDetalleServicio);
            this.groupBox3.Controls.Add(this.infoPanel2);
            this.groupBox3.Controls.Add(this.ipTotalServicio);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Location = new System.Drawing.Point(707, 410);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(661, 305);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Costo Servicio";
            // 
            // btnDetalleServicio
            // 
            this.btnDetalleServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDetalleServicio.FlatAppearance.BorderSize = 0;
            this.btnDetalleServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnDetalleServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDetalleServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleServicio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnDetalleServicio.Location = new System.Drawing.Point(456, 249);
            this.btnDetalleServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetalleServicio.Name = "btnDetalleServicio";
            this.btnDetalleServicio.Size = new System.Drawing.Size(193, 48);
            this.btnDetalleServicio.TabIndex = 8;
            this.btnDetalleServicio.Text = "Detalles ➤";
            this.btnDetalleServicio.UseVisualStyleBackColor = false;
            this.btnDetalleServicio.Click += new System.EventHandler(this.btnDetalleServicio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.cdtpFin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cdtpInit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(707, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 54);
            this.panel1.TabIndex = 4;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMostrar.Location = new System.Drawing.Point(399, 4);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(135, 36);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(188, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(141, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(305, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ipTotal
            // 
            this.ipTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipTotal.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipTotal.Location = new System.Drawing.Point(449, 177);
            this.ipTotal.Margin = new System.Windows.Forms.Padding(4);
            this.ipTotal.MaximumSize = new System.Drawing.Size(225, 79);
            this.ipTotal.MoneyFormat = true;
            this.ipTotal.Name = "ipTotal";
            this.ipTotal.Size = new System.Drawing.Size(151, 79);
            this.ipTotal.TabIndex = 6;
            this.ipTotal.Titulo = "Total";
            // 
            // ipNeto
            // 
            this.ipNeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipNeto.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipNeto.Location = new System.Drawing.Point(291, 177);
            this.ipNeto.Margin = new System.Windows.Forms.Padding(4);
            this.ipNeto.MaximumSize = new System.Drawing.Size(225, 79);
            this.ipNeto.MoneyFormat = true;
            this.ipNeto.Name = "ipNeto";
            this.ipNeto.Size = new System.Drawing.Size(151, 79);
            this.ipNeto.TabIndex = 5;
            this.ipNeto.Titulo = "Neto";
            // 
            // ipCredito
            // 
            this.ipCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipCredito.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipCredito.Location = new System.Drawing.Point(60, 177);
            this.ipCredito.Margin = new System.Windows.Forms.Padding(4);
            this.ipCredito.MaximumSize = new System.Drawing.Size(225, 79);
            this.ipCredito.MoneyFormat = true;
            this.ipCredito.Name = "ipCredito";
            this.ipCredito.Size = new System.Drawing.Size(151, 79);
            this.ipCredito.TabIndex = 4;
            this.ipCredito.Titulo = "Credito";
            // 
            // ipTransfe
            // 
            this.ipTransfe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipTransfe.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipTransfe.Location = new System.Drawing.Point(493, 47);
            this.ipTransfe.Margin = new System.Windows.Forms.Padding(4);
            this.ipTransfe.MaximumSize = new System.Drawing.Size(225, 79);
            this.ipTransfe.MoneyFormat = true;
            this.ipTransfe.Name = "ipTransfe";
            this.ipTransfe.Size = new System.Drawing.Size(151, 79);
            this.ipTransfe.TabIndex = 3;
            this.ipTransfe.Titulo = "Transfe";
            // 
            // ipCheque
            // 
            this.ipCheque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipCheque.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipCheque.Location = new System.Drawing.Point(335, 47);
            this.ipCheque.Margin = new System.Windows.Forms.Padding(4);
            this.ipCheque.MaximumSize = new System.Drawing.Size(225, 79);
            this.ipCheque.MoneyFormat = true;
            this.ipCheque.Name = "ipCheque";
            this.ipCheque.Size = new System.Drawing.Size(151, 79);
            this.ipCheque.TabIndex = 2;
            this.ipCheque.Titulo = "Cheque";
            // 
            // ipTerminal
            // 
            this.ipTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipTerminal.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipTerminal.Location = new System.Drawing.Point(176, 47);
            this.ipTerminal.Margin = new System.Windows.Forms.Padding(4);
            this.ipTerminal.MaximumSize = new System.Drawing.Size(225, 79);
            this.ipTerminal.MoneyFormat = true;
            this.ipTerminal.Name = "ipTerminal";
            this.ipTerminal.Size = new System.Drawing.Size(151, 79);
            this.ipTerminal.TabIndex = 1;
            this.ipTerminal.Titulo = "Terminal";
            // 
            // ipEfectivo
            // 
            this.ipEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipEfectivo.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipEfectivo.Location = new System.Drawing.Point(17, 47);
            this.ipEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.ipEfectivo.MaximumSize = new System.Drawing.Size(225, 79);
            this.ipEfectivo.MoneyFormat = true;
            this.ipEfectivo.Name = "ipEfectivo";
            this.ipEfectivo.Size = new System.Drawing.Size(151, 79);
            this.ipEfectivo.TabIndex = 0;
            this.ipEfectivo.Titulo = "Efectivo";
            // 
            // ipRefTotal
            // 
            this.ipRefTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipRefTotal.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipRefTotal.Location = new System.Drawing.Point(409, 50);
            this.ipRefTotal.Margin = new System.Windows.Forms.Padding(4);
            this.ipRefTotal.MaximumSize = new System.Drawing.Size(225, 79);
            this.ipRefTotal.MoneyFormat = false;
            this.ipRefTotal.Name = "ipRefTotal";
            this.ipRefTotal.Size = new System.Drawing.Size(151, 79);
            this.ipRefTotal.TabIndex = 4;
            this.ipRefTotal.Titulo = "Total";
            // 
            // ipCostoRef
            // 
            this.ipCostoRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipCostoRef.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipCostoRef.Location = new System.Drawing.Point(208, 150);
            this.ipCostoRef.Margin = new System.Windows.Forms.Padding(4);
            this.ipCostoRef.MaximumSize = new System.Drawing.Size(225, 79);
            this.ipCostoRef.MoneyFormat = true;
            this.ipCostoRef.Name = "ipCostoRef";
            this.ipCostoRef.Size = new System.Drawing.Size(225, 79);
            this.ipCostoRef.TabIndex = 3;
            this.ipCostoRef.Titulo = "Ingresos";
            // 
            // ipRefGarantia
            // 
            this.ipRefGarantia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipRefGarantia.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipRefGarantia.Location = new System.Drawing.Point(251, 50);
            this.ipRefGarantia.Margin = new System.Windows.Forms.Padding(4);
            this.ipRefGarantia.MaximumSize = new System.Drawing.Size(225, 79);
            this.ipRefGarantia.MoneyFormat = false;
            this.ipRefGarantia.Name = "ipRefGarantia";
            this.ipRefGarantia.Size = new System.Drawing.Size(151, 79);
            this.ipRefGarantia.TabIndex = 2;
            this.ipRefGarantia.Titulo = "Garantia";
            // 
            // ipRefUsadas
            // 
            this.ipRefUsadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipRefUsadas.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipRefUsadas.Location = new System.Drawing.Point(92, 50);
            this.ipRefUsadas.Margin = new System.Windows.Forms.Padding(4);
            this.ipRefUsadas.MaximumSize = new System.Drawing.Size(225, 79);
            this.ipRefUsadas.MoneyFormat = false;
            this.ipRefUsadas.Name = "ipRefUsadas";
            this.ipRefUsadas.Size = new System.Drawing.Size(151, 79);
            this.ipRefUsadas.TabIndex = 1;
            this.ipRefUsadas.Titulo = "Cobradas";
            // 
            // infoPanel2
            // 
            this.infoPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.infoPanel2.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.infoPanel2.Location = new System.Drawing.Point(335, 70);
            this.infoPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.infoPanel2.MaximumSize = new System.Drawing.Size(225, 79);
            this.infoPanel2.MoneyFormat = true;
            this.infoPanel2.Name = "infoPanel2";
            this.infoPanel2.Size = new System.Drawing.Size(225, 79);
            this.infoPanel2.TabIndex = 6;
            this.infoPanel2.Titulo = "Ingreso Servicio";
            // 
            // ipTotalServicio
            // 
            this.ipTotalServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipTotalServicio.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipTotalServicio.Location = new System.Drawing.Point(101, 70);
            this.ipTotalServicio.Margin = new System.Windows.Forms.Padding(4);
            this.ipTotalServicio.MaximumSize = new System.Drawing.Size(225, 79);
            this.ipTotalServicio.MoneyFormat = false;
            this.ipTotalServicio.Name = "ipTotalServicio";
            this.ipTotalServicio.Size = new System.Drawing.Size(225, 79);
            this.ipTotalServicio.TabIndex = 5;
            this.ipTotalServicio.Titulo = "Mecanicos";
            // 
            // cdtpFin
            // 
            this.cdtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdtpFin.Location = new System.Drawing.Point(219, 4);
            this.cdtpFin.Margin = new System.Windows.Forms.Padding(4);
            this.cdtpFin.Name = "cdtpFin";
            this.cdtpFin.Size = new System.Drawing.Size(171, 34);
            this.cdtpFin.TabIndex = 2;
            this.cdtpFin.ValueChanged += new System.EventHandler(this.cdtpFin_ValueChanged);
            // 
            // cdtpInit
            // 
            this.cdtpInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtpInit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdtpInit.Location = new System.Drawing.Point(4, 4);
            this.cdtpInit.Margin = new System.Windows.Forms.Padding(4);
            this.cdtpInit.Name = "cdtpInit";
            this.cdtpInit.Size = new System.Drawing.Size(175, 34);
            this.cdtpInit.TabIndex = 0;
            this.cdtpInit.ValueChanged += new System.EventHandler(this.cdtpInit_ValueChanged);
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1400, 745);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1400, 745);
            this.Name = "Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrar;
        private Clases.CustomDateTimePicker cdtpFin;
        private System.Windows.Forms.Label label2;
        private Clases.CustomDateTimePicker cdtpInit;
        private CustomComponents.infoPanel ipTransfe;
        private CustomComponents.infoPanel ipCheque;
        private CustomComponents.infoPanel ipTerminal;
        private CustomComponents.infoPanel ipEfectivo;
        private CustomComponents.infoPanel ipTotal;
        private CustomComponents.infoPanel ipNeto;
        private CustomComponents.infoPanel ipCredito;
        private CustomComponents.infoPanel ipCostoRef;
        private CustomComponents.infoPanel ipRefGarantia;
        private CustomComponents.infoPanel ipRefUsadas;
        private CustomComponents.infoPanel ipRefTotal;
        private System.Windows.Forms.Button btnDetalleRefaccion;
        private System.Windows.Forms.Button btnDetalleServicio;
        private CustomComponents.infoPanel infoPanel2;
        private CustomComponents.infoPanel ipTotalServicio;
        private System.Windows.Forms.Button btnReporte;
    }
}