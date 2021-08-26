using System;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            ushort year;

            name = Console.ReadLine();
            year = Convert.ToUInt16(Console.ReadLine());

            System.Console.WriteLine("Name : {0}, year : {1}", name, year);
            System.Console.WriteLine("You're {0} years old", AgeCalculator(year, 2021));
        }

        private static ushort AgeCalculator(ushort bornYear, ushort yearToCalculate)
        {
            return Convert.ToUInt16((int)yearToCalculate - (int)bornYear);
        }
    }
}
