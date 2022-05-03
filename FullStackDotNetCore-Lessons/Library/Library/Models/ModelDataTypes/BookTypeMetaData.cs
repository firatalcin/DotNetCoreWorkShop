using System.ComponentModel.DataAnnotations;

namespace Library.Models.ModelDataTypes
{
    public class BookTypeMetaData
    {
        [Required(ErrorMessage = "Zorunlu Alan")]
        [MinLength(2, ErrorMessage = "En az 2 karakterli olmalıdır")]
        public string Name { get; set; }
    }
}
