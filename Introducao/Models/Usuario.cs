using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario
    {
        public int PessoaId { get; set; }
        [Required(ErrorMessage ="O nome é obrigatório")]
        public string Nome { get; set; }
        [Range(18,70, ErrorMessage = "A idade tem que está entre 18 e 70 anos")]
        public int Idade { get; set; }
      //  [RegularExpression(@"\w+([.-]?\w+)@\w+([.-]?\w+)(.\w{1,3})+$/", ErrorMessage = "Digite um email válido")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somentes letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "Login é obrigatório")]
        [Remote("LoginUnico","Usuario", ErrorMessage = "Este login já existe")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha obrigatória")]

        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "Senhas devem ser iguais")]
        public string ConfirmarSenha { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage = "Insira as obs com o tamanho min de 5 e maximo de 20")]
        public string Observacoes { get; set; }

    }
}