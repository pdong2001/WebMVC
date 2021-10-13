using Models.Entity;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        private List<Product> data;

        public ProductService()
        {
            data = new List<Product>();
            InitData();
        }

        public bool Creat(Product data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Product data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return this.data.ToArray();
        }

        public void InitData()
        {
            data.AddRange(new Product[] {
                new Product{ID = data.Count + 1, Descriptionn = $"Laptop {data.Count}", ImagePath="product.jpg", Name=$"Product {data.Count}", Price = 100 },
                new Product{ID = data.Count + 1, Descriptionn = $"Laptop {data.Count}", ImagePath="product.jpg", Name=$"Product {data.Count}", Price = 100 },
                new Product{ID = data.Count + 1, Descriptionn = $"Laptop {data.Count}", ImagePath="product.jpg", Name=$"Product {data.Count}", Price = 100 },
                new Product{ID = data.Count + 1, Descriptionn = $"Laptop {data.Count}", ImagePath="product.jpg", Name=$"Product {data.Count}", Price = 100 },
                new Product{ID = data.Count + 1, Descriptionn = $"Laptop {data.Count}", ImagePath="product.jpg", Name=$"Product {data.Count}", Price = 100 },
                new Product{ID = data.Count + 1, Descriptionn = $"Laptop {data.Count}", ImagePath="product.jpg", Name=$"Product {data.Count}", Price = 100 },
            });
        }

        public bool Update(Product data)
        {
            throw new NotImplementedException();
        }
    }
}
