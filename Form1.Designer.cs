using System;

namespace FuzzySetCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn1 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem3 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem4 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem5 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem6 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem7 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem8 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem9 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem10 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem11 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem12 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem13 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.crt_grafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelAll = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.btn_debug = new System.Windows.Forms.Button();
            this.lbl_operation = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lbl_B_or_Digit = new System.Windows.Forms.Label();
            this.tBox_B = new System.Windows.Forms.TextBox();
            this.tBox_A = new System.Windows.Forms.TextBox();
            this.lbl_A = new System.Windows.Forms.Label();
            this.tBox_U = new System.Windows.Forms.TextBox();
            this.lbl_U = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crt_grafik)).BeginInit();
            this.panelAll.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // crt_grafik
            // 
            this.crt_grafik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crt_grafik.BackColor = System.Drawing.Color.Transparent;
            this.crt_grafik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.crt_grafik.BorderSkin.BackColor = System.Drawing.Color.LightGreen;
            this.crt_grafik.BorderSkin.BorderColor = System.Drawing.Color.Teal;
            this.crt_grafik.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.crt_grafik.ChartAreas.Add(chartArea1);
            legendCellColumn1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            legendCellColumn1.ColumnType = System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType.SeriesSymbol;
            legendCellColumn1.Name = "Column1";
            legendCellColumn1.SeriesSymbolSize = new System.Drawing.Size(0, 0);
            legendCellColumn1.Text = "";
            legend1.CellColumns.Add(legendCellColumn1);
            legendItem1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DiagonalCross;
            legendItem1.BackSecondaryColor = System.Drawing.Color.HotPink;
            legendItem1.BorderColor = System.Drawing.Color.Gray;
            legendItem1.Color = System.Drawing.Color.MediumPurple;
            legendItem1.Name = "Результат пересечения";
            legendItem2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent50;
            legendItem2.BorderColor = System.Drawing.Color.HotPink;
            legendItem2.Color = System.Drawing.Color.HotPink;
            legendItem2.Name = "A";
            legendItem3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.OutlinedDiamond;
            legendItem3.BorderColor = System.Drawing.Color.MediumPurple;
            legendItem3.Color = System.Drawing.Color.MediumPurple;
            legendItem3.Name = "B";
            legend1.CustomItems.Add(legendItem1);
            legend1.CustomItems.Add(legendItem2);
            legend1.CustomItems.Add(legendItem3);
            legend1.Enabled = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "пересечение";
            legendItem4.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent50;
            legendItem4.Color = System.Drawing.Color.HotPink;
            legendItem4.Name = "Результат объединения";
            legendItem5.BorderColor = System.Drawing.Color.HotPink;
            legendItem5.BorderWidth = 2;
            legendItem5.Color = System.Drawing.Color.HotPink;
            legendItem5.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legendItem5.Name = "A";
            legendItem6.BorderColor = System.Drawing.Color.MediumPurple;
            legendItem6.BorderWidth = 2;
            legendItem6.Color = System.Drawing.Color.MediumPurple;
            legendItem6.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legendItem6.Name = "B";
            legend2.CustomItems.Add(legendItem4);
            legend2.CustomItems.Add(legendItem5);
            legend2.CustomItems.Add(legendItem6);
            legend2.Enabled = false;
            legend2.Name = "объединение";
            legendItem7.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent50;
            legendItem7.Color = System.Drawing.Color.HotPink;
            legendItem7.Name = "Результат отрицания";
            legendItem8.BorderWidth = 2;
            legendItem8.Color = System.Drawing.Color.Transparent;
            legendItem8.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legendItem8.Name = "не A";
            legend3.CustomItems.Add(legendItem7);
            legend3.CustomItems.Add(legendItem8);
            legend3.Enabled = false;
            legend3.InterlacedRows = true;
            legend3.Name = "отрицание";
            legendItem9.BorderWidth = 2;
            legendItem9.Color = System.Drawing.Color.HotPink;
            legendItem9.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legendItem9.Name = "Результат";
            legendItem10.BorderWidth = 2;
            legendItem10.Color = System.Drawing.Color.MediumPurple;
            legendItem10.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legendItem10.Name = "А";
            legend4.CustomItems.Add(legendItem9);
            legend4.CustomItems.Add(legendItem10);
            legend4.Enabled = false;
            legend4.Name = "возв. в степень и умн. на число";
            legendItem11.BorderWidth = 2;
            legendItem11.Color = System.Drawing.Color.Crimson;
            legendItem11.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legendItem11.Name = "Результат произведения";
            legendItem12.BorderWidth = 2;
            legendItem12.Color = System.Drawing.Color.HotPink;
            legendItem12.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legendItem12.Name = "A";
            legendItem13.BorderWidth = 2;
            legendItem13.Color = System.Drawing.Color.MediumPurple;
            legendItem13.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Line;
            legendItem13.Name = "B";
            legend5.CustomItems.Add(legendItem11);
            legend5.CustomItems.Add(legendItem12);
            legend5.CustomItems.Add(legendItem13);
            legend5.Enabled = false;
            legend5.Name = "произведение";
            this.crt_grafik.Legends.Add(legend1);
            this.crt_grafik.Legends.Add(legend2);
            this.crt_grafik.Legends.Add(legend3);
            this.crt_grafik.Legends.Add(legend4);
            this.crt_grafik.Legends.Add(legend5);
            this.crt_grafik.Location = new System.Drawing.Point(1, 1);
            this.crt_grafik.Name = "crt_grafik";
            this.crt_grafik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.OutlinedDiamond;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.MediumPurple;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.MediumPurple;
            series1.LabelForeColor = System.Drawing.Color.MediumPurple;
            series1.Legend = "пересечение";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerColor = System.Drawing.Color.MediumPurple;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "B";
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent50;
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.BackSecondaryColor = System.Drawing.Color.Transparent;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.HotPink;
            series2.Legend = "пересечение";
            series2.MarkerBorderColor = System.Drawing.Color.Transparent;
            series2.MarkerColor = System.Drawing.Color.HotPink;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "A";
            series2.ShadowColor = System.Drawing.Color.Transparent;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DiagonalCross;
            series3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series3.BackSecondaryColor = System.Drawing.Color.Transparent;
            series3.BorderColor = System.Drawing.Color.Blue;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Color = System.Drawing.Color.Blue;
            series3.IsVisibleInLegend = false;
            series3.LabelForeColor = System.Drawing.Color.Blue;
            series3.Legend = "пересечение";
            series3.MarkerBorderColor = System.Drawing.Color.Transparent;
            series3.MarkerColor = System.Drawing.Color.Transparent;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "BA";
            series3.ShadowColor = System.Drawing.Color.Transparent;
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.crt_grafik.Series.Add(series1);
            this.crt_grafik.Series.Add(series2);
            this.crt_grafik.Series.Add(series3);
            this.crt_grafik.Size = new System.Drawing.Size(783, 263);
            this.crt_grafik.TabIndex = 0;
            this.crt_grafik.Text = "Операции над нечеткими множествами";
            this.crt_grafik.Click += new System.EventHandler(this.crt_grafik_Click);
            // 
            // panelAll
            // 
            this.panelAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAll.BackColor = System.Drawing.Color.Transparent;
            this.panelAll.Controls.Add(this.flowLayoutPanel1);
            this.panelAll.Controls.Add(this.btn_debug);
            this.panelAll.Controls.Add(this.lbl_operation);
            this.panelAll.Controls.Add(this.groupBox);
            this.panelAll.Controls.Add(this.tBox_U);
            this.panelAll.Controls.Add(this.lbl_U);
            this.panelAll.Location = new System.Drawing.Point(0, 265);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(785, 195);
            this.panelAll.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButton0);
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.radioButton2);
            this.flowLayoutPanel1.Controls.Add(this.radioButton3);
            this.flowLayoutPanel1.Controls.Add(this.radioButton4);
            this.flowLayoutPanel1.Controls.Add(this.radioButton5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(629, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(156, 137);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Location = new System.Drawing.Point(3, 3);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(92, 17);
            this.radioButton0.TabIndex = 4;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = "Пересечение";
            this.radioButton0.UseVisualStyleBackColor = true;
            this.radioButton0.CheckedChanged += new System.EventHandler(this.radioButton0_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Объединение";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Отрицание А";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(142, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Умножение А на число";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 95);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(149, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Возведение А в степень";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 118);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(99, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Произведение";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // btn_debug
            // 
            this.btn_debug.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_debug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_debug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_debug.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_debug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(228)))));
            this.btn_debug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btn_debug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_debug.Location = new System.Drawing.Point(607, 159);
            this.btn_debug.Name = "btn_debug";
            this.btn_debug.Size = new System.Drawing.Size(156, 23);
            this.btn_debug.TabIndex = 6;
            this.btn_debug.Text = "Построить";
            this.btn_debug.UseVisualStyleBackColor = false;
            this.btn_debug.Click += new System.EventHandler(this.btn_debug_Click);
            // 
            // lbl_operation
            // 
            this.lbl_operation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_operation.AutoSize = true;
            this.lbl_operation.Location = new System.Drawing.Point(629, 0);
            this.lbl_operation.Name = "lbl_operation";
            this.lbl_operation.Size = new System.Drawing.Size(110, 13);
            this.lbl_operation.TabIndex = 13;
            this.lbl_operation.Text = "Выберите операцию";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.lbl_B_or_Digit);
            this.groupBox.Controls.Add(this.tBox_B);
            this.groupBox.Controls.Add(this.tBox_A);
            this.groupBox.Controls.Add(this.lbl_A);
            this.groupBox.Location = new System.Drawing.Point(3, 85);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(650, 107);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Параметры:";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // lbl_B_or_Digit
            // 
            this.lbl_B_or_Digit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_B_or_Digit.AutoSize = true;
            this.lbl_B_or_Digit.Location = new System.Drawing.Point(3, 60);
            this.lbl_B_or_Digit.Name = "lbl_B_or_Digit";
            this.lbl_B_or_Digit.Size = new System.Drawing.Size(301, 13);
            this.lbl_B_or_Digit.TabIndex = 5;
            this.lbl_B_or_Digit.Text = "Введите множество B (например: 0,3/3 + 0,5/5) или число";
            this.lbl_B_or_Digit.Click += new System.EventHandler(this.lbl_B_or_Digit_Click);
            // 
            // tBox_B
            // 
            this.tBox_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_B.BackColor = System.Drawing.Color.LightPink;
            this.tBox_B.ForeColor = System.Drawing.Color.Maroon;
            this.tBox_B.Location = new System.Drawing.Point(7, 76);
            this.tBox_B.Multiline = true;
            this.tBox_B.Name = "tBox_B";
            this.tBox_B.Size = new System.Drawing.Size(555, 22);
            this.tBox_B.TabIndex = 3;
            this.tBox_B.TextChanged += new System.EventHandler(this.tBox_B_TextChanged);
            // 
            // tBox_A
            // 
            this.tBox_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tBox_A.ForeColor = System.Drawing.Color.Maroon;
            this.tBox_A.Location = new System.Drawing.Point(7, 35);
            this.tBox_A.Multiline = true;
            this.tBox_A.Name = "tBox_A";
            this.tBox_A.Size = new System.Drawing.Size(555, 22);
            this.tBox_A.TabIndex = 2;
            this.tBox_A.TextChanged += new System.EventHandler(this.tBox_A_TextChanged);
            // 
            // lbl_A
            // 
            this.lbl_A.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_A.AutoSize = true;
            this.lbl_A.Location = new System.Drawing.Point(6, 16);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(394, 13);
            this.lbl_A.TabIndex = 4;
            this.lbl_A.Text = "Введите множество A, используя запятые (например: 0,1/1 + 0,2/2 + 0,3/3) ";
            // 
            // tBox_U
            // 
            this.tBox_U.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_U.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tBox_U.ForeColor = System.Drawing.Color.Maroon;
            this.tBox_U.Location = new System.Drawing.Point(10, 60);
            this.tBox_U.Multiline = true;
            this.tBox_U.Name = "tBox_U";
            this.tBox_U.Size = new System.Drawing.Size(555, 22);
            this.tBox_U.TabIndex = 10;
            // 
            // lbl_U
            // 
            this.lbl_U.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_U.AutoSize = true;
            this.lbl_U.Location = new System.Drawing.Point(10, 44);
            this.lbl_U.Name = "lbl_U";
            this.lbl_U.Size = new System.Drawing.Size(329, 13);
            this.lbl_U.TabIndex = 12;
            this.lbl_U.Text = "Введите целое универсальное множество (например: 1 2 3 4 5)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(785, 463);
            this.Controls.Add(this.panelAll);
            this.Controls.Add(this.crt_grafik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "Form1";
            this.Text = "Операции над нечеткими множествами";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crt_grafik)).EndInit();
            this.panelAll.ResumeLayout(false);
            this.panelAll.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crt_grafik;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Label lbl_operation;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btn_debug;
        private System.Windows.Forms.Label lbl_B_or_Digit;
        private System.Windows.Forms.TextBox tBox_B;
        private System.Windows.Forms.TextBox tBox_A;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.TextBox tBox_U;
        private System.Windows.Forms.Label lbl_U;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}

