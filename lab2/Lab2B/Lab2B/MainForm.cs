/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines the MainForm class for a hair salon pricing application. 
             It allows users to select a hairdresser, services, client type, and the number 
             of client visits to calculate the total price for the salon services. 
             The application validates input fields and provides a user-friendly interface.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's 
    work has been used without due acknowledgement.
*/

using System;
using System.Windows.Forms;

namespace Lab2B
{
    /// <summary>
    /// MainForm class for the hair salon pricing application. 
    /// Provides the user interface to select a hairdresser, services, client type, 
    /// and number of client visits to calculate the total price.
    /// </summary>
    public partial class MainForm : Form
    {
        // Member variables to store pricing information
        private double basePrice = 0;
        private double serviceCost = 0;
        private double discount = 0;

        /// <summary>
        /// Constructor for MainForm. Initializes the form components.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Calculate button click event. Calculates the total price based on user selections.
        /// </summary>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Reset previous calculation values
            basePrice = 0;
            serviceCost = 0;
            discount = 0;

            // Determine the selected hairdresser's base price
            if (radioJane.Checked) basePrice = 30;
            else if (radioPat.Checked) basePrice = 45;
            else if (radioRon.Checked) basePrice = 40;
            else if (radioSue.Checked) basePrice = 50;
            else if (radioLaura.Checked) basePrice = 55;

            // Calculate the total cost of selected services
            if (checkCut.Checked) serviceCost += 30;
            if (checkColor.Checked) serviceCost += 40;
            if (checkHighlights.Checked) serviceCost += 50;
            if (checkExtensions.Checked) serviceCost += 200;

            // Ensure at least one service is selected
            if (serviceCost == 0)
            {
                MessageBox.Show("Please select at least one service.");
                checkCut.Focus(); // Set focus to the services group
                return;
            }

            // Get the discount rate based on the selected client type
            if (radioStandard.Checked) discount = 0;
            else if (radioChild.Checked) discount = 0.10;
            else if (radioStudent.Checked) discount = 0.05;
            else if (radioSenior.Checked) discount = 0.15;

            // Validate the number of client visits input
            if (int.TryParse(textClientVisits.Text, out int visits) && visits > 0)
            {
                // Apply additional discount based on the number of visits
                if (visits >= 4 && visits <= 8) discount += 0.05;
                else if (visits >= 9 && visits <= 13) discount += 0.10;
                else if (visits >= 14) discount += 0.15;
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number for client visits.");
                textClientVisits.Focus(); // Set focus to the client visits input
                return;
            }

            // Calculate the total price after applying discounts
            double totalPrice = (basePrice + serviceCost) * (1 - discount);
            labelTotalPrice.Text = $"${totalPrice:F2}";
        }

        /// <summary>
        /// Handles the Clear button click event. Resets all controls to their default state.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset all selections to default
            radioJane.Checked = true;// Select the first hairdresser by default
            radioStandard.Checked = true;//Select first client type
            checkCut.Checked = false;
            checkColor.Checked = false;
            checkHighlights.Checked = false;
            checkExtensions.Checked = false;
            textClientVisits.Clear();
            labelTotalPrice.Text = "";
            radioJane.Focus(); // Set focus to the first radio button in Hairdresser group
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }

        /// <summary>
        /// Handles the Exit button click event. Closes the application.
        /// </summary>
        

        private void radioSue_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioChild_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textClientVisits_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void hairDresser_Enter(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
