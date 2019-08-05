using System;
using System.Collections.Generic;

namespace GeektasticCodeChallenge
{
    public class Checkout
    {
        public string Items { get; set; }
        public List<Item> AvailableItems { get; set; }
        Dictionary<char, int> checkoutContents = new Dictionary<char, int>();

        public Checkout(string items)
        {
            Items = items.ToUpper();
            ReadPrices();
        }

        public double CalculateTotal()
        {
            double total = 0.0;
            foreach(char c in Items.ToCharArray())
            {
                AddItemToCheckout(AvailableItems.Find(item => item.Name.ToString() == c.ToString()));
            }
            total = GetTotal();
            return total;
        }

        private void ReadPrices()
        {
            //create items
            /*  Item Name		Price		Special Price
                A				£50			3 for £130
                B				£30			2 for £45
                C 				£20			
                D				£15 */
            AvailableItems = new List<Item>
            {
                new Item('A', 50, new PriceForNumberOfItems(3, 130)),
                new Item('B', 30, new PriceForNumberOfItems(2, 45)),
                new Item('C', 20),
                new Item('D', 15)
            };
        }


        public void AddItemToCheckout(Item itemToAdd)
        {
            if (itemToAdd != null)
            {
                if (checkoutContents.ContainsKey(itemToAdd.Name))
                {
                    checkoutContents[itemToAdd.Name] += 1;
                }
                else
                {
                    checkoutContents.Add(itemToAdd.Name, 1);
                }
            }
        }

        public double GetPrice(string name, int noOfItems)
        {
            double price = 0;
            Item anItem = AvailableItems.Find(item => item.Name.ToString() == name);
            if (anItem.SpecialPrice != null)
            {
                int noOfSpecialPrices = Math.DivRem(noOfItems, anItem.SpecialPrice.NoOfItems, out int result);
                price = noOfSpecialPrices * anItem.SpecialPrice.GroupPrice;
                price += result * anItem.Price;
                return price;
            }

            price = (noOfItems * anItem.Price);
            return price;
        }

        public double GetTotal()
        {
            double total = 0;
            checkoutContents.TryGetValue('A', out int noOfA);
            total += GetPrice("A", noOfA);
            checkoutContents.TryGetValue('B', out int noOfB);
            total += GetPrice("B", noOfB);
            checkoutContents.TryGetValue('C', out int noOfC);
            total += GetPrice("C", noOfC);
            checkoutContents.TryGetValue('D', out int noOfD);
            total += GetPrice("D", noOfD);
            return total;
        }
    }
}
