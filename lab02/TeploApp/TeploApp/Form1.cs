using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeploApp
{
    public partial class Form1 : Form
    {
        private double L, T0, Ta, Tn, rho, c, lambda;

        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCenterTemp.Text = "Температура в центре: --- °C";
            lblCalcTime.Text = "Время расчета: --- мс";

            chartTemperature.Series.Clear();

            txtL.Text = "1.0";
            txtT0.Text = "0.0";
            txtTa.Text = "100.0";
            txtTn.Text = "0.0";
            txtRho.Text = "1.0";
            txtC.Text = "1.0";
            txtLambda.Text = "1.0";
            txtTotalTime.Text = "2.0";

            cboTimeStep.SelectedIndex = 1;
            cboSpaceStep.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InitializeComboBoxes()
        {
            string[] steps = { "0.1", "0.01", "0.001", "0.0001" };

            cboTimeStep.Items.AddRange(steps);
            cboTimeStep.SelectedIndex = 1;

            cboSpaceStep.Items.AddRange(steps);
            cboSpaceStep.SelectedIndex = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                
                L = double.Parse(txtL.Text.Replace('.', ','));
                T0 = double.Parse(txtT0.Text.Replace('.', ','));
                Ta = double.Parse(txtTa.Text.Replace('.', ','));
                Tn = double.Parse(txtTn.Text.Replace('.', ','));
                rho = double.Parse(txtRho.Text.Replace('.', ','));
                c = double.Parse(txtC.Text.Replace('.', ','));
                lambda = double.Parse(txtLambda.Text.Replace('.', ','));

                double tau = double.Parse(cboTimeStep.SelectedItem.ToString().Replace('.', ','));
                double h = double.Parse(cboSpaceStep.SelectedItem.ToString().Replace('.', ','));
                double totalTime = 2.0;

                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                double[] result = CalculateHeatDistribution(tau, h, totalTime);
                stopwatch.Stop();

                int centerIndex = result.Length / 2;
                double centerTemp = result[centerIndex];

              
                lblCenterTemp.Text = $"Температура в центре: {centerTemp:F3} °C";
                lblCalcTime.Text = $"Время расчета: {stopwatch.ElapsedMilliseconds} мс";

                DrawGraph(result, h);

                MessageBox.Show($"Расчет завершен!\n{lblCenterTemp.Text}\n{lblCalcTime.Text}",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double[] SolveTridiagonal(double[] a, double[] b, double[] c, double[] f, int n)
        {
            double[] alpha = new double[n];
            double[] beta = new double[n];
            double[] x = new double[n];

            alpha[0] = -c[0] / b[0];
            beta[0] = f[0] / b[0];

            for (int i = 1; i < n; i++)
            {
                double denom = b[i] + a[i] * alpha[i - 1];
                alpha[i] = -c[i] / denom;
                beta[i] = (f[i] - a[i] * beta[i - 1]) / denom;
            }

            x[n - 1] = beta[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                x[i] = alpha[i] * x[i + 1] + beta[i];
            }

            return x;
        }

        private double[] CalculateHeatDistribution(double tau, double h, double totalTime)
        {
            int N = (int)(L / h) + 1;
            int timeSteps = (int)(totalTime / tau);

            double[] T = new double[N];
            for (int i = 0; i < N; i++) T[i] = T0;

            double r = lambda * tau / (rho * c * h * h);

            double[] a = new double[N];
            double[] b = new double[N];
            double[] c_coef = new double[N];
            double[] f = new double[N];

            for (int i = 0; i < N; i++)
            {
                if (i == 0 || i == N - 1)
                {
                    a[i] = 0; b[i] = 1; c_coef[i] = 0;
                }
                else
                {
                    a[i] = -r;
                    b[i] = 1 + 2 * r;
                    c_coef[i] = -r;
                }
            }

            for (int step = 0; step < timeSteps; step++)
            {
                for (int i = 0; i < N; i++)
                {
                    if (i == 0) f[i] = Ta;
                    else if (i == N - 1) f[i] = Tn;
                    else f[i] = T[i];
                }
                T = SolveTridiagonal(a, b, c_coef, f, N);
            }

            return T;
        }

        private void DrawGraph(double[] temperature, double h)
        {
            chartTemperature.Series.Clear();
            var series = chartTemperature.Series.Add("Распределение T");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series.Color = Color.Red;
            series.BorderWidth = 2;

            for (int i = 0; i < temperature.Length; i++)
            {
                double x = i * h;
                series.Points.AddXY(x, temperature[i]);
            }

            var area = chartTemperature.ChartAreas[0];
            area.AxisX.Title = "x (м)";
            area.AxisY.Title = "T (°C)";
            area.AxisX.MajorGrid.Enabled = true;
            area.AxisY.MajorGrid.Enabled = true;
        }
       
    }
}