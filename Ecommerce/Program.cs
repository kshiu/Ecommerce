using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            //adding in a new product
            //removing the produce

            //adding a user

            //ordering

            Console.WriteLine("Welcome to my store!");
            Console.WriteLine("Please select from the list of choices below: ");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Add to cart");
            Console.WriteLine("2. See what's in your Basket");
            Console.WriteLine("3. Remove from cart");
            Console.WriteLine("4. Change quantity");
            Console.WriteLine("5. Place Order");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "0"; Console.WriteLine("Have a great day!");
                    return;
                case "1":
                    var addingNewProduct = new BasketUpdate;
                    return;
                case "2":
                    Transaction.getBasket();
                    return;
                case "3":
                    Console.WriteLine("");
                    return;
                case "5":
                    Console.WriteLine($"Thank you for your purchase. Your transaction ID is {basket.TransactionID}");
                    break;
                default:
                    break;
            }

        }
    }
}
