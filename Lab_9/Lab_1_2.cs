
using System;

class Program
{
    static void Main() {
        
         int sec_in_min = 60;
         int min_in_hour = 60;
         int hour_in_day = 24;
         int day_in_week = 7;
         int day_in_year = 365;
         
         int day, week, year;
         secInAnywhere ( sec_in_min,  min_in_hour,  hour_in_day,  day_in_week,  day_in_year, out  day, out  week, out  year );
         Console.WriteLine("Секунд v добі: " + day);
         Console.WriteLine("\nСекунд в тижні: " + week);
         Console.WriteLine("\nСекунд в році: " + year);
         Console.ReadKey();
        
        
    }
    
    static void secInAnywhere (int sec_in_min, int min_in_hour, int hour_in_day, int day_in_week, int day_in_year, out int day, out int week, out int year ){
        
            day = sec_in_min * min_in_hour * hour_in_day;
            week = sec_in_min * min_in_hour * hour_in_day * day_in_week;
            year = sec_in_min * min_in_hour * hour_in_day * day_in_year;
        
        
    }
}