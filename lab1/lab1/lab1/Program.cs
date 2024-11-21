using System;
using System.IO;

/// <summary>
/// Author: Anupam Pandey
/// Student Number: 000921043
/// Date: 22 Sep, 2024
/// Purpose: The purpose of the program is to read the csv file, calculate and sort on different criteria.       
/// Statement of Authorship: I, Anupam Pandey, 000921043 certify that this material is my original work. 
///                          No other person's work has been used without due acknowledgement.
/// </summary>

class Employee
{
    public string Name { get; private set; }
    public int Number { get; private set; }
    public decimal Rate { get; private set; }
    public double Hours { get; private set; }
    public decimal Gross { get; private set; }

    //constructor to create a new employee

    public Employee(string name, int number, decimal rate, double hours)
    {
        Name = name;
        Number = number;
        Rate = rate;
        Hours = hours;
        CalculateGross();
    }

    //method to calculate gross pay on the basis of hours

    private void CalculateGross()
    {
        if (Hours > 40)
            Gross = Rate * 40 + (Rate * 1.5M * (decimal)(Hours - 40));
        else
            Gross = Rate * (decimal)Hours;
    }

    //making it readable
    public override string ToString()
    {
        return $"{Name,-20} {Number,10} {Rate,10:C} {Hours,10} {Gross,10:C}";
    }
}

class Program
{
    static Employee[] employees = new Employee[100]; //Array hold employee objcts
    static int employeeCount = 0;

    static void Main()
    {
        Read();
        while (true) //reprompts for menu
        {
            int choice = DisplayMenu();
            if (choice == 6) break;
            SortEmployees(choice);
            DisplayEmployees();
        }
    }


    //reads employee data with exception handling
    static void Read()
    {
        try
        {
            string[] lines = File.ReadAllLines("employees.txt");
            employeeCount = lines.Length;

            for (int i = 0; i < employeeCount; i++)
            {
                string[] data = lines[i].Split(',');
                string name = data[0].Trim();
                int number = int.Parse(data[1].Trim());
                decimal rate = decimal.Parse(data[2].Trim());
                double hours = double.Parse(data[3].Trim());
                employees[i] = new Employee(name, number, rate, hours);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The file 'employees.txt' was not found.");
            Environment.Exit(1);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: The data format in the file is incorrect.");
            Environment.Exit(1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Environment.Exit(1);
        }
    }
    //display options and take input
    static int DisplayMenu()
    {
        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("1. Sort by Employee Name (ascending)");
        Console.WriteLine("2. Sort by Employee Number (ascending)");
        Console.WriteLine("3. Sort by Employee Pay Rate (descending)");
        Console.WriteLine("4. Sort by Employee Hours (descending)");
        Console.WriteLine("5. Sort by Employee Gross Pay (descending)");
        Console.WriteLine("6. Exit");

        Console.WriteLine("\nEnter: ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
        }

        return choice;
    }


    //sort on the basis of input
    static void SortEmployees(int choice)
    {
        switch (choice)
        {
            case 1:
                CustomSort((e1, e2) => e1.Name.CompareTo(e2.Name));
                break;
            case 2:
                CustomSort((e1, e2) => e1.Number.CompareTo(e2.Number));
                break;
            case 3:
                CustomSort((e1, e2) => e2.Rate.CompareTo(e1.Rate));
                break;
            case 4:
                CustomSort((e1, e2) => e2.Hours.CompareTo(e1.Hours));
                break;
            case 5:
                CustomSort((e1, e2) => e2.Gross.CompareTo(e1.Gross));
                break;
        }
    }
    

    //bubble sort used
    static void CustomSort(Comparison<Employee> comparison)
    {
        for (int i = 0; i < employeeCount - 1; i++)
        {
            for (int j = 0; j < employeeCount - i - 1; j++)
            {
                if (comparison(employees[j], employees[j + 1]) > 0)
                {
                    // Swap employees
                    Employee temp = employees[j];
                    employees[j] = employees[j + 1];
                    employees[j + 1] = temp;
                }
            }
        }
    }

    //displays employee list
    static void DisplayEmployees()
    {
        Console.WriteLine("\nSorted Employees:");
        Console.WriteLine($"{"Name",-20} {"Number",10} {"Rate",10} {"Hours",10} {"Gross",10}");
        Console.WriteLine(new string('-', 70));

        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine(employees[i]);
        }
    }
}
