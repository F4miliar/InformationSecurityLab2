namespace InformationSecurityLab2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelA = new System.Windows.Forms.Label();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.labelB = new System.Windows.Forms.Label();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.labelC = new System.Windows.Forms.Label();
            this.numericUpDownAlpha = new System.Windows.Forms.NumericUpDown();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.numericUpDownBeta = new System.Windows.Forms.NumericUpDown();
            this.labelBeta = new System.Windows.Forms.Label();
            this.numericUpDownGamma = new System.Windows.Forms.NumericUpDown();
            this.labelGamma = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.numericUpDownTStart = new System.Windows.Forms.NumericUpDown();
            this.labelTStart = new System.Windows.Forms.Label();
            this.numericUpDownTEnd = new System.Windows.Forms.NumericUpDown();
            this.labelTEnd = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.labelInterval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(776, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(834, 11);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(25, 20);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "A:";
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(865, 12);
            this.numericUpDownA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownA.TabIndex = 2;
            this.numericUpDownA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(865, 40);
            this.numericUpDownB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownB.TabIndex = 4;
            this.numericUpDownB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDownB_ValueChanged);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(834, 39);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(26, 20);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "B:";
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(865, 68);
            this.numericUpDownC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownC.TabIndex = 6;
            this.numericUpDownC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDownC_ValueChanged);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(834, 67);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(26, 20);
            this.labelC.TabIndex = 5;
            this.labelC.Text = "C:";
            // 
            // numericUpDownAlpha
            // 
            this.numericUpDownAlpha.Location = new System.Drawing.Point(865, 96);
            this.numericUpDownAlpha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownAlpha.Name = "numericUpDownAlpha";
            this.numericUpDownAlpha.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownAlpha.TabIndex = 8;
            this.numericUpDownAlpha.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAlpha.ValueChanged += new System.EventHandler(this.numericUpDownAlpha_ValueChanged);
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlpha.Location = new System.Drawing.Point(834, 95);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(23, 20);
            this.labelAlpha.TabIndex = 7;
            this.labelAlpha.Text = "a:";
            // 
            // numericUpDownBeta
            // 
            this.numericUpDownBeta.Location = new System.Drawing.Point(865, 124);
            this.numericUpDownBeta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownBeta.Name = "numericUpDownBeta";
            this.numericUpDownBeta.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownBeta.TabIndex = 10;
            this.numericUpDownBeta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBeta.ValueChanged += new System.EventHandler(this.numericUpDownBeta_ValueChanged);
            // 
            // labelBeta
            // 
            this.labelBeta.AutoSize = true;
            this.labelBeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBeta.Location = new System.Drawing.Point(834, 123);
            this.labelBeta.Name = "labelBeta";
            this.labelBeta.Size = new System.Drawing.Size(23, 20);
            this.labelBeta.TabIndex = 9;
            this.labelBeta.Text = "b:";
            // 
            // numericUpDownGamma
            // 
            this.numericUpDownGamma.Location = new System.Drawing.Point(865, 152);
            this.numericUpDownGamma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownGamma.Name = "numericUpDownGamma";
            this.numericUpDownGamma.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownGamma.TabIndex = 12;
            this.numericUpDownGamma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGamma.ValueChanged += new System.EventHandler(this.numericUpDownGamma_ValueChanged);
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGamma.Location = new System.Drawing.Point(834, 151);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(22, 20);
            this.labelGamma.TabIndex = 11;
            this.labelGamma.Text = "y:";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncrypt.Location = new System.Drawing.Point(794, 389);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(137, 49);
            this.buttonEncrypt.TabIndex = 13;
            this.buttonEncrypt.Text = "Шифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // numericUpDownTStart
            // 
            this.numericUpDownTStart.Location = new System.Drawing.Point(865, 180);
            this.numericUpDownTStart.Name = "numericUpDownTStart";
            this.numericUpDownTStart.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownTStart.TabIndex = 15;
            this.numericUpDownTStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTStart.ValueChanged += new System.EventHandler(this.numericUpDownTStart_ValueChanged);
            // 
            // labelTStart
            // 
            this.labelTStart.AutoSize = true;
            this.labelTStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTStart.Location = new System.Drawing.Point(834, 179);
            this.labelTStart.Name = "labelTStart";
            this.labelTStart.Size = new System.Drawing.Size(28, 20);
            this.labelTStart.TabIndex = 14;
            this.labelTStart.Text = "t0:";
            // 
            // numericUpDownTEnd
            // 
            this.numericUpDownTEnd.Location = new System.Drawing.Point(865, 208);
            this.numericUpDownTEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownTEnd.Name = "numericUpDownTEnd";
            this.numericUpDownTEnd.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownTEnd.TabIndex = 17;
            this.numericUpDownTEnd.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTEnd.ValueChanged += new System.EventHandler(this.numericUpDownTEnd_ValueChanged);
            // 
            // labelTEnd
            // 
            this.labelTEnd.AutoSize = true;
            this.labelTEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTEnd.Location = new System.Drawing.Point(834, 207);
            this.labelTEnd.Name = "labelTEnd";
            this.labelTEnd.Size = new System.Drawing.Size(28, 20);
            this.labelTEnd.TabIndex = 16;
            this.labelTEnd.Text = "t1:";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.DecimalPlaces = 1;
            this.numericUpDownInterval.Location = new System.Drawing.Point(865, 236);
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownInterval.TabIndex = 19;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInterval.Location = new System.Drawing.Point(834, 235);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(24, 20);
            this.labelInterval.TabIndex = 18;
            this.labelInterval.Text = "T:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 452);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.numericUpDownTEnd);
            this.Controls.Add(this.labelTEnd);
            this.Controls.Add(this.numericUpDownTStart);
            this.Controls.Add(this.labelTStart);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.numericUpDownGamma);
            this.Controls.Add(this.labelGamma);
            this.Controls.Add(this.numericUpDownBeta);
            this.Controls.Add(this.labelBeta);
            this.Controls.Add(this.numericUpDownAlpha);
            this.Controls.Add(this.labelAlpha);
            this.Controls.Add(this.numericUpDownC);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.NumericUpDown numericUpDownAlpha;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.NumericUpDown numericUpDownBeta;
        private System.Windows.Forms.Label labelBeta;
        private System.Windows.Forms.NumericUpDown numericUpDownGamma;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.NumericUpDown numericUpDownTStart;
        private System.Windows.Forms.Label labelTStart;
        private System.Windows.Forms.NumericUpDown numericUpDownTEnd;
        private System.Windows.Forms.Label labelTEnd;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label labelInterval;
    }
}

