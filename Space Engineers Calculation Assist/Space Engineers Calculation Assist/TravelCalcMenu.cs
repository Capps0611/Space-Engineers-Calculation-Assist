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
    public partial class TravelCalcMenu : Form
    {
        public TravelCalcMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string distanceText = distanceTextBox.Text;
            string speedText = speedTextBox.Text;
            double distance = 0;
            double.TryParse(distanceText, out distance);
            double speed = 0;
            double.TryParse(speedText, out speed);
            double etaSec;
            double etaMins;
            double etaHours;

            if ((distance != 0) && (speed != 0))
            {
                etaSec = Math.Round(distance / speed,0);
                if(etaSec > 60)
                {
                    etaMins = Math.Round(etaSec / 60,0);
                    double remainingSec = Math.Round(etaSec - (etaMins * 60),0);
                    if(etaMins > 60)
                    {
                        etaHours = Math.Round(etaMins / 60,0);
                        double remainingMins = Math.Round(etaMins - (etaHours * 60),0);
                        etaTextBox.Text = etaHours + ":" + Math.Abs(remainingMins);
                    }
                    else
                    {
                        etaTextBox.Text = "00:" + etaMins + ":" + Math.Abs(remainingSec);
                    }

                }
                else
                {
                    etaTextBox.Text = "00:00:" + etaSec;
                }
            }
            else
            {
                MessageBox.Show("Please check to ensure you entered valid numeric values", "Invalid Input!", MessageBoxButtons.OKCancel);
            }
        }
    }
}
