using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(txtPrincipal.Text);
            double r = Convert.ToDouble(cbo1.Text);
            double t = Convert.ToDouble(cbo2.Text);
            double si = (p * t * r) / 100;
            txtResult.Text = si.ToString();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtPrincipal.Clear();
            txtResult.Clear();
        }

        private void Cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(cbo1.Text);
            cbo2.Items.Clear();
            switch (r)
            {
                case 5:
                    cbo2.Items.Add(1);
                    cbo2.Items.Add(2);
                    cbo2.Items.Add(3);
                    break;
                case 10:
                    cbo2.Items.Add(4);
                    cbo2.Items.Add(6);
                    cbo2.Items.Add(8);
                    break;
                case 15:
                    cbo2.Items.Add(5);
                    cbo2.Items.Add(10);
                    cbo2.Items.Add(12);
                    break;
                default:
                    break;
            }
        }

        private void TxtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
