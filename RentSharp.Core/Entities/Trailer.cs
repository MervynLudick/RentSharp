namespace RentSharp.Core.Entities
{
    public class Trailer
    {
        public Guid TrailerID { get; set; }
        public String Code { get; set; }
        public String? RegistrationNumber { get; set; }
        public String? VinNumber { get; set; }
        public DateTime DateAdded { get; set; }
        public Boolean IsActive { get; set; }
        public TrailerType TrailerType { get; set; }
    }
}
