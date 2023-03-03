using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"C:\data\students.txt";
        string[] lines = File.ReadAllLines(filePath);

        double minGPA = 3.0;

        var filteredStudents = lines
            .Skip(1)
            .Select(line => line.Split(','))
            .Select(parts => new {
                Name = parts[0],
                GPA = double.Parse(parts[1]),
                Grade = int.Parse(parts[2])
            })
            .Where(student => student.GPA >= minGPA);

        Console.WriteLine("Отфильтрованные студенты:");
        foreach (var student in filteredStudents)
        {
            Console.WriteLine("{0}: GPA = {1}, Grade = {2}", student.Name, student.GPA, student.Grade);
        }
    }
}
