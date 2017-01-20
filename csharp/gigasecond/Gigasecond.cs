using System;

namespace Exercism.Gigasecond
{
    public class Gigasecond
    {
        public static DateTime Date(DateTime bday)
        {
            return bday.AddSeconds(Math.Pow(10, 9));
        }
    }
}