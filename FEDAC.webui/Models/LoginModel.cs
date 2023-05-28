using System.ComponentModel.DataAnnotations;

namespace FEDAC.webui.Models
{
    public class LoginModel
    {
        [Required]
       //username ile login sayfasına giriş yapmak istiyorsan bunu aktifleştirmen lazım-> public string UserName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]//girdiğikarakterler gözükmesin.
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}