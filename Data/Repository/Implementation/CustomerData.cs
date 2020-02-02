using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AaronPuffer.DependencyInjection.Data.Repository.Interfaces;
using AaronPuffer.DependencyInjection.DTO;

namespace AaronPuffer.DependencyInjection.Data.Repository.Implementation
{
    public class CustomerData : ICustomerData
    {
        //This represents a context for a database.  This example is not currently functioning
        private List<Customer> context;

        public void DeleteCustomer(int CustomerId)
        {
            context = context.Where(customer => customer.Id != CustomerId).ToList();
        }

        public Customer GetCustomer(int CustomerId)
        {
            return context.Where(customer => customer.Id == CustomerId).FirstOrDefault();
        }

        public void SaveCustomer(Customer Customer)
        {
            context.Add(Customer);
        }

        public void UpdateCustomer(Customer Customer)
        {
            if (Customer.Id == 0)
            {
                throw new Exception("Invalid Customer Number");
            }

            var existingCustomer = context.Where(customer => customer.Id == Customer.Id).FirstOrDefault();

            if (existingCustomer == null)
            {
                throw new Exception("Customer does not exist");
            } else
            {
                context = context.Where(customer => customer.Id != Customer.Id).ToList();
                context.Add(Customer);
            }
        }
    }
}
