using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AaronPuffer.DependencyInjection.DTO;

namespace AaronPuffer.DependencyInjection.Data.Repository.Interfaces
{
    public interface IOrderedProductData
    {

        void UpdateOrderedProducts(int OrderId, List<OrderedProduct> OrderedProducts);

        List<OrderedProduct> GetOrderedProducts(int OrderId);

    }
}
