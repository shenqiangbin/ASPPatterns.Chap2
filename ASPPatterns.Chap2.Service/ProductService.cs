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
        private ProductRepository _productCategory;

        public ProductService()
        {
            _productCategory = new ProductRepository();
        }

        public IList<Product> GetAllProductsIn(int categoryId)
        {
            IList<Product> products = null;

            string storageKey = $"products_in_categoryId_{categoryId}";
            products = HttpContext.Current.Cache.Get(storageKey) as IList<Product>;
            if (products == null)
            {
                products = _productCategory.GetAllProductsIn(categoryId);
                HttpContext.Current.Cache.Insert(storageKey, products);
            }

            return products;
        }
    }
}
