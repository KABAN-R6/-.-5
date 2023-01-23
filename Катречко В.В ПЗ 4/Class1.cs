using System;
namespace Катречко_В.В_ПЗ_4
{
    public class Times
    {
        public int year = 2021;

    }
    public class Time : Times
    {
        public int _hour;
        public int _minute;
        public int _second;
        public Time(int hour, int minute, int second )
        {
            _hour = hour;
            _minute = minute;
            _second = second;
        }

        public void Read()
        {
            
        }
        public void Display()
        {
            Console.WriteLine($"$год {year} , часы {_hour}, минуты {_minute} ,second {_second}");
        }
    }
}
