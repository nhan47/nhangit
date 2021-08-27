using System;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDay = new DateTime(2019, 1, 29);
            DateTime endDate = DateTime.Today;
            Console.WriteLine((endDate - startDay).TotalDays);
        }

    }
}
