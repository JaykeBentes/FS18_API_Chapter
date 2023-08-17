using System.ComponentModel.DataAnnotations;

namespace Chapter.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Informe o e-mail do Usuário")]
        public string email { get; set; }

        [Required(ErrorMessage ="Informe a Senha do usuário")]
        public string senha { get; set; }
    }
}
