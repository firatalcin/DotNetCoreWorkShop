using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfWebApp.Data.Entities
{
    //[Table(name:"Category",Schema = "c")]
    public class Category
    {
        public int Id { get; set; }
        //[Required]
        //[MaxLength]
        //[Column(name: "category_name", TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
