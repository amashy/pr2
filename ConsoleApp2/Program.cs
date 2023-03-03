using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"C:\data\employees.txt";
        string[] lines = File.ReadAllLines(filePath);

        var sortedEmployees = lines
            .Skip(1)
            .Select(line => line.Split(','))
            .Select(parts => new {
                Name = parts[0],
                Salary = double.Parse(parts[1]),
                YearsOfExperience = int.Parse(parts[2])
            })
            .OrderByDescending(employee => employee.Salary);

        Console.WriteLine("Отсортированные рабочие:");
        foreach (var employee in sortedEmployees)
        {
            Console.WriteLine("{0}: Salary = {1:C}, Years of Experience = {2}", employee.Name, employee.Salary, employee.YearsOfExperience);
        }
    }
}
