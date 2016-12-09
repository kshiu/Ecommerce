using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Transaction
    {
        private static int lastTransactionNumber = 0;
        private static decimal Revenue;
        public static List<> getBasket; //or Hash
        public int TransactionID { get; private set; }
        public decimal Shipping { get; private set; }
        public decimal Tax { get; private set; }
        public decimal SubTotal { get; private set; }
        public decimal GrandTotal { get; private set; }

        public Transaction()
        {
            TransactionID = ++lastTransactionNumber;
            Shipping = 8.50M;
            TaxRate = SubTotal * .097;
        }

        public Basket(Product ProductName, Product ProductPrice, Product ProductQuantity)
        {
            var basket.Add(ProductName)
        }

        public void AddToCart(string Product, decimal ProducePrice, int quantityOrdered)
        {
            basket.Add(Product, quantityOrdered);
            Console.WriteLine($"You have added  { } to your cart.");
        }

        public static getBasket()
        {
            for(var i = 0; i < getBasket.length; i++)
            {
                Console.WriteLine(getBasket[i].getInfo);
            }
            return getBasket;
        }

        public void CheckOut()
        {
            var emailAddress = Console.ReadLine();
            var fullName = Console.ReadLine();
            
        }

        public void PlaceOrder()
        {
            Revenue += GrandTotal;
            ProductQuantity -= quantityOrdered;
            Console.WriteLine("Your order is placed!");
        }
    }
}
