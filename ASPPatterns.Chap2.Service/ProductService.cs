using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return _productCategory.GetAllProductsIn(categoryId);
        }
    }
}
