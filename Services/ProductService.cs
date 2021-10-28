using Models;
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

        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public bool Creat(Product data)
        {
            _context.Products.Add(data);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(Product data)
        {
            _context.Products.Remove(_context.Products.FirstOrDefault(p => p.ID == data.ID));
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToArray();
        }

        public bool Update(Product data)
        {
            _context.Update(data);
            return _context.SaveChanges() > 0;
        }
    }
}
