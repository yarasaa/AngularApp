using AngularApp.Application.Abstractions;
using AngularApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularApp.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new()
        {
            new()
            {
                Id = Guid.NewGuid(),
                ProductName = "Test",
                Price = 100,
                Stock = 5
            },

            new()
            {
                Id = Guid.NewGuid(),
                ProductName = "Test1",
                Price = 200,
                Stock = 41
            },
            new()
            {
                Id = Guid.NewGuid(),
                ProductName = "Test2",
                Price = 300,
                Stock = 10
            },
            new()
            {
                Id = Guid.NewGuid(),
                ProductName = "Test3",
                Price = 400,
                Stock = 544
            },

        };
        
        };
    }

