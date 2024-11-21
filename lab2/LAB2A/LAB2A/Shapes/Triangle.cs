/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines the Triangle class, which represents a 2D triangular shape.
             It allows the user to input the base length and height of the triangle, calculates the area,
             and provides a text description of the triangle's properties.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/

using System;

namespace Lab2A
{
    /// <summary>
    /// Represents a triangle. This class allows setting the base length and height,
    /// calculating the area, and displaying the triangle's details in a readable format.
    /// </summary>
    public class Triangle : TwoDimensionalShape
    {
        private double baseLength; // Holds the length of the triangle's base
        private double height; // Holds the height of the triangle

        /// <summary>
        /// Constructor for the Triangle class. Sets the shape type to "Triangle".
        /// </summary>
        public Triangle()
        {
            Type = "Triangle";
        }

        /// <summary>
        /// Prompts the user to enter the base length and height of the triangle.
        /// Keeps asking until the user provides valid positive numbers.
        /// </summary>
        public override void SetData()
        {
            bool validInput = false; // Tracks whether the input is valid
            while (!validInput) // Loop until valid input is received
            {
                Console.WriteLine("Enter the base length of the triangle: ");
                // Try to parse the user input for the base length
                if (double.TryParse(Console.ReadLine(), out double input1) && input1 > 0)
                {
                    baseLength = input1; // Save the valid base length
                    Console.WriteLine("Enter the height of the triangle:");
                    // Try to parse the user input for the height
                    if (double.TryParse(Console.ReadLine(), out double input2) && input2 > 0)
                    {
                        height = input2; // Save the valid height
                        validInput = true; // Exit the loop since we have valid input
                    }
                    else
                    {
                        // If the height input is invalid, show an error message
                        Console.WriteLine("Invalid input. Please enter a positive numeric value for height...");
                    }
                }
                else
                {
                    // If the base length input is invalid, show an error message
                    Console.WriteLine("Invalid input. Please enter a positive numeric value for base length...");
                }
            }
        }

        /// <summary>
        /// Calculates the area of the triangle using the formula: 0.5 * base * height.
        /// </summary>
        /// <returns>The calculated area of the triangle.</returns>
        public override double CalculateArea()
        {
            return 0.5 * baseLength * height; // Formula for the area of a triangle
        }

        /// <summary>
        /// Creates a string that describes the triangle's base length, height, and area.
        /// </summary>
        /// <returns>A string with the triangle's dimensions and calculated area.</returns>
        public override string ToString()
        {
            // Format the output to include the base length, height, and area
            return $"{Type}: Base = {baseLength}, Height = {height}, Area = {CalculateArea():F2}";
        }
    }
}
