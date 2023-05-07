namespace RentSharp.Web.Server.Entities
{
    public class Driver
    {
        public Guid DriverID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String IDNumber { get; set; }
        public Media CopyOfID { get; set; }
    }
}
