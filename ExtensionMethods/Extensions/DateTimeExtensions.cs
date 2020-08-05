
using System.Globalization;


namespace System //colocando a class extention no mesmo namespace do local de uso, para facilitar o uso!
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj) // necessario que seja criado assim <<
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
