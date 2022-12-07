namespace GruppArbete1.Models
{
    public class ProductsService
    {
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Make = "Gibson", Model = "Les Paul", Price = 25000},
            new Product { Id = 2, Make = "Taylor", Model = "Academy", Price = 10000},
            new Product { Id = 3, Make = "Roland", Model = "TR-808", Price = 2000}
        };

        public Product[] GetAll()
        {
            return products
                .OrderBy(x => x.Make)
                .ThenBy(x => x.Model)
                .ToArray();
        }
    }
}
