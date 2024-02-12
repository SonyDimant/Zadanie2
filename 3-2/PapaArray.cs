using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    public abstract class PapaArray: IPrinter, IPapaArray
    {
        public abstract void IntValues();

        public abstract void RandomValues();
        public abstract void Print();
        public abstract double AverageValue();


    }
}
