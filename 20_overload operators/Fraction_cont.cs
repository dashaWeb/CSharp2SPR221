using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_overload_operators
{
    partial class Fraction
    {
        // overload operators
        // + 
        public static Fraction operator +(Fraction one, Fraction two)
        {
            int num = one.Num * two.Denom + two.Num * one.Denom;
            int denom = one.Denom * two.Denom;
            Fraction res = new Fraction(num, denom);
            return res;
        }

        // == !=

        public static bool operator ==(Fraction one, Fraction two)
        {
            if (ReferenceEquals(one, two))
            {
                return true;
            }
            if (one is null || two is null)
            {
                return false;
            }
            return one.Equals(two);
        }
        public static bool operator !=(Fraction one, Fraction two)
        {
            return !(one == two);
        }

        // true, false
        public static bool operator true(Fraction one)
        {
            return one.Num != 0;
        }
        public static bool operator false(Fraction one)
        {
            return one.Num == 0;
        }

        // перетворе типів можна визначити у дві сторони Fraction ---> other.type; other.type --> Fraction
        public static explicit operator int(Fraction one) //explicit - явне перетворення буде дозволеноб неявне ні
        {
            return one.Num / one.Denom;
        }
        public static implicit operator double(Fraction one) //explicit - явне перетворення буде дозволеноб неявне ні
        {
            return (double)one.Num / one.Denom;
        }
        public static Fraction operator ++(Fraction one)
        {
            Fraction fr = new Fraction(one.Num+1, one.Denom+1);
            return fr;
        }
    }
}
