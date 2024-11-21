/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines the Square class, which represents a 2D square shape.
             It allows the user to input the side length of the square, calculates the area,
             and provides a text description of the square's properties.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/

using System;

namespace Lab2A
{
    /// <summary>
    /// Represents a square. This class allows setting the side length,
    /// calculating the area, and displaying the square's details in a readable format.
    /// </summary>
    public class Square : TwoDimensionalShape
    {
        private double side; // Holds the side length of the square

        /// <summary>
        /// Constructor for the Square class. Sets the shape type to "Square".
        /// </summary>
        public Square()
        {
            Type = "Square";
        }

        /// <summary>
        /// Prompts the user to enter the side length of the square.
        /// Keeps asking until the user provides a valid positive number.
        /// </summary>
        public override void SetData()
        {
            bool validInput = false; // Tracks whether the input is valid
            while (!validInput) // Loop until valid input is received
            {
                Console.WriteLine("Enter the side length of the square: ");
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
        /// Calculates the area of the square using the formula: side * side.
        /// </summary>
        /// <returns>The calculated area of the square.</returns>
        public override double CalculateArea()
        {
            return side * side; // Formula for the area of a square
        }

        /// <summary>
        /// Creates a string that describes the square's side length and area.
        /// </summary>
        /// <returns>A string with the square's side length and calculated area.</returns>
        public override string ToString()
        {
            // Format the output to include the side length and area
            return $"{Type}: Side = {side}, Area = {CalculateArea():F2}";
        }
    }
}
