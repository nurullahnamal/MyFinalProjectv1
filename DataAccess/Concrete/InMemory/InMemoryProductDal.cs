using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class IProductDal : Abstract.IProductDal
    {
        List<Product> _products;
        public IProductDal()
        {
            _products = new List<Product>();
            {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Vardak", UnitPrice = 213, UnitsInStock = 222 };
                new Product { ProductId = 2, CategoryId = 1, ProductName = "avize", UnitPrice = 113, UnitsInStock = 1222 };
                new Product { ProductId = 3, CategoryId = 2, ProductName = "kamera", UnitPrice = 113, UnitsInStock = 4222 };
                new Product { ProductId = 4, CategoryId = 2, ProductName = "lens", UnitPrice = 513, UnitsInStock = 5222 };
                new Product { ProductId = 5, CategoryId = 2, ProductName = "telefon", UnitPrice = 613, UnitsInStock = 7222 };

            }
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productUpdate= _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productUpdate.ProductName = product.ProductName;
            productUpdate.CategoryId = product.CategoryId;
            productUpdate.UnitPrice = product.UnitPrice;
            productUpdate.UnitsInStock = product.UnitsInStock;
            
        }
       

        public List<Product> GetAllCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
