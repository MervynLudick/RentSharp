namespace RentSharp.Core.Entities
{
    public class Driver
    {
        public Guid DriverId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String IdNumber { get; set; }
        public Media CopyOfID { get; set; }
    }
}
