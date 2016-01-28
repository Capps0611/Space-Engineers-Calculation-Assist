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
    public partial class PowerCalcMenu : Form
    {
        public PowerCalcMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gets all info for Lg Atmo Thrusters and sets total usage
            double lgAtmoPower = 0;
            double.TryParse(lgAtmoOutput.Text, out lgAtmoPower);
            double lgAtmoNum = Convert.ToDouble(lgAtmoAmount.Value);
            double lgAtmoResult = lgAtmoPower * lgAtmoNum;
            lgAtmoTotal.Text = lgAtmoResult.ToString("#,##");

            //Gets all info for Sm Atmo Thruster and sets total usage
            double smAtmoPower = 0;
            double.TryParse(smAtmoOutput.Text, out smAtmoPower);
            double smAtmoNum = Convert.ToDouble(smAtmoAmount.Value);
            double smAtmoResult = smAtmoPower * smAtmoNum;
            smAtmoTotal.Text = smAtmoResult.ToString("#,##");

            //Gets all info for Lg Hydro Thruster and sets total usage
            double lgHydroPower = 0;
            double.TryParse(lgHydroOutput.Text, out lgHydroPower);
            double lgHydroNum = Convert.ToDouble(lgHydroAmount.Value);
            double lgHydroResult = lgHydroPower * lgHydroNum;
            lgHydroTotal.Text = lgHydroResult.ToString("#,##");

            //Gets all info for Sm Hydro Thruster and sets total usage
            double smHydroPower = 0;
            double.TryParse(smHydroOutput.Text, out smHydroPower);
            double smHydroNum = Convert.ToDouble(smHydroAmount.Value);
            double smHydroResult = smHydroPower * smHydroNum;
            smHydroTotal.Text = smHydroResult.ToString("#,##");

            //Gets all info for Lg Ion Thruster and sets total usage
            double lgIonPower = 0;
            double.TryParse(lgIonOutput.Text, out lgIonPower);
            double lgIonNum = Convert.ToDouble(lgIonAmount.Value);
            double lgIonResult = lgIonPower * lgIonNum;
            lgIonTotal.Text = lgIonResult.ToString("#,##");

            //Gets all info for Sm Ion Thruster and sets total usage
            double smIonPower = 0;
            double.TryParse(smIonOutput.Text, out smIonPower);
            double smIonNum = Convert.ToDouble(smIonAmount.Value);
            double smIonResult = smIonPower * smIonNum;
            smIonTotal.Text = smIonResult.ToString("#,##");

            //Gets total power needed and # of small/large reactors needed
            double totalShipPower = lgAtmoResult + smAtmoResult + lgHydroResult + smHydroResult + lgIonResult + smIonResult;
            totalPower.Text = totalShipPower.ToString("#,##");
            double totalSmReactorsNeeded = Math.Round(totalShipPower / 15000, 2);
            totalSmReactors.Text = totalSmReactorsNeeded.ToString();
            double totalLgReactorsNeeded = Math.Round(totalShipPower / 300000, 2);
            totalLgReactors.Text = totalLgReactorsNeeded.ToString();

        }
    }
}
