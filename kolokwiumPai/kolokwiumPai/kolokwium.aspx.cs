using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kolokwiumPai
{
    public partial class kolokwium : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Chart1.Visible = true;
            Chart1.Series.Clear();
            Chart1.Titles.Clear();

            Chart1.Titles.Add("Całka sinx");
            Chart1.ChartAreas[0].AxisX.Title = "Oś wartości X";
            Chart1.ChartAreas[0].AxisY.Title = "Oś wartości Y";
            Chart1.ChartAreas[0].AxisY.LineWidth = 5;

            Chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Black;
            Chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = true;
            Chart1.ChartAreas[0].AxisX.MinorGrid.LineDashStyle = System.Web.UI.DataVisualization.Charting.ChartDashStyle.Dot;

            Chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
            Chart1.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.Silver;
            Chart1.ChartAreas[0].AxisY.MinorGrid.LineDashStyle = System.Web.UI.DataVisualization.Charting.ChartDashStyle.Dot;

            Chart1.Series.Add("Wykres sinx");

            try
            {
                double x1 = double.Parse(TextBox1.Text);
                double x2 = double.Parse(TextBox2.Text);

                // double result = FastIntegral(x1, x2, 1);
                // Label1.Text = String.Format(" result: {0:0.0000}", result);

                Chart1.Series["Wykres sinx"].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Line;

                Chart1.Series["Wykres sinx"].Color = Color.DarkBlue;
                Chart1.Series["Wykres sinx"].BorderWidth = 2;

                for(double x = x1;x<=x2;x+=0.001)
                {
                    Chart1.Series["Wykres sinx"].Points.AddXY(x, Math.Sin(x));
                }

                DateTime startTime = DateTime.Now;
                
                Label1.Text = String.Format(" result: {0:0.0000}", Integral(x1, x2));
                // Label1.Text = String.Format(" result: {0:0.0000}", FastIntegral(x1, x2, 1));

                TimeSpan runningTime = DateTime.Now - startTime;
                Label2.Text = "Czas zadania: " + runningTime.TotalSeconds + " sec";

                Label3.Visible = false;
            }
            catch(Exception)
            {
                Label3.Text = "Wystapil blad w dzialaniu programu";
                Label3.Visible = true;
            }

        }

        private double Integral(double start, double end, double accuracy=0.001)
        {
            double result = 0.0;

            for (double i = start; i < end; i += accuracy)
            {
                result += Area(Math.Sin(i), Math.Sin(i + accuracy), accuracy);
            }

            return result;
        }

        private double FastIntegral(double start, double end, int intervals, double accuracy = 0.001)
        {
            double[] result = new double[intervals];
            double interval = (end-start)/intervals;

            Parallel.For(0, intervals, (int x) =>
            {
                result[x] = 0.0;
                for (double i = start + x*interval; i <= start + (x+1)*interval; i += accuracy)
                {
                    result[x] += Area(Math.Sin(i), Math.Sin(i + accuracy), accuracy);
                }
            });

            return result.Sum();
        }

        private double Area(double a, double b, double h)
        {
            return (a + b) * h / 2.0;
        }
    }
}