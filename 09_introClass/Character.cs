using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_introClass
{
    // видимість класу
    // public ---> відкритий для інших збірок
    // internal ---> закритий для інших збірок, видиий тільк для своєїзбірки
    // protected ---> видимий вміст для класів які настідуються
    // private 
    // protected internal
    public class Character
    {
        // поля
        private string name = "Unknown";
        private uint hpChar; // якщо не ініціалізувати поля, значення буде типу по замовчуванню (для посилальних типів null)
        // методи
        public Character()
        {

        }
        public Character(string newName, uint hp) // конструктор з параметрами
        {
            this.name = newName; // this - посилання на обєкт для якого працює метод
            this.hpChar = hp;
        }
        public Character(string newName) // каскадно викликається конструктор цього ж класу з двома параметрами
            :this(newName,100) 
        {
            
        }
        public void Print()
        {
            string text = new string('=', 40);
            Console.WriteLine($"\n{text}\n");
            Console.WriteLine($"\tCharacter name :: {name}");
            Console.WriteLine($"\tCharacter hp   :: {hpChar}");
            Console.WriteLine($"\n{text}\n");
        }

        public string Name
        {
            /*get
            {
                return name;
            }*/
            get => name;
            set // value - ключове слово для set - значення яке хочемо встанови
            {
                /*if(value.Length != 0)
                {
                    name = value;
                }*/
                if(!String.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        
        }
        public override string ToString()
        {
            return $"Name :: {name,-10} HP :: {hpChar,-5} Damage :: {Damage}";
        }
        public uint Damage { get; set; } = 5; // авто-властивість, компілятор створить поле типу uint та для нього get,set
        public uint KPD { get => hpChar * Damage; }
        public uint HpChar { get => hpChar; set => hpChar = value; }
    }
}
