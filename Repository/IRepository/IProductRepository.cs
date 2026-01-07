using System;
using ApiECommerce.Models;

namespace ApiECommerce.Repository.IRepository;

public interface IProductRepository
{
    ICollection<Product> GetProduct();
    ICollection<Product> GetProductsForCategory(int categoryId);
    ICollection<Product> SearchProduct(string name);
    Product? GetProduct(int id);
    bool BuyProducto(string name, int quantity);
    bool ProductExists(int id);
    bool ProductExists(string name);
    bool CreateProduct(Product product);
    bool UpdateProduct(Product product);
    bool DeleteProduct(Product product);
    bool Save();
}
