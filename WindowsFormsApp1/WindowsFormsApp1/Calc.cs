using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Calc
    {
        Stack<char> operators;
        Stack<double> value;
     
        public Calc()
        {
            operators = new Stack<char>();
            value = new Stack<double>();

        }
    }
}
