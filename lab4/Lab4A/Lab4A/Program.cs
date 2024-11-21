using System;
using System.Collections.Generic;

///<summary>
///     Name: Anupam Pandey
///     Student ID: 000921043
///     Date: 17th Nov 2024
///     Program Purpose:  This program allows sorting employee data based on different criteria like name, ID, rate, hours, or gross pay.
///                       It uses a menu to take user input and display sorted data.
///     Statement of Authorship: I, Anupam Pandey, 000921043 certify that this material is my original work.  
///                              No other person's work has been used without due acknowledgement.
///
/// 
/// </summary>

class Program
{
   
    static void Main(string[] args)
    {
        bool loop = true; 
        string input; 
        int choice; 

        // Create a list of employees 
        List<Employee> employees = ReadEmployeeData();

        while (loop)
        {
            
            input = Menu();

            // Check if the input is a valid number
            if (int.TryParse(input, out choice))
            {
                
                switch (choice)
                {
                    case 1: // Sort by Employee Name (ascending)
                        employees.Sort((e1, e2) => e1.Name.CompareTo(e2.Name));
                        break;
                    case 2: // Sort by Employee ID (ascending)
                        employees.Sort(); // Uses the default CompareTo method for EmployeeId
                        break;
                    case 3: // Sort by Rate (descending)
                        employees.Sort((e1, e2) => e2.Rate.CompareTo(e1.Rate));
                        break;
                    case 4: // Sort by Hours (descending)
                        employees.Sort((e1, e2) => e2.Hours.CompareTo(e1.Hours));
                        break;
                    case 5: // Sort by Gross Pay (descending)
                        employees.Sort((e1, e2) => e2.GrossPay.CompareTo(e1.GrossPay));
                        break;
                    case 6: // Exit the program
                        loop = false;
                        break;
                    default: // Invalid choice
                        Console.WriteLine("\n*** Invalid Choice - Try Again ***\n");
                        break;
                }

                // Display the table of employees if a valid sorting option was chosen
                if (choice >= 1 && choice <= 5)
                {
                    DisplayTable(employees);
                }
            }
            else
            {
                Console.WriteLine("\n*** Invalid Choice - Try Again ***\n");
            }
        }
    }

    /// <summary>
    /// Reads employee data from a file called "employees.txt" and creates a list of Employee objects.
    /// Each line in the file contains details about an employee in the format: Name, ID, Rate, Hours.
    /// </summary>
    /// <returns>A list of employees read from the file.</returns>
    static List<Employee> ReadEmployeeData()
    {
        List<Employee> employees = new List<Employee>();
        string input; // To store each line from the file

        try
        {
            // Open the file for reading
            using (var reader = new System.IO.StreamReader("employees.txt"))
            {
                while ((input = reader.ReadLine()) != null)
                {
                   
                    string[] data = input.Split(',');

                    // Extract employee details
                    string name = data[0];
                    int id = int.Parse(data[1]);
                    decimal rate = decimal.Parse(data[2]);
                    double hours = double.Parse(data[3]);

                  
                    employees.Add(new Employee(name, id, rate, hours));
                }
            }
        }
        catch (System.IO.IOException e)
        {
            // Display an error message and exit if there is a problem reading the file
            Console.WriteLine("*** Error reading file: " + e.Message + " ***");
            Environment.Exit(1);
        }

        return employees; 
    }

    /// <summary>
    /// Displays the employee data in a table format.
    /// Each employee's name, ID, rate, hours, and gross pay are shown in columns.
    /// </summary>
    /// <param name="employees">The list of employees to display.</param>
    static void DisplayTable(List<Employee> employees)
    {
        Console.Clear(); // Clear the console for a fresh display
        Console.WriteLine("Employee              ID      Rate   Hours   Gross Pay");
        Console.WriteLine("========================================================");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee); // Print each employee's details
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Displays the sorting menu to the user and returns their choice.
    /// The menu allows sorting by different employee attributes.
    /// </summary>
    /// <returns>The user's choice as a string.</returns>
    static string Menu()
    {
        Console.WriteLine("1. Sort by Employee Name");
        Console.WriteLine("2. Sort by Employee ID");
        Console.WriteLine("3. Sort by Employee Pay Rate");
        Console.WriteLine("4. Sort by Employee Hours");
        Console.WriteLine("5. Sort by Employee Gross Pay");
        Console.WriteLine("\n6. Exit");
        Console.Write("\nEnter choice: ");
        return Console.ReadLine(); // Get the user's input
    }
}
