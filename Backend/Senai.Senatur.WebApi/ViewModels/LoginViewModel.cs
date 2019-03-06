using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        public string senha { get; set; }
    }
}
