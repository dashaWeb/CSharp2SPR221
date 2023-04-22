using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_interfaces
{
    class StreamerDuck : Duck, IFly 
    {
        public override void Fly()
        {
            Console.WriteLine("Streamer duck can not fly");
        }
    }
}
