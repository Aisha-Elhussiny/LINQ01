using LINQ.DataSources;
using LINQ.Models;
using System.Drawing;
using System.Xml.Linq;

namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1  Get all products from the "Seafood" category. Print each product's name and price.

            //var seafoodProducts = from product in Source.ProductList
            //                      where product.Category == "Seafood"
            //                      select new { product.ProductName, product.UnitPrice };

            //foreach (var product in seafoodProducts)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Q2. Get a list of only the product names from ProductList. Print each name.
            //var productNames = Source.ProductList
            // .Select(p => p.ProductName)
            // .ToList();

            //foreach (var product in productNames)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region Q3. Sort all products by UnitPrice (ascending). Print each product's name and price.
            //var seafoodProducts = from product in Source.ProductList
            //                      where product.Category == "Seafood"
            //                      orderby product.UnitPrice ascending
            //                      select new { product.ProductName, product.UnitPrice };

            //foreach (var product in seafoodProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q4. Get all products where UnitPrice is between 10 and 30
            //var productsInRange = Source.ProductList
            //    .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30)
            //    .Select (p => new { p.ProductName, p.UnitPrice })  ;
            //foreach (var product in productsInRange)
            //{
            //    Console.WriteLine(product);
            //}


            #endregion
            #region Q5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.
            //var inStockCondiments = Source.ProductList
            //    .Where(p => p.UnitsInStock > 0 && p.Category == "Spices & Condiments")
            //    .Select(p => new { p.ProductName, p.UnitsInStock });
            //foreach (var product in inStockCondiments)
            //{
            //    Console.WriteLine(product);
            //}


            //m3ndesh category condiments bs 3ndi Spices & Condiments 3la b3d
            #endregion
            #region Q6. Create a new anonymous type with three properties: Name → the product name, Price → the unit price, StockStatus → a string: "Available" if UnitsInStock > 0,otherwise "Out of Stock", Print the result.
            //var productStockStatus = Source.ProductList
            //    .Select(p => new
            //    {
            //        Name = p.ProductName,
            //        Price = p.UnitPrice,
            //        StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //    });
            //foreach (var product in productStockStatus)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Q7. Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc.
            //var productNamesWithPosition = Source.ProductList
            //    .Select((p, index) => new { Position = index + 1, Name = p.ProductName });
            //foreach (var product in productNamesWithPosition)
            //{
            //    Console.WriteLine($"{product.Position}. {product.Name}");
            //}

            //3mlt el print gwa el for kda 3shan el output yb2a zay el expected format
            #endregion

            #region Q8. Sort ProductList by Category ascending, then within each   category, sort by UnitPrice descending.
            //var sortedProducts = Source.ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice)
            //    .Select(p => new { p.ProductName, p.Category, p.UnitPrice });
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion


        }
    }
}
