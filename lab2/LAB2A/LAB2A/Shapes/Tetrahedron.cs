/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines the Tetrahedron class, which represents a 3D tetrahedral shape.
             It allows the user to input the side length of the tetrahedron, calculates the surface area and volume,
             and provides a text description of the tetrahedron's properties.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/

using System;

namespace Lab2A
{
    /// <summary>
    /// Represents a tetrahedron. This class allows setting the side length,
    /// calculating the surface area and volume, and displaying the tetrahedron's details in a readable format.
    /// </summary>
    public class Tetrahedron : ThreeDimensionalShape
    {
        private double side; // Holds the length of the tetrahedron's side

        /// <summary>
        /// Constructor for the Tetrahedron class. Sets the shape type to "Tetrahedron".
        /// </summary>
        public Tetrahedron()
        {
            Type = "Tetrahedron";
        }

        /// <summary>
        /// Prompts the user to enter the side length of the tetrahedron.
        /// Keeps asking until the user provides a valid positive number.
        /// </summary>
        public override void SetData()
        {
            bool validInput = false; // Tracks whether the input is valid
            while (!validInput) // Loop until valid input is received
            {
                Console.WriteLine("Enter the side length of the tetrahedron: ");
                // Try to parse the user input for the side length
                if (double.TryParse(Console.ReadLine(), out double input) && input > 0)
                {
                    side = input; // Save the valid side length
                    validInput = true; // Exit the loop since we have valid input
                }
                else
                {
                    // If the input is invalid, show an error message
                    Console.WriteLine("Invalid input. Please enter a positive numeric value...");
                }
            }
        }

        /// <summary>
        /// Calculates the surface area of the tetrahedron using the formula: √3 * side^2.
        /// </summary>
        /// <returns>The calculated surface area of the tetrahedron.</returns>
        public override double CalculateArea()
        {
            return Math.Sqrt(3) * side * side; // Formula for the surface area of a tetrahedron
        }

        /// <summary>
        /// Calculates the volume of the tetrahedron using the formula: (side^3) / (6 * √2).
        /// </summary>
        /// <returns>The calculated volume of the tetrahedron.</returns>
        public override double CalculateVolume()
        {
            return (Math.Pow(side, 3) / (6 * Math.Sqrt(2))); // Formula for the volume of a tetrahedron
        }

        /// <summary>
        /// Creates a string that describes the tetrahedron's side length, surface area, and volume.
        /// </summary>
        /// <returns>A string with the tetrahedron's side length, surface area, and volume.</returns>
        public override string ToString()
        {
            // Format the output to include the side length, surface area, and volume with two decimal places
            return $"{Type}: Side = {side}, Surface Area = {CalculateArea():F2}, Volume = {CalculateVolume():F2}";
        }
    }
}
