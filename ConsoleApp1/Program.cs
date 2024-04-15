using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Id = 10;
            double gpa = 3.3;
            string title = "welcome";
            bool IsActive = true;

            Console.WriteLine("Integer " + Id);
            Console.WriteLine("Double: " + gpa);
            Console.WriteLine("String: " + title);
            Console.WriteLine("Bool: " + IsActive);


            int number = 5;
            double result = Convert.ToDouble(number);
            Console.WriteLine("Converted double: " + result);


            string studentName = "Maha Salem";
            double gradePointAverage = 3.6;
            string favoriteSubject = "Mathematics";

            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Grade Point Average: " + gradePointAverage);
            Console.WriteLine("Favorite Subject: " + favoriteSubject);

            double width = 5.5;
            double height = 3.2;
            double area = width * height;

            Console.WriteLine("rectangle area: " + area);

        }
    }
}
