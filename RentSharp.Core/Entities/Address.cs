namespace RentSharp.Core.Entities
{
    public class Address
    {
        public Guid AddressID { get; set; }
        public String AddressLine1 { get; set; }
        public String AddressLine2 { get; set; }
        public String Suburb { get; set; }
        public String City { get; set; }
        public String PostalCode { get; set; }
    }
}
