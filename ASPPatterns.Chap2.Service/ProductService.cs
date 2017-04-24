using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ASPPatterns.Chap2.Service
{
    public class ProductService
    {
        private IProductRepository _productCategory;
        private ICacheStorage _cacheStorage;

        public ProductService(IProductRepository productRepository, ICacheStorage cacheStorage)
        {
            _productCategory = productRepository;
            _cacheStorage = cacheStorage;
        }

        public IList<Product> GetAllProductsIn(int categoryId)
        {
            IList<Product> products = null;

            string storageKey = $"products_in_categoryId_{categoryId}";            
            products = _cacheStorage.Retrieve<IList<Product>>(storageKey);

            if (products == null)
            {
                products = _productCategory.GetAllProductsIn(categoryId);                
                _cacheStorage.Store(storageKey, products);
            }

            return products;
        }
    }
}
