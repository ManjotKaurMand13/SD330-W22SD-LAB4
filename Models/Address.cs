using System;
namespace SD330_W22SD_LAB4.Models
{
    public class Address
    {
        public int Id { get; set; }
        public AddressLine Addressline { get; set; }

        public enum AddressLine
        {
            AddressLine1,
            AddressLine2,
        }

        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}

