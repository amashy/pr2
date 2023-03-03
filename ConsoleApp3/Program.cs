using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"C:\data\products.txt";
        string[] lines = File.ReadAllLines(filePath);

        var groupedProducts = lines
            .Skip(1) 
            .Select(line => line.Split(','))
            .Select(parts => new {
                Name = parts[0],
                Category = parts[1],
                Price = double.Parse(parts[2])
            })
            .GroupBy(product => product.Category);

        Console.WriteLine("Сгруппирированыне продукты:");
        foreach (var group in groupedProducts)
        {
            Console.WriteLine("{0}:", group.Key);
            foreach (var product in group)
            {
                Console.WriteLine("- {0}: Price = {1:C}", product.Name, product.Price);
            }
            Console.WriteLine();
        }
    }
}
