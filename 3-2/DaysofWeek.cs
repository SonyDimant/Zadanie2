using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    public class DaysofWeek : IPrinter
    {
        void IPrinter.Print()
        {
            string[] daysofWeeks = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскременье" };
            foreach (var day in daysofWeeks)
            {
                Console.WriteLine(day);
            }
        }
    }
}
