using System;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Massive_1 one = new Massive_1(3);
            PapaArray two = new Massive_1(4);

            Massive_2 three = new Massive_2(5, 2);
            PapaArray four = new Massive_2(4, 2);

            Massive_3 five = new Massive_3(3);
            PapaArray six = new Massive_3(4);

            PapaArray[] papaArrays = new PapaArray[6] { one, two, three, four, five, six };
            foreach (PapaArray i in papaArrays)
            {
                Console.WriteLine(i.GetType() + "\n");
                Console.WriteLine(i.AverageValue());
                i.Print();


            }
            DaysofWeek daysofweek = new DaysofWeek();


            IPapaArray[] array = new IPapaArray[3]
            {
                new Massive_1(3), new Massive_2(2, 4), new Massive_3(6)
            };

            foreach (IPapaArray i in array)
            {
                Console.WriteLine($"Среднее значение {i.GetType()} массива {i.AverageValue()}\n");
                Console.WriteLine($"Элементы массива {i.GetType()}\n");
                i.Print();
            }

             
        }

    }
}
