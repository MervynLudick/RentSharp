using System.ComponentModel.DataAnnotations;


namespace RentSharp.Web.Shared.ViewModels
{
    public class CreateCustomerViewModel
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? Surname { get; set; }
        [Required]
        public string? Cellphone { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
        [Required]
        [MaxLength(13)]
        [RegularExpression(@"^\d+$")]
        public string? IdNumber { get; set; }
        [Required]
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        [Required]
        public string? Suburb { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
    }
}
