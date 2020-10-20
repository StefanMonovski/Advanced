using System;

namespace _05.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            DateModifier dateModifier = new DateModifier();
            dateModifier.DaysDifference = dateModifier.GetDaysDifference(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(dateModifier.DaysDifference);
        }
    }
}
