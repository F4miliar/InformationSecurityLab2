using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private int K;
        private int n;
        private bool isEncripted = false;

        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].ChartType = SeriesChartType.Line;
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
            T = (int)numericUpDownInterval.Value;
            K = (int)numericUpDownK.Value;
            n = (int)numericUpDownn.Value;

            numericUpDownTStart.Maximum = numericUpDownTEnd.Value - 1;
            numericUpDownK.Maximum = numericUpDownn.Value;
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
                isEncripted = true;
                buttonEncrypt.Text = "Расшифровать";
            }
        }

        private void Encrypt()
        {
            UpdateGraphWithCryptoKey(K);
        }

        private void Decrypt()
        {
            UpdateGraphWithCryptoKey(n - 1 - K);
        }

        private void UpdateGraphWithCryptoKey(int k)
        {
            DataPoint[] array = chart1.Series[0].Points.ToArray();
            chart1.Series[0].Points.Clear();

            List<List<DataPoint>> matrix = ArrayToListOfLists(array);
            matrix = CeasarCipher(matrix, k);
            ChartPointsAddition(matrix);
        }

        private List<List<DataPoint>> CeasarCipher(List<List<DataPoint>> matrix, int offset)
        {
            for (int o = 0 ; o < offset; o++)
            {
                for (int i = 0; i < matrix.Count; i++)
                {
                    for (int j = 0; j < matrix[i].Count - 2; j++)
                    {
                        int pointer = j + 1;
                        if (pointer >= matrix[i].Count)
                            pointer -= matrix[i].Count;
                        else if (pointer < 0)
                            pointer += matrix[i].Count;

                        double[] temp = matrix[i][j].YValues;
                        matrix[i][j].YValues = matrix[i][pointer].YValues;
                        matrix[i][pointer].YValues = temp;
                    }
                }
            }
            return matrix;
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

        private void RenderGraph()
        {
            UpdateValues();

            chart1.Series[0].Points.Clear();

            for (double t = t0; t < t1; t += Math.Round(T / n, 1))
            {
                double X = Function(t);
                chart1.Series[0].Points.Add(new DataPoint(Math.Round(t, 1), X));
            }
        }

        private double Function(double t)
        {
            return A * Math.Sin(a * t) + B * Math.Cos(b * t) + t * C * Math.Cos(Math.Cos(y * t));
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            RenderGraph();
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

        private void numericUpDownK_ValueChanged(object sender, EventArgs e)
        {
            RenderGraph();
        }

        private void numericUpDownn_ValueChanged(object sender, EventArgs e)
        {
            RenderGraph();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RenderGraph();
        }
    }
}
