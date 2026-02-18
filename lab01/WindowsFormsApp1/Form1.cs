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

namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Series currentSeries;
        decimal t, x, y, v0, cosa, sina, dt, MaxHeight, S, m, k, vx, vy;
        const decimal g = 9.81M, rho = 1.29M, C = 0.15M;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            label6.Text = "Distance: -";
            label1.Text = "Max height: -";
            label3.Text = "Final speed: -";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                
                t = 0;
                x = 0;
                MaxHeight = 0;

                
                y = inputHeight.Value;
                v0 = inputSpeed.Value;
                dt = inputStep.Value;

            
                double a = (double)inputAngle.Value * Math.PI / 180;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);

               
                S = inputSize.Value;
                m = inputWeight.Value;

                
                k = 0.5M * C * rho * S / m;

                
                vx = v0 * cosa;
                vy = v0 * sina;

             
                string seriesName = "Step " + dt.ToString() + " #" + (chart1.Series.Count + 1);
                currentSeries = chart1.Series.Add(seriesName);
                currentSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                currentSeries.BorderWidth = 3;

               
                currentSeries.Points.AddXY(x, y);

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int subSteps = 1000;   
            int drawEach = 50;     

            for (int i = 0; i < subSteps; i++)
            {
                t += dt;

                decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));

               
                vx = vx - k * vx * v * dt;
                vy = vy - (g + k * vy * v) * dt;

               
                x = x + vx * dt;
                y = y + vy * dt;

                if (y > MaxHeight) MaxHeight = y;

                if (i % drawEach == 0)
                    currentSeries.Points.AddXY(x, y);

                
                if (y <= 0)
                {
                    y = 0;
                    currentSeries.Points.AddXY(x, y); // добавим точку на земле
                    timer1.Stop();
                    break;
                }

               
                if (y > 10000 || x > 100000 || x < -100000)
                {
                    timer1.Stop();
                    break;
                }
            }

           
            decimal vNow = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            label6.Text = "Distance: " + x.ToString("0.00") + " m";
            label1.Text = "Max height: " + MaxHeight.ToString("0.00") + " m";
            label3.Text = "Final speed: " + vNow.ToString("0.00") + " m/s";
        }
    }
    }

