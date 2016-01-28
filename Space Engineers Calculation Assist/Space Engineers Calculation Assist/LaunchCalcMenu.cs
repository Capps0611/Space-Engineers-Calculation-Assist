using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Engineers_Calculation_Assit
{
    public partial class LaunchCalcMenu : Form
    {
        public LaunchCalcMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string massText = massTextBox.Text;
            string gravityText = gravityTextBox.Text;
            string forceText = forceTextBox.Text;
            double mass = 0;
            double.TryParse(massText,out mass);
            double gravity = 0;
            double.TryParse(gravityText, out gravity);
            double force;

            if((mass != 0) && (gravity != 0))
            {
                force = (mass * gravity) / 1000;
                forceTextBox.Text = force.ToString("#,##");
            }
            else
            {
                MessageBox.Show("Please check to ensure you entered valid numeric values", "Invalid Input!" , MessageBoxButtons.OKCancel);
            }

        }
    }
}
