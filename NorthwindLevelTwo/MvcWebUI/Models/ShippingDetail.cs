using System.ComponentModel.DataAnnotations;

namespace MvcWebUI.Models
{
    public class ShippingDetail
    {
       // [Required(ErrorMessage = "İsim gerekli")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //[Required]
       // [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
       // [Range(18,65)]
        public int Age { get; set; }
    }
}
