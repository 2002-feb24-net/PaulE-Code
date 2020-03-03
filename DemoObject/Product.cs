using System;

namespace DemoObject
{
    class Product
    {
        string ProductId;
        int Stock;
        double StarRating;

        public void SetDefaultValues()
        {
            ProductId = "1";
            Stock = 0;
            StarRating = 5;
        }

        public void SetValues(string id, int quantity, double rating)
        {
            if (quantity > 50)
            {
                Console.WriteLine("Error! Too much quantity!");
            }

            this.ProductId = id;
            this.Stock = quantity;
            this.StarRating = rating;
        }

        public override string ToString()
        {
            return "product " + ProductId + ", " + Stock + " in stock, " + StarRating + " star rating";
        }
    }
}