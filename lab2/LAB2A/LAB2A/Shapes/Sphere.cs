/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines the Sphere class, which represents a 3D spherical shape.
             It allows the user to input the radius of the sphere, calculates the surface area and volume,
             and provides a text description of the sphere's properties.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/

using System;

namespace Lab2A
{
    /// <summary>
    /// Represents a sphere. This class allows setting the radius, calculating the surface area and volume,
    /// and displaying the sphere's details in a readable format.
    /// </summary>
    public class Sphere : ThreeDimensionalShape
    {
        private double radius; // Holds the radius of the sphere

        /// <summary>
        /// Constructor for the Sphere class. Sets the shape type to "Sphere".
        /// </summary>
        public Sphere()
        {
            Type = "Sphere";
        }

        /// <summary>
        /// Prompts the user to enter the radius of the sphere.
        /// Keeps asking until the user provides a valid positive number.
        /// </summary>
        public override void SetData()
        {
            bool validInput = false; // Tracks whether the input is valid
            while (!validInput) // Loop until a valid input is received
            {
                Console.WriteLine("Enter the radius of the sphere: ");
                // Try to parse the user input for the radius
                if (double.TryParse(Console.ReadLine(), out double input) && input > 0)
                {
                    radius = input; // Save the valid radius
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
        /// Calculates the surface area of the sphere using the formula: 4 * π * radius^2.
        /// </summary>
        /// <returns>The calculated surface area of the sphere.</returns>
        public override double CalculateArea()
        {
            return 4 * PI * radius * radius; // Formula for the surface area of a sphere
        }

        /// <summary>
        /// Calculates the volume of the sphere using the formula: (4/3) * π * radius^3.
        /// </summary>
        /// <returns>The calculated volume of the sphere.</returns>
        public override double CalculateVolume()
        {
            return (4.0 / 3.0) * PI * radius * radius * radius; // Formula for the volume of a sphere
        }

        /// <summary>
        /// Creates a string that describes the sphere's radius, surface area, and volume.
        /// </summary>
        /// <returns>A string with the sphere's radius, surface area, and volume.</returns>
        public override string ToString()
        {
            // Format the output to include the radius, surface area, and volume with two decimal places
            return $"{Type}: Radius = {radius}, Surface Area = {CalculateArea():F2}, Volume = {CalculateVolume():F2}";
        }
    }
}
