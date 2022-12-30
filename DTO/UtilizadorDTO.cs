

using System.ComponentModel.DataAnnotations;

namespace AuthApi.DTO
{
    public class UtilizadorDTO
    {
        [Required(ErrorMessage = "Nome do utilizador é obrigadorio")]
        [MinLength(3, ErrorMessage = "numero minummo de caractere são 3")]
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}