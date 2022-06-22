using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentity.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage = "Kullanıcı adı gereklidir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Parola gereklidir")]
        public string Password { get; set; }
    }
}