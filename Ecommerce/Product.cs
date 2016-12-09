using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Product
    {
        #region Properties
        public virtual string ProductName { get; private set; }
        public virtual decimal ProductPrice { get; private set; }
        public virtual int ProductQuantity { get; private set; }
        #endregion
    }

    public Product()
    {
        this.ProductName = ProductName;
        this ProductPrice = ProductPrice;
        this ProductQuantity = ProductQuantity;
    }

    //adding a Product constructor
    public void AddProduct(string ProductName, decimal ProductQuantity)
    {
        var addingNewProduct = new Product;
        addingNewProduct = Console.ReadLine();
        Console.WriteLine($"You have added new item: " {addingNewProduct});
    }

    //removing a Product
    public void RemoveProduct(string ProductName)
    {
        var deleteProduct = ProductName.Remove();
        Console.WriteLine("You have deleted item: " { deleteProduct});
    }
}
