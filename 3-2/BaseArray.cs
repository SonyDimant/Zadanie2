using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    public abstract class BaseArray
    {
        // массив заполняется целыми числами
        public abstract void IntValues();

        //массив заполняется случайными числами
        public abstract void RandomValues();
        public abstract void ShowArray();
        public abstract double AverageValue();


    }
}
