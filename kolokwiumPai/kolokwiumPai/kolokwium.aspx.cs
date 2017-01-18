using System;
using System.Collections.Generic;
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
            double x1 = double.Parse(TextBox1.Text);
            double x2 = double.Parse(TextBox2.Text);

            double result = integral(x1, x2);
            Label1.Text = String.Format(" result: {0:0.0000}",result);
        }

        private double integral(double start, double end, double accuracy=0.001)
        {
            double result = 0.0;

            for (double i = start; i < end; i += accuracy)
            {
                result += area(Math.Sin(i), Math.Sin(i + accuracy), accuracy);
            }

            return result;
        }

        private double integral(double start, double end, int intervals, double accuracy = 0.001)
        {
            double[] result = new double[intervals];
            double interval = (end-start)/intervals;

            Parallel.For(0, intervals, (int x)=> 
            {
                result[x] = 0.0;
                for(double i = start;i<end;i+=accuracy)
                {

                }
            }

            for (double i = start; i < end; i += accuracy)
            {
                result += area(Math.Sin(i), Math.Sin(i + accuracy), accuracy);
            }

            return result;
        }

        private double area(double a, double b, double h)
        {
            return (a + b) * h / 2.0;
        }
    }
}