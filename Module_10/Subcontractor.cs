using System;

namespace Project10
{
    class Subcontractor : Contractor
    {
        public int shift;
        public double payrate;
        public Subcontractor(string name, int number, DateTime startdate, int shift, double payrate): base(name, number, startdate)
        {
            this.shift = shift;
            this.payrate = payrate;
        }

    }
}
