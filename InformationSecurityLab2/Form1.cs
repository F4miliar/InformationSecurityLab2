﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InformationSecurityLab2
{
    public partial class Form1 : Form
    {
        private double A;
        private double B;
        private double C;
        private double a;
        private double b;
        private double y;
        private bool isEncripted = false;

        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].ChartType = SeriesChartType.Line;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            RenderGraph();
        }

        private void UpdateValues()
        {
            A = (double)numericUpDownA.Value;
            B = (double)numericUpDownB.Value;
            C = (double)numericUpDownC.Value;
            a = (double)numericUpDownAlpha.Value;
            b = (double)numericUpDownBeta.Value;
            y = (double)numericUpDownGamma.Value;
        }

        private void RenderGraph()
        {
            UpdateValues();

            chart1.Series[0].Points.Clear();

            for (double t = 1; t <= 10; t += 0.2)
            {
                double X = Function(t);
                chart1.Series[0].Points.Add(new DataPoint(t, X));
            }
        }

        private double Function(double t)
        {
            return A * Math.Sin(a * t) + B * Math.Cos(b * t) + t * C * Math.Cos(Math.Cos(y * t));
        }

        private void Encrypt()
        {
            DataPoint[] array = chart1.Series[0].Points.ToArray();
            int step = 2;
            
        }

        private void Decrypt()
        {

        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (isEncripted)
                Decrypt();
            else 
                Encrypt();
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            RenderGraph();
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            RenderGraph();
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            RenderGraph();
        }

        private void numericUpDownAlpha_ValueChanged(object sender, EventArgs e)
        {
            RenderGraph();
        }

        private void numericUpDownBeta_ValueChanged(object sender, EventArgs e)
        {
            RenderGraph();
        }

        private void numericUpDownGamma_ValueChanged(object sender, EventArgs e)
        {
            RenderGraph();
        }
    }
}
