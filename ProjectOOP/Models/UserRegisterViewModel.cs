using System.ComponentModel.DataAnnotations;

namespace ProjectOOP.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen isim değeri giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyisim değeri giriniz.")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı değeri giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen mail değeri giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifre değeri giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet seçiniz.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
        [Compare("Password", ErrorMessage = "Lütfen şifreleri eşleştiğinden emin olun.")]
        public string ConfirmPassword { get; set; }
    }
}
