using System.ComponentModel.DataAnnotations;

namespace Ex11_CRUDClientes_AT.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome do cliente e obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Sobrenome do cliente e obrigatório")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }
    }
}
