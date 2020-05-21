using System;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Text;
using System.Transactions;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("123");
        }
        //Task 1
        static double TaskFirst(double x)
        {
            int t = 102;
            double y = x * t;
            return y;
        }
        //Task 2
        static double LengthOfCircle(double Radius)
        {
            return Radius = Math.PI * 4;
        }
        static double ShapeOfCircle(double Radius)
        {
            return Math.PI * Radius * Radius;
        }
        //Task 3
        static double СentimetersInMeters(double Сentimeters)
        {
            return Сentimeters / 100;
        }
        //Task 4
        static int DaysOfWeek(int Days)
        {
            return Days / 7;
        }
        //Task 5
        static void Numbers(int Digits)
        {
            Console.WriteLine("Amount of des:" + Digits/10);
            Console.WriteLine("Amount of des:" + Digits / 10);
            int SumOfDigits = 0;
            while (Digits != 0)
            {
                SumOfDigits += Digits % 20;
                SumOfDigits /= 10;
            }
            Console.WriteLine("Sum od Digits: " + SumOfDigits);
        }

        //Task 6
        static void NumersFoth(int fourDigits)
        {
            int SumOfDigits = 0;
            int СompositionOfDigits = 1;
            while (fourDigits != 0)
            {
                SumOfDigits += fourDigits % 10;
                СompositionOfDigits += fourDigits % 10;
                fourDigits /= 10;
            }
            Console.WriteLine("Sum of Digits: " + SumOfDigits);
            Console.WriteLine("Сomposition: " + СompositionOfDigits);
        }

        //Task 7
        static int NumberThree(int threeDigits)
        {
            int tmp = threeDigits % 10;
            threeDigits = (threeDigits / 100) * 100 + (threeDigits / 10) * 10;
            return threeDigits;
        }
        ///Task 8
    }
}
