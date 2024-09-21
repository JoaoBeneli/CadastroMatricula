using System.ComponentModel.DataAnnotations;

namespace CadastroMatricula.Models
{
    public class Professor
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "A especialização é obrigatória.")]
        public string Especializacao { get; set; }

        [Required(ErrorMessage = "A titulação é obrigatória.")]
        public string Titulacao { get; set; }

        [Required(ErrorMessage = "A data de contratação é obrigatória.")]
        public DateTime DataContratacao { get; set; }

        [Required(ErrorMessage = "O departamento é obrigatório.")]
        public string Departamento { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [StringLength(100, ErrorMessage = "A senha deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "A confirmação da senha é obrigatória.")]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        public string ConfirmarSenha { get; set; }
    }
}
