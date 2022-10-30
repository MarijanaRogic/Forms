using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal pi, R, result1, result2;
            pi = Convert.ToDecimal(3.14);
            R = Convert.ToDecimal(txtRadius.Text);
            result1 = pi * R * R;
            result2 = 2 * pi * R;
            lblArea.Text = $"Area {result1}";
            lblPerimetar.Text = $"Perimetar {result2}";
        }
    }
}
