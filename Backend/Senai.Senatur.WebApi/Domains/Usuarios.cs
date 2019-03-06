using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Usuarios
    {
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Informe o e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe o tipo de usuário")]
        public string TipoUsuario { get; set; }
    }
}
