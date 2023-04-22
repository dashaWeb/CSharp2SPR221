using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_interfaces
{
    interface IMove
    {
        public int Speed { get; }
        void Move();
    }
}
