using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Calc
    {
        public string operators;
        public double? value1;
        public double? value2;
        public List<double> member;

        public Calc()
        {
            member = new List<double>();
            operators = null;
            value1 = null;
            value2 = null;
        }

        public double? Plus()
        {
            return (value1 + value2);
        }


      
    }
}
