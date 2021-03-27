using System;
using System.Windows.Forms;

namespace windows_calculator
{
    public partial class Form1 : Form
    {
        // Globle Variables
        private Double results = 0;

        private String operation = "";

        private bool enter_value = false;

        private float iCelsius, iFahrenheit, ikelvin;
        private char iOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void sciToolStripMenuItem_Click(object sender, EventArgs e)

        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.141592653589976323";
            // Value of PI
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void standerdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 280;
            txtDisplay.Width = 245;
            //Change width along with stripmenu action
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 560;
            txtDisplay.Width = 525;
            //Change width along with stripmenu action
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void tempConvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 820;
            txtDisplay.Width = 530;
            //Change width along with stripmenu action
        }

        private void button_Click(object sender, EventArgs e)
        {
            //grab number input and display

            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;
            Button num = (Button)sender;

            //enter decimal and show only one decimal place
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + num.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        private void lblShowOp_Click(object sender, EventArgs e)
        {
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            lblShowOp.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Group as click events  + - / * mod exp operator buttons and assign arithmetics operation
            lblShowOp.Text = " ";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "*":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "Mod":
                    txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = (results);
                    txtDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }// END Group

        private void button22_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Sqrt" + "(" + (txtDisplay.Text) + ")");
            sq = Math.Sqrt(sq);
            txtDisplay.Text = System.Convert.ToString(sq);
        }

        //trig identites (Sin, Cos, Tan, Sinh,Cosh,Tanh)
        private void button23_Click(object sender, EventArgs e)
        {
            double Sinh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Sinh" + "(" + (txtDisplay.Text) + ")");
            Sinh = Math.Sinh(Sinh);
            txtDisplay.Text = System.Convert.ToString(Sinh);
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Sin" + "(" + (txtDisplay.Text) + ")");
            sin = Math.Sin(sin);
            txtDisplay.Text = System.Convert.ToString(sin);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Cos" + "(" + (txtDisplay.Text) + ")");
            cos = Math.Cos(cos);
            txtDisplay.Text = System.Convert.ToString(cos);
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            double Cosh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Cosh" + "(" + (txtDisplay.Text) + ")");
            Cosh = Math.Cosh(Cosh);
            txtDisplay.Text = System.Convert.ToString(Cosh);
        }

        private void btntanh_Click(object sender, EventArgs e)
        {
            double Tanh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Tanh" + "(" + (txtDisplay.Text) + ")");
            Tanh = Math.Tanh(Tanh);
            txtDisplay.Text = System.Convert.ToString(Tanh);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double Tan = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Tan" + "(" + (txtDisplay.Text) + ")");
            Tan = Math.Tan(Tan);
            txtDisplay.Text = System.Convert.ToString(Tan);
        }

        // End trig identites

        // Base converstion 2 8 10 16
        private void button31_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 2);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 8);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 10);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 16);
        }

        // END Base converstion

        private void button37_Click(object sender, EventArgs e)
        {
            Double b;
            b = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(b);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Double c;
            c = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(c);
        }

        // calculate Log
        private void button39_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void unitConvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Stripe_Click(object sender, EventArgs e)
        {
        }

        // Temperature Conversion

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void rbFtoC_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        // about button
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void none(object sender, EventArgs e)
        {
        }

        private void none(object sender, MouseEventArgs e)
        {
        }

        private void tempCvt_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'C':
                    // C to F cvt.
                    iCelsius = float.Parse(Tempin.Text);
                    lblTempout.Text = (((iCelsius * 1.8) + 32).ToString());
                    break;

                case 'F':
                    // F to C cvt.
                    iFahrenheit = float.Parse(Tempin.Text);
                    lblTempout.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
                    break;

                case 'K':
                    // Cvt C to kelvin
                    ikelvin = float.Parse(Tempin.Text);
                    lblTempout.Text = (((ikelvin) + 273.15).ToString());
                    break;
            }
        }

        private void tempReset_Click(object sender, EventArgs e)
        {
            Tempout.Clear();
            Tempin.Clear();
            lblTempout.Text = "";
            rbCtoF.Checked = false;
            rbFtoC.Checked = false;
            rbKelvin.Checked = false;
        }

        // Temperature Conversion End
    }
}