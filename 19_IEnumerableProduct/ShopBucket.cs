using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_IEnumerableProduct
{
    class ShopBucket : IEnumerable
    {
        Item[] items = new Item[0];
        public void AddItem(Item item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = item;
        }
        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
        public IEnumerable<Item> GetReverse() // іменований ітератор = товари будуть проходитися у зворотньому порядку
        {
            for (int i = items.Length - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }
        public IEnumerable<Item> GetCheaperItems(int priceLimit) // іменований ітератор = товари будуть проходитися у зворотньому порядку
        {
            for (int i = items.Length - 1; i >= 0; i--)
            {
                if(items[i].Price <= priceLimit)
                    yield return items[i];
            }
        }
        public override string ToString()
        {
            return String.Join<Item>("\n",items);
        }
    }
}
