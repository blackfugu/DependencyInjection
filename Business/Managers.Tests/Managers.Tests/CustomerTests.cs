using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AaronPuffer.DependencyInjection.Business.Managers;
using AaronPuffer.DependencyInjection.Data.Repository.Interfaces;
using AaronPuffer.DependencyInjection.Data.Repository.Stubs;
using AaronPuffer.DependencyInjection.DTO; 

namespace AaronPuffer.DependencyInjection.Business.Managers.Tests
{
    [TestClass]
    public class CustomerManagerTests
    {
        private CustomerManager customerManager;

        public CustomerManagerTests()
        {
            ICustomerData customerData = new CustomerDataStub();
            customerManager = new CustomerManager(customerData);
        }

        [TestMethod]
        public void CreateCustomer()
        {
            Customer customer = new Customer()
            {
                Address1 = "321 Test Address",
                Address2 = "",
                City = "West Point",
                State = "New York",
                FirstName = "Karen",
                LastName = "Washington",
                ZipCode = "33021",
                Id = 999
            };

            customerManager.CreateCustomer(customer);

            Customer addedCustomer = customerManager.GetCustomer(999);

            Assert.IsNotNull(addedCustomer);
                        
        }

        [TestMethod]
        public void ValidateCustomer()
        {
            Customer addedCustomer = customerManager.GetCustomer(1);

            string expected = "Jim";
            string actual = addedCustomer.FirstName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateCustomer()
        {
            Customer customer = customerManager.GetCustomer(2);

            customer.FirstName = "Marilyn";

            customerManager.UpdateCustomer(customer);

            Customer updatedCustomer = customerManager.GetCustomer(2);

            var expected = "Marilyn";
            var actual = updatedCustomer.FirstName;

            Assert.AreEqual(expected, actual, $"Customer Names do not match: { expected } != { actual }");
        }

        [TestMethod]
        public void UpdateCustomerAddress()
        {
            customerManager.UpdateCustomerName(1, "Susan", "Bishop");

            Customer customer = customerManager.GetCustomer(1);

            var expected = "Susan Bishop";
            var actual = $"{ customer.FirstName.Trim() } {customer.LastName.Trim() }";

            Assert.AreEqual(expected, actual, $"Customer names do not match: { expected } != { actual }");
        }
    }
}
