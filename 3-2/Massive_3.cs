using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _3_2
{
    sealed class Massive_3 : PapaArray
    {
        private int[][] _array;
        private int _size;

        public Massive_3(int size, bool t = false)
        {
            _size = size;
            _array = new int[size][];

            if (!t)
            {
                RandomValues();
            }
            else
            {
                IntValues();
            }
        }

        public override void RandomValues()
        {
            Random rnd = new Random();

            for (int i = 0; i < _size; i++)
            {
                int col = rnd.Next(3, 10);
                _array[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    _array[i][j] = rnd.Next(0, 10);
                }
            }
        }

        public override void IntValues()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine("Введите элементы: ");
                int collumn = int.Parse(Console.ReadLine());
                _array[i] = new int[collumn];

                for (int j = 0; j < collumn; j++)
                {
                    Console.WriteLine("Введите элементы: ");
                    _array[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public override void ShowArray()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < _array[i].Length; j++)
                {
                    Console.Write(_array[i][j] + "");
                }
                Console.WriteLine();
            }
        }

        public override double AverageValue()
        {
            int count_ = 0;
            double summa = 0;

            foreach (int[] item in _array)
            {
                summa += item.Sum();
                count_ += item.Length;
            }

            return summa / count_;
        }
    }
}
