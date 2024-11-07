using DelMar.DB.Interfaces;
using DelMar.Entidades.Models;

namespace DelMar.DB.Repositorios
{
    public class CategoriasRepositorio : GenericRepository<Categoria>, ICategoriaRepositorio
    {
        public CategoriasRepositorio(DelMarContext context) : base(context) { }
    }
}
