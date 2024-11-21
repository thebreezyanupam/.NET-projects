using System;
///////////////////////////////////////////////////////////////////////////////
// Program: Employee Sort
// Author: Anupam Pandey
// Student Number: 000921043
// Date:   17th Nov, 2024
// Purpose: This program reads a list of employees from a file, stores the data
//          in a List<Employee>, and allows the user to sort the employees based 
//          on different criteria such as name, ID, rate, hours worked, or gross pay.
//          The program then displays the sorted employee list.
//
// Statement of Authorship:
//I, Anupam Pandey, 000921043 certify that this
//material is my original work.  No other person's
//work has been used without due acknowledgement.
///////////////////////////////////////////////////////////////////////////////


/// <summary>
/// This class describes an employee with properties and implements IComparable for sorting.
/// </summary>
public class Employee : IComparable<Employee>
{
    // Auto-implemented properties for employee fields
    public string Name { get; set; }
    public int EmployeeId { get; set; }
    public decimal Rate { get; set; }
    public double Hours { get; set; }

    // Calculated property for gross pay (based on rate and hours)
    public decimal GrossPay => (Hours < 40) ? (decimal)Hours * Rate : (40.0m * Rate) + (((decimal)Hours - 40.0m) * Rate * 1.5m);

    /// <summary>
    /// Default constructor for Employee.
    /// </summary>
    public Employee() { }

    /// <summary>
    /// Four-argument constructor for Employee.
    /// </summary>
    /// <param name="name">Employee name</param>
    /// <param name="employeeId">Employee ID number</param>
    /// <param name="rate">Hourly rate</param>
    /// <param name="hours">Weekly hours worked</param>
    public Employee(string name, int employeeId, decimal rate, double hours)
    {
        Name = name;
        EmployeeId = employeeId;
        Rate = rate;
        Hours = hours;
    }

    /// <summary>
    /// Implements IComparable to enable sorting based on EmployeeId (default sort order).
    /// </summary>
    /// <param name="other">The other employee to compare to</param>
    /// <returns>Comparison result based on EmployeeId</returns>
    public int CompareTo(Employee other)
    {
        if (other == null)
            return 1; // This will place any non-null Employee objects before null objects.

        return EmployeeId.CompareTo(other.EmployeeId);
    }

    /// <summary>
    /// Overrides ToString to display employee details in a formatted manner.
    /// </summary>
    /// <returns>Formatted string representing employee information</returns>
    public override string ToString()
    {
        return $"{Name,-20}  {EmployeeId:D5}  {Rate,6:C}  {Hours,6:F2}  {GrossPay,9:C}";
    }
}
