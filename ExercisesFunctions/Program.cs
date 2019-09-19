using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1
            //F1. test
            //F2. den integer man skriver som argument multiplicerat med sig självt
            //F3. vid Anrop, ett heltat som är produkten av integer x multiplicerat med y
            //F4. den integer man skriver som argument multiplicerat med 5
            //F5. vid Anrop, summan av double d argumentet och 1

            //Exercise1
            //1: test
            //2: 3
            //3: 15
            //4: 22
            //5: 6.5

            Console.WriteLine(GetInterest(100,(decimal)1.10,3));
            Console.ReadKey(true);
        }

        //Exercise2a
        private static double Add(double x, double y)
        {
            return x + y;
        }

        //Exercise2b
        private static double Multi(double x, double y, double z)
        {
            return x * y * z;
        }

        //Exercise2c
        private static double Calculate(double a, double b, double c, double e)
        {
            return Add
            (
                Multi(a, b, c),
                e
            );
        }

        //Exercise 3
        private static void DisplayWelcomeMessage(string name, string city, ushort favoriteNumber)
        {
            Console.WriteLine($"Välkommen {name} från {city} med favorittal {favoriteNumber}");
        }

        //Exercise 4
        private static uint ParseUint(string input)
        {
            try
            {
                return uint.Parse(input);
            }
            catch
            {
                throw new Exception();
            }
        }

        //Exercise 5
        private static double RoundToTwoDecimals(double number)
        {
            int noDecimals = (int)number;
            double decimals = number - noDecimals;
            string firstTwoDecimals = decimals.ToString().Substring(2, 2);
            return double.Parse($"{noDecimals}.{firstTwoDecimals}");
        }

        //Exercise 6
        private static string Paragraph(string input)
        {
            return $"<p>{input}</p>";
        }

        //Exercise 7
        private static int DaysInMonth(MonthOfYear month)
        {
            if (month == MonthOfYear.February)
                return 28;

            if ((int)month % 2 == 0) 
                return 30;

            return 31;
        }

        //Exercise 8
        private static string FirstThreeLetters(string inputString)
        {
            return inputString.Substring(0, 3);
        }

        //Exercise 9
        private static int Year(string date)
        {
            return Convert.ToDateTime(date).Year;
        }

        //Exercise 10
        private static int Month(string date)
        {
            return Convert.ToDateTime(date).Month;
        }

        //Exercise 10 
        private static int Day(string date)
        {
            return Convert.ToDateTime(date).Day;
        }
        
        //Exercise 10
        private static int DaysBetween(string firstDate, string secondDate)
        {
            int daysBetween = 0;
            daysBetween += (Year(firstDate) - Year(secondDate)) * 365;
            daysBetween += (Month(firstDate) - Month(secondDate)) * 30;
            daysBetween += Day(firstDate) - Day(secondDate);
            return daysBetween;
        }

        //Exercise 11
        private static double FarenheitToCelsius(double degreesFarenheit)
        {
            return (degreesFarenheit - 32) * 5;
        }

        //Exercise 12
        private static int Exercise12()
        {
            int sum = 0;
            for (int i = 0; i < 101; i++)
            {
                sum += i;
            }
            return sum;
        }

        private static int Exercise12(int numberOfNumbers)
        {
            int sum = 0;
            for (int i = 0; i < numberOfNumbers + 1; i++)
            {
                sum += i;
            }
            return sum;
        }

        //Exercise 13
        private static string Reverse(string toReverse)
        {
            string reversedString = "";
            for (int i = toReverse.Length - 1; i > - 1; i--)
            {
                reversedString += toReverse[i];
            }
            return reversedString;
        }

        //Exercise 14
        private static bool IsPrimeNumber(int number)
        {
            return number % number == 0 && number % 1 == 0;
        }

        //Exercise 15
        private static int FactorialLoop(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial  * i;
            }
            return factorial;
        }

        //Exercise 16
        private static int Factorial(int number)
        {
            if (number < 2) { return 1; }

            return number * Factorial(number);
        }

        //Exercise 17
        private static int Fibonacci(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        //Exercise 18
        static string ReverseStringRecursive(string inputString)
        {
            if (inputString.Length <= 1)
                return inputString;

            return ReverseStringRecursive(inputString.Substring(1)) + inputString[0];
        }

        static void AssignRandom(double inputValue)
        {
            new Random().Next(0, 1);
        }

        static double MakePositive(double inputValue)
        {
            return Math.Abs(inputValue);
        }

        static Array CopyArray(Array array)
        {
            Array returnArray = null;
            Array.Copy(array, returnArray, array.Length);
            return returnArray;
        }

        private static int[] FilterLessThan(int[] values, int inputValue)
        {
            int size = 0;
            int[] filteredValues = new int[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > inputValue)
                    continue;

               
                Array.Resize(ref filteredValues, ++size);
                filteredValues[i] = values[i];
            }
            return filteredValues;
        }

        private static decimal GetInterest(decimal balance, decimal rate, int years)
        {
            if (years == 1)
            {
                return balance * rate;
            }

            return GetInterest(balance * rate, rate, years - 1);
        }

        
    }

    
    //Exercise 7
    public enum MonthOfYear
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
