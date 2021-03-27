using System;
using System.Windows.Forms;

namespace windows_calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 1099)
            {
                LoadingTimer.Stop();
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}