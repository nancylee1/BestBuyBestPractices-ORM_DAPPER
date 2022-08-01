using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPractices
{
//    Create a IProductRepository Interface - this interface will have:
//      A GetAllProducts() method:
//      A CreateProduct(string name, double price, int categoryID) method:
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        public void CreateProduct(string name, double price, int categoryID);
        public void UpdateProduct(int productID, double price); 
        public void DeleteProduct(int productID);   
    }
}
