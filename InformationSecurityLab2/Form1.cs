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
        private string K;
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
            K = textBoxK.Text;
            n = (int)numericUpDownn.Value;
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
            UpdateGraphWithCryptoKey();
        }

        private void Decrypt()
        {
            UpdateGraphWithCryptoKey();
        }

        private void UpdateGraphWithCryptoKey()
        {
            DataPoint[] array = chart1.Series[0].Points.ToArray();
            chart1.Series[0].Points.Clear();

            List<List<DataPoint>> matrix = ArrayToListOfLists(array);
            if (isEncripted)
            {
                matrix = Reverce(matrix);
            }
            else
            {
                matrix = Replace(matrix);
            }
            ChartPointsAddition(matrix);
        }

        private List<List<DataPoint>> Replace(List<List<DataPoint>> matrix)
        {
            K = textBoxK.Text;
            for (int i = 0; i < matrix.Count; i++)
            {
                if (matrix[i].Count != K.Length) continue;
                List<DataPoint> dp = Copy(matrix[i]);
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    int index = int.Parse(K[j].ToString()) - 1;
                    dp[j].YValues = matrix[i][index].YValues;
                }
                matrix[i] = dp;
            }
            return matrix;
        }

        private List<List<DataPoint>> Reverce(List<List<DataPoint>> matrix)
        {
            K = textBoxK.Text;
            for (int i = 0; i < matrix.Count; i++)
            {
                if (matrix[i].Count != K.Length) continue;
                List<DataPoint> dp = Copy(matrix[i]);
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    int index = int.Parse(K[j].ToString()) - 1;
                    dp[index].YValues = matrix[i][j].YValues;
                }
                matrix[i] = dp;
            }
            return matrix;
        }

        private static List<DataPoint> Copy(List<DataPoint> matrix)
        {
            List<DataPoint> dp = new List<DataPoint>();
            foreach (DataPoint p in matrix)
            {
                DataPoint pn = new DataPoint();
                pn.SetValueXY(p.XValue, p.YValues);
                dp.Add(pn);
            }

            return dp;
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

        private void numericUpDownn_ValueChanged(object sender, EventArgs e)
        {
            RenderGraph();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RenderGraph();
        }

        private void textBoxK_Leave(object sender, EventArgs e)
        {
            if (textBoxK.Text.Length != 5 || !textBoxK.Text.Contains("1"))
            {
                textBoxK.Text = "12345";
                RenderGraph();
            }
        }
    }
}
