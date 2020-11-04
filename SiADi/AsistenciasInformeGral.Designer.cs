namespace SiADi
{
    partial class AsistenciasInformeGral
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelIngresosCantidad = new System.Windows.Forms.Label();
            this.labelFaltasCantidad = new System.Windows.Forms.Label();
            this.labelIngresos = new System.Windows.Forms.Label();
            this.labelFaltas = new System.Windows.Forms.Label();
            this.chartInformeGral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEgresosCantidad = new System.Windows.Forms.Label();
            this.labelEgresos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartInformeGral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIngresosCantidad
            // 
            this.labelIngresosCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelIngresosCantidad.AutoSize = true;
            this.labelIngresosCantidad.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresosCantidad.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelIngresosCantidad.Location = new System.Drawing.Point(74, 75);
            this.labelIngresosCantidad.Name = "labelIngresosCantidad";
            this.labelIngresosCantidad.Size = new System.Drawing.Size(30, 26);
            this.labelIngresosCantidad.TabIndex = 26;
            this.labelIngresosCantidad.Text = "XX";
            // 
            // labelFaltasCantidad
            // 
            this.labelFaltasCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFaltasCantidad.AutoSize = true;
            this.labelFaltasCantidad.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFaltasCantidad.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelFaltasCantidad.Location = new System.Drawing.Point(58, 49);
            this.labelFaltasCantidad.Name = "labelFaltasCantidad";
            this.labelFaltasCantidad.Size = new System.Drawing.Size(30, 26);
            this.labelFaltasCantidad.TabIndex = 25;
            this.labelFaltasCantidad.Text = "XX";
            // 
            // labelIngresos
            // 
            this.labelIngresos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelIngresos.AutoSize = true;
            this.labelIngresos.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelIngresos.Location = new System.Drawing.Point(12, 75);
            this.labelIngresos.Name = "labelIngresos";
            this.labelIngresos.Size = new System.Drawing.Size(76, 26);
            this.labelIngresos.TabIndex = 23;
            this.labelIngresos.Text = "Ingresos:";
            // 
            // labelFaltas
            // 
            this.labelFaltas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFaltas.AutoSize = true;
            this.labelFaltas.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFaltas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelFaltas.Location = new System.Drawing.Point(12, 49);
            this.labelFaltas.Name = "labelFaltas";
            this.labelFaltas.Size = new System.Drawing.Size(56, 26);
            this.labelFaltas.TabIndex = 21;
            this.labelFaltas.Text = "Faltas:";
            // 
            // chartInformeGral
            // 
            this.chartInformeGral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.chartInformeGral.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.LabelStyle.Font = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea5.AxisX2.TitleFont = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisX2.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea5.AxisY.IsLabelAutoFit = false;
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea5.AxisY.TitleFont = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisY.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea5.AxisY2.TitleFont = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisY2.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea5.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea5.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea5.Name = "ChartArea1";
            this.chartInformeGral.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            legend5.Font = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend5.ForeColor = System.Drawing.Color.LightGray;
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            legend5.TitleFont = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend5.TitleForeColor = System.Drawing.Color.LightGray;
            this.chartInformeGral.Legends.Add(legend5);
            this.chartInformeGral.Location = new System.Drawing.Point(10, 279);
            this.chartInformeGral.Name = "chartInformeGral";
            this.chartInformeGral.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartInformeGral.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MediumSpringGreen};
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartInformeGral.Series.Add(series5);
            this.chartInformeGral.Size = new System.Drawing.Size(481, 137);
            this.chartInformeGral.TabIndex = 20;
            this.chartInformeGral.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(149, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Informe general de hoy";
            // 
            // labelEgresosCantidad
            // 
            this.labelEgresosCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEgresosCantidad.AutoSize = true;
            this.labelEgresosCantidad.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEgresosCantidad.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelEgresosCantidad.Location = new System.Drawing.Point(71, 110);
            this.labelEgresosCantidad.Name = "labelEgresosCantidad";
            this.labelEgresosCantidad.Size = new System.Drawing.Size(30, 26);
            this.labelEgresosCantidad.TabIndex = 28;
            this.labelEgresosCantidad.Text = "XX";
            // 
            // labelEgresos
            // 
            this.labelEgresos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEgresos.AutoSize = true;
            this.labelEgresos.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelEgresos.Location = new System.Drawing.Point(12, 111);
            this.labelEgresos.Name = "labelEgresos";
            this.labelEgresos.Size = new System.Drawing.Size(70, 26);
            this.labelEgresos.TabIndex = 27;
            this.labelEgresos.Text = "Egresos:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.Location = new System.Drawing.Point(183, 71);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Myriad Pro Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.LightGray;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Size = new System.Drawing.Size(319, 152);
            this.dataGridView1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(287, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Empleados  ausentes";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(161, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Empleados  presentes";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea6.AxisX.TitleFont = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisX.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea6.AxisX2.TitleFont = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisX2.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea6.AxisY.TitleFont = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea6.AxisY2.TitleFont = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY2.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea6.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea6.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            legend6.Font = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend6.ForeColor = System.Drawing.Color.LightGray;
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            legend6.TitleFont = new System.Drawing.Font("Myriad Pro Cond", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend6.TitleForeColor = System.Drawing.Color.LightGray;
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(0, 174);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MediumSpringGreen};
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(177, 78);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // AsistenciasInformeGral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(500, 418);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelEgresosCantidad);
            this.Controls.Add(this.labelEgresos);
            this.Controls.Add(this.labelIngresosCantidad);
            this.Controls.Add(this.labelFaltasCantidad);
            this.Controls.Add(this.labelIngresos);
            this.Controls.Add(this.labelFaltas);
            this.Controls.Add(this.chartInformeGral);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AsistenciasInformeGral";
            this.Load += new System.EventHandler(this.AsistenciasInformeGral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartInformeGral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label labelFaltas;
        private System.Windows.Forms.Label labelFaltasCantidad;

        private System.Windows.Forms.Label labelEgresos;
        private System.Windows.Forms.Label labelEgresosCantidad;
        private System.Windows.Forms.Label labelIngresos;
        private System.Windows.Forms.Label labelIngresosCantidad;

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInformeGral;
        private System.Windows.Forms.Label label1;
    }
}