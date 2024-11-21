/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines a Circle class that inherits from the TwoDimensionalShape class.
             The class lets the user enter the circle's radius and then calculates the area based on that input.
             It also provides a simple text description of the circle's properties.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's
    work has been used without due acknowledgement.
*/

using System;

namespace Lab2A
{
    /// <summary>
    /// Represents a circle. This class allows setting the radius, calculating the area,
    /// and displaying the circle's details in a simple format.
    /// </summary>
    public class Circle : TwoDimensionalShape
    {
        private double radius; // This will hold the radius of the circle

        /// <summary>
        /// Constructor for the Circle class. Sets the shape type to "Circle".
        /// </summary>
        public Circle()
        {
            Type = "Circle";
        }

        /// <summary>
        /// Prompts the user to enter the radius of the circle.
        /// Keeps asking until the user provides a valid positive number.
        /// </summary>
        public override void SetData()
        {
            bool validInput = false; // This will track whether the input is valid
            while (!validInput) // Loop until a valid input is provided
            {
                Console.WriteLine("Enter the radius of the circle: ");
                // Try to parse the user input into a double and check if it's positive
                if (double.TryParse(Console.ReadLine(), out double input) && input > 0)
                {
                    radius = input; // Save the valid radius
                    validInput = true; // Exit the loop since we have valid input
                }
                else
                {
                    // If the input is not valid, print an error message
                    Console.WriteLine("Invalid input. Please enter a positive number for the radius...");
                }
            }
        }

        /// <summary>
        /// Calculates the area of the circle using the formula: π * radius^2.
        /// </summary>
        /// <returns>The calculated area of the circle.</returns>
        public override double CalculateArea()
        {
            return PI * radius * radius; // Formula for the area of a circle
        }

        /// <summary>
        /// Returns a string that describes the circle's radius and area.
        /// </summary>
        /// <returns>A string with the circle's radius and calculated area.</returns>
        public override string ToString()
        {
            // Format the output to include the radius and area with two decimal places
            return $"{Type}: Radius = {radius}, Area = {CalculateArea():F2}";
        }
    }
}
