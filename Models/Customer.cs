using System;
namespace SD330_W22SD_LAB4.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public FullName Name { get; set; }
        public string CompanyName { get; set; }
        public enum FullName
        {
            FirstName,
            lastName
        }
        public string Phone { get; set; }
        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();

    }
}

