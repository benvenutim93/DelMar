using DelMar.DB.Interfaces;
using DelMar.Entidades.Models;

namespace DelMar.DB.Repositorios
{
    public class ArticulosRepositorio : GenericRepository<Articulo>, IArticulosRepositorio
    {
        public ArticulosRepositorio(DelMarContext context) : base(context)
        {

        }
    }
}
