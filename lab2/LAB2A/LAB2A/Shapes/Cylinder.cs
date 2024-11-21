/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines the Cylinder class, which represents a 3D cylindrical shape. 
             It allows the user to input the cylinder's radius and height, calculates the surface area and volume,
             and provides a text description of the cylinder's properties.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/

using System;

namespace Lab2A
{
    /// <summary>
    /// Represents a cylinder. This class allows setting the radius and height of the cylinder,
    /// calculating its surface area and volume, and displaying its details in a readable format.
    /// </summary>
    public class Cylinder : ThreeDimensionalShape
    {
        private double radius; // Stores the radius of the cylinder
        private double height; // Stores the height of the cylinder

        /// <summary>
        /// Constructor for the Cylinder class. Sets the shape type to "Cylinder".
        /// </summary>
        public Cylinder()
        {
            Type = "Cylinder";
        }

        /// <summary>
        /// Prompts the user to enter the radius and height of the cylinder.
        /// Keeps asking until the user provides valid positive numbers.
        /// </summary>
        public override void SetData()
        {
            bool validInput = false; // Tracks whether the input is valid
            while (!validInput) // Loop until valid input is received
            {
                Console.WriteLine("Enter the radius of the cylinder: ");
                // Try to parse the user input for the radius
                if (double.TryParse(Console.ReadLine(), out double input1) && input1 > 0)
                {
                    radius = input1; // Save the valid radius
                    Console.WriteLine("Enter the height of the cylinder: ");
                    // Try to parse the user input for the height
                    if (double.TryParse(Console.ReadLine(), out double input2) && input2 > 0)
                    {
                        height = input2; // Save the valid height
                        validInput = true; // Exit the loop since we have valid input
                    }
                    else
                    {
                        // If the height input is invalid, show an error message
                        Console.WriteLine("Invalid input. Please enter a positive numeric value for the height...");
                    }
                }
                else
                {
                    // If the radius input is invalid, show an error message
                    Console.WriteLine("Invalid input. Please enter a positive numeric value for the radius...");
                }
            }
        }

        /// <summary>
        /// Calculates the surface area of the cylinder using the formula: 2 * π * radius * (radius + height).
        /// </summary>
        /// <returns>The calculated surface area of the cylinder.</returns>
        public override double CalculateArea()
        {
            return 2 * PI * radius * (radius + height); // Formula for the surface area of a cylinder
        }

        /// <summary>
        /// Calculates the volume of the cylinder using the formula: π * radius^2 * height.
        /// </summary>
        /// <returns>The calculated volume of the cylinder.</returns>
        public override double CalculateVolume()
        {
            return PI * radius * radius * height; // Formula for the volume of a cylinder
        }

        /// <summary>
        /// Creates a string that describes the cylinder's radius, height, surface area, and volume.
        /// </summary>
        /// <returns>A string with the cylinder's dimensions, surface area, and volume.</returns>
        public override string ToString()
        {
            // Format the output to include the radius, height, surface area, and volume with two decimal places
            return $"{Type}: Radius = {radius}, Height = {height}, Surface Area = {CalculateArea():F2}, Volume = {CalculateVolume():F2}";
        }
    }
}
