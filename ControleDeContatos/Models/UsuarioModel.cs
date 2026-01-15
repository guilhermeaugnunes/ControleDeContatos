using ControleDeContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Digite o nome do contato.")]
        public string? Nome { get; set; }
       
        [Required(ErrorMessage = "Digite o login do contato.")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Digite o E-mail do contato.")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido.")]
        public string? Email { get; set; }

        public PerfilEnum Perfil { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Digite a senha do usuário.")]
        public string? Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
