using System;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Massive_1 one = new Massive_1(3);
            BaseArray two = new Massive_1(4);

            Massive_2 three = new Massive_2(5,2);
            BaseArray four = new Massive_2(4,2);

            Massive_3 five = new Massive_3(3);
            BaseArray six = new Massive_3(4);

            BaseArray[] baseArrays = new BaseArray[6] {one, two, three, four, five, six};
            foreach (BaseArray i in baseArrays)
            {
                Console.WriteLine(i.GetType());
            }

        }

    }
}
