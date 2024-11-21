/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines the Rectangle class, which represents a 2D rectangular shape.
             It allows the user to input the length and width of the rectangle, calculates the area,
             and provides a text description of the rectangle's properties.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/

using System;

namespace Lab2A
{
    /// <summary>
    /// Represents a rectangle. This class allows setting the length and width,
    /// calculating the area, and displaying the rectangle's details in a readable format.
    /// </summary>
    public class Rectangle : TwoDimensionalShape
    {
        private double length; // Holds the length of the rectangle
        private double width;  // Holds the width of the rectangle

        /// <summary>
        /// Constructor for the Rectangle class. Sets the shape type to "Rectangle".
        /// </summary>
        public Rectangle()
        {
            Type = "Rectangle";
        }

        /// <summary>
        /// Prompts the user to enter the length and width of the rectangle.
        /// Keeps asking until the user provides valid positive numbers.
        /// </summary>
        public override void SetData()
        {
            bool validInput = false; // Tracks whether the input is valid
            while (!validInput) // Loop until valid input is received
            {
                Console.WriteLine("Enter the length of the rectangle: ");
                // Try to parse the user input for the length
                if (double.TryParse(Console.ReadLine(), out double input1) && input1 > 0)
                {
                    length = input1; // Save the valid length
                    Console.WriteLine("Enter the width of the rectangle: ");
                    // Try to parse the user input for the width
                    if (double.TryParse(Console.ReadLine(), out double input2) && input2 > 0)
                    {
                        width = input2; // Save the valid width
                        validInput = true; // Exit the loop since we have valid input
                    }
                    else
                    {
                        // If the width input is invalid, show an error message
                        Console.WriteLine("Invalid input. Please enter a positive numeric value for width...");
                    }
                }
                else
                {
                    // If the length input is invalid, show an error message
                    Console.WriteLine("Invalid input. Please enter a positive numeric value for length...");
                }
            }
        }

        /// <summary>
        /// Calculates the area of the rectangle using the formula: length * width.
        /// </summary>
        /// <returns>The calculated area of the rectangle.</returns>
        public override double CalculateArea()
        {
            return length * width; // Formula for the area of a rectangle
        }

        /// <summary>
        /// Creates a string that describes the rectangle's length, width, and area.
        /// </summary>
        /// <returns>A string with the rectangle's dimensions and calculated area.</returns>
        public override string ToString()
        {
            // Format the output to include the length, width, and area with two decimal places
            return $"{Type}: Length = {length}, Width = {width}, Area = {CalculateArea():F2}";
        }
    }
}
