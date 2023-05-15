using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_EventHandler
{
    class MyArgs : EventArgs
    {
        public string Description { get; set; }
        public DateTime Date => DateTime.Today;
    }
    //delegate void PositionDelegate(string description);// 1) визначили тип делегату для події NewPosition(нова вакансія)
    class Company
    {
        public string Name { get; set; }
        public event EventHandler<MyArgs> NewPosition; //2) подія - екземпляр делегату
        public void AddPosition(string description) // bussiness logic method
        {
            MyArgs args = new MyArgs()
            {
                Description = description
            };
            NewPosition?.Invoke(this, args); // ініціювання (запуск) події NewPosition ------ виклик методів приєднаних до делегату
        }
    }
}

