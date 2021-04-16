using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ivana's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            
            var stats  = book.GetStatistics();
            
            System.Console.WriteLine($"The avarage grade is {stats.Average:N1}");
            System.Console.WriteLine($"The Max grade is {stats.Hihg}");
            System.Console.WriteLine($"The Min grade is {stats.Low}"); 
            System.Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
