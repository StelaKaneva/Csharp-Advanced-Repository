using System;

namespace DateModifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
            var result = dateModifier.GetDaysDifference(startDate, endDate);
            Console.WriteLine(result);
        }
    }
}
