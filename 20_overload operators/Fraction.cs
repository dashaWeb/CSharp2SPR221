using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_overload_operators
{
    // static operator (method) +, -, / , *
    // перевантаження + неявно забезпечує перевантаження +=,  -   -= ....
    // слід перевантажувати парами == і !=, > <, >= <=, true false;
    // перетворення типів explicit(явне) implicit (неявне)
    // [] - через властивість
    partial class Fraction
    {
        public Fraction(int num, int denom)
        {
            Num = num;
            Denom = denom;
        }
        public int Num { get; set; }
        public int Denom
        {
            get => denom;
            set => denom = value != 0 ? value : throw new Exception("Error denominator"); 
        }

        private int denom;
        public override string ToString()
        {
            return $"{Num} / {Denom}";
        }
        public override bool Equals(object obj)
        {
            Fraction other = obj as Fraction;
            if (other == null)
                return false;
            return this.Num * other.Denom == this.Denom * other.Num;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public int this[int index] // формальний параметр для індекса (можна не тільки цілого)
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Num;
                    case 1:
                        return Denom;
                    default:
                        throw new Exception($"Error (get) index {index}");
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        Num = value;
                        break;
                    case 1:
                        Denom = value;
                        break;
                    default:
                        throw new Exception($"Error (set) index {index}");
                }
            }
        }
    }
}

