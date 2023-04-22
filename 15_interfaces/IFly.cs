using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_interfaces
{
    interface IFly
    {
        // interface - може містити методи, властивості, події C#8(static fields const)
        int Speed { get; } // NOT auto-property, неявно абстрактна властивість
        void Fly();
    }
}
