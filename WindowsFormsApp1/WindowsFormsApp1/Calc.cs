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
        public double? member_value2;
        public double? member;

        public Calc()
        {
            member = null;
            operators = null;
            value1 = null;
            value2 = null;
            member_value2 = null;
        }

        private double? Addition()
        {
            return (value1 + value2);
        }
        private double? Subtraction()
        {
            return (value1 - value2);
        }
        private double? Multiplication()
        {
            return (value1 * value2);
        }
        private double? Division()
        {
            return (value1 / value2);
        }
        public double? Proz()
        {
            if (value1 != null && value2 != null)
                return (value1 * value2 / 100);
            return null;
        }
        public double? Operetion()
        {
            if(operators == "+" )
            {
                if (value1 != null&&value2 != null)
                {
                    return Addition();
                }
            }
            else if(operators =="-")
            {
                if (value1 != null && value2 != null)
                {
                    return Subtraction();
                }
            }
            else if (operators == "*")
            {
                if (value1 != null && value2 != null)
                {
                    return Multiplication();
                }
            }
            else if (operators == "/")
            {
                if (value1 != null && value2 != null)
                {
                    return Division();
                }
            }
           
            return null;
        }    
    }
}
