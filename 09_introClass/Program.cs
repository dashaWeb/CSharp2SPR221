using System;

namespace _09_introClass
{

    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character("Elf", 200);
            character.Print();
            character.Name = "";
            character.Print();
            Console.WriteLine($"\t {character}");
            //Console.WriteLine(character); // по замовчуванню генерує рядок з назвою типу (Простір імен.Назва класу)
            Console.WriteLine("\n\n");
            Character character1 = new Character(hp: 150, newName: "Mage");
            Console.WriteLine($"\t {character1}");
            Character character2 = new Character { Name = "Warrior", Damage = 12, HpChar = 36 };
            Console.WriteLine($"\t {character2}");
        }
    }
}
