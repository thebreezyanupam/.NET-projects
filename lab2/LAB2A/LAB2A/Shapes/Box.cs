/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines the Box class, which is a three-dimensional shape that inherits
             from the ThreeDimensionalShape base class. The class contains methods for setting
             dimensions, calculating surface area, and calculating volume.

    Statement of Authorship: I, Anupam Pandey, 000921043 certify that this material is my original work.  
                             No other person's work has been used without due acknowledgement.

*/





using System;

namespace Lab2A
{
    /// <summary>
    /// Represents a box shape, inheriting from the ThreeDimensionalShape class.
    /// </summary>
    public class Box : ThreeDimensionalShape
    {
        private double length;
        private double width;
        private double height;

        public Box()
        {
            Type = "Box";
        }

        /// <summary>
        /// Prompts the user to enter the dimensions of the box.
        /// </summary>
        public override void SetData()
        {

            bool validInput = false;

            // Loop until user provide valid inputs for all dimensions
            while (!validInput)
            {
                Console.WriteLine("Enter the length of the box:");
                if (double.TryParse(Console.ReadLine(), out double input1) && input1 > 0)
                {
                    length = input1;
                    Console.WriteLine("Enter the width of the box:");
                    if (double.TryParse(Console.ReadLine(), out double input2) && input2 > 0)
                    {
                        width = input2;
                        Console.WriteLine("Enter the height of the box:");
                        if (double.TryParse(Console.ReadLine(), out double input3) && input3 > 0)
                        {
                            height = input3;
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a positive numeric value for height.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a positive numeric value for width.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive numeric value for length.");
                }
            }
        }

        /// <summary>
        /// Calculates the surface area of the box.
        /// </summary>
        /// <returns>The surface area of the box.</returns>
        public override double CalculateArea()
        {
            return 2 * (length * width + width * height + height * length);
        }

        /// <summary>
        /// Calculates the volume of the box.
        /// </summary>
        /// <returns>The volume of the box.</returns>
        public override double CalculateVolume()
        {
            return length * width * height;
        }

        /// <summary>
        /// Returns a string representation of the box.
        /// </summary>
        /// <returns>A string describing the box's dimensions, surface area, and volume.</returns>
        public override string ToString()
        {
            return $"{Type}: Length = {length}, Width = {width}, Height = {height}, Surface Area = {CalculateArea():F2}, Volume = {CalculateVolume():F2}";
        }
    }
}
