namespace RentSharp.Core.Entities
{
    public class TrailerType
    {
        public Guid TrailerTypeID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public decimal Price { get; set; }
        public int Weight { get; set; }
        public int CarryWeight { get; set; }

    }
}
