using CarFinance247TechnicalTest.Model;
using CarFinance247TechTestV4.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace CustomerUnitTest
{
    [TestClass]
    public class CustomerUnitTest
    {
        private readonly CustomerContext _context;
        public CustomerUnitTest()
        {
            var customer = new[]
            {
                new Customer { id = 0, firstName ="Nick", emailAddress="nicheung@rocketmail.com" },
                new Customer { id = 1, firstName ="John", emailAddress="John@rocketmail.com" },
                new Customer { id = 2, firstName ="Peter", emailAddress="peter@rocketmail.com" }
            };
            _context.Customers.AddRange(customer);
            _context.SaveChanges();
        }


        [TestMethod]
        public async void AddCustomer_ReturnCorrectAction()
        {
            // Arrange
            var controller = new CustomerController(_context);
            // Act
            var cust = new Customer();
            cust.firstName = "AddCustomerTest";
            cust.emailAddress = "AddCustomerTest@AddCustomerTest.com";
            var result = await controller.Create(cust);
            // Assert
            Xunit.Assert.IsType<CreatedAtActionResult>(result);
        }

        [TestMethod]
        public async void getCustomer_ReturnCustomer()
        {
            // Arrange
            var controller = new CustomerController(_context);
            // Act
            var result = await controller.Details(0);
            // Assert
            var objectResult = Xunit.Assert.IsType<OkObjectResult>(result);
            Xunit.Assert.IsAssignableFrom<Customer>(objectResult);
        }

        [TestMethod]
        public async void deleteCustomer_ReturnsOK()
        {
            // Arrange
            var controller = new CustomerController(_context);
            // Act
            var result = await controller.Delete(0);
            // Assert
            Xunit.Assert.IsType<OkObjectResult>(result);
        }

    }
}
