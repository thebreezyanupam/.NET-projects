/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines the Cube class, which represents a 3D cube shape. It allows the user to input the side length of the cube,
             calculates the surface area and volume, and provides a text description of the cube's properties.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/

using System;

namespace Lab2A
{
    /// <summary>
    /// Represents a cube. This class allows setting the side length of the cube,
    /// calculating its surface area and volume, and displaying its details in a readable format.
    /// </summary>
    public class Cube : ThreeDimensionalShape
    {
        private double side; // This will hold the length of the cube's side

        /// <summary>
        /// Constructor for the Cube class. Sets the shape type to "Cube".
        /// </summary>
        public Cube()
        {
            Type = "Cube";
        }

        /// <summary>
        /// Prompts the user to enter the side length of the cube.
        /// Keeps asking until the user provides a valid positive number.
        /// </summary>
        public override void SetData()
        {
            bool validInput = false; // This will track whether the input is valid
            while (!validInput) // Loop until a valid input is provided
            {
                Console.WriteLine("Enter the side length of the cube:");
                // Try to parse the user input into a double and check if it's positive
                if (double.TryParse(Console.ReadLine(), out double input) && input > 0)
                {
                    side = input; // Save the valid side length
                    validInput = true; // Exit the loop since we have valid input
                }
                else
                {
                    // If the input is not valid, print an error message
                    Console.WriteLine("Invalid input. Please enter a positive numeric value...");
                }
            }
        }

        /// <summary>
        /// Calculates the surface area of the cube using the formula: 6 * side^2.
        /// </summary>
        /// <returns>The calculated surface area of the cube.</returns>
        public override double CalculateArea()
        {
            return 6 * side * side; // Formula for the surface area of a cube
        }

        /// <summary>
        /// Calculates the volume of the cube using the formula: side^3.
        /// </summary>
        /// <returns>The calculated volume of the cube.</returns>
        public override double CalculateVolume()
        {
            return side * side * side; // Formula for the volume of a cube
        }

        /// <summary>
        /// Creates a string that describes the cube's side length, surface area, and volume.
        /// </summary>
        /// <returns>A string with the cube's side length, surface area, and volume.</returns>
        public override string ToString()
        {
            // Format the output to include the side length, surface area, and volume with two decimal places
            return $"{Type}: Side = {side}, Surface Area = {CalculateArea():F2}, Volume = {CalculateVolume():F2}";
        }
    }
}
