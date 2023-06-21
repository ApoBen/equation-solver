using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Serialization;

namespace aposeducate
{

    public partial class Form1 : Form
    {
               
        public Form1()
        {

            InitializeComponent();
            


        }
        private void button1_Click(object sender, EventArgs e)
        {
         int a = Convert.ToInt32(textBox1.Text);
         int b = Convert.ToInt32(textBox2.Text);
         int c = Convert.ToInt32(textBox3.Text);


            int delta = b * b - 4 * a * c;
            double kdelta = Math.Sqrt(Math.Abs(delta));



            double realPart = -b / (2.0 * a);
            double imaginaryPart = kdelta / (2.0 * a);



            label5.Text = "Δ = " + delta;


            if (delta < 0)
            {
                
            label6.Text = "solution (no real root) = " + "x1 = " + realPart + "+" + imaginaryPart + "i" + "  &  " + "x1 = " + realPart + "-" + imaginaryPart + "i";


            }
            else {
                double x1 = realPart + imaginaryPart;
                double x2 = realPart - imaginaryPart;

                label6.Text = "reel solution = " + Convert.ToString(x1) + " and " + Convert.ToString(x2);
                int kcarp = c / a;
                int ktop = -b / a;
                label7.Text = "x1.x2 = "+ kcarp;
                label8.Text = "x1+x2 = "+ ktop;



            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
