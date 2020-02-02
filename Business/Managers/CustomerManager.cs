using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AaronPuffer.DependencyInjection.Data.Repository.Implementation;
using AaronPuffer.DependencyInjection.Data.Repository.Interfaces;
using AaronPuffer.DependencyInjection.Data.Repository.Stubs;
using AaronPuffer.DependencyInjection.DTO;

namespace AaronPuffer.DependencyInjection.Business.Managers
{
    public class CustomerManager
    {
        private ICustomerData data;

        public CustomerManager()
        {
            data = new CustomerData();
        }

        public CustomerManager(ICustomerData data)
        {
            this.data = data;
        }

        public void CreateCustomer(Customer Customer)
        {
            data.SaveCustomer(Customer);
        }

        public void UpdateCustomer(Customer Customer)
        {
            data.UpdateCustomer(Customer);
        }

        public void UpdateCustomerAddress(int CustomerId, string Address1, string Address2)
        {
            var Customer = data.GetCustomer(CustomerId);

            Customer.Address1 = Address1;
            Customer.Address2 = Address2;

            data.UpdateCustomer(Customer);
        }

        public Customer GetCustomer(int CustomerId)
        {
            return data.GetCustomer(CustomerId);
        }

        public void UpdateCustomerName(int CustomerId, string FirstName, string LastName)
        {
            var Customer = data.GetCustomer(CustomerId);

            if ((FirstName == null || FirstName == String.Empty) || (LastName == null || LastName == String.Empty))
            {
                throw new Exception($"Customer Information is not complete: FirstName: {FirstName}, LastName: {LastName}");
            }

            Customer.FirstName = FirstName;
            Customer.LastName = LastName;

            data.UpdateCustomer(Customer);
        }
    }
}
