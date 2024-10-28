using System;
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
        private double t0;
        private double t1;
        private double T;
        private double n = 10.0;
        private bool isEncripted = false;

        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].ChartType = SeriesChartType.Line;
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
            t0 = (double)numericUpDownTStart.Value;
            t1 = (double)numericUpDownTEnd.Value;
            T = (double)numericUpDownInterval.Value;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (isEncripted)
            {
                Decrypt();
                isEncripted = false;
                buttonEncrypt.Text = "Шифровать";
            }
            else
            {
                Encrypt();
                isEncripted |= true;
                buttonEncrypt.Text = "Расшифровать";
            }
        }

        private void RenderGraph()
        {
            UpdateValues();

            chart1.Series[0].Points.Clear();

            for (double t = t0 + T / n; t <= t1; t += T / n)
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
            chart1.Series[0].Points.Clear();

            List<List<DataPoint>> matrix = ArrayToListOfLists(array);
            matrix = CeasarCipher(matrix);
            ChartPointsAddition(matrix);
        }

        private List<List<DataPoint>> ArrayToListOfLists(DataPoint[] array)
        {
            double t = T / n;
            double i = t0;
            double j = t0;

            List<List<DataPoint>> matrix = new List<List<DataPoint>> { new List<DataPoint>() };
            int TSector = 0;

            foreach (DataPoint p in array)
            {
                if (p.XValue >= i + t)
                {
                    i += t;
                }
                if (p.XValue >= j + T)
                {
                    j += T;
                    TSector++;
                    matrix.Add(new List<DataPoint>());
                }
                matrix.ElementAt(TSector).Add(p);
            }

            return matrix;
        }

        private List<List<DataPoint>> CeasarCipher(List<List<DataPoint>> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                int pointer = i + 5;
                if (pointer >= matrix.Count)
                    pointer -= matrix.Count;

                List<DataPoint> temp = matrix[i];
                matrix[i] = matrix[pointer];
                matrix[pointer] = temp;
            }
            for (int i = 0; i < matrix.Count; i++)
            {
                
                for (int j = 0; j < matrix[i].Count - 1; j++)
                {
                    int pointer = j + 1;
                    if (pointer >= matrix[i].Count)
                        pointer -= matrix[i].Count;

                    double temp = matrix[i][j].XValue;
                    matrix[i][j].XValue = matrix[i][pointer].XValue;
                    matrix[i][pointer].XValue = temp;
                }
            }

            return matrix;
        }

        private void ChartPointsAddition(List<List<DataPoint>> matrix)
        {
            foreach (List<DataPoint> l in matrix)
            {
                foreach (DataPoint p in l)
                {
                    chart1.Series[0].Points.Add(p);
                }
            }
        }

        private void Decrypt()
        {

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

        private void numericUpDownTStart_ValueChanged(object sender, EventArgs e)
        {
            RenderGraph();
        }

        private void numericUpDownTEnd_ValueChanged(object sender, EventArgs e)
        {
            RenderGraph();
        }

        private void numericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            RenderGraph();
        }
    }
}
