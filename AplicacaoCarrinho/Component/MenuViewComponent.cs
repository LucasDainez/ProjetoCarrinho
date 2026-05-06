using AplicacaoCarrinho.Repository.Contract;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoCarrinho.Component
{
    public class MenuViewComponent : ViewComponent
    {
        private ICategoriaRepository _categoriaRepository;
        public MenuViewComponent(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ListaCategoria = _categoriaRepository.ObterTodasCategorias().ToList();
            return View(ListaCategoria);
        }
    }
}
