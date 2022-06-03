using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrensib.SR.CorrectUse
{
    abstract class BasePrinter
    {
        public abstract void Print(string value);
    }

    interface IScan
    {
        void Scan(string value);
    }

    class HpPrinter : BasePrinter
    {
        public override void Print(string value)
        {
            //işlemler falan 
        }


    }

    class CanonPrinter : BasePrinter, IScan
    {
        public override void Print(string value)
        {
            //işlemler falan 
        }

        public void Scan(string value)
        {
            //işlemler falan 
        }
    }

    class Printer2
    {
        readonly BasePrinter _canonPrinter = new CanonPrinter();
        readonly CanonPrinter _canonScaner = new CanonPrinter();
        readonly BasePrinter _hpPrinter = new HpPrinter();

        public void Print(string value)
        {

            _canonPrinter.Print(value);
            _canonScaner.Scan(value);

            _hpPrinter.Print(value);

        }

    }

}

