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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.labelK = new System.Windows.Forms.Label();
            this.numericUpDownn = new System.Windows.Forms.NumericUpDown();
            this.labeln = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownn)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(9, 10);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(582, 346);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(626, 9);
            this.labelA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(21, 17);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "A:";
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(649, 10);
            this.numericUpDownA.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(52, 20);
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
            this.numericUpDownB.Location = new System.Drawing.Point(649, 32);
            this.numericUpDownB.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(52, 20);
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
            this.labelB.Location = new System.Drawing.Point(626, 32);
            this.labelB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(21, 17);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "B:";
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(649, 55);
            this.numericUpDownC.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(52, 20);
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
            this.labelC.Location = new System.Drawing.Point(626, 54);
            this.labelC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(21, 17);
            this.labelC.TabIndex = 5;
            this.labelC.Text = "C:";
            // 
            // numericUpDownAlpha
            // 
            this.numericUpDownAlpha.Location = new System.Drawing.Point(649, 78);
            this.numericUpDownAlpha.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownAlpha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownAlpha.Name = "numericUpDownAlpha";
            this.numericUpDownAlpha.Size = new System.Drawing.Size(52, 20);
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
            this.labelAlpha.Location = new System.Drawing.Point(626, 77);
            this.labelAlpha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(20, 17);
            this.labelAlpha.TabIndex = 7;
            this.labelAlpha.Text = "a:";
            // 
            // numericUpDownBeta
            // 
            this.numericUpDownBeta.Location = new System.Drawing.Point(649, 101);
            this.numericUpDownBeta.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBeta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownBeta.Name = "numericUpDownBeta";
            this.numericUpDownBeta.Size = new System.Drawing.Size(52, 20);
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
            this.labelBeta.Location = new System.Drawing.Point(626, 100);
            this.labelBeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBeta.Name = "labelBeta";
            this.labelBeta.Size = new System.Drawing.Size(20, 17);
            this.labelBeta.TabIndex = 9;
            this.labelBeta.Text = "b:";
            // 
            // numericUpDownGamma
            // 
            this.numericUpDownGamma.Location = new System.Drawing.Point(649, 124);
            this.numericUpDownGamma.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownGamma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownGamma.Name = "numericUpDownGamma";
            this.numericUpDownGamma.Size = new System.Drawing.Size(52, 20);
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
            this.labelGamma.Location = new System.Drawing.Point(626, 123);
            this.labelGamma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(19, 17);
            this.labelGamma.TabIndex = 11;
            this.labelGamma.Text = "y:";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncrypt.Location = new System.Drawing.Point(596, 316);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(103, 40);
            this.buttonEncrypt.TabIndex = 13;
            this.buttonEncrypt.Text = "Шифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // numericUpDownTStart
            // 
            this.numericUpDownTStart.Location = new System.Drawing.Point(649, 146);
            this.numericUpDownTStart.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTStart.Name = "numericUpDownTStart";
            this.numericUpDownTStart.Size = new System.Drawing.Size(52, 20);
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
            this.labelTStart.Location = new System.Drawing.Point(626, 145);
            this.labelTStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTStart.Name = "labelTStart";
            this.labelTStart.Size = new System.Drawing.Size(24, 17);
            this.labelTStart.TabIndex = 14;
            this.labelTStart.Text = "t0:";
            // 
            // numericUpDownTEnd
            // 
            this.numericUpDownTEnd.Location = new System.Drawing.Point(649, 169);
            this.numericUpDownTEnd.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownTEnd.Name = "numericUpDownTEnd";
            this.numericUpDownTEnd.Size = new System.Drawing.Size(52, 20);
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
            this.labelTEnd.Location = new System.Drawing.Point(626, 168);
            this.labelTEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTEnd.Name = "labelTEnd";
            this.labelTEnd.Size = new System.Drawing.Size(24, 17);
            this.labelTEnd.TabIndex = 16;
            this.labelTEnd.Text = "t1:";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(649, 192);
            this.numericUpDownInterval.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownInterval.TabIndex = 19;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInterval.Location = new System.Drawing.Point(626, 191);
            this.labelInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(21, 17);
            this.labelInterval.TabIndex = 18;
            this.labelInterval.Text = "T:";
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelK.Location = new System.Drawing.Point(626, 239);
            this.labelK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(21, 17);
            this.labelK.TabIndex = 20;
            this.labelK.Text = "K:";
            // 
            // numericUpDownn
            // 
            this.numericUpDownn.Location = new System.Drawing.Point(649, 216);
            this.numericUpDownn.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownn.Name = "numericUpDownn";
            this.numericUpDownn.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownn.TabIndex = 23;
            this.numericUpDownn.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownn.ValueChanged += new System.EventHandler(this.numericUpDownn_ValueChanged);
            // 
            // labeln
            // 
            this.labeln.AutoSize = true;
            this.labeln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeln.Location = new System.Drawing.Point(626, 215);
            this.labeln.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(20, 17);
            this.labeln.TabIndex = 22;
            this.labeln.Text = "n:";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(649, 242);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(52, 20);
            this.textBoxK.TabIndex = 24;
            this.textBoxK.Text = "12345";
            this.textBoxK.Leave += new System.EventHandler(this.textBoxK_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 367);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.numericUpDownn);
            this.Controls.Add(this.labeln);
            this.Controls.Add(this.labelK);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownn)).EndInit();
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
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.NumericUpDown numericUpDownn;
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.TextBox textBoxK;
    }
}

