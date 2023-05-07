namespace RentSharp.Web.Server.Entities
{
    public abstract class Customer
    {
        public Guid CustomerID { get; set; }
        public String EmailAddress { get; set; }
        public String Name { get; set; }
        public Address Address { get; set; }

    }
}
