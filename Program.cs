namespace advanced02
{


    public class Program
    {
        static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        {
            List<Product> result = new List<Product>();

            foreach (Product p in products)
            {
                if (filter(p))
                    result.Add(p);
            }

            return result;
        }

        static void PrintProducts(List<Product> products)
        {
            foreach (Product p in products)
                Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
        }

        static void Main()
        {
            #region answer01
            List<Product> catalog = new()
        {
            new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
            new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
            new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
            new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
            new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
            new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
            new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
            new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
            new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
            new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
        };

            Console.WriteLine("--- Electronics ---");
            PrintProducts(SearchProducts(catalog, p => p.Category == "Electronics"));

            Console.WriteLine("\n--- Under $50 ---");
            PrintProducts(SearchProducts(catalog, p => p.Price < 50));

            Console.WriteLine("\n--- In Stock ---");
            PrintProducts(SearchProducts(catalog, p => p.Stock > 0));

            Console.WriteLine("\n--- Clothing Under $100 ---");
            PrintProducts(SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100)); 
            #endregion
        }
    }

    

}