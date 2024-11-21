/**
 * Name: Anupam Pandey
 * Student Number: 000921043
 * Date: 3rd Nov 2024
 * Purpose: This file contains the main logic for handling media data and user interactions in the console program.
 * Statement of Authorship: I, Anupam Pandey, 000921043 certify that this material is my 
 * original work. No other person's work has 
 * been used without due acknowledgement.
 */

using System;
using System.Windows.Forms;

namespace Lab3B
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the form.
        /// Initializes UI elements to their default state.
        /// </summary>
        private void HairSalon_Load(object sender, EventArgs e)
        {
            // Disable buttons initially 
            btn_AddServices.Enabled = false;
            btn_CalculateTotalPrice.Enabled = false;

            // Select the first hairdresser by default
            cb_hairdresser.SelectedIndex = 0;

            // Set charged items and prices list boxes to read-only
            lb_chargedItems.Enabled = false;
            lb_Prices.Enabled = false;
        }

        // Arrays representing prices for hairdressers and services
        private int[] hairdresserPrices = { 30, 45, 40, 50, 55 };
        private int[] servicePrices = { 30, 20, 40, 50, 200, 60 };

        /// <summary>
        /// Handles the Add Services button click event.
        /// Adds the selected hairdresser and services to the charged items list.
        /// </summary>
        private void btn_ClickAddServices(object sender, EventArgs e)
        {
            // Add the selected hairdresser if the ComboBox is enabled
            if (cb_hairdresser.Enabled && cb_hairdresser.SelectedIndex != -1)
            {
                int selectedDresserIndex = cb_hairdresser.SelectedIndex;
                string selectedHairdresser = cb_hairdresser.SelectedItem.ToString();
                int dresserPrice = hairdresserPrices[selectedDresserIndex];

                // Add hairdresser name and price to the Charged Items and Prices list boxes
                lb_chargedItems.Items.Add($"{selectedHairdresser}");
                lb_Prices.Items.Add($"${dresserPrice}");

                // Disable the ComboBox to prevent re-selection of the hairdresser
                cb_hairdresser.Enabled = false;
            }

            // Add selected services and their prices if any are selected.
            if (lb_service.SelectedItems.Count > 0)
            {
                foreach (int selectedServiceIndex in lb_service.SelectedIndices)
                {
                    string selectedService = lb_service.Items[selectedServiceIndex].ToString();
                    int servicePrice = servicePrices[selectedServiceIndex];

                    // Add service name and price to the Charged Items and Prices list boxes.
                    lb_chargedItems.Items.Add(selectedService);
                    lb_Prices.Items.Add($"${servicePrice}");
                }
                // Clear service selections after adding.
                lb_service.ClearSelected();
            }

            // Enable the Calculate Total Price button after adding items.
            btn_CalculateTotalPrice.Enabled = true;
        }

        /// <summary>
        /// Handles the Calculate Total Price button click event.
        /// Calculates and displays the total price of the selected items.
        /// </summary>
        private void btn_ClickCalculateTotalPrice(object sender, EventArgs e)
        {
            decimal totalPrice = 0;

            // Sum up the prices in the Prices ListBox.
            foreach (object item in lb_Prices.Items)
            {
                string priceString = item.ToString().Trim('$');
                if (decimal.TryParse(priceString, out decimal price))
                {
                    totalPrice += price;
                }
            }

            // Display the total price in the label.
            label_TotalPrice.Text = $"${totalPrice}";
        }

        /// <summary>
        /// Handles the Reset button click event.
        /// Resets the form to its initial state.
        /// </summary>
        private void btn_ClickReset(object sender, EventArgs e)
        {
            // Enable the ComboBox for hairdresser selection.
            cb_hairdresser.Enabled = true;
            // Select the first entry.
            cb_hairdresser.SelectedIndex = 0;

            // Clear the charged items and prices.
            lb_chargedItems.Items.Clear();
            lb_Prices.Items.Clear();
            lb_service.ClearSelected();

            // Clear the total price label.
            label_TotalPrice.Text = "";

            // Disable buttons to reset the initial state.
            btn_AddServices.Enabled = false;
            btn_CalculateTotalPrice.Enabled = false;
        }

        /// <summary>
        /// Handles the Exit button click event.
        /// Closes the application.
        /// </summary>
        private void btn_ClickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Service ListBox selection change event.
        /// Enables the Add Services button when a service is selected.
        /// </summary>
        private void lb_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_AddServices.Enabled = true;
        }
    }
}
