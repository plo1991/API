using System.ComponentModel.DataAnnotations;


namespace mvc_AuthenticationFilter.Models
{
    public class LoginModel
    {
        [Display(Name = "Nome")]
        [Required]
        public string UserName { get; set; }

        [Display(Name ="Senha")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}