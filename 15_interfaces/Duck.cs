using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_interfaces
{
    class Duck : ISwim, IMove, IFly
    {
        public int Weight { get; set; }
        //way 1 - одна реалізація для всіх інтерфейсів
        //public int Speed => 3; // неяна реалізація інтерфейсу 
        // явна реалізація
        int IMove.Speed => 3;
        int IFly.Speed => 10;

        public virtual void Fly()
        {
            Console.WriteLine($"Duck can fly with {((IFly)this).Speed}");
        }

        public void Move()
        {
            Console.WriteLine($"Duck can fly with {((IMove)this).Speed}");
        }

        public void Swim()
        {
            Console.WriteLine($"Duck can swim");
        }
    }
}
