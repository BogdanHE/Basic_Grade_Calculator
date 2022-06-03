using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Grade_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float v1, v2, v3, v4, total, avg;
            v1 = float.Parse(Input1.Text);
            v2 = float.Parse(Input2.Text);
            v3 = float.Parse(Input3.Text);
            v4 = float.Parse(Input4.Text);
            total = v1+v2+ v3 + v4;
            avg = total / 4;

            InputTotal.Text = "" + total;
            InputAverage.Text = "" + avg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input1.Text = "";
            Input2.Text = "";
            Input3.Text = "";
            Input4.Text = "";
            InputTotal.Text = "";
            InputAverage.Text = "";
            Input1.Focus();
        }

        private void Input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input4_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputAverage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
