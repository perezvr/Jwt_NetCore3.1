using Jwt_NetCore3._1.Entities;
using Jwt_NetCore3._1.Services.Interfaces;
using System.Collections.Generic;

namespace Jwt_NetCore3._1.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Description = "Product 1",
                    Price = 2.12m
                },
                new Product()
                {
                    Id = 2,
                    Description = "Product 2",
                    Price = 5.59m
                },
                new Product()
                {
                    Id = 3,
                    Description = "Product 3",
                    Price = 12.13m
                },
                new Product()
                {
                    Id = 4,
                    Description = "Product 4",
                    Price = 15.88m
                },
                new Product()
                {
                    Id = 5,
                    Description = "Product 5",
                    Price = 41.54m
                }
            };
        }
    }
}
