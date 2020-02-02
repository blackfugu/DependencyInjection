using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AaronPuffer.DependencyInjection.DTO;

namespace AaronPuffer.DependencyInjection.Data.Repository.Interfaces
{
    public interface ICustomerData
    {
        void SaveCustomer(Customer Customer);

        Customer GetCustomer(int CustomerId);

        void DeleteCustomer(int CustomerId);

        void UpdateCustomer(Customer Customer);
    }
}
