using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AaronPuffer.DependencyInjection.Data.Repository.Interfaces;
using AaronPuffer.DependencyInjection.DTO;

namespace AaronPuffer.DependencyInjection.Data.Repository.Stubs
{
    public class CustomerDataStub : ICustomerData
    {
        public void DeleteCustomer(int CustomerId)
        {
            Customers = Customers.Where(customer => customer.Id != CustomerId).ToList();
        }

        public Customer GetCustomer(int CustomerId)
        {
            return Customers.Where(customer => customer.Id == CustomerId).FirstOrDefault();
        }

        public void SaveCustomer(Customer Customer)
        {
            Customers.Add(Customer);
        }

        public void UpdateCustomer(Customer Customer)
        {
            if (Customer.Id == 0)
            {
                throw new Exception("Invalid Customer Number");
            }

            var existingCustomer = Customers.Where(customer => customer.Id == Customer.Id).FirstOrDefault();

            if (existingCustomer == null)
            {
                throw new Exception("Customer does not exist");
            }
            else
            {
                Customers = Customers.Where(customer => customer.Id != Customer.Id).ToList();
                Customers.Add(Customer);
            }
        }

        /// <summary>
        /// This represents mocked up Customer information that will not change.
        /// </summary>
        private List<Customer> Customers = new List<Customer>()
        {
            new Customer() { Id = 1, FirstName = "Jim", LastName = "Smith", Address1 = "123 Paper Street", Address2 = "Apt 1", City = "Los Angeles", State = "CA", ZipCode = "90214"  },
            new Customer() { Id = 2, FirstName = "Mary", LastName = "Lamb", Address1 = "378 Little Lamb Way", City = "Forest City", State = "WI", ZipCode = "22309"  },
            new Customer() { Id = 3, FirstName = "Christopher", LastName = "Jones", Address1 = "146 South Avenue", City = "Billings", State = "MT", ZipCode = "76903"  }
        };
    }
}
