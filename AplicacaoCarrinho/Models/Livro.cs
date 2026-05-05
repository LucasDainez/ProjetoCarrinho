using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace AplicacaoCarrinho.Models
{
    public class Livro
    {
        [Required (ErrorMessage="Código é obrigatório")]
        [DisplayName("Código do Livro")]
        public int codLivro { get; set; }

        [Required(ErrorMessage = "Nome do Livro é obrigatório")]
        [DisplayName("Nome do Livro")]
        public string? NomeLivro { get; set; }

        [Required(ErrorMessage = "Quantidade é obrigatória")]
        [DisplayName("Quantidade de Livros")]
        public int quantidade { get; set; }

        [Required(ErrorMessage = "Imagem do Livro é obrigatória")]
        [DisplayName("Imagem do Livro")]
        public string? imagemLivro { get; set; }
    }
}
