using System;

namespace DemoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            int candyBarAmount = GetStock("candy bar");

            Product candyBar = new Product();
            candyBar.SetValues("1",candyBarAmount,5.0);
            Console.WriteLine(candyBar);

            int cerealAmount = GetStock("cereal");

            Product cereal = new Product();
            cereal.SetDefaultValues();
            cereal.SetValues("21",cerealAmount,4.5);
            Console.WriteLine(cereal);

        }

        static int GetStock(string name)
        {
            int quantity;
            do
            {
                Console.Write("Enter quantity of product " + name + ": ");
                quantity = int.Parse(Console.ReadLine());
            } while (quantity < 0);

            return quantity;
        }
    }
}
