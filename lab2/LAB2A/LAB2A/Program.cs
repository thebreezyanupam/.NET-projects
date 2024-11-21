/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file contains the main program for managing and displaying various geometric shapes.
             It provides a user interface for selecting different shapes, collecting user input for shape dimensions,
             calculating properties like area and volume, and displaying a list of all created shapes.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/

using System;
using System.Collections.Generic;

namespace Lab2A
{
    public class Lab2A
    {
        // A list to store all the shapes created by the user
        private static List<Shape> shapes = new List<Shape>();

        /// <summary>
        /// The main method that drives the program. Displays a menu for shape selection,
        /// collects input data for each shape, and manages the list of shapes.
        /// </summary>
        public static void Main()
        {
            bool exit = false; // Tracks whether the user wants to exit the program
            while (!exit)
            {
                // Display the UI menu
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan; // Change the text color to Cyan
                Console.WriteLine("Anupam's Geometry Class:");
                Console.ForegroundColor = ConsoleColor.White; // Reset to white

                // Display shape options
                Console.WriteLine("A - Rectangle     E - Ellipse     I - Triangle");
                Console.WriteLine("B - Square        F - Circle      J - Tetrahedron");
                Console.WriteLine("C - Box           G - Cylinder");
                Console.WriteLine("D - Cube          H - Sphere");
                Console.WriteLine();
                Console.WriteLine("0 - List all shapes and Exit...");
                Console.WriteLine();
                Console.Write($"Enter your choice:      ({shapes.Count} shapes entered so far)");
                Console.WriteLine();

                // Read user input and convert to uppercase
                string choice = Console.ReadLine()?.ToUpper();
                Shape shape = null;

                // Determine the user's choice and create the appropriate shape object
                switch (choice)
                {
                    case "A":
                        shape = new Rectangle();
                        break;
                    case "B":
                        shape = new Square();
                        break;
                    case "C":
                        shape = new Box();
                        break;
                    case "D":
                        shape = new Cube();
                        break;
                    case "E":
                        shape = new Ellipse();
                        break;
                    case "F":
                        shape = new Circle();
                        break;
                    case "G":
                        shape = new Cylinder();
                        break;
                    case "H":
                        shape = new Sphere();
                        break;
                    case "I":
                        shape = new Triangle();
                        break;
                    case "J":
                        shape = new Tetrahedron();
                        break;
                    case "0":
                        exit = true; // Exit the program
                        continue;
                    default:
                        // Handle invalid input
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        continue;
                }

                // If a valid shape was selected, prompt for its data and add it to the list
                if (shape != null)
                {
                    shape.SetData();
                    shapes.Add(shape);
                }
            }

            // Display all created shapes before exiting
            DisplayShapes();
        }

        /// <summary>
        /// Displays the list of all shapes created by the user.
        /// </summary>
        private static void DisplayShapes()
        {
            Console.Clear();
            Console.WriteLine("\nShapes Created:");
            if (shapes.Count == 0)
            {
                Console.WriteLine("No shapes created."); // Inform the user if no shapes were created
            }
            else
            {
                // Loop through each shape and display its details
                foreach (Shape shape in shapes)
                {
                    Console.WriteLine(shape);
                }
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(); // Wait for user input before exiting
        }
    }
}
