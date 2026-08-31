namespace AssignmentADVC_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task01
            //List<Product> catalog = new()
            //{
            //  new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
            //  new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
            //  new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
            //  new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
            //  new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
            //  new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
            //  new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
            //  new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
            //  new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
            //  new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
            //};

            //ProductCatalog productCatalog = new ProductCatalog();
            //List<Product> electronics = productCatalog.SearchProducts(
            //   catalog,
            //   p => p.Category == "Electronics"
            //);

            //List<Product> cheapProducts = productCatalog.SearchProducts(
            //    catalog,
            //    p => p.Price < 50
            //);

            //List<Product> inStockProducts = productCatalog.SearchProducts(
            //    catalog,
            //    p => p.Stock > 0
            //);

            //List<Product> clothingProducts = productCatalog.SearchProducts(
            //    catalog,
            //    p => p.Category == "Clothing" && p.Price < 100
            //);


            //Console.WriteLine("--- Electronics ---");
            //foreach (Product p in electronics)
            //{
            //    Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            //}

            //Console.WriteLine("\n--- Under $50 ---");
            //foreach (Product p in cheapProducts)
            //{
            //    Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            //}

            //Console.WriteLine("\n--- In Stock ---");
            //foreach (Product p in inStockProducts)
            //{
            //    Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            //}

            //Console.WriteLine("\n--- Clothing Under $100 ---");
            //foreach (Product p in clothingProducts)
            //{
            //    Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            //}

            #endregion

            #region Tssk03 3.1 Print Reports

            //List<Product> catalog = new()
            //{
            //  new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
            //  new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
            //  new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
            //  new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
            //  new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
            //  new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
            //  new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
            //  new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
            //  new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
            //  new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
            //};

            //ProductCatalog Print = new ProductCatalog();

            //Console.WriteLine("--- Short Report ---");
            //Print.PrintReport
            //    (
            //    catalog, p =>Console.WriteLine($"{p.Name} - ${p.Price}")
            //);

            //Console.WriteLine("\n--- Detailed Report ---");
            //Print.PrintReport
            //    (
            //    catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | ${p.Price} | Stock: {p.Stock}")
            //);

            #endregion

            #region Tssk03 3.2 Transform Products

            //List<Product> catalog = new()
            //{
            //  new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
            //  new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
            //  new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
            //  new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
            //  new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
            //  new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
            //  new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
            //  new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
            //  new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
            //  new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
            //};

            //ProductCatalog Transform = new ProductCatalog();

            //List<string> SummaryList = Transform.TransformProducts(
            //     catalog,
            //     p => $"{p.Name} (${p.Price})"
            //         );
            //Console.WriteLine("\n--- Summary List ---");
            //foreach (string s in SummaryList)
            //{
            //    Console.WriteLine(s);
            //}

            //List<string> priceLabels = Transform.TransformProducts
            //    (
            //     catalog,
            //       p => p.Price > 100 ? $"{p.Name}: Expensive!" : $"{p.Name}: Affordable"
            //    );

            //Console.WriteLine("\n--- Price Label ---");
            //foreach (string s in priceLabels)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

        }
    }
}
