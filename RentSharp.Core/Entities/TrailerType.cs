namespace RentSharp.Web.Server.Entities
{
    public class TrailerType
    {
        public Guid TrailerTypeID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public double CarryWeight { get; set; }

    }
}
