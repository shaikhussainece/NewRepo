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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = cboColor.Text;
            switch(c)
            {
                case "Red":
                    this.BackColor = Color.Red;
                    break;
                case "Green":
                    this.BackColor = Color.Green;
                    break;
                case "Blue":
                    this.BackColor = Color.Blue;
                        break;
/// this.BackColor = Color.FromName(c);
/// if (
            }
        }
    }
}
