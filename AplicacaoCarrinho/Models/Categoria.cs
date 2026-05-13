using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AplicacaoCarrinho.Models
{
    public class Categoria
    {
        [Required(ErrorMessage = "O código da categoria é obrigatório")]
        [DisplayName("Código da categoria")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Código é obrigatório")]
        [DisplayName("Nome da categoria")]
        public string? Nome { get; set; }
    }
}
