using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    sealed class Massive_2 : PapaArray
    {
        private int[,] _array;
        private int _row;
        private int _coll;
        public Massive_2(int row, int collumn, bool t = false)
        {
            _array = new int[row, collumn];
            _row = row;
            _coll = collumn;

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
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _coll; j++)
                {
                    _array[i, j] = rnd.Next(0, 255);
                }
            }
        }


        public override void IntValues()
        {
            Console.WriteLine("Введите элементы: ");
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _coll; j++)
                {
                    _array[i, j] = int.Parse(Console.ReadLine());
                }

            }
        }

        public override double AverageValue()
        {
            int count_ = 0;
            double summa = 0;
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _coll; j++)
                {
                    summa += _array[i, j];
                }
            }
            return summa / count_;
        }

        public override void ShowArray()
        {
            int rows = _array.GetLength(0);
            int collumns = _array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < collumns; j++)
                {
                    Console.Write(_array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
