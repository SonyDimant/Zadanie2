using System;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Massive_1 one = new Massive_1(3);
            PapaArray two = new Massive_1(4);

            Massive_2 three = new Massive_2(5,2);
            PapaArray four = new Massive_2(4,2);

            Massive_3 five = new Massive_3(3);
            PapaArray six = new Massive_3(4);
           
            PapaArray[] papaArrays = new PapaArray[6] {one, two, three, four, five, six};
            foreach (PapaArray i in papaArrays)
            {
                Console.WriteLine(i.GetType() + "\n");
                Console.WriteLine(i.AverageValue());
                i.Print();


            }
            DaysofWeek daysofweek = new DaysofWeek();

        }

    }
}
