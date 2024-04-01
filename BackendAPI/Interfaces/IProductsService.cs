using BackendAPI.Models;

namespace BackendAPI.Interfaces
{
    public interface IProductsService
    {
        public Task<List<Product>?> GetProductsFirst();

        public Task<List<Product>?> GetProductsSecond();
    }
}
