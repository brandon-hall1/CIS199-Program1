/*
 * Grading ID: K3194
 * Due Date: 2/15/2022
 * Program 1
 * Course Section: CIS 199-01
 * Description: Calculates total sq feet needed, 10% extra, total labor and material cost,
 *              and overall total cost for building a shed based on user inputted values.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string frontLengthInputAsString = frontLengthInput.Text; //string to hold front length input
            string sideLengthInputAsString = sideLengthInput.Text; //string to hold side length input
            string heightInputAsString = heightInput.Text; //string to hold height input
            string windowSelectionAsString = windowInput.Text; //string to hold window selection input
            string dryWallCostAsString = dryWallCostInput.Text; //string to hold dry wall cost input
            string laborCostAsString = laborCostInput.Text; //string to hold labor cost input
            double frontLength; //double to hold parsed front length
            double sideLength; //double to hold parsed side length
            double height; //double to hold parsed height
            int windowSelection; //int to hold parsed window selection
            double dryWallCost; //double to hold parsed dry wall cost
            double laborCost; //double to hold parsed labor cost

            try //attempt to parse all strings inputted by user
            {
                frontLength = double.Parse(frontLengthInputAsString);
                sideLength = double.Parse(sideLengthInputAsString);
                height = double.Parse(heightInputAsString);
                windowSelection = Int32.Parse(windowSelectionAsString);
                if(windowSelection != 0 && windowSelection != 1) //verify either 0 or 1 was inputted for window selection
                {
                    throw new Exception(); //if window selection not 0 or 1, throw exception
                }
                dryWallCost = double.Parse(dryWallCostAsString);
                laborCost = double.Parse(laborCostAsString);
            }
            catch (Exception ex) //set all output values to INVALID INPUT if any inputs can't be parsed/are incorrect
            {
                totalSqFeetOutput.Text = "INVALID INPUT";
                tenPercentExtraOutput.Text = "INVALID INPUT";
                totalLaborCostOutput.Text = "INVALID INPUT";
                totalMaterialCostOutput.Text = "INVALID INPUT";
                totalCostOutput.Text = "INVALID INPUT";
                return;
            }

            double windowCost = 0; //double to hold window cost ($0 or $100)
            if(windowSelection == 1) //if window is wanted, set window cost to $100
            {
                windowCost = 100;
            }

            const double TEN_PERCENT_EXTRA = 1.1; //constant to hold ten percent extra multiplier
            double frontAndBackSqFeet = frontLength * height * 2; //double to hold front and back sq feet
            double bothSidesSqFeet = sideLength * height * 2; //double to hold both sides' sq feet
            double ceilingSqFeet = frontLength * sideLength; //double to hold ceiling's sq feet

            double totalSqFeet = frontAndBackSqFeet + bothSidesSqFeet + ceilingSqFeet; //double to hold sum of all sq feet
            double tenPercentExtra = totalSqFeet * TEN_PERCENT_EXTRA; //double to hold 110% of total sq feet
            double totalLaborCost = laborCost * tenPercentExtra; //double to hold total labor cost
            double totalMaterialCost = dryWallCost * tenPercentExtra; //double to hold total material cost
            double totalCost = totalLaborCost + totalMaterialCost + windowCost; //double to hold total overall cost

            totalSqFeetOutput.Text = totalSqFeet.ToString("N2"); //set all output labels to their respective values with formatting
            tenPercentExtraOutput.Text = tenPercentExtra.ToString("N2");
            totalLaborCostOutput.Text = totalLaborCost.ToString("C");
            totalMaterialCostOutput.Text = totalMaterialCost.ToString("C");
            totalCostOutput.Text = totalCost.ToString("C");
        }
    }
}
