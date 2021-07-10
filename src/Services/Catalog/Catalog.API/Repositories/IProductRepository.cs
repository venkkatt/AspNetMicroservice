using Catalog.API.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {

        Task<IEnumerable<Product>> GetProducts();

        Task<Product> GetProduct(string id);

        Task<IEnumerable<Product>> GetProductByName(String name);

        Task<IEnumerable<Product>> GetProductByCateogry(string categoryName);

        Task CreateProduct(Product product);
        Task<bool> UpdateProducct(Product product);

        Task<bool> DeleteProduct(string id);



    }
}
