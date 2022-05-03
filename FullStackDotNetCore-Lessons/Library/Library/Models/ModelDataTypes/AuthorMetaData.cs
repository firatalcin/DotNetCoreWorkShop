using System.ComponentModel.DataAnnotations;

namespace Library.Models.ModelDataTypes
{
    public class AuthorMetaData
    {
        [Required(ErrorMessage = "Zorunlu Alan")]
        [MaxLength(15, ErrorMessage = "Maksimum 15 karakter giribilirsiniz")]
        public string FirstName { get; set; }
    }
}
