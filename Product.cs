using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADVC_02
{
    internal class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }


    }


    internal class ProductCatalog
    {
        public List<Product> SearchProducts(
            List<Product> products,
            Func<Product, bool> filter)
        {
            return products.Where(filter).ToList();
        }

        public void PrintReport(List<Product> products, Action<Product> action)
        {

            foreach (Product p in products)
            {
                action(p);
            }

        }

        public List<string> TransformProducts(List<Product> products, Func<Product, string> transformer)
        {
            List<string> results = new List<string>();

            foreach (Product p in products)
            {
                results.Add(transformer(p));
            }

            return results;
        }

        public List<Product> FilterProducts(List<Product> products , Predicate<Product> condition) 
        {

            List<Product> results = new List<Product>();
            foreach (Product p in products)
            {
                if (condition(p))
                {
                    results.Add(p);
                }
            }
            return results;

        }

    }


      

}
