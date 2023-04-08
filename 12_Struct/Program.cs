using System;

namespace _12_Struct
{
    /*
    1) Структури не підтримують успадкування, але можуть реалізовувати множину інтерфейсів
    2) Не можна ініціалізувати поля та автовластивості при їх визначення, лише константи
    3) конструктор за замовчуванням не пишемо, його створить компілятор і проініціалізує поля дефолтними значеннями
    4) у конструкторі обовязкова ініціалізація
     */
    struct City
    {
        const int DefaultPopulation = 100_000;
        const int MaxPopulation = 10_000_000;
        private int population;
        public string Name { get; set; }
        public int Population { 
            get=>population; 
            set=> population = value<=MaxPopulation ? value : MaxPopulation ; }
        public City(string name, int population)
            :this()
        {
            Name = name;
            Population = population;
        }

        public override string ToString()
        {
            return $"{Name, 10} [{population}]";
        }
        public int CompareCity(City obj)
        {
            // < 0 => first city
            // > 0 => second city
            return this.population - obj.population;
        }
        public int CompareNameCity(City y)
        {
            return String.Compare(this.Name, y.Name);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            Console.WriteLine(city);
            Console.WriteLine($"\n{new string('=',40)}\n");

            City rivne = new City("Rivne", 243_934);
            Console.WriteLine(rivne);
            Console.WriteLine($"\n{new string('=',40)}\n");

            // value type
            City clone = rivne;
            Console.WriteLine(rivne);
            Console.WriteLine(clone);
            Console.WriteLine($"\n{new string('=',40)}\n");
            clone.Name = "Rivne 2";
            clone.Population += 100;

            Console.WriteLine(rivne);
            Console.WriteLine(clone);
            Console.WriteLine($"\n{new string('=', 40)}\n");

            City lviv = new City("Lviv", 721_301);
            Console.WriteLine(lviv);

            Console.WriteLine($"\n{new string('=', 40)}\n");

            Console.WriteLine(rivne.CompareCity(lviv));
            Console.WriteLine(rivne.CompareNameCity(lviv));

            Console.WriteLine($"\n{new string('=', 40)}\n");
            City[] cities =
            {
                lviv,
                rivne,
                new City("Kyiv",2_884_000),
                new City("Kharkiv",1_419_000)
            };
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
            Array.Sort(cities,(x,y)=> x.Name.CompareTo(y.Name));
            Console.WriteLine($"\n{new string('=', 40)}\n");

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
            Array.Sort(cities, (x, y) => x.Population.CompareTo(y.Population));

            Console.WriteLine($"\n{new string('=', 40)}\n");

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
        }
    }
}
