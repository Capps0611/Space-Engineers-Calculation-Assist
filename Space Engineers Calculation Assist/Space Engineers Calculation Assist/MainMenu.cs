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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LaunchCalcMenu lc = new LaunchCalcMenu();
            lc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TravelCalcMenu tc = new TravelCalcMenu();
            tc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PowerCalcMenu pc = new PowerCalcMenu();
            pc.Show();
        }
    }
}
