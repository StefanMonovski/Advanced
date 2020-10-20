using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.DateModifier
{
    class DateModifier
    {
        public int DaysDifference { get; set; }

        public int GetDaysDifference(string firstInput, string secondInput)
        {
            int[] firstInputData = firstInput.Split().Select(int.Parse).ToArray();
            int[] secondInputData = secondInput.Split().Select(int.Parse).ToArray();
            DateTime firstDate = new DateTime(firstInputData[0], firstInputData[1], firstInputData[2]);
            DateTime secondDate = new DateTime(secondInputData[0], secondInputData[1], secondInputData[2]);
            if (firstDate > secondDate)
            {
                return (int)firstDate.Subtract(secondDate).TotalDays;
            }
            else
            {
                return (int)secondDate.Subtract(firstDate).TotalDays;
            }
        }
    }
}
