using System;
using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //-- Arrange

            Customer newCustomer = new Customer();
            newCustomer.FirstName = "Ivana";
            newCustomer.LastName = "Calderon";

            //-- Act

            var customerFullName = newCustomer.FullName;

            //-- Assert

            Assert.Equal("Ivana, Calderon", customerFullName);

        }
    }
}
