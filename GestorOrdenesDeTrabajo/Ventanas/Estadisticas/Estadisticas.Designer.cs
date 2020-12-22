
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.customDateTimePicker2 = new GestorOrdenesDeTrabajo.Clases.CustomDateTimePicker();
            this.customDateTimePicker1 = new GestorOrdenesDeTrabajo.Clases.CustomDateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Grafica, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 605);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(530, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 249);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos";
            // 
            // Grafica
            // 
            this.Grafica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Grafica.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.Grafica.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Grafica.BorderlineColor = System.Drawing.SystemColors.ControlLight;
            this.Grafica.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Grafica.BorderlineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.Grafica.ChartAreas.Add(chartArea1);
            this.Grafica.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            legend1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            legend1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            legend1.ForeColor = System.Drawing.SystemColors.ControlLight;
            legend1.Name = "Legend1";
            this.Grafica.Legends.Add(legend1);
            this.Grafica.Location = new System.Drawing.Point(23, 73);
            this.Grafica.Name = "Grafica";
            this.Grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.Grafica.Series.Add(series1);
            this.Grafica.Size = new System.Drawing.Size(496, 249);
            this.Grafica.TabIndex = 0;
            this.Grafica.Text = "Ordenes";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.SystemColors.ControlDark;
            title1.Name = "Title1";
            title1.Text = "Ordenes de trabajo";
            this.Grafica.Titles.Add(title1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.ipRefTotal);
            this.groupBox2.Controls.Add(this.ipCostoRef);
            this.groupBox2.Controls.Add(this.ipRefGarantia);
            this.groupBox2.Controls.Add(this.ipRefUsadas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(23, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 249);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Refacciones";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(343, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "Detalles ➤";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.infoPanel2);
            this.groupBox3.Controls.Add(this.ipTotalServicio);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Location = new System.Drawing.Point(530, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 249);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Costo Servicio";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(342, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Detalles ➤";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.customDateTimePicker2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.customDateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(530, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 44);
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
            this.btnMostrar.Location = new System.Drawing.Point(299, 3);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(101, 29);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(141, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
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
            this.ipTotal.Location = new System.Drawing.Point(337, 144);
            this.ipTotal.MaximumSize = new System.Drawing.Size(169, 64);
            this.ipTotal.MoneyFormat = true;
            this.ipTotal.Name = "ipTotal";
            this.ipTotal.Size = new System.Drawing.Size(113, 64);
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
            this.ipNeto.Location = new System.Drawing.Point(218, 144);
            this.ipNeto.MaximumSize = new System.Drawing.Size(169, 64);
            this.ipNeto.MoneyFormat = true;
            this.ipNeto.Name = "ipNeto";
            this.ipNeto.Size = new System.Drawing.Size(113, 64);
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
            this.ipCredito.Location = new System.Drawing.Point(45, 144);
            this.ipCredito.MaximumSize = new System.Drawing.Size(169, 64);
            this.ipCredito.MoneyFormat = true;
            this.ipCredito.Name = "ipCredito";
            this.ipCredito.Size = new System.Drawing.Size(113, 64);
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
            this.ipTransfe.Location = new System.Drawing.Point(370, 38);
            this.ipTransfe.MaximumSize = new System.Drawing.Size(169, 64);
            this.ipTransfe.MoneyFormat = true;
            this.ipTransfe.Name = "ipTransfe";
            this.ipTransfe.Size = new System.Drawing.Size(113, 64);
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
            this.ipCheque.Location = new System.Drawing.Point(251, 38);
            this.ipCheque.MaximumSize = new System.Drawing.Size(169, 64);
            this.ipCheque.MoneyFormat = true;
            this.ipCheque.Name = "ipCheque";
            this.ipCheque.Size = new System.Drawing.Size(113, 64);
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
            this.ipTerminal.Location = new System.Drawing.Point(132, 38);
            this.ipTerminal.MaximumSize = new System.Drawing.Size(169, 64);
            this.ipTerminal.MoneyFormat = true;
            this.ipTerminal.Name = "ipTerminal";
            this.ipTerminal.Size = new System.Drawing.Size(113, 64);
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
            this.ipEfectivo.Location = new System.Drawing.Point(13, 38);
            this.ipEfectivo.MaximumSize = new System.Drawing.Size(169, 64);
            this.ipEfectivo.MoneyFormat = true;
            this.ipEfectivo.Name = "ipEfectivo";
            this.ipEfectivo.Size = new System.Drawing.Size(113, 64);
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
            this.ipRefTotal.Location = new System.Drawing.Point(307, 41);
            this.ipRefTotal.MaximumSize = new System.Drawing.Size(169, 64);
            this.ipRefTotal.MoneyFormat = false;
            this.ipRefTotal.Name = "ipRefTotal";
            this.ipRefTotal.Size = new System.Drawing.Size(113, 64);
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
            this.ipCostoRef.Location = new System.Drawing.Point(156, 122);
            this.ipCostoRef.MaximumSize = new System.Drawing.Size(169, 64);
            this.ipCostoRef.MoneyFormat = true;
            this.ipCostoRef.Name = "ipCostoRef";
            this.ipCostoRef.Size = new System.Drawing.Size(169, 64);
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
            this.ipRefGarantia.Location = new System.Drawing.Point(188, 41);
            this.ipRefGarantia.MaximumSize = new System.Drawing.Size(169, 64);
            this.ipRefGarantia.MoneyFormat = false;
            this.ipRefGarantia.Name = "ipRefGarantia";
            this.ipRefGarantia.Size = new System.Drawing.Size(113, 64);
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
            this.ipRefUsadas.Location = new System.Drawing.Point(69, 41);
            this.ipRefUsadas.MaximumSize = new System.Drawing.Size(169, 64);
            this.ipRefUsadas.MoneyFormat = false;
            this.ipRefUsadas.Name = "ipRefUsadas";
            this.ipRefUsadas.Size = new System.Drawing.Size(113, 64);
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
            this.infoPanel2.Location = new System.Drawing.Point(251, 57);
            this.infoPanel2.MaximumSize = new System.Drawing.Size(169, 64);
            this.infoPanel2.MoneyFormat = false;
            this.infoPanel2.Name = "infoPanel2";
            this.infoPanel2.Size = new System.Drawing.Size(169, 64);
            this.infoPanel2.TabIndex = 6;
            this.infoPanel2.Titulo = null;
            // 
            // ipTotalServicio
            // 
            this.ipTotalServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ipTotalServicio.Info = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ipTotalServicio.Location = new System.Drawing.Point(76, 57);
            this.ipTotalServicio.MaximumSize = new System.Drawing.Size(169, 64);
            this.ipTotalServicio.MoneyFormat = false;
            this.ipTotalServicio.Name = "ipTotalServicio";
            this.ipTotalServicio.Size = new System.Drawing.Size(169, 64);
            this.ipTotalServicio.TabIndex = 5;
            this.ipTotalServicio.Titulo = "Servicio";
            // 
            // customDateTimePicker2
            // 
            this.customDateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.customDateTimePicker2.Location = new System.Drawing.Point(164, 3);
            this.customDateTimePicker2.Name = "customDateTimePicker2";
            this.customDateTimePicker2.Size = new System.Drawing.Size(129, 29);
            this.customDateTimePicker2.TabIndex = 2;
            // 
            // customDateTimePicker1
            // 
            this.customDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.customDateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.customDateTimePicker1.Name = "customDateTimePicker1";
            this.customDateTimePicker1.Size = new System.Drawing.Size(132, 29);
            this.customDateTimePicker1.TabIndex = 0;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1050, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1050, 605);
            this.Name = "Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafica;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrar;
        private Clases.CustomDateTimePicker customDateTimePicker2;
        private System.Windows.Forms.Label label2;
        private Clases.CustomDateTimePicker customDateTimePicker1;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private CustomComponents.infoPanel infoPanel2;
        private CustomComponents.infoPanel ipTotalServicio;
    }
}