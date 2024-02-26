using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    public abstract class PapaArray: IPrinter, IPapaArray
    {
        private bool A;
        public PapaArray(bool a){
            A = a;
        }
        public abstract void IntValues();

        public abstract void RandomValues();
        public abstract void Print();
        public abstract double AverageValue();
        public void Fill(){
            if(A){
                IntValues();
            }
            else{
                RandomValues();
            }
        }

    }
}
