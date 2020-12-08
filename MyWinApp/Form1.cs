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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;

        }
    }
}
