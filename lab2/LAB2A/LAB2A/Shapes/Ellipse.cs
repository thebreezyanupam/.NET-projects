/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines the Ellipse class, which represents a 2D ellipse shape. 
             It allows the user to input the semi-major and semi-minor axes of the ellipse, 
             calculates the area, and provides a text description of the ellipse's properties.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/

using System;

namespace Lab2A
{
    /// <summary>
    /// Represents an ellipse. This class allows setting the semi-major and semi-minor axes,
    /// calculating the area, and displaying the ellipse's details in a readable format.
    /// </summary>
    public class Ellipse : TwoDimensionalShape
    {
        private double semiMajorAxis; // Holds the length of the ellipse's semi-major axis
        private double semiMinorAxis; // Holds the length of the ellipse's semi-minor axis

        /// <summary>
        /// Constructor for the Ellipse class. Sets the shape type to "Ellipse".
        /// </summary>
        public Ellipse()
        {
            Type = "Ellipse";
        }

        /// <summary>
        /// Prompts the user to enter the semi-major and semi-minor axes of the ellipse.
        /// Keeps asking until the user provides valid positive numbers.
        /// </summary>
        public override void SetData()
        {
            bool validInput = false; // Tracks whether the input is valid
            while (!validInput) // Loop until valid input is received
            {
                Console.WriteLine("Enter the semi-major axis of the ellipse: ");
                // Try to parse the user input for the semi-major axis
                if (double.TryParse(Console.ReadLine(), out double input1) && input1 > 0)
                {
                    semiMajorAxis = input1; // Save the valid semi-major axis
                    Console.WriteLine("Enter the semi-minor axis of the ellipse: ");
                    // Try to parse the user input for the semi-minor axis
                    if (double.TryParse(Console.ReadLine(), out double input2) && input2 > 0)
                    {
                        semiMinorAxis = input2; // Save the valid semi-minor axis
                        validInput = true; // Exit the loop since we have valid input
                    }
                    else
                    {
                        // If the semi-minor axis input is invalid, show an error message
                        Console.WriteLine("Invalid input. Please enter a positive numeric value for the semi-minor axis...");
                    }
                }
                else
                {
                    // If the semi-major axis input is invalid, show an error message
                    Console.WriteLine("Invalid input. Please enter a positive numeric value for the semi-major axis...");
                }
            }
        }

        /// <summary>
        /// Calculates the area of the ellipse using the formula: π * semiMajorAxis * semiMinorAxis.
        /// </summary>
        /// <returns>The calculated area of the ellipse.</returns>
        public override double CalculateArea()
        {
            return PI * semiMajorAxis * semiMinorAxis; // Formula for the area of an ellipse
        }

        /// <summary>
        /// Creates a string that describes the ellipse's semi-major axis, semi-minor axis, and area.
        /// </summary>
        /// <returns>A string with the ellipse's dimensions and calculated area.</returns>
        public override string ToString()
        {
            // Format the output to include the semi-major axis, semi-minor axis, and area with two decimal places
            return $"{Type}: Semi-Major Axis = {semiMajorAxis}, Semi-Minor Axis = {semiMinorAxis}, Area = {CalculateArea():F2}";
        }
    }
}
