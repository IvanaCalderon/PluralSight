using System;
namespace ACM.BL
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Descripcion { get; set; }
        public int CurrentPrice { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;

            return isValid;

        }

        public Product Retrieve()
        {
            return new Product();
        }

        public void Save()
        {

        }

    }
}
