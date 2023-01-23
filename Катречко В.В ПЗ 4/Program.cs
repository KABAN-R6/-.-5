using System;

namespace Катречко_В.В_ПЗ_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1._hour = Convert.ToInt32(Console.ReadLine());
            t1._minute = Convert.ToInt32(Console.ReadLine());
            t1._second = Convert.ToInt32(Console.ReadLine());
            Time t2 = new Time();
            t2._hour = Convert.ToInt32(Console.ReadLine());
            t2._minute = Convert.ToInt32(Console.ReadLine());
            t2._second = Convert.ToInt32(Console.ReadLine());
            Time t3 = new Time();
            t3._hour = Convert.ToInt32(Console.ReadLine());
            t3._minute = Convert.ToInt32(Console.ReadLine());
            t3._second = Convert.ToInt32(Console.ReadLine());
            t1.Display();
            t2.Display();
            t3.Display();
        }
    }
}
