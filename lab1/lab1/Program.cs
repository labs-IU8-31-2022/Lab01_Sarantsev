//Lab01_task01_DaniilSarantsev_IU8-31

using System;
using System.Drawing;

namespace lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 1");
            Console.WriteLine("VALUE TYPES");
            Console.WriteLine("Numeric, signed integer: ");
            Console.WriteLine($"Sbyte: {sbyte.MinValue}, {sbyte.MaxValue}");
            Console.WriteLine($"Short: {short.MinValue}, {short.MaxValue}");
            Console.WriteLine($"Int: {int.MinValue}, {int.MaxValue}");
            Console.WriteLine($"Long: {long.MinValue}, {long.MaxValue}");
            Console.WriteLine("Numeric, unsigned integer: ");
            Console.WriteLine($"Byte: {byte.MinValue}, {byte.MaxValue}");
            Console.WriteLine($"UShort: {ushort.MinValue}, {ushort.MaxValue}");
            Console.WriteLine($"Uint: {uint.MinValue}, {uint.MaxValue}");
            Console.WriteLine($"Ulong: {ulong.MinValue}, {ulong.MaxValue}");
            Console.WriteLine("Numeric, real number: ");
            Console.WriteLine($"Float: {float.MinValue}, {float.MaxValue}");
            Console.WriteLine($"Double: {double.MinValue}, {double.MaxValue}");
            Console.WriteLine($"Decimal: {decimal.MinValue}, {decimal.MaxValue}");
            Console.WriteLine($"Logical: {bool.FalseString}, {bool.TrueString}");
            Console.WriteLine($"Character: unicode symbols 0...65535");
            Console.WriteLine($"Reference, string: -");
            Console.WriteLine($"Reference, object: -");

            Console.WriteLine("TASK 2");

            Console.Write("Enter the sides of the rectangle: ");
            double first_side = Convert.ToDouble(Console.ReadLine());
            double second_side = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(first_side, second_side);
            Console.WriteLine($"The area of the rectangle is: {rectangle.Area}");
            Console.WriteLine($"The perimeter of the rectangle is: {rectangle.Perimeter}");

            Console.WriteLine("TASK 3");
            Point p1 = new Point(5, 6);
            Point p2 = new Point(8, 10);
            Point p3 = new Point(10, 12);
            Figure test = new Figure(p1, p2, p3);
            Console.WriteLine($"The figure is: {test.Name}");
            Console.WriteLine($"The perimeter of the {test.Name} is {test.PerimeterCalculator()}");
            Console.WriteLine(test.LengthSide(p1, p2));
        }
    }
}