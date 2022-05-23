using System.ComponentModel.DataAnnotations;

namespace FastShopApp.WebUI.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string? Password { get; set; }
    }
}

