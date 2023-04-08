using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_myException
{
    class Product // public
    {
        string name; // private
        int price;
        DateTime dateIn;
        public string Name { 
            get => name;
            set { 
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name must be not null or writespace");
                }
                if(!value.All(c=>char.IsLetter(c)))
                {
                    throw new Exception("Bad name :: must has all letters");
                }
                name = value;
            } 
        }
        public DateTime DateIn { 
            get=>dateIn; 
            set => dateIn = value <= DateTime.Now ? value : throw new BadProductDateException("Date of product :: ", value); }
        public void InputName()
        {
            while (true)
            {
                Console.WriteLine("Input product name ");
                string input = Console.ReadLine();
                try
                {
                    Name = input;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                }
            }
        }
    }
}
