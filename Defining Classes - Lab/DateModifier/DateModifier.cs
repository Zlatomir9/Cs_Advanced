using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public double GetDaysDifference(string firstDate, string secondDate) 
        {
            DateTime startDate = DateTime.Parse(firstDate);
            DateTime endDate = DateTime.Parse(secondDate);

            double daysDifference = (endDate - startDate).TotalDays;

            return daysDifference;
        }
    }
}
