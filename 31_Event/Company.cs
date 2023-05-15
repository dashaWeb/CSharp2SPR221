using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Event
{
    delegate void PositionDelegate(string description);// 1) визначили тип делегату для події NewPosition(нова вакансія)
    class Company
    {
        public string Name { get; set; }
        public event PositionDelegate NewPosition; //2) подія - екземпляр делегату
        public void AddPosition(string description) // bussiness logic method
        {
            NewPosition?.Invoke(description); // ініціювання (запуск) події NewPosition ------ виклик методів приєднаних до делегату
        }
    }
}
