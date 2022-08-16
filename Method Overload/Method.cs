using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload
{
    internal class Method
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double c, double d)
        {
            return c + d;
        }
        public static string Add(int e, int f, bool isTrue)
        {
            if (isTrue)
            {
                string plural = (e + f > 1) ? "s" : null;
                return e + f + " dollar" + plural;

            }
            else
            {
                return "Invalid entry. Try again.";
            }
        }

    }   

        
}
