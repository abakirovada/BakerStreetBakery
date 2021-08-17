using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBaker
{

    // Here's two ways we can setup product, way one is to setup an enum and then a private dictionary for prices. This is so there's only one very obvious spot for prices.

    // An alternative method, of using an Interface/Class is below as well
    public enum Products { Bread, Cake, Pastry, Pies }
    public class Order
    {
        private readonly Dictionary<Products, decimal> _prices = new Dictionary<Products, decimal>
        {
            { Products.Bread, 500.01m },
            { Products.Cake, 2000m },
            { Products.Pastry, 200.10m },
            { Products.Pies, 851.5m }
        };

        public Order (int num, Products products, int batches)
        {
            OrderNumber = num;
            Product = products;
            NumberOfBatches = batches;
        }
        public int OrderNumber { get; set; }
        public int NumberOfBatches { get; set; }

        public Products Product { get; set; }
        //Property that uses enum Dictionary combo
        public decimal TotalCost
        {
            get
            {
                decimal batchPrice = _prices[Product] * NumberOfBatches;
                return batchPrice+=100;
            }
        }

        public IProduct ProductsOne { get; set; }
        //Property that uses class as a propert
        public decimal TotalCostFromClass
        {
            get
            {
                decimal batchPrice = ProductsOne.Price * NumberOfBatches;
                return batchPrice += 100;
            }
        }
    }
    // our other way where we setup IProduct (Which could also just be a product class) with hard set classes.
    public interface IProduct
    {
        string Name { get; }
        decimal Price { get;}
    }

    public class Pies : IProduct
    {
        public string Name => "Pies";
        public decimal Price => 851.1m;
    }
}
