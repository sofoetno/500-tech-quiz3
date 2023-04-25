// Შექმენით ინტერფეისი IShape რომელსაც ექნება ფართობის და პერიმეტრის გამოთვლის მეთოდები.
// Შექმენით პრიზმის, სამკუთხედის , მართკუთხედის, და ტრაპეციის კლასები. Ველები დაამატეთ საჭიროებისამებრ.
// Გააკეთეთ თითოეულ კლასში IShape-ის იმპლემენტაცია.

using System;

namespace Problem3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Regtangle regtangle = new Regtangle(12,4);
            Console.WriteLine(regtangle.CalculateArea());

            Trapezium trapezium = new Trapezium(12, 34, 3, 6, 7);
            Console.WriteLine(trapezium.CalculatePerimeter());

            Triangle triangle = new Triangle(3, 5, 7, 4);
            Console.WriteLine(triangle.CalculatePerimeter());

        }
    }
}