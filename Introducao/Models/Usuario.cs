using System.ComponentModel.DataAnnotations;

namespace Introducao.Models
{
    public class Usuario
    {
        public int PessoaId { get; set; }
        [Required(ErrorMessage ="O nome é obrigatório")]
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage = "Insira as obs com o tamanho min de 5 e maximo de 20")]
        public string Observacoes { get; set; }

        /*if(string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("", "O campo nome é obrigatório"); //primeiro parametro é a localização do campo para mostra a msg ao lado.
            }

            if (usuario.Senha != usuario.ConfirmarSenha)
            {
                ModelState.AddModelError("", "A senha deve ser igual a senha de confirmação"); //primeiro parametro é a localização do campo para mostra a msg ao lado.
            }
        */
    }
}