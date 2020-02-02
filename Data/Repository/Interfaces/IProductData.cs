using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AaronPuffer.DependencyInjection.DTO;

namespace AaronPuffer.DependencyInjection.Data.Repository.Interfaces
{
    public interface IProductData
    {
        void SaveProduct(Product Product);

        Product GetProduct(int ProductId);

        List<Product> GetProducts(List<int> ProductId);
    }
}
