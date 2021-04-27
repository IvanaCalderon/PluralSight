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

            Customer newCustomer = new Customer
            {
                FirstName = "Ivana",
                LastName = "Calderon"
            };

            //-- Act

            var customerFullName = newCustomer.FullName;

            //-- Assert

            Assert.Equal("Calderon, Ivana", customerFullName);

        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer newCustomer = new Customer
            {
                FirstName = "Ivana"
            };
            //-- Act
            var customerFullName = newCustomer.FullName;
            //-- Assert

            Assert.Equal("Ivana", customerFullName);

        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer newCustomer = new Customer
            {
                LastName = "Calderon"
            };
            //-- Act
            var customerFullName = newCustomer.FullName;
            //-- Assert

            Assert.Equal("Calderon", customerFullName);

        }

        [Fact]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Tatiana";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "Andry";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "Tomas";
            Customer.InstanceCount += 1;


            //-- Act


            //-- Assert
            Assert.Equal(3, Customer.InstanceCount);

        }

        [Fact]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer();
            customer.LastName = "Calderon";
            customer.EmailAddress = "odanamcm@gmail.com";
            //-- Act
            var actual = customer.Validate();
            //-- Assert
            Assert.True(actual);

        }

        [Fact]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer();
            customer.EmailAddress = "odanamcm@gmail.com";
            //-- Act
            var actual = customer.Validate();
            //-- Assert
            Assert.False(actual);

        }
    }
}
